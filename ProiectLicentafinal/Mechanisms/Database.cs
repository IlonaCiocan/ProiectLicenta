using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Mechanisms
{
    public class Database
    {
        string connectionstring;
        SQLiteConnection _dbConnection;

        public Database(string name)
        {

            connectionstring = "Data Source=" + name + ".sqlite;Version=3;";
            if (File.Exists(name + ".sqlite"))
            {
                _dbConnection = new SQLiteConnection(connectionstring);
            }
            else
            {
                CreateNewDB(name, connectionstring, "");
                _dbConnection = new SQLiteConnection(connectionstring);
            }



        }

        public void CreateNewDB(string db_name, string connectionstring, string user)
        {
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {

                SQLiteConnection.CreateFile(db_name + ".sqlite");
                string sql = "create table Users (user_id INTEGER PRIMARY KEY, isadmin varchar(30), name varchar(30),departament varchar(50), hashdefault blob(256))";
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                _dbConnection.Open();
                command.ExecuteNonQuery();
                _dbConnection.Close();
                Login lg = new Login();
                lg.NewUser("admin", "admin1998@", "1", "Administrator");
                WriteToLogFile("Creare_baza_de_date", db_name, "", user);

            }

        }
        public void CreateNewUser(string nume, byte[] hashdefault, string isadmin, string user, string departament)
        {
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql1 = "insert into Users (name,isadmin,departament, hashdefault) values (@nume, @isadmin, @departament, @hashdefault)";
                SQLiteCommand command = new SQLiteCommand(sql1, _dbConnection);
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@isadmin", isadmin);
                command.Parameters.AddWithValue("@departament", departament);
                command.Parameters.AddWithValue("@hashdefault", hashdefault);
                _dbConnection.Open();
                command.ExecuteNonQuery();
                _dbConnection.Close();
                WriteToLogFile("Creare_user_nou", nume, "", user);
            }


        }

        //public void ChangeDefaultPassword(string username, byte[] hashdefault, string user)
        //{
        //        using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
        //        using (SQLiteCommand command = _dbConnection.CreateCommand())
        //        {
        //            command.CommandText = "update Users set hashdefault=@hashdefault where name=@username";

        //            command.Parameters.AddWithValue("@username", username);
               
        //            command.Parameters.AddWithValue("@hashdefault", hashdefault);
           
        //            _dbConnection.Open();
        //            command.ExecuteNonQuery();
        //            _dbConnection.Close();
        //            WriteToLogFile("Resetare_parola", username, "", user);

        //        }


        //    }
        [DllImport("argon.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int export_func(byte[] password,
                                                    uint passwordLen,
                                                    [In, Out] byte[] hash,
                                                    uint hash_len,
                                                    byte[] salt,
                                                    uint saltLen,
                                                    uint t_cost,
                                                    uint m_cost,
                                                    uint parallelism);

        [DllImport("RDRand_ASM.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int export_rdrand([In, Out] byte[] salt,
                                                   uint length);
        //public bool VerifyHash(string passwordStr, string user)
        //{

        //    var saltbd = GetSalt(user);

        //    uint hash_len = 32;
        //    uint t_cost = 2;
        //    uint m_cost = (1 << 16);
        //    uint parallelism = 4;
        //    byte[] hash = new byte[hash_len];
        //    uint salt_len = 32;
        //    byte[] saltByteArr = saltbd;
        //    var passwordByteArr = Encoding.ASCII.GetBytes(passwordStr);


        //    export_func(passwordByteArr, (uint)passwordByteArr.Length, hash, hash_len, saltByteArr, salt_len, t_cost, m_cost, parallelism);

        //    string hash_string = BitConverter.ToString(hash).Replace("-", string.Empty);

        //    return CompareHash(hash, user);
        //}
        public byte[] HashPsw(string passwordStr)
        {
            uint hash_len = 32;
            uint t_cost = 2;
            uint m_cost = (1 << 16);
            uint parallelism = 4;
            byte[] hash1 = new byte[hash_len];

            uint salt_len = 32;
            byte[] saltByteArr = new byte[salt_len];
            export_rdrand(saltByteArr, salt_len);
            var passwordByteArr = Encoding.ASCII.GetBytes(passwordStr);


            int asd = export_func(passwordByteArr, (uint)passwordByteArr.Length, hash1, hash_len, saltByteArr, salt_len, t_cost, m_cost, parallelism);

            string salt = BitConverter.ToString(saltByteArr).Replace("-", string.Empty);

            string hash1_string = BitConverter.ToString(hash1).Replace("-", string.Empty);

            var salt_hash = saltByteArr.Concat(hash1).ToArray();
            return salt_hash;
        }

        //public void ChangePsw(string username, byte[] hashdefault, string user)
        //{

        //    using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
        //    {
        //        _dbConnection.Open();

        //        string sql = "update Users set  hashdefault = @hashdefault where name = @username";
        //        using (SQLiteCommand command = new SQLiteCommand(sql, _dbConnection))
        //        {
        //            command.Parameters.AddWithValue("@username", username);
        //            command.Parameters.AddWithValue("@hashdefault", hashdefault);

        //            command.ExecuteNonQuery();
        //        }
        //        WriteToLogFile("Schimbare_parola", username, "", user);
        //    }

        //}
       
        public bool VerifyUser(string user)
        {
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select * from Users";
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                _dbConnection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["name"].ToString() == user)
                        {
                            _dbConnection.Close();
                            //reader.Close();
                            return true;
                        }


                    }

                    _dbConnection.Close();
                    ////reader.Close();
                    return false;
                }
            }


        }
        public string getDepartament(string user_acc)
        {
            string departament = "";
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select departament from Users where name=@user_acc";
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                command.Parameters.AddWithValue("@user_acc", user_acc);
                _dbConnection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                         departament = reader["departament"].ToString();
                        
                     
                    }
                    reader.Close();
                    _dbConnection.Close();
                    
                 
                }
                return departament;
            }

        }

        public List<string> getDepartaments()
        {
           
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select distinct departament from Users order by departament";
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                List<string> _list_dep = new List<string>();
                _dbConnection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string departament = reader["departament"].ToString();

                        _list_dep.Add(departament);
                    }
                    try
                    {
                        reader.Close();
                        _dbConnection.Close();
                    }
                    catch
                    {

                    }
                    return _list_dep;
                }
            }

        }

        public string CountAcc()
        {

            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select count(distinct name) from Users";
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                string accounts = "";
                _dbConnection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts = reader[0].ToString();
                        
                    }
                    try
                    {
                        reader.Close();
                        _dbConnection.Close();
                    }
                    catch
                    {

                    }
                    return accounts;
                }
            }

        }
        public string CountAdm()
        {

            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select count(distinct name) from Users where isadmin='1' ";
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                string accounts = "";
                _dbConnection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts = reader[0].ToString();

                       

                    }
                    try
                    {

                        _dbConnection.Close();
                        //reader.Close();
                    }
                    catch
                    {

                    }
                    return accounts;
                }
            }

        }
        public byte[] GetSalt(string user)
        {
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select hashdefault from Users where name ='" + user + "'";
                char[] saltbd = new char[32];
                byte[] saltByteArr = new byte[32];
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                _dbConnection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reader.GetBytes(reader.GetOrdinal("hashdefault"), 0, saltByteArr, 0, 32);

                        _dbConnection.Close();
                        
                        return saltByteArr;
                    }

                }

                _dbConnection.Close();
                return null;
            }
        }
        public bool CompareHash(byte[] hash, string user)
        {
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select hashdefault from Users where name ='" + user + "'";
                byte[] hashbd = new byte[32];
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                _dbConnection.Open();
              
                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        reader.GetBytes(reader.GetOrdinal("hashdefault"), 32, hashbd, 0, 32);
                        if (hashbd.SequenceEqual(hash))
                        {
                            _dbConnection.Close();
                            WriteToLogFile("Incercare_logare", user, "reusit", user);
                            return true;
                        }
                      


                    }
                    try
                    {
                        _dbConnection.Close();

                    }
                    catch
                    {

                    }
                    WriteToLogFile("Incercare_logare", user, "nereusit", user);


                    return false;

                    //reader.Close();
                }
                //  return code;

            }


        }
        public List<User> GetAllUsers()
        {
            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                string sql = "select * from Users";
                SQLiteCommand command = new SQLiteCommand(sql, _dbConnection);
                List<User> _list_users = new List<User>();
                _dbConnection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string user = reader["name"].ToString();

                        User usr = new User(user);
                        _list_users.Add(usr);
                    }
                    try
                    {
                        reader.Close();
                        _dbConnection.Close();
                        //reader.Close();
                    }
                    catch
                    {

                    }
                    return _list_users;
                }
            }

        }
        public void ModifyUser( string username, byte[] hashdefault, string isadmin, string who,string departament)
        {

            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            using (SQLiteCommand command = _dbConnection.CreateCommand())
            {
                command.CommandText = "update Users set hashdefault=@hashdefault, isadmin=@isadmin,departament=@departament where name=@username";

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@isadmin", isadmin);
                command.Parameters.AddWithValue("@hashdefault", hashdefault);
                command.Parameters.AddWithValue("@departament", departament);
                _dbConnection.Open();
                command.ExecuteNonQuery();
                _dbConnection.Close();
                WriteToLogFile("Modificare_date_user", username, "reusit", who);

            }

        }

        public void DeteleSpecificUser(string desters, string user)
        {

            using (SQLiteConnection _dbConnection = new SQLiteConnection(connectionstring))
            {
                using (SQLiteCommand command = _dbConnection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Users WHERE name=@desters";
                    command.Parameters.AddWithValue("@desters", desters);
                    _dbConnection.Open();
                    command.ExecuteNonQuery();
                    _dbConnection.Close();

                    WriteToLogFile("Stergere_user", desters, "", user);
                }

            }
        }

        public bool isAdmin(string nume)
        {

            bool isadm = false;

            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                con.Open();
                string sql = "select * from Users";
                using (SQLiteCommand command = new SQLiteCommand(sql, con))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["name"].ToString() == nume)
                            {
                                if (reader["isadmin"].ToString().Trim() == "1")
                                {
                                    isadm = true;
                                    break;
                                }
                                else
                                {
                                    isadm = false;
                                    break;
                                }
                            }
                        }

                    }

                }
                con.Close();

            }

            return isadm;


        }


        public void WriteToLogFile(string tip, string paramentru1, string parametru2, string user)
        {
            TextWriter tsw = new StreamWriter(@"logfile.txt", true);
            tsw.WriteLine(tip + " - " + paramentru1 + " - " + parametru2 + " - " + user + " - " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
            tsw.Close();
        }
    }
}
