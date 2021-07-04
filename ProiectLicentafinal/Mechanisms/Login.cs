using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Mechanisms
{
    public class Login
    {
        Database database;

        public Login()
        {
            database = new Database("dbtest");

        }


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

        public int LoginApp(string user, string password)
        {
            if(VerificareUserBD(user) == false)
            {
                return -1;
            }
            if(VerifyHash(password,user) == false)
            {
                return 0;
            }
            return 1;

        }
        private bool VerificareUserBD(string user)
        {
            return database.VerifyUser(user);

        }
        public bool VerifyHash(string passwordStr, string user)
        {

            var saltbd = database.GetSalt(user);
           
            uint hash_len = 32;
            uint t_cost = 2;
            uint m_cost = (1 << 16);
            uint parallelism = 4;
            byte[] hash = new byte[hash_len];
            uint salt_len = 32; 
            byte[] saltByteArr = saltbd;
            var passwordByteArr = Encoding.ASCII.GetBytes(passwordStr);


            export_func(passwordByteArr, (uint)passwordByteArr.Length, hash, hash_len, saltByteArr, salt_len, t_cost, m_cost, parallelism); 

            string hash_string = BitConverter.ToString(hash).Replace("-", string.Empty);

            return database.CompareHash(hash, user);
        }
       

        public int NewUser(string user, string passwordStr,string isadmin,string departament,string master_user= "LoginUnknown")
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

            string salt = BitConverter.ToString(saltByteArr).Replace("-",string.Empty);
           
            string hash1_string = BitConverter.ToString(hash1).Replace("-", string.Empty);

            var salt_hash = saltByteArr.Concat(hash1).ToArray();

            try
            {
                database.CreateNewUser(user, salt_hash ,isadmin,master_user,departament);
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
            
            
        }

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
        public int NewUser(string user, string passwordStr,string departament)
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

            try
            {
                database.CreateNewUser(user, salt_hash, "0", "LoginUnknown",departament);
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }

        }
    }
}
