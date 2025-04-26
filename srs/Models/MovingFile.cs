using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Models
{
    class MovingFile
    {
        //TODO Разобраться с каталогами
        public bool CopyFile()
        {
            var pathDirect = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var foldTempDrIncal = false;

            var tempFolder = System.IO.Directory.GetDirectories(pathDirect, "TempDrIncal");



            if (tempFolder.Length == 1)
            {
                foldTempDrIncal = true;
            }

            return foldTempDrIncal;
        }
    }
}
