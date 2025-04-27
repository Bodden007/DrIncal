using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.ModelsDirectory
{
    /// <summary>
    /// Поиск папки по файлам
    /// </summary>
    internal class CheckDirectory
    {
        public bool FindFOlder(string pathDirect, string nameFolder)
        {         
            var findFold = false;

            var tempFolder = System.IO.Directory.GetDirectories(pathDirect, nameFolder);

            if (tempFolder.Length != 0)
            {
                findFold = true;
            }

            return findFold;  
        }
    }
}
