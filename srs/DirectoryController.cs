using DrIncal.srs.Entities;
using DrIncal.srs.ModelsDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs
{
    /// <summary>
    /// Класс работы с папками
    /// </summary>
    internal class DirectoryController : DirectoryEntities
    {
        //TODO доделать работу с каталогами
        public bool FolderManagement()
        {
            //NOTE Наличие папки DrInkal
            var isDrIncal = false;
            //NOTE Наличие папки Intelect
            var isIntelect = false;
            //NOTE Наличие папки data
            var isData = false;

            CheckDirectory checkDirectory = new CheckDirectory();

            var pathDirect = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //NOTE Проверка, есть ли наличие папки DrIncal, если нет то создаем полный каталог до папки data
            //isDrIncal = checkDirectory.FindFOlder(pathDirect, _DrIncal);
            //if (isDrIncal)
            //{
                var pathDirData = pathDirect + "\\" + _DrIncal + "\\" + _Intelect + "\\" + _Esdn + "\\" + _Data;
                CreateCatalog createCatalog = new CreateCatalog();

                isData = createCatalog.Creating(pathDirData);
            //}


            //isIntelect = checkDirectory.FindFOlder(pathDirect, _Intelect);

            return isData;
        }
    }
}
