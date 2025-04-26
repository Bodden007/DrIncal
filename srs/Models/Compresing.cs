using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Models
{
    //TODO В этот класс передавать пароли и возвращать пароль которым открылся
    internal class Compresing
    {
        //public string[] Passport = new string[2]
        //{
        //    "6a88nqgVC6K7vJuIUiVZAfm6w06jcMFCPvcjyLS06jsLslZaf1zCbDjzZmjCVK1z3sqjuTrlHhh",
        //    "fULhOPQtsuO3tFlq3RE3"
        //};
        public string UncopressFile(string filename, string pathFile, string[] passport)
        {
            FastZip fastZip = new FastZip();
            var passportUncompress = String.Empty;

            for (int i = 0; i < passport.Length; i++)
            {
                try
                {
                    fastZip.Password = passport[i];
                    fastZip.ExtractZip(filename, pathFile, null);

                    passportUncompress = passport[i];
                    break;
                }
                catch (Exception ex)
                {
                    passportUncompress = String.Empty;
                }
            }

            return passportUncompress;
        }
    }
}
