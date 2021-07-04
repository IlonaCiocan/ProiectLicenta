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
            try
            {


                byte[] hash_psw = db.HashPsw("Password181998@");
                try
                {
                    db.ResetPwd(user, hash_psw, mainForm.user);
                    var result=MessageBox.Show("Datele au fost modificate cu succes!");
                    if (result == DialogResult.OK)
                    {
                        mainForm.Controls.Remove(mainForm.uc_accounts);
                        mainForm.uc_accounts = null;
                        mainForm.BringAccountsBDToFront();
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

            string isAdmin;
            if (checkBox_Yes.Checked == true)
            {
                isAdmin = "1";
            }
            else
                isAdmin = "0";
                try
                {
                db.ModifyRoleDep(user, this.label_serviciu_edit.Text, isAdmin, mainForm.user);
                var result = MessageBox.Show("Datele au fost modificate cu succes!");
                if (result == DialogResult.OK)
                {
                    mainForm.Controls.Remove(mainForm.uc_accounts);
                    mainForm.uc_accounts = null;
                    mainForm.BringAccountsBDToFront();
                }


            }
            catch (Exception exc)
                {
                    MessageBox.Show("Datele nu au fost schimbate!");
                  
                }





        }

        private void label_serviciu_edit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
