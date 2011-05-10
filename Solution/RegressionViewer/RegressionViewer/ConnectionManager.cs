using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SQLite;

namespace RegressionViewer
{
    static class ConnectionManager
    {
        private static string _filename;
        private static SQLiteConnection _connection;
        public static SQLiteConnection connection
        {
            get
            {
                if (_connection==null) 
                {
                    _connection = new SQLiteConnection("Data Source = " + filename);
                    _connection.Open();
                }
                return _connection;
            }
        }
        public static string filename
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
                if (_connection!=null) _connection.Close();
                _connection = null;
            }
        }
        public static void CloseConnection()
        {
            _connection.Close();
            _connection = null;
        }
        public static void ExecuteNonQuery(string sql)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql,connection))
                command.ExecuteNonQuery();
        }
    }
}
