using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Models
{
    internal class Compresing
    {
        public string[] Passport = new string[2]
        {
            "6a88nqgVC6K7vJuIUiVZAfm6w06jcMFCPvcjyLS06jsLslZaf1zCbDjzZmjCVK1z3sqjuTrlHhh",
            "fULhOPQtsuO3tFlq3RE3"
        };
        public bool UncopressFile(string filename, string pathFile)
        {
            FastZip fastZip = new FastZip();
            var resultUncompress = false;

            for (int i = 0; i < Passport.Length; i++)
            {
                try
                {
                    fastZip.Password = Passport[i];
                    fastZip.ExtractZip(filename, pathFile, null);

                    resultUncompress = true;
                    break;
                }
                catch (Exception ex)
                {
                    resultUncompress = false;
                }
            }

            return resultUncompress;
        }
    }
}
