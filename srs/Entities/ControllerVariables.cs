using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Entities
{
    internal class ControllerVariables
    {
        public string[] _Passport = new string[2] 
        {
            "6a88nqgVC6K7vJuIUiVZAfm6w06jcMFCPvcjyLS06jsLslZaf1zCbDjzZmjCVK1z3sqjuTrlHhh",
            "fULhOPQtsuO3tFlq3RE3"
        }; 
        readonly string _Provider = "Provider=Microsoft.jet.OLEDB.4.0; Data Source=";
        public string? PassportCompressing { get; set; } = string.Empty;
        public string? PathFolder { get; set; } = string.Empty;
        public string? FolderNameOnly { get; set; } = string.Empty;
        public string? EsdnPath { get; set; } = string.Empty;
        public string? PathMdbFile { get; set; } = string.Empty;
        public string? JulianDate { get; set; } = string.Empty;
        public DateTime? CalDate { get; set; }
        public bool CmpName { get; set; } = true;
        public bool? NameEsdnPath { get; set; } = false;
    }
}
