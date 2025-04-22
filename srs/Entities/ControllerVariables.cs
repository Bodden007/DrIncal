using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Entities
{
    internal class ControllerVariables
    {
        readonly string Provider = "Provider=Microsoft.jet.OLEDB.4.0; Data Source=";
        public string? MessageController { get; set; } = string.Empty;
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
