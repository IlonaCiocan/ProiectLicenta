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
using System.Runtime.InteropServices;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlDecrypt : UserControl
    {

        public string selectedFile;
        string user;
        FormPrincipal mainForm;
        public UserControlDecrypt(string who, FormPrincipal mainF)
        {
            mainForm = mainF;
            InitializeComponent();
            this.user = who;

            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
                mainForm.BringGenerateKeyToFront("D");
        }

        [DllImport("aesgcm.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int export_aes_gcm_decrypt(
                                     byte[] key,
                                     uint keyLen,
                                     byte[] iv,
                                     uint ivLen,
                                     [In, Out] byte[] decrypted,
                                     byte[] ciphertext,
                                     uint plaintextLen,
                                     byte[] authTag,
                                     uint authTagLen);
        public void Decrypt(string fisier)
        {
            byte[] authTag = new byte[15];
            byte[] salt = new byte[32];
            byte[] rawCiphertext = File.ReadAllBytes(fisier);
            byte[] ciphertext = new byte[rawCiphertext.Length - authTag.Length - salt.Length];

            // extract salt, authentication and ciphertext tag from raw encrypted file
            Array.Copy(rawCiphertext, 0, salt, 0, 32);
            Array.Copy(rawCiphertext, 32, ciphertext, 0, ciphertext.Length);
            Array.Copy(rawCiphertext, salt.Length + ciphertext.Length, authTag, 0, authTag.Length);

            byte[] decrypted = new byte[ciphertext.Length];

            int ret = export_aes_gcm_decrypt(UserControlKey.CurrentKey, (uint)UserControlKey.CurrentKey.Length, UserControlKey.CurrentIV, (uint)UserControlKey.CurrentIV.Length, decrypted, ciphertext, (uint)ciphertext.Length, authTag, (uint)authTag.Length);

            byte[] toFile = new byte[ciphertext.Length];
            decrypted.CopyTo(toFile, 0);


            // zero-ing memory location for the Salt, IV and Key for a better security
            Array.Clear(UserControlKey.CurrentSalt, 0, UserControlKey.CurrentSalt.Length);
            Array.Clear(UserControlKey.CurrentKey, 0, UserControlKey.CurrentKey.Length);
            Array.Clear(UserControlKey.CurrentIV, 0, UserControlKey.CurrentIV.Length);

            FileInfo fileInfo = new FileInfo(fisier);
            File.WriteAllBytes(fileInfo.Directory.FullName + @"\dec_" + fileInfo.Name, toFile);

            WriteToLogFile("Operatiune_decriptare", this.label3.Text, @"\dec_" + this.label3.Text, this.user);
            DialogResult result=MessageBox.Show("Fisier Decriptat");
            if(result==DialogResult.OK)
            {
                this.pictureBox2.Visible = false;
                this.pictureBox1.Visible = false;
                this.pictureBox3.Visible = false;
                this.selectedFile = null;
                this.label3.Text = "Nume fișier";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selectedFile) || (this.pictureBox2.Visible == false))
                MessageBox.Show("Fisierul sau parola nu au fost selectatate!");
            else
                Decrypt(selectedFile);
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
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la citire");
                }

                this.pictureBox1.Visible = true;
                this.label3.Text = ofd.SafeFileName.ToString();
            }
        }

        public static void WriteToLogFile(string tip, string paramentru1, string parametru2, string user)
        {
            TextWriter tsw = new StreamWriter(@"logfile.txt", true);
            tsw.WriteLine(tip + " - " + paramentru1 + " - " + parametru2 + " - " + user + " - " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
            tsw.Close();
        }
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
