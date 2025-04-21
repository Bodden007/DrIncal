using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DrIncal.srs.Models
{
    internal class DbConnectios
    {
        //TODO Class
        
        public DateTime DbDateTime { get; set; }
        public string? DbJulianDate { get; set; }
        static private OleDbConnection? oledDbConnection;
        public bool ReadingDB(string provider)
        {
            var readingDb = false;
            

            try
            {
                using (oledDbConnection = new OleDbConnection(provider))
                {
                    OleDbCommand oleDbCommand = oledDbConnection.CreateCommand();
                    oleDbCommand.CommandText = "SELECT * FROM CALDATE";
                    oledDbConnection.Open();
                    OleDbDataReader dbDataReader = oleDbCommand.ExecuteReader();

                    dbDataReader.Read();

                    DbDateTime = (DateTime)dbDataReader[0];
                    DbJulianDate = (string)dbDataReader[1];

                    dbDataReader.Close();
                    oledDbConnection.Close();

                    readingDb = true;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Exception {ex.Message}");
            }

            return readingDb;
        }

        public bool СhangeDb(string provider)
        {
            var changeDb = false;

            try
            {
                using (oledDbConnection = new OleDbConnection(provider))
                {
                    OleDbCommand oleDbCommand = oledDbConnection.CreateCommand();
                    oleDbCommand.CommandText = "UPDATE CALDATE SET CalDate = '01.01.2025', JulianDate = 3000";
                    oledDbConnection.Open();
                    //OleDbDataReader dbDataReader = oleDbCommand.ExecuteReader();

                    //dbDataReader.Read();

                    //dbDataReader.Close();

                    var val = oleDbCommand.ExecuteNonQuery();

                    oledDbConnection.Close();

                    MessageBox.Show($"Запрос SQL вернул {val} измененние(ий)");

                    changeDb = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception {ex.Message}");
            }

            return changeDb;
        }
    }
}
