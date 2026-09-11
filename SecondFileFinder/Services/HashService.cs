using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SecondFileFinder.Services
{
    public class HashService
    {
         public static string GetFileHash(string filePath) {
            using (FileStream stream = File.OpenRead(filePath))
            using (SHA256 sHA = SHA256.Create()) {
                byte[] hash = sHA.ComputeHash(stream);
                StringBuilder stb = new StringBuilder();
                foreach (byte b in hash)
                {
                    stb.Append(b.ToString("x2"));
                }
                return stb.ToString();
            }
        }
    }
}
