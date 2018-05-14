using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using BusinessApp.Contracts.Services;
using SQLite.Net;

namespace BusinessApp.UWP
{
   public class SQLiteService:ISQLite
    {
        public SQLiteService()
        {
        }

        #region ISQLite implementation

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var fileName = "BusinessApp.db3";
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, fileName);

            var platform = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }

        #endregion
    }
}
