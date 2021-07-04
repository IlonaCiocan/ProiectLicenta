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
using System.Runtime.InteropServices;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlEditUser : UserControl
    {
       public string user;
       public string departament;
       public bool isAdmin;
        FormPrincipal mainForm;
        Database db;
        public UserControlEditUser(string _user, string dep,bool adm,FormPrincipal mainF)
        {
            db = new Database("dbtest");
            InitializeComponent();
            mainForm = mainF;
            user = _user;
            departament = dep;
            isAdmin = adm;
            label_serviciu_edit.Text = departament;
            label_user_edit.Text =user;
            if (isAdmin==false)
            {
                checkBox_No.Checked = true;
            }
            else
            {
                checkBox_Yes.Checked = true;
            }


        }
    
        private void Button2_Click(object sender, EventArgs e)
        {
            
            Database db1 = new Database("dbtest");
         
              
           byte[] hash_psw = db1.HashPsw("Password987!");
            
           
            string adm;
            if (isAdmin == true)
            {
                adm = "1";
            }
            else
                adm = "0";
            try
            {
                db1.DeteleSpecificUser(user, user);
                db1.CreateNewUser(user, hash_psw, adm, user, departament);
                MessageBox.Show("Parola a fost schimbată cu succes!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Parola nu a fost schimbată!");
            }
            
        }

        private void Label_serviciu1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Yes.Checked == true)
                checkBox_No.Checked = false;
            else if (checkBox_No.Checked == true && checkBox_Yes.Checked == true)
            {
                checkBox_No.Checked = true;
            }
            else
                checkBox_No.Checked = false;

        }

        private void UserControlEditUser_Load(object sender, EventArgs e)
        {

        }

        private void Label_user_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_No_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_No.Checked == true)
                checkBox_Yes.Checked = false;
            else if (checkBox_No.Checked==true && checkBox_Yes.Checked == true)
            { 
                checkBox_Yes.Checked = true;
                }
        
            else
                checkBox_Yes.Checked = false;
        }
        private void Enable_Departament(object sender, EventArgs e)
        {
            if (checkBox_editD.Checked == true)
            {
                label_serviciu_edit.Enabled = true;
                label_serviciu_edit.BorderStyle = BorderStyle.Fixed3D;
            }
            if (checkBox_editD.Checked == false)
            {
                label_serviciu_edit.Enabled = false;
                label_serviciu_edit.BorderStyle = BorderStyle.None;
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            mainForm.BringAccountsBDToFront();
        }

        private void Button_save_Click(object sender, EventArgs e)
        {

            try
            {

                byte[] hash_psw = db.HashPsw("Password987!");
                try
                {
                    
                    if (checkBox_Yes.Checked== true)
                    {
                        db.ModifyUser(user, hash_psw, "1", user, departament);
                        var result = MessageBox.Show("Modificările au fost modificate cu succes!");
                       
                    }
                    else if(checkBox_No.Checked==true)
                    {
                        db.ModifyUser(user, hash_psw, "0", user, departament);


                        var result = MessageBox.Show("Modificările au fost modificate cu succes!");
                       
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Modificările nu au fost schimbate!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label_serviciu_edit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
