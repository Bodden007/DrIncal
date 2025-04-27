using DrIncal.srs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Models
{
    /// <summary>
    /// Класс работы с директориями
    /// </summary>
    class MovingFile : IMovingFile
    {
        //TODO Разобраться с каталогами
        
        public bool CopyFile()
        {
            var pathDirect = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var foldTempDrIncal = false;

            var tempFolder = System.IO.Directory.GetDirectories(pathDirect, "DrIncal");

            if (tempFolder.Length != 1)
            {
                foldTempDrIncal = true;
            }

            return foldTempDrIncal;
        }

        public bool CreateFold(string pathFold)
        {

            return false;
        }
        public bool DeleteFold()
        {

            return false;
        }

        public bool CopyFold()
        {
            return false;
        }

    }
}
