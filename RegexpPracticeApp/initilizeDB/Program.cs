using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace initilizeDB {
    class Program {
        static void Main(string[] args) {
            
            string dbName = "Regexp.db";
            string passWord = "password";

            //存在する時削除する
            if (File.Exists(dbName)){ File.Delete(dbName); }

            using(SQLiteConnection con = new SQLiteConnection("Data Source = " + dbName + ";password=" + passWord)){
                con.Open();

                using (SQLiteTransaction trans = con.BeginTransaction()) {


                    //[mst_match]tableの作成
                    string sql = "CREATE TABLE [mst_match] (" +
                                   "[id]   INTEGER PRIMARY KEY AUTOINCREMENT," +
                                   "[item] TEXT    NOT NULL UNIQUE" +
                                 ");";
                    using (SQLiteCommand cmd = con.CreateCommand()) {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }


                    //[problem]tableの作成
                    sql = "CREATE TABLE [problemList] (" +
                            "[id]      INTEGER      PRIMARY KEY AUTOINCREMENT," +
                            "[title]   VARCHAR(50)  NOT NULL," +
                            "[problem] VARCHAR(500) NOT NULL," +
                            "[data]    VARCHAR(500) NOT NULL," +
                            "[answer]  VARCHAR(500) NOT NULL," +
                            "[level]   INTEGER      NOT NULL," +
                            "[ctime]   VARCHAR(19)  NOT NULL CHECK( [ctime] like '____-__-__ __:__:__')," +
                            "[mtime]   VARCHAR(19)  NOT NULL CHECK( [mtime] like '____-__-__ __:__:__')" +
                          ");";
                    using (SQLiteCommand cmd = con.CreateCommand()) {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }


                    //[matchData]tableの作成
                    sql = "CREATE TABLE [matchData] (" +
                            "[problem_id]  INTEGER NOT NULL REFERENCES [problemList]([id]) ON DELETE CASCADE," +
                            "[type]        INTEGER NOT NULL REFERENCES [mst_match]([id])," +
                            "[matchIndex]  INTEGER NOT NULL," +
                            "[matchLength] INTEGER NOT NULL" +
                          ");";
                    using (SQLiteCommand cmd = con.CreateCommand()) {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }

                    string[] items = new string[]{"全体にマッチ", "カッコ内にマッチ"};
                    foreach (string item in items){
                        sql ="INSERT INTO [mst_match] ([item]) VALUES(@item);";
                        using (SQLiteCommand cmd = con.CreateCommand()) {
                            cmd.CommandText = sql;
                            cmd.Parameters.Add("item", System.Data.DbType.String);
                            cmd.Parameters["item"].Value = item;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    
                    trans.Commit();
                }

                con.Close();
            }
        }
    }
}
