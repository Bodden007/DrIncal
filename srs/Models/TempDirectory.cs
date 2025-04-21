using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Models
{
    internal class TempDirectory
    {
        private const string IntelFolder = "intelect";
        private const string EsdnFolde = "esdn";
        private const string DataFolder = "data";

        public bool CheckDir()
        {
            var isDir = false;

            Directory.CreateDirectory(IntelFolder);



            return isDir;
        }
    }
}
