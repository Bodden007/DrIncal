using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DrIncal.srs.Models
{
    internal class SortNameFolder
    {
        public string? PathNameFolder { get; set; }
        public string? EsdnPath { get; set; }
        public string? NameEsdnPath { get; set; }
        public SortNameFolder(string? nameFolder)
        {
            PathNameFolder = nameFolder;
        }

        public void SelectName()
        {
            //FIXME ошибка надо разобраться

            //var bufPath = TempDirectory.GetParent(PathNameFolder)!.ToString();

            //EsdnPath = TempDirectory.GetParent(bufPath)!.ToString();

            //NameEsdnPath = Path.GetFileName(Path.GetDirectoryName(bufPath));
        }
    }
}
