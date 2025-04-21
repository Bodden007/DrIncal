using DrIncal.srs.Entities;
using DrIncal.srs.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.WebRequestMethods;

namespace DrIncal.srs
{
    internal class Controller
    {
        const string Provider = "Provider=Microsoft.jet.OLEDB.4.0; Data Source=";
        public string? MessageController { get; set; } = string.Empty;
        public string? PathFolder { get; set; } = string.Empty;
        public string? FolderNameOnly { get; set; } = string.Empty;
        public string? EsdnPath { get; set; } = string.Empty;
        public string? PathMdbFile { get; set; } = string.Empty;
        public string? JulianDate { get; set; } = string.Empty;
        public DateTime? CalDate { get; set; }
        public bool CmpName { get; set; } = true;
        public bool? NameEsdnPath { get; set; } = false;

        //NOTE Class reading DB
        DbConnectios dbConnectios = new DbConnectios();

        //NOTE Event declarations
        public delegate void EventHandler(object sender, ControllerMessage message);
        public EventHandler? MessageSend;

        public bool Run(string? nameFolder, string saveNameFolder)
        {
            //NOTE Проверка правильности выбора папки
            var folder = false;
            CheckNameFolder checkNameFolder = new(saveNameFolder);
            folder = checkNameFolder.FolderName();

            if (folder)
            {
                //NOTE Sending Message to class MainWindows
                //MessageController = ;
                MessageSend?.Invoke(this, new ControllerMessage($"Папка {saveNameFolder} получена", false));

                PathFolder = nameFolder;
                FolderNameOnly = saveNameFolder;

                CheckCmpName checkCmpName = new();

                //NOTE проверка наличия файла .смр
                var cmpFile = checkCmpName.CmpName(PathFolder!, saveNameFolder);

                #region
                if (cmpFile)
                {
                    MessageSend?.Invoke(this, new ControllerMessage("Файл .cmp обнаружен", false));

                    //FIXME Раскоментировать
                    //NOTE rename cmp -> zip 
                    //RenameFile renameFile = new();
                    //renameFile.Rename(PathFolder + "\\" + saveNameFolder + ".cmp", cmpFile);

                    //FIXME Раскоментировать
                    //NOTE Uncompressing file
                    #region
                    //Compresing uncompresing = new();
                    //var resultUncompress = uncompresing.UncopressFile(PathFolder + "\\" + saveNameFolder + ".zip",
                    //    PathFolder!);
                    #endregion
                    #region
                    //if (resultUncompress)
                    //{
                    //    MessageSend?.Invoke(this, new ControllerMessage("Файл .cmp прочитан"));

                    //    //Getting access and reading the DB
                    //    var provider = Provider + PathFolder + "\\" + saveNameFolder + ".mdb";
                    //    var readingDB = dbConnectios.ReadingDB(provider);

                    //    if (readingDB)
                    //    {
                    //        MessageSend?.Invoke(this, new ControllerMessage("Данные .mdb получены"));

                    //        CalDate = dbConnectios.DbDateTime;
                    //        JulianDate = dbConnectios.DbJulianDate;

                    //        MessageSend?.Invoke(this, new ControllerMessage(CalDate.ToString()!));
                    //        MessageSend?.Invoke(this, new ControllerMessage(JulianDate!));

                    //        dbConnectios.СhangeDb(provider);
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show($"База НЕ Прочитана!!");
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show($" Архив НЕ Распакован");
                    //}
                    #endregion
                }
                else
                {
                    MessageBox.Show($"  Файл НЕ обнаружен");
                }
                #endregion

                //NOTE Поднятие по каталогу на уровень выше и поиск папки esdn
                SortNameFolder sortNameFolder = new SortNameFolder(nameFolder);
                sortNameFolder.SelectName();
                EsdnPath = sortNameFolder.EsdnPath;

                if (sortNameFolder.NameEsdnPath == "esdn")
                {
                    NameEsdnPath = true;

                    MessageSend?.Invoke(this, new ControllerMessage("Папка esdn обнаружена", false));
                }
                else
                {
                    NameEsdnPath = false;

                    MessageSend?.Invoke(this, new ControllerMessage("Папка esdn не обнаружена", true));
                }

                //FIXME delete
                //MessageBox.Show($"Правильный выбор. Folder {FolderNameOnly} , EsdnPatch {NameEsdnPath} ");
            }
            else
            {
                MessageBox.Show("Неправильный выбор папки. Папка формата ХХХ (Три прописные буквы)");
                folder = false;
            }

            return folder;
        }
    }
}
