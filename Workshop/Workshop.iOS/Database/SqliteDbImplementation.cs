using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using UIKit;
using Workshop.Interfaces;

namespace Workshop.iOS.Database
{
    public class SqliteDbImplementation : ISQLiteDb
    {
        public SQLiteAsyncConnection GetSqliteConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "DumpDays.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}