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
            if (_connection!=null)
                _connection.Close();
            _connection = null;
        }
        public static void ExecuteNonQuery(string sql)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql,connection))
                command.ExecuteNonQuery();
        }
        public static void CreateDB()
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
                    relationships.rate AS rate,
                    relationships.id AS id
                    FROM
                    modules AS m1
                    INNER JOIN files AS f1 ON m1.id = f1.module_id
                    INNER JOIN relationships ON f1.id = relationships.uses
                    INNER JOIN files AS f2 ON relationships.used = f2.id
                    INNER JOIN modules AS m2 ON f2.module_id = m2.id");
            ExecuteNonQuery(@"CREATE VIEW moddeps AS 
                    SELECT
                    m1.name AS uses,
                    m2.name AS used,
                    Count(relationships.rate) AS count,
                    Sum(relationships.rate) AS rate
                    FROM
                    files AS f1
                    INNER JOIN modules AS m1 ON m1.id = f1.module_id
                    INNER JOIN relationships ON f1.id = relationships.uses
                    INNER JOIN files AS f2 ON relationships.used = f2.id
                    INNER JOIN modules AS m2 ON f2.module_id = m2.id
                    WHERE
                    m1.id <> m2.id
                    GROUP BY
                    m1.name,
                    m2.name;");
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
                    m2.name AS used,
                    m1.name AS uses,
                    Count(relationships.rate) AS count,
                    Sum(relationships.rate) AS rate
                    FROM
                    modules AS m1
                    INNER JOIN files AS f1 ON m1.id = f1.module_id
                    INNER JOIN relationships ON f1.id = relationships.uses
                    INNER JOIN files AS f2 ON relationships.used = f2.id
                    INNER JOIN modules AS m2 ON f2.module_id = m2.id
                    INNER JOIN patchdetails ON patchdetails.file_id = relationships.used
                    GROUP BY
                    patchdetails.patch_id,
                    m2.name,
                    m1.name;");
            ExecuteNonQuery(@"CREATE VIEW patchview2 AS 
                    SELECT
                    patchview.patch_id,
                    m1.name AS uses,
                    m2.name AS used,
                    Count(relationships.rate) AS count,
                    Sum(relationships.rate) AS rate
                    FROM
                    modules AS m1
                    INNER JOIN files AS f1 ON m1.id = f1.module_id
                    INNER JOIN relationships ON f1.id = relationships.uses
                    INNER JOIN files AS f2 ON relationships.used = f2.id
                    INNER JOIN modules AS m2 ON f2.module_id = m2.id
                    INNER JOIN patchview ON m2.name = patchview.uses
                    WHERE
                    m1.id <> m2.id AND
                    patchview.used <> m1.name
                    GROUP BY
                    m1.name,
                    m2.name,
                    patchview.patch_id;");

        }
    }
}
