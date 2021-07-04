using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mechanisms;
using ProiectLicenta.Business_Layer;
using ProiectLicenta.Interfata.UserControls;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlMainForm : UserControl
    {
        UserControlNewAccount uc_newacc;


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

        public UserControlMainForm(string type="")
        {
            InitializeComponent();
            this.uc_newacc = new UserControlNewAccount();
            this.uc_newacc.Dock = DockStyle.Fill;
            this.uc_newacc.Tag = "newacc";
            this.ActiveControl = buttonLogare;

            textBox_user.ForeColor = SystemColors.GrayText;
            textBox_user.Text = "Nume utilizator";
            this.textBox_user.Leave += new System.EventHandler(this.textBox_user_Leave);
            this.textBox_user.Enter += new System.EventHandler(this.textBox_user_Enter);

            textBox2_password.UseSystemPasswordChar = false;
            textBox2_password.ForeColor = SystemColors.GrayText;
            textBox2_password.Text = "Parola";
            this.textBox2_password.Leave += new System.EventHandler(this.textBox2_password_Leave);
            this.textBox2_password.Enter += new System.EventHandler(this.textBox2_password_Enter);

            if (File.Exists("enc_setup_file"))
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
                UserControlKey.GenKeyForSetupDec(password);

                byte[] authTag = new byte[15];
                byte[] salt = new byte[32];
                byte[] rawCiphertext = File.ReadAllBytes("enc_setup_file");
                byte[] ciphertext = new byte[rawCiphertext.Length - authTag.Length - salt.Length];

                // extract salt, authentication and ciphertext tag from raw encrypted file
                Array.Copy(rawCiphertext, 0, salt, 0, 32);
                Array.Copy(rawCiphertext, 32, ciphertext, 0, ciphertext.Length);
                Array.Copy(rawCiphertext, salt.Length + ciphertext.Length, authTag, 0, authTag.Length);

                byte[] decrypted = new byte[ciphertext.Length];

                int ret = export_aes_gcm_decrypt(UserControlKey.CurrentKey, (uint)UserControlKey.CurrentKey.Length, UserControlKey.CurrentIV, (uint)UserControlKey.CurrentIV.Length, decrypted, ciphertext, (uint)ciphertext.Length, authTag, (uint)authTag.Length);

                byte[] LogFileHashedFromFile = new byte[64];
                byte[] ExecFileHashedFromFile = new byte[64];

                Array.Copy(decrypted, 0, LogFileHashedFromFile, 0, 64);
                Array.Copy(decrypted, 64, ExecFileHashedFromFile, 0, 64);
                if (type != "iesire")
                {
                    if (LogFileHashed.SequenceEqual(LogFileHashedFromFile) && ExecFileHashed.SequenceEqual(ExecFileHashedFromFile))
                    {
                        MessageBox.Show("Fisierele de setup coincid.");
                        File.Delete("enc_setup_file");
                    }
                    else
                    {
                        MessageBox.Show("Fisierele de setup au fost alterate.");
                    }
                }

            }
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void Button_mini_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ButonAutentificare();
        }


        public void ButonAutentificare()
        {   
            panel2.Controls.Add(uc_newacc);
            for (int i = 0; i < this.panel2.Controls.Count; i++)
            {
                this.panel2.Controls[i].Hide();
            }
            for (int i = 0; i < this.panel2.Controls.Count; i++)
            {
                try
                {
                    if (this.panel2.Controls[i].Tag.ToString() == "newacc")
                    {
                        this.panel2.Controls[i].Show();
                        this.panel2.Controls[i].BringToFront();
                        break;
                    }
                }
                catch
                {
                    continue;
                }

            }

        }

        private void buttonLogare_Click(object sender, EventArgs e)
        {

            Login lg = new Login();
            try
            {
                int rez = lg.LoginApp(this.textBox_user.Text, this.textBox2_password.Text);
                if (rez == -1)
                {
                    MessageBox.Show("Utilizator inexistent!");
                }
                else
                {
                    if (rez == 0)
                    {
                        
                       MessageBox.Show("Parolă incorectă!");
                    }
                    else
                    {
                        Interfata.FormPrincipal formPrincipal = new Interfata.FormPrincipal(this.textBox_user.Text);

                        ((Form)this.TopLevelControl).Hide();
                        formPrincipal.ShowDialog();
                        ((Form)this.TopLevelControl).Close();
                       
                       

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void textBox_user_Leave(object sender, EventArgs e)
        {
            if (textBox_user.Text.Length == 0)
            {
                textBox_user.Text = "Nume utilizator";
                textBox_user.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox_user_Enter(object sender, EventArgs e)
        {
            if (textBox_user.Text == "Nume utilizator")
            {
                textBox_user.Text = "";
                textBox_user.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox2_password_Leave(object sender, EventArgs e)
        {
            if (textBox2_password.Text.Length == 0)
            {   
                textBox2_password.UseSystemPasswordChar = false;
                textBox2_password.PasswordChar = '\0';
                textBox2_password.Text = "Parola";
                textBox2_password.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox2_password_Enter(object sender, EventArgs e)
        {
            if (textBox2_password.Text == "Parola")
            {
                textBox2_password.Text = "";
                textBox2_password.UseSystemPasswordChar = true;
                textBox2_password.PasswordChar = '*';

                textBox2_password.ForeColor = SystemColors.WindowText;
            }
        }


        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLogare_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserControlMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
