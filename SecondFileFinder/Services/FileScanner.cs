using System;
using System.Collections.Generic;
using System.Text;
using SecondFileFinder.Models;
using System.Security.Cryptography;

namespace SecondFileFinder.Services
{
    internal class FileScanner
    {
        public async Task< List<DuplicateFile>> Scan(string folder,IProgress<int> progress) {

            Dictionary<long,List<string>> sizeGroups= new Dictionary<long,List<string>>();
            Dictionary<string,List<string>> hashGroups= new Dictionary<string,List<string>>();

            List<DuplicateFile> duplicates = new List<DuplicateFile>();

            int count = 0;

            foreach (string file in Directory.EnumerateFiles(folder,"*.*",SearchOption.AllDirectories)) {
                try
                {
                    FileInfo info = new FileInfo(file);

                    if (!sizeGroups.ContainsKey(info.Length))
                        sizeGroups[info.Length] = new List<string>();
                    sizeGroups[info.Length].Add(file);

                    count++;
                    progress?.Report(count);
                    await Task.Yield();
                }
                catch { continue; }
            }

            foreach (var group in sizeGroups) {
                if (group.Value.Count < 2)
                    continue;
                foreach (string file in group.Value) {
                    string hash = HashService.GetFileHash(file);

                    if (!hashGroups.ContainsKey(hash)) 
                        hashGroups[hash]= new List<string>();

                    hashGroups[hash].Add(file);
                    
                }
            }

            foreach (var group in hashGroups) {
                if (group.Value.Count < 2)
                    continue;
                foreach (string file in group.Value) {
                    FileInfo info = new FileInfo(file);
                    duplicates.Add(new DuplicateFile
                    {
                        Filename = info.Name,
                        Folder = info.DirectoryName,
                        Size = info.Length,
                        Hash=group.Key
                    });
                }
            }
            return duplicates;
        }
    }
}
