using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Models
{
    internal class RenameFile
    {
        public bool Rename(string pathNameFile, bool cmpName)
        {

            var successfulRename = false;

            //TODO else rename .cmp
            try
            {
                if (cmpName)
                {
                    File.Move(pathNameFile, Path.ChangeExtension(pathNameFile, "zip"));
                } 
                else
                {
                    File.Move(pathNameFile, Path.ChangeExtension(pathNameFile, "cmp"));
                }

                successfulRename = true;
            }
            catch
            {
                successfulRename = false;
            }

            return successfulRename;
        }
    }
}
