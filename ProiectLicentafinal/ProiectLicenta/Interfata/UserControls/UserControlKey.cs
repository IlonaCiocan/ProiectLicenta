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


namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlKey : UserControl
    {

        Database db;
        string user;
        string key1;
        public string typeB;
        FormPrincipal mainForm;


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
                if (this.textBox1.Text != this.textBox2.Text)
                {
                    MessageBox.Show("Parolele nu coincid");
                }
                else
                {
                    string key = CreateKey(this.textBox2.Text.ToString());
                    this.key1 = key;
                    // bun daca fol formul de chei     temp_bd.AddNewKey(key, this.comboBox1.Text.ToString(), this.user);
                    MessageBox.Show(key);
                    mainForm.BringCryptoKeyToFront(this.key1,typeB);

                   // ((Form)this.TopLevelControl).Close();
                }
            }

        }
        private string CreateKey(string password)
        {
            

            uint hash_len = 32;
            uint t_cost = 2;
            uint m_cost = (1 << 16);
            uint parallelism = 4;
            byte[] hash1 = new byte[hash_len];
            string saltStr = "0000000000000000"; 
            var saltByteArr = Encoding.ASCII.GetBytes(saltStr);
            var passwordByteArr = Encoding.ASCII.GetBytes(password);


            export_func(passwordByteArr, (uint)passwordByteArr.Length, hash1, hash_len, saltByteArr, (uint)saltByteArr.Length, t_cost, m_cost, parallelism);


            string hash1_string = BitConverter.ToString(hash1);
       
            return hash1_string;
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
    }
 
}
