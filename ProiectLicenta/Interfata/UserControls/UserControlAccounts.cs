using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectLicenta.Business_Layer;
using Mechanisms;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class but : UserControl
    {
        List<User> _lista_useri;
        List<Button> _lista_butoane;
        Database db;
        string _user;
        FormPrincipal mainForm;

        public but(string user,FormPrincipal mainF)
        {
            InitializeComponent();
            this._user = user;
            db = new Database("dbtest");
            mainForm = mainF;
            _lista_useri = new List<User>();
            _lista_butoane = new List<Button>();
            GetUsersBD();
             AfisareUsers();
        }

        public void GetUsersBD()
        {
            _lista_useri = db.GetAllUsers();
        }

        public void AfisareUsers()
        {
            for(int i=0;i<_lista_useri.Count;i++)
            {
                if (_lista_useri[i].getnume() != _user)
                {
                    Business_Layer.ButonAccount butonAccount = new Business_Layer.ButonAccount(_lista_useri[i], this, this._user, mainForm);
                    butonAccount.Tag = _lista_useri[i].gettag();
                    this.panel_acc.Controls.Add(butonAccount);
                    this._lista_butoane.Add(butonAccount);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.BringNewAccountToFront();      
        }



        private void panel_acc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_Load(object sender, EventArgs e)
        {

        }
        [DllImport("aesgcm.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int export_aes_gcm_encrypt(
                             byte[] key,
                             uint keyLen,
                             byte[] iv,
                             uint ivLen,
                             byte[] plaintext,
                             [In, Out] byte[] ciphertext,
                             uint plaintextLen,
                             [In, Out] byte[] authTag,
                             uint authTagLen);
        private void GenSetupFile(object sender, EventArgs e)
        {
            byte[] LogFile = File.ReadAllBytes("logfile.txt");
            byte[] ExecFile = File.ReadAllBytes("ProiectLicenta.exe");
            SHA512 sHA512 = new SHA512Managed();
            var LogFileHashed = sHA512.ComputeHash(LogFile);
            var ExecFileHashed = sHA512.ComputeHash(ExecFile);
            var SetupFile = new byte[128];
            Array.Copy(LogFileHashed, 0, SetupFile, 0, 64);
            Array.Copy(ExecFileHashed, 0, SetupFile, 64, 64);

            // Mock implementation: proof of concept only
            var password = "Password";
            UserControlKey.CurrentKey = UserControlKey.GenKeyForEnc(password);
            
            byte[] authTag = new byte[15];
            byte[] ciphertext = new byte[SetupFile.Length];
            int ret = export_aes_gcm_encrypt(UserControlKey.CurrentKey, (uint)UserControlKey.CurrentKey.Length, UserControlKey.CurrentIV, (uint)UserControlKey.CurrentIV.Length, SetupFile, ciphertext, (uint)SetupFile.Length, authTag, (uint)authTag.Length);

            byte[] toFile = new byte[UserControlKey.CurrentSalt.Length + ciphertext.Length + authTag.Length];
            UserControlKey.CurrentSalt.CopyTo(toFile, 0);
            ciphertext.CopyTo(toFile, UserControlKey.CurrentSalt.Length);
            authTag.CopyTo(toFile, UserControlKey.CurrentSalt.Length + ciphertext.Length);


            // zero-ing memory location of the Salt, IV and Key for a better security
            Array.Clear(UserControlKey.CurrentSalt, 0, UserControlKey.CurrentSalt.Length);
            Array.Clear(UserControlKey.CurrentKey, 0, UserControlKey.CurrentKey.Length);
            Array.Clear(UserControlKey.CurrentIV, 0, UserControlKey.CurrentIV.Length);

            FileInfo fileInfo = new FileInfo("setup_file");
            File.WriteAllBytes(fileInfo.Directory.FullName + @"\enc_" + fileInfo.Name, toFile);

            MessageBox.Show("Setup File generat!");
        }
    }
}
