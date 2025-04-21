using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Models
{
    internal class CheckNameFolder
    {
        public string NameFolder { get; set; } = string.Empty;

        public CheckNameFolder(string nameFolder)
        {
            NameFolder = nameFolder;
        }
        public bool FolderName()
        {
            var folder = false;

            if (NameFolder.Length == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (char.IsUpper(NameFolder[i]) == true)
                    {
                        folder = true;
                    }
                    else
                    {
                        folder = false;
                        break;
                    }
                }
            }
            else
            {
                folder = false;
            }

            return folder;
        }
    }
}
