using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DrIncal.srs.Models
{
    internal class CheckCmpName
    {
        public bool CmpName(string pathCmp, string nameFolder)
        {
            var checkFile = false;

            DirectoryInfo directoryInfo = new DirectoryInfo(pathCmp);

            FileInfo[] filesFolder = directoryInfo.GetFiles("*.cmp");

            foreach (FileInfo files in filesFolder)
            {
                var nameFile = files.Name.ToString();

                if(nameFile == nameFolder + ".cmp")
                {
                    checkFile = true;
                    break;
                }
                else
                {
                    checkFile = false;
                }
            }
            return checkFile;
        }
    }
}
