using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.ModelsDirectory
{
    /// <summary>
    /// Класс создания директорий
    /// </summary>
    internal class CreateCatalog
    {
        public bool Creating(string pathDirData)
        {
            var resultCreate = false;
            try
            {
                Directory.CreateDirectory(pathDirData);
                resultCreate = true;
            }
            catch (Exception ex)
            {
                resultCreate = false;
            }

            return resultCreate;
        }
    }
}
