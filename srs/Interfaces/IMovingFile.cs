using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Interfaces
{
    /// <summary>
    /// Перечисления методов класса MovingFile. Для создания, копирования и удаления директорий
    /// </summary>
    internal interface IMovingFile
    {
        bool CopyFile();
        bool CreateFold(string pathFold);
        bool DeleteFold();
        bool CopyFold();
    }
}
