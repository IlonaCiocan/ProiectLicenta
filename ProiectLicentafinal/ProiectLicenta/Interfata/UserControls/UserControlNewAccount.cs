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
using System.Text.RegularExpressions;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlNewAccount : UserControl
    {
        UserControlMainForm uc_main;

        bool canProceed;
        bool edit;
        bool hasreturn;
        string who;
        bool main = true;
        FormPrincipal mainForm;

        public UserControlNewAccount()
        {
            
            InitializeComponent();
            label_admin.Visible = false;
            checkBox_admin.Visible = false;
            InitializeNewAccountComponent();


        }
        private void InitializeNewAccountComponent()
        {
            textBox_user.ForeColor = SystemColors.GrayText;
            textBox_user.Text = "Nume utilizator";
            this.textBox_user.Leave += new System.EventHandler(this.textBox_user_Leave);
            this.textBox_user.Enter += new System.EventHandler(this.textBox_user_Enter);

            textBoxPassword.UseSystemPasswordChar = false;
            textBoxPassword.ForeColor = SystemColors.GrayText;
            textBoxPassword.Text = "Parola";
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);


            textBoxRetype.UseSystemPasswordChar = false;
            textBoxRetype.ForeColor = SystemColors.GrayText;
            textBoxRetype.Text = "Confirmare parolă";
            this.textBoxRetype.Leave += new System.EventHandler(this.textBoxRetype_Leave);
            this.textBoxRetype.Enter += new System.EventHandler(this.textBoxRetype_Enter);


            textBoxServiciul.ForeColor = SystemColors.GrayText;
            textBoxServiciul.Text = "Denumire serviciu";
            this.textBoxServiciul.Leave += new System.EventHandler(this.textBoxServiciul_Leave);
            this.textBoxServiciul.Enter += new System.EventHandler(this.textBoxServiciul_Enter);

            edit = false;
            hasreturn = false;
            canProceed = false;
            CheckAll();
            this.textBoxLabel.Select(0, 0);
        }
        public UserControlNewAccount(FormPrincipal mainF)
        {
            InitializeComponent();
            InitializeNewAccountComponent();
            main = false;
            mainForm = mainF;
        }
        public UserControlNewAccount(string nume)
        {
            InitializeComponent();
            canProceed = false;
            hasreturn = false;
            edit = true;
            this.textBox_user.Text = nume;
            CheckAll();
            this.textBoxLabel.Select(0, 0);

        }
        public UserControlNewAccount(User user)
        {
            InitializeComponent();
            canProceed = false;
            hasreturn = false;
            edit = true;
            this.textBox_user.Text = user.getnume();
            this.textBoxPassword.Text = user.getparole()[0];
            this.textBoxRetype.Text = user.getparole()[0];
            this.textBoxServiciul.Text = user.getserviciu();
            CheckAll();
            this.textBoxLabel.Select(0, 0);
        }
        public UserControlNewAccount(User user, int i, string who)
        {
            InitializeComponent();
            this.label5.Text = "Editare";
            this.buttonLogare.Text = "Editare";
            this.who = who;
            canProceed = false;
            hasreturn = false;
            edit = true;
            this.textBox_user.Text = user.getnume();
            this.textBoxServiciul.Text = user.getserviciu();
            Database db = new Database("dbtest");
            CheckAll();
            this.textBoxLabel.Select(0, 0);
        }

        public UserControlNewAccount(bool edit, User user)
        {
            InitializeComponent();

            this.edit = true;
            canProceed = false;
            hasreturn = false;
            edit = true;
            this.textBox_user.Text = user.getnume();
            this.textBoxPassword.Text = user.getparole()[0];
            this.textBoxRetype.Text = user.getparole()[0];
            this.textBoxServiciul.Text = user.getserviciu();

            CheckAll();
            this.textBoxLabel.Select(0, 0);
        }
       
        public void CheckAll(string pass="")
        {
            if(pass=="" && textBoxPassword.Text.Length>11 && textBoxRetype.Text.Length>11 && CheckRetype()=="ok")
            {
                pass = textBoxPassword.Text;
            }

            
            if (CheckUsername() == "ok")
            {
                if (CheckPassword(pass) == "ok")
                {
                    if (CheckRetype() == "ok")
                    {
                        if (CheckServiciu() == "ok")
                        {
                            this.pictureBox1.Image = global::ProiectLicenta.Properties.Resources.verified;
                            this.textBoxLabel.Text = "Confirmați crearea contului!";
                            this.canProceed = true;
                        }
                        else
                        {
                            this.textBoxLabel.Text = CheckServiciu();
                            this.pictureBox1.Image = global::ProiectLicenta.Properties.Resources.warning;
                            this.canProceed = false;
                        }
                    }
                    else
                    {
                        this.textBoxLabel.Text = CheckRetype();
                        this.pictureBox1.Image = global::ProiectLicenta.Properties.Resources.warning;
                        this.canProceed = false;
                    }
                }
                else
                {
                    this.textBoxLabel.Text = CheckPassword(pass);
                    this.pictureBox1.Image = global::ProiectLicenta.Properties.Resources.warning;
                    this.canProceed = false;
                }
            }
            else
            {
                this.textBoxLabel.Text = CheckUsername();
                this.pictureBox1.Image = global::ProiectLicenta.Properties.Resources.warning;
                this.canProceed = false;
            }
        }
        public string CheckUsername()
        {
            string username = this.textBox_user.Text;
            if (this.textBox_user.Text.Length > 5)
            {
                if (Regex.IsMatch(username, "[!@#$%^&*()_+]"))
                {
                    return "Numele de utilizator trebuie să conțină doar litere";
                }
                if (Regex.IsMatch(username, "[1234567890]"))
                    return "Numele de utilizator trebuie să conțină doar litere";

                return "ok";
            }
            else
                return "Numele de utilizator trebuie să conțină minim 6 caractere";
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
            if (this.textBoxPassword.Text == this.textBoxRetype.Text)
            {
                return "ok";
            }
            return "Parolele nu se potrivesc";
        }
        public string CheckServiciu()
        {
            if (this.textBoxServiciul.Text.Length > 2)
            {
                return "ok";
            }
            return "Serviciul trebuie să conțină minim 3 caractere";
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

        private void textBoxServiciul_Leave(object sender, EventArgs e)
        {
            if (textBoxServiciul.Text.Length == 0)
            {
                textBoxServiciul.Text = "Denumire serviciu";
                textBoxServiciul.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxServiciul_Enter(object sender, EventArgs e)
        {
            if (textBoxServiciul.Text == "Denumire serviciu")
            {
                textBoxServiciul.Text = "";
                textBoxServiciul.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0)
            {

                button_view.Enabled = false;
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Parola";
                textBoxPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxLabel.Text = "Parola trebuie să conțină minim 12 caractere,\n cel puțin o literă mare și o literă mică, o cifră \n și cel puțin un caracter special.";
            if (textBoxPassword.Text == "Parola")
            {
                button_view.Enabled = true;
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.PasswordChar = '*';
              
                textBoxPassword.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxRetype_Leave(object sender, EventArgs e)
        {
            if (textBoxRetype.Text.Length == 0)
            {
                button_view2.Enabled = false;
                textBoxRetype.UseSystemPasswordChar = false;
                textBoxRetype.PasswordChar = '\0';
                textBoxRetype.Text = "Confirmare parolă";
                textBoxRetype.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBoxRetype_Enter(object sender, EventArgs e)
        {
            if (textBoxRetype.Text == "Confirmare parolă")
            {
                button_view2.Enabled = true;
                textBoxRetype.Text = "";
                textBoxRetype.UseSystemPasswordChar = true;
                textBoxRetype.PasswordChar = '*';
                textBoxRetype.ForeColor = SystemColors.WindowText;
            }
        }
        private void TextBoxServiciul_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }
        private void TextBox_user_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }
        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            CheckAll(this.textBoxPassword.Text);
        }
        private void TextBoxRetype_TextChanged(object sender, EventArgs e)
        {
            CheckAll(this.textBoxRetype.Text);
        }

        private void ButtonLogare_Click(object sender, EventArgs e)
        {
            Database db1 = new Database("dbtest");
            if (this.canProceed == true)
            {
                if (this.edit == true)
                {
                    hasreturn = true;

                }
                else
                {
                    if (db1.VerifyUser(this.textBox_user.Text) == true)
                    {
                        MessageBox.Show("Există deja un utilizator cu același nume!");

                    }
                    else
                    {
                        hasreturn = true;
                        Login login = new Login();
                        if (checkBox_admin.Checked == true)
                        {
                            if (login.NewUser(this.textBox_user.Text.ToString(), this.textBoxPassword.Text.ToString(),"1", this.textBoxServiciul.Text.ToString()) == 0)
                            {
                                MessageBox.Show("nereusit");

                            }
                            else
                            {
                             
                                mainForm.Controls.Remove(mainForm.uc_accounts);
                                mainForm.uc_accounts = null;
                                mainForm.BringAccountsBDToFront();


                            }
                        }
                        else { 

                            if (login.NewUser(this.textBox_user.Text.ToString(), this.textBoxPassword.Text.ToString(), this.textBoxServiciul.Text.ToString()) == 0)
                            {
                                MessageBox.Show("nereusit");

                            }
                            else
                            {
                                if (main == true)
                                    BackToMain();
                                else
                                {
                                    mainForm.Controls.Remove(mainForm.uc_accounts);
                                    mainForm.uc_accounts = null;
                                    mainForm.BringAccountsBDToFront();
                                }



                            }
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Criterii cont neîndeplinite!");
            }
        }
        public User ReturnUser()
        {
            User user = new User();
            user.Add(this.textBox_user.Text, this.textBoxPassword.Text, this.textBoxServiciul.Text);
            return user;
        }
        public bool HasReturn()
        {
            return this.hasreturn;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BackToMain()
        {
            
            this.uc_main = new UserControlMainForm();
            this.uc_main.Dock = DockStyle.Fill;
            this.uc_main.Tag = "main";


            panel2.Controls.Add(uc_main);


            for (int i = 0; i < this.panel2.Controls.Count; i++)
            {
                this.panel2.Controls[i].Hide();
            }
            this.panel1.Hide();
            for (int i = 0; i < this.panel2.Controls.Count; i++)
            {
                try
                {
                    if (this.panel2.Controls[i].Tag.ToString() == "main")
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
        private void Button1_Click(object sender, EventArgs e)
        {
            if (main == true)
                BackToMain();
            else
            {
       
                mainForm.BringAccountsBDToFront();
            }
          

        }

        private void viewPassword(object sender, EventArgs e)
        {
           
            int bullet = 9679;
          if (textBoxPassword.PasswordChar==(char)bullet && textBoxPassword.Text!="Parola")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                this.textBoxPassword.PasswordChar = '\0';
               
            }

            else
            {   
                
                this.textBoxPassword.PasswordChar = (char)bullet;
                
            }
        }
        private void viewPasswordRetype(object sender, EventArgs e)
        {

            int bullet = 9679;
            if (textBoxRetype.PasswordChar == (char)bullet && textBoxRetype.Text != "Confirmare parolă")
            {
                textBoxRetype.UseSystemPasswordChar = false;
                this.textBoxRetype.PasswordChar = '\0';

            }

            else
            {

                this.textBoxRetype.PasswordChar = (char)bullet;

            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
