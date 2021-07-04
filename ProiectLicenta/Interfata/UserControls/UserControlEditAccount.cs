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
using System.Text.RegularExpressions;
namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlEditAccount : UserControl
    {
        Database db;
        string user;
        string departament;
        public UserControlEditAccount(string who)
        {
            db = new Database("dbtest");
            InitializeComponent();
            this.user = who;
            button2.Visible = true;
            DisableComponents();
            PopulateComponents();
        }
        private void PopulateComponents()
        {
            label_user.Text = this.user;
           
            departament = db.getDepartament(this.user);

            if (departament != "")
            {
                label_serviciu.Text = departament;
            }
            else
            {
                label_serviciu.Text = "Acest câmp nu este completat";
            }
        }

        private void DisableComponents()
        {
            button1_check.Visible = false;
            button2_check.Visible = false;
            button2.Visible = true;
            button_save_mod.Visible = false;
            label_message.Visible = false;
            textBoxNewPassword.Visible = false;
            textBoxNewRetype.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            button_viewN.Visible = false;
            button_viewNR.Visible = false;
            button_cancel.Visible = false;
            button_save.Visible = false;
            panel5.Visible = false;

        }
        private void EnabledComponents()
        {
            button2.Visible = false;
            button_save_mod.Visible = false;
            textBoxNewPassword.Visible = true;
            textBoxNewRetype.Visible = true;
            pictureBox3.Visible = true;
            pictureBox1.Visible = true;
            button_viewN.Visible = true;
            button_viewNR.Visible = true;
            button_cancel.Visible = true;
            button_save.Visible = true;
            panel5.Visible = true;
            button_save.Enabled = false;

            textBoxNewPassword.ForeColor = SystemColors.GrayText;
            textBoxNewPassword.Text = "Parola nouă";
            this.textBoxNewPassword.Leave += new System.EventHandler(this.TextBoxNewPassword_Leave);
            this.textBoxNewPassword.Enter += new System.EventHandler(this.TextBoxNewPassword_Enter);

            textBoxNewRetype.ForeColor = SystemColors.GrayText;
            textBoxNewRetype.Text = "Confirmare parolă nouă";
            this.textBoxNewRetype.Leave += new System.EventHandler(this.TextBoxNewRetype_Leave);
            this.textBoxNewRetype.Enter += new System.EventHandler(this.TextBoxNewRetype_Enter);

        }


        private void TextBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text.Length == 0)
            {

                button_viewN.Enabled = false;
                textBoxNewPassword.UseSystemPasswordChar = false;
                textBoxNewPassword.PasswordChar = '\0';
                textBoxNewPassword.Text = "Parola nouă";
                textBoxNewPassword.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxNewPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "Parola nouă")
            {
                int bullet = 9679;
                button_viewN.Enabled = true;
                textBoxNewPassword.Text = "";

                textBoxNewPassword.PasswordChar = (char)bullet;

                textBoxNewPassword.ForeColor = SystemColors.WindowText;
            }
        }


        private void TextBoxNewRetype_Leave(object sender, EventArgs e)
        {
            if (textBoxNewRetype.Text.Length == 0)
            {

                button_viewNR.Enabled = false;
                textBoxNewRetype.UseSystemPasswordChar = false;
                textBoxNewRetype.PasswordChar = '\0';
                textBoxNewRetype.Text = "Confirmare parolă nouă";
                textBoxNewRetype.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxNewRetype_Enter(object sender, EventArgs e)
        {
            if (textBoxNewRetype.Text == "Confirmare parolă nouă")
            {
                int bullet = 9679;
                button_viewNR.Enabled = true;
                textBoxNewRetype.Text = "";

                textBoxNewRetype.PasswordChar = (char)bullet;

                textBoxNewRetype.ForeColor = SystemColors.WindowText;
            }
        }


        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlEditAccount_Load(object sender, EventArgs e)
        {

        }

        private void Label_serviciu_Click(object sender, EventArgs e)
        {

        }

        private void change_password(object sender, EventArgs e)
        {
            EnabledComponents();
            label_message.Text = "Parola trebuie să conțină minim 12 caractere,\n cel puțin o literă mare și o literă mică, o cifră \n și cel puțin un caracter special.";
        }
        private void close_change_password(object sender, EventArgs e)
        {
            DisableComponents();
        }
   
        private void viewNewPassword(object sender, EventArgs e)
        {
            int bullet = 9679;
            if (textBoxNewPassword.PasswordChar == (char)bullet && textBoxNewPassword.Text != "Parola nouă")
            {
                textBoxNewPassword.UseSystemPasswordChar = false;
                this.textBoxNewPassword.PasswordChar = '\0';

            }

            else
            {

                this.textBoxNewPassword.PasswordChar = (char)bullet;

            }

        }
        private void viewNewRetype(object sender, EventArgs e)
        {
            int bullet = 9679;
            if (textBoxNewRetype.PasswordChar == (char)bullet && textBoxNewRetype.Text != "Confirmare parolă nouă")
            {
                textBoxNewRetype.UseSystemPasswordChar = false;
                this.textBoxNewRetype.PasswordChar = '\0';

            }

            else
            {

                this.textBoxNewRetype.PasswordChar = (char)bullet;

            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                
                    byte[] hash_psw = db.HashPsw(textBoxNewPassword.Text);
                try
                {
                    bool adm = db.isAdmin(user);
                    if (adm == true)
                    {
                        db.ModifyUser(user, hash_psw, "1", user, this.label_serviciu.Text);
                        var result = MessageBox.Show("Datele au fost modificate cu succes!");
                        if (result == DialogResult.OK)
                        {
                            DisableComponents();
                        }
                    }
                    else
                    {
                        db.ModifyUser(user, hash_psw, "0", user, this.label_serviciu.Text);


                        var result = MessageBox.Show("Datele au fost modificate cu succes!");
                        if (result == DialogResult.OK)
                        {
                            DisableComponents();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Datele nu au fost schimbate!");
                }


                    
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public string CheckPassword(string textBox_pass)
        {
            string psw = textBox_pass;
            if (psw.Length > 11)
            {   if (Regex.IsMatch(psw, "[a-zA-Z]"))
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
                                {
                                    button_save.Enabled = true;
                                    return "ok";
                                }
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
            if (this.textBoxNewPassword.Text == this.textBoxNewRetype.Text)
            {
                return "ok";
            }
            return "Parolele nu se potrivesc";
        }
        private void Check(String password)
        {
            String message = CheckPassword(password);
            if (message!="ok")
            {
                label_message.Visible = true;
                label_message.Text = message;
                label_message.ForeColor = System.Drawing.Color.White;
            }
            else 
            {
                label_message.Text = " ";
            }
         
       
        }
        private void TextBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            Check(textBoxNewPassword.Text);

        }

        private void TextBoxNewRetype_TextChanged(object sender, EventArgs e)
        {
            Check(textBoxNewRetype.Text);
            

        }
        private void Label_Message_Changed(object sender, EventArgs e)
        {
            string message = CheckRetype();
            if(message=="ok" && label_message.Text=="")
            {
                button1_check.Visible = true;
                button2_check.Visible = true;
            }

        }

        private void Enable_Departament(object sender, EventArgs e)
        {
            if(checkBox_editD.Checked==true)
            {
                label_serviciu.Enabled = true;
                label_serviciu.BorderStyle = BorderStyle.Fixed3D;
                button_save_mod.Visible = true;

            }
            if (checkBox_editD.Checked == false)
            {
                label_serviciu.Enabled = false;
                label_serviciu.BorderStyle = BorderStyle.None;
            }
        }

        private void save_mod(object sender, EventArgs e)
        {

            try
            {


                
                try
                {
                        db.ModifyDepartament(user, this.label_serviciu.Text, user);
                       
                        var result = MessageBox.Show("Datele au fost modificate cu succes!");
                        if (result == DialogResult.OK)
                        {
                            DisableComponents();
                        }
                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Datele nu au fost schimbate!");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Label_serviciu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

