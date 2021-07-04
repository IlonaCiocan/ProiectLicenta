using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mechanisms;
using ProiectLicenta.Business_Layer;
using ProiectLicenta.Interfata.UserControls;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlKey : UserControl
    {

        Database db;
        string user;
        public string typeB;
        FormPrincipal mainForm;
        public static byte[] CurrentSalt { get; set; }
        public static byte[] CurrentIV { get; set; }
        public static byte[] CurrentKey { get; set; }

        [DllImport("RDRand_ASM.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int export_rdrand([In, Out] byte[] salt,
                                                   uint length);

        [DllImport("Argon2_Blk3.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int export_argon2_blake3(uint t_cost,
                                             uint m_cost,
                                             uint parallelism,
                                             byte[] password,
                                             uint passwordLen,
                                             byte[] salt,
                                             uint saltLen,
                                             [In, Out] byte[] hash,
                                             uint hash_len);
        public UserControlKey(string who, FormPrincipal mainF)
        {
            InitializeComponent();
            this.user = who;
            db = new Database("dbtest");
       
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "Parola";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Text = "Confirmare parolă";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);

            Initializare();
            mainForm = mainF;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {

               
                textBox1.UseSystemPasswordChar = false;
                textBox1.PasswordChar = '\0';
                textBox1.Text = "Parola";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Parola")
            {
                int bullet = 9679;
              
                textBox1.Text = "";

                textBox1.PasswordChar = (char)bullet;

                textBox1.ForeColor = SystemColors.WindowText;

                label_message_key.Text = "  Parola trebuie să conțină minim 12 caractere,\n cel puțin o literă mare și o literă mică, o cifră \n și cel puțin un caracter special.";
            }
        }


        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Confirmare parolă";
                textBox2.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Confirmare parolă")
            {
                int bullet = 9679;
                textBox2.Enabled = true;
                textBox2.Text = "";

                textBox2.PasswordChar = (char)bullet;

                textBox2.ForeColor = SystemColors.WindowText;
            }
        }
        public void Initializare()
        {

            List<User> _lista_useri = new List<User>();
            _lista_useri = db.GetAllUsers();
            for (int i = 0; i < _lista_useri.Count; i++)
            {
                this.comboBox1.Items.Add(_lista_useri[i].getnume());
            }
            this.comboBox1.SelectedItem = this.user;
            this.comboBox1.AllowDrop = false;
            this.comboBox1.Enabled = false;
        }

        private void ButtonLogare_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length < 3)
            {
                MessageBox.Show("Introduceti parola");
            }
            else
            {
                if (!this.textBox1.Text.Equals(this.textBox2.Text))
                {
                    MessageBox.Show("Parolele nu coincid");
                }
                else
                {
                    if (mainForm.uc_newkey.typeB.Equals("E"))
                    {
                        CurrentKey = GenKeyForEnc(this.textBox2.Text.ToString());
                    }
                    if (mainForm.uc_newkey.typeB.Equals("D"))
                    {
                        CurrentKey = GenKeyForDec(this.textBox2.Text.ToString());
                    }
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    mainForm.BringCryptoKeyToFront(null, typeB);
                }
            }

        }

        private byte[] GenKeyForDec(string password)
        {
            uint t_cost = 2;
            uint m_cost = (1 << 16);
            uint parallelism = 4;
            CurrentSalt = new byte[32];
            byte[] rawCiphertext = File.ReadAllBytes(mainForm.uc_decrypt.selectedFile);
            var passwordByteArr = Encoding.ASCII.GetBytes(password);
            Array.Copy(rawCiphertext, 0, CurrentSalt, 0, 32);

            byte[] hash = new byte[44];
            int ret_a2_b3 = export_argon2_blake3(t_cost, m_cost, parallelism, passwordByteArr, (uint)passwordByteArr.Length, CurrentSalt, (uint)CurrentSalt.Length, hash, (uint)hash.Length);

            CurrentKey = new byte[32];
            CurrentIV = new byte[12];

            Array.Copy(hash, 0, CurrentKey, 0, 32);
            Array.Copy(hash, 32, CurrentIV, 0, 12);

            return CurrentKey;
        }

        public static void GenKeyForSetupDec(string password)
        {
            uint t_cost = 2;
            uint m_cost = (1 << 16);
            uint parallelism = 4;
            CurrentSalt = new byte[32];
            byte[] rawCiphertext = File.ReadAllBytes("enc_setup_file");
            var passwordByteArr = Encoding.ASCII.GetBytes(password);
            Array.Copy(rawCiphertext, 0, CurrentSalt, 0, 32);
            byte[] hash = new byte[44];
            int ret_a2_b3 = export_argon2_blake3(t_cost, m_cost, parallelism, passwordByteArr, (uint)passwordByteArr.Length, CurrentSalt, (uint)CurrentSalt.Length, hash, (uint)hash.Length);

            CurrentKey = new byte[32];
            CurrentIV = new byte[12];

            Array.Copy(hash, 0, CurrentKey, 0, 32);
            Array.Copy(hash, 32, CurrentIV, 0, 12);
        }

        public static byte[] GenKeyForEnc(string password)
        {
            uint hash_len = 44;
            uint t_cost = 2;
            uint m_cost = (1 << 16);
            uint parallelism = 4;
            byte[] hash = new byte[hash_len];
            uint salt_len = 32;
            byte[] saltByteArr = new byte[salt_len];
            int ret_rdrand = export_rdrand(saltByteArr, salt_len);
            var passwordByteArr = Encoding.ASCII.GetBytes(password);
            CurrentSalt = new byte[32];
            CurrentIV = new byte[12];

            int ret_a2_b3 = export_argon2_blake3(t_cost, m_cost, parallelism, passwordByteArr, (uint)passwordByteArr.Length, saltByteArr, salt_len, hash, hash_len);

            if ((ret_rdrand != 0) && (ret_a2_b3 != 0))
            {
                return null;
            }

            byte[] key = new byte[32];
            saltByteArr.CopyTo(CurrentSalt, 0);
            Array.Copy(hash, 0, key, 0, 32);
            Array.Copy(hash, 32, CurrentIV, 0, 12);

            return key;
        }



        private void UserControlKey_Load(object sender, EventArgs e)
        {

        }

       

        private void Clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";

        }
        private void button_cancelKey(object sender, EventArgs e)
        {
            if (typeB == "E")
                mainForm.BringEncryptToFront(typeB);
            else if (typeB == "D")
                mainForm.BringDecryptToFront(typeB);
            this.Clear();
        }
        public string CheckPassword(string textBox_pass)
        {
            string psw = textBox_pass;
            if (psw.Length > 11)
            {
                if (Regex.IsMatch(psw, "[a-zA-Z]"))
                {
                    if (Regex.IsMatch(psw, "[!@#$%^&*()_+]"))
                    {
                        if (Regex.IsMatch(psw, "[1234567890]"))
                        {
                            if (Regex.IsMatch(psw, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z])(?=.*[!@#^&*()_+]).{12}.+$"))
                            {
                                if (Regex.IsMatch(psw, "[<>%'${}\\[\\]]"))
                                {
                                    return "Parola conține caractere speciale nepermise!";
                                }
                                else
                                    return "ok";
                            }
                        }
                        else
                            return "Parola trebuie să conțină minim o cifră!";
                    }
                    else
                        return "Parola trebuie să conțină minim un caracter special!\nCaractere speciale permise @#^&*()_+";
                }
                else
                    return "Parola trebuie să conțină minim o literă mare și o literă mică! ";
            }
            return "Parola trebuie să conțină minim 12 caractere!";
        }
        public string CheckRetype()
        {
            if (this.textBox1.Text == this.textBox2.Text)
            {
                return "ok";
            }
            return "Parolele nu se potrivesc";
        }
        private void Check(String password)
        {
            String message = CheckPassword(password);
            if (message != "ok")
            {
                label_message_key.Visible = true;
                label_message_key.Text = message;
                label_message_key.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                label_message_key.Text = "";
            }


        }
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            Check(textBox1.Text);

        }

        private void TextBoxRetype_TextChanged(object sender, EventArgs e)
        {
            Check(textBox2.Text);


        }
        private void Label_Message_Changed(object sender, EventArgs e)
        {
            string message = CheckRetype();
            if (message == "ok" && label_message_key.Text == "")
            {
                button1_checkp.Visible = true;
                button2_retypep.Visible = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 
}
