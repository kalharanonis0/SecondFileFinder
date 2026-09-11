using System;
using System.Collections.Generic;
using System.Text;

namespace SecondFileFinder.Models
{
    internal class DuplicateFile
    {
        public string Filename { get; set; }
        public string Folder { get; set; }
        public long Size { get; set; }
        public string Hash { get; set; }
    }
}
