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
        public static string ConnectionString
        {
            get
            {
                return "data source=" + _filename;
            }
        }
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
        private static void CreateDB()
        {
            ExecuteNonQuery(@"CREATE TABLE [folders] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [p_id] integer,
                    [name] char(255) NOT NULL,
                    FOREIGN KEY (p_id) REFERENCES folders (id) on delete cascade
                    );");
            ExecuteNonQuery(@"CREATE TABLE [modules] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [name] char(255) NOT NULL
                    );");
            ExecuteNonQuery(@"CREATE TABLE [files] (
                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [p_id] integer NOT NULL,
                    [name] char(255) NOT NULL,
                    [module_id] integer,
                    FOREIGN KEY (p_id) REFERENCES folders (id) on delete cascade
                    FOREIGN KEY (module_id) REFERENCES modules (id) on delete set NULL
                    );");
            ExecuteNonQuery(@"CREATE TABLE [relationships] (
                    [id]  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [uses]  INTEGER NOT NULL,
                    [used]  INTEGER NOT NULL,
                    [rate]  INTEGER NOT NULL,
                    FOREIGN KEY (uses) REFERENCES files (id) ON DELETE CASCADE,
                    FOREIGN KEY (used) REFERENCES files (id) ON DELETE CASCADE
                    );");
            ExecuteNonQuery(@"CREATE VIEW [rels] AS 
                    SELECT
                    f1.name AS uses,
                    m1.name AS uses_module,
                    f2.name AS used,
                    m2.name AS used_module,
                    relationships.rate AS rate
                    relationships.id AS id
                    FROM
                    modules AS m1 ,
                    files AS f1 ,
                    relationships ,
                    modules AS m2 ,
                    files AS f2
                    WHERE
                    m1.id = f1.module_id AND
                    m2.id = f2.module_id AND
                    relationships.uses = f1.id AND
                    relationships.used = f2.id;");
            ExecuteNonQuery(@"CREATE VIEW moddeps AS 
                    SELECT
                    m1.name as uses,
                    m2.name as used
                    FROM
                    modules AS m1 ,
                    modules AS m2 ,
                    relationships ,
                    files AS f1 ,
                    files AS f2
                    WHERE
                    m1.id = f1.module_id AND
                    m2.id = f2.module_id AND
                    f1.id = relationships.uses AND
                    f2.id = relationships.used AND
                    m1.id <> m2.id;");
            ExecuteNonQuery(@"CREATE TABLE patches (
                    id  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    name  TEXT NOT NULL);");
            ExecuteNonQuery(@"CREATE TABLE patchdetails (
                    id  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    file_id  INTEGER NOT NULL,
                    patch_id  INTEGER NOT NULL,
                    FOREIGN KEY (file_id) REFERENCES files (id) ON DELETE CASCADE,
                    FOREIGN KEY (patch_id) REFERENCES patches (id) ON DELETE CASCADE);");
            ExecuteNonQuery(@"CREATE VIEW patchview AS 
                    SELECT
                    patchdetails.patch_id,
                    m1.id AS uses,
                    m2.id AS used,
                    relationships.rate
                    FROM
                    modules AS m1 ,
                    files AS f1 ,
                    relationships ,
                    files AS f2 ,
                    modules AS m2 ,
                    patchdetails
                    WHERE
                    m1.id = f1.module_id AND
                    f1.id = relationships.uses AND
                    relationships.used = f2.id AND
                    f2.module_id = m2.id AND
                    patchdetails.file_id = relationships.used;");


        }
    }
}
