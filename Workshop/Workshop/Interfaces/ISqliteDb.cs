using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop.Interfaces
{
    public interface ISQLiteDb
    {
        SQLiteConnection GetSqliteConnection();
    }
}
