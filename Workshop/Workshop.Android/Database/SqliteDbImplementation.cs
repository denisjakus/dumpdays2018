using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Workshop.Interfaces;

namespace Workshop.Droid.Database
{
    public class SqliteDbImplementation : ISQLiteDb
    {
        public SQLiteConnection GetSqliteConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, "DumpDays.db3");

            return new SQLiteConnection(path);
        }
    }
}