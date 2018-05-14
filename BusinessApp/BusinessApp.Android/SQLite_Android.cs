using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.IO;
using Xamarin.Forms;

using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;
using BusinessApp.Contracts.Services;

namespace BusinessApp.Droid
{
    public class SQLite_Android : ISQLite
    {
        private SQLiteConnection _conn;

        public SQLite_Android()
        {

        }

        public static string GetDatabasePath()
        {
            const string sqliteFilename = "XamarinBase.db3";

            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);

            return path;
        }

        public SQLiteConnection GetConnection()
        {
            var dbPath = GetDatabasePath();

            // Return the synchronous database connection 
            return new SQLiteConnection(new SQLitePlatformAndroid(), dbPath);
        }

 
        public void DeleteDatabase()
        {
            var path = GetDatabasePath();

            try
            {
                if (_conn != null)
                {
                    _conn.Close();

                }
            }
            catch
            {
                // Best effort close. No need to worry if throws an exception
            }

            if (File.Exists(path))
            {

                File.Delete(path);
            }

            _conn = null;
        }

        public void CloseConnection()
        {
            if (_conn != null)
            {
                _conn.Close();
                _conn.Dispose();
                _conn = null;

                // Must be called as the disposal of the connection is not released until the GC runs.
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}