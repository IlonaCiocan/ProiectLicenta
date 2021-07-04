using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlCrypt : UserControl
    {
        string selectedFile;

        string user;
        FormPrincipal mainForm;
        public UserControlCrypt(string who, FormPrincipal main)
        {
            mainForm = main;
            InitializeComponent();
            this.user = who;
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
        }

        private void IncarcatiFisierul(object sender, EventArgs e)
        {
            System.IO.Stream myStream;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            this.pictureBox1.Visible = true;
                            this.selectedFile = ofd.FileName;
                            MessageBox.Show(ofd.SafeFileName);
                            myStream.Close();
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la citirea fisierului " + ofd.SafeFileName);
                }

                this.pictureBox1.Visible = true;
                this.label3.Text = ofd.SafeFileName.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        public void Crypt(string fisier)
        {
            byte[] authTag = new byte[15];
            byte[] plaintext = File.ReadAllBytes(fisier);
            byte[] ciphertext = new byte[plaintext.Length];


            int ret = export_aes_gcm_encrypt(UserControlKey.CurrentKey, (uint)UserControlKey.CurrentKey.Length, UserControlKey.CurrentIV, (uint)UserControlKey.CurrentIV.Length, plaintext, ciphertext, (uint)plaintext.Length, authTag, (uint)authTag.Length);

            byte[] toFile = new byte[UserControlKey.CurrentSalt.Length + ciphertext.Length + authTag.Length];
            UserControlKey.CurrentSalt.CopyTo(toFile, 0);
            ciphertext.CopyTo(toFile, UserControlKey.CurrentSalt.Length);
            authTag.CopyTo(toFile, UserControlKey.CurrentSalt.Length + ciphertext.Length);


            // zero-ing memory location of the Salt, IV and Key for a better security
            Array.Clear(UserControlKey.CurrentSalt, 0, UserControlKey.CurrentSalt.Length);
            Array.Clear(UserControlKey.CurrentKey, 0, UserControlKey.CurrentKey.Length);
            Array.Clear(UserControlKey.CurrentIV, 0, UserControlKey.CurrentIV.Length);

            FileInfo fileInfo = new FileInfo(fisier);
            File.WriteAllBytes(fileInfo.Directory.FullName + @"\enc_" + fileInfo.Name, toFile);

            WriteToLogFile("Operatiune_criptare", this.label3.Text, @"\enc_" + this.label3.Text, this.user);

            DialogResult result = MessageBox.Show("Fisier Criptat");
            if (result == DialogResult.OK)
            {
                this.pictureBox2.Visible = false;
                this.pictureBox1.Visible = false;
                this.pictureBox3.Visible = false;
                this.selectedFile = null;
                this.label3.Text = "Nume fișier";


            }

        }

        public static void WriteToLogFile(string tip, string paramentru1, string parametru2, string user)
        {
            TextWriter tsw = new StreamWriter(@"logfile.txt", true);
            tsw.WriteLine(tip + " - " + paramentru1 + " - " + parametru2 + " - " + user + " - " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
            tsw.Close();
        }

        private void Criptare(object sender, EventArgs e)
        {
           if ( String.IsNullOrEmpty(selectedFile) || (this.pictureBox2.Visible == false)) 
               MessageBox.Show("Fisierul sau parola nu au fost selectatate!");
            else
               Crypt(this.selectedFile);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
                mainForm.BringGenerateKeyToFront("E");
         }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UserControlCrypt_Load(object sender, EventArgs e)
        {

        }
    }
}
