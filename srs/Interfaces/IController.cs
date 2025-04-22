using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Interfaces
{
    interface IController
    {
        public bool Run(string? nameFolder, string saveNameFolder);
    }
}
