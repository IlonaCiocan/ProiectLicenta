using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectLicenta.Interfata.UserControls;
using System.Runtime.InteropServices;
using Mechanisms;
using System.ComponentModel;
using System.Text.RegularExpressions;

using ProiectLicenta.Interfata;

namespace ProiectLicenta.Business_Layer
{

    
    public class ButonAccount : Button
    {
        
        Button buton_delete;
        
        Database db;
        public User user;
        but interf;
        string _oldtag;
        string who;
        FormPrincipal mainForm;
        public ButonAccount()
        {
        }


    


        public ButonAccount(User user, but interfata, string userwho,FormPrincipal mainF)
        {
            db = new Database("dbtest");
            mainForm = mainF;
            this.interf = interfata;
            this.user = user;
            this._oldtag = user.gettag();
            Initializare(user, userwho);
        }
        public void Initializare(User user, string userwho)
        {
            this.who = userwho;

            buton_delete = new Button();
            buton_delete.Dock = DockStyle.Right;
            buton_delete.FlatStyle = FlatStyle.Flat;
            buton_delete.FlatAppearance.BorderSize = 0;
            buton_delete.Image = ProiectLicenta.Properties.Resources.delete25p;
            buton_delete.MouseClick += Buton_delete_MouseClick;

            this.Text = user.getnume();
            //this.Text = user.getnume() + " - " + user.getserviciu();
            this.FlatStyle = FlatStyle.Flat;
            this.Dock = DockStyle.Top;
            this.ForeColor = System.Drawing.Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new System.Drawing.Size(50, 50);
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.Font = new System.Drawing.Font("Century Gothic", 10);
            this.Tag = user.getnume() ;
            this.Controls.Add(buton_delete);
            this.Image = ProiectLicenta.Properties.Resources.accountsmall;
            this.MouseClick += ButonAccount_MouseClick;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this, "Editare utilizator: "+this.Text);
        }



        private void ButonAccount_MouseClick(object sender, MouseEventArgs e)
        {


            Database db1 = new Database("dbtest");
            string departament = db1.getDepartament(this.Text);
            bool isAdmin = db1.isAdmin(this.Text);

            mainForm.BringEditUserToFront(this.Text, departament, isAdmin);
            
            /*
            
            Interfata.Autentificare auth = new Interfata.Autentificare(this.user,1,who);
            auth.ShowDialog();
            if (auth.HasReturn() == true)
            { 
                uint hash_len = 32;
                uint t_cost = 2;
                uint m_cost = (1 << 16);
                uint parallelism = 4;
                byte[] hash1 = new byte[hash_len];

                uint salt_len = 32;
                byte[] saltByteArr = new byte[salt_len];
                export_rdrand(saltByteArr, salt_len);
                var passwordByteArr = Encoding.ASCII.GetBytes(auth.ReturnUser().getparole()[0]);


                int asd = export_func(passwordByteArr, (uint)passwordByteArr.Length, hash1, hash_len, saltByteArr, salt_len, t_cost, m_cost, parallelism);

                string salt = BitConverter.ToString(saltByteArr).Replace("-", string.Empty);

                string hash1_string = BitConverter.ToString(hash1).Replace("-", string.Empty);

                var salt_hash = saltByteArr.Concat(hash1).ToArray();


                db.ModifyUser(user.getnume(), auth.ReturnUser().getnume(), auth.ReturnUser().getparole()[0],salt_hash,auth.ReturnUser().getIsAdmin(), who);
                
                this.Text = auth.ReturnUser().gettag();
                }
                */
            
        }

        private void Buton_delete_MouseClick(object sender, MouseEventArgs e)
        {
            db.DeteleSpecificUser(this.user.getnume(), who);
            this.Dispose();

        }
        public void UpdateUser(User usertmp)
        {
            this.user = usertmp;
        }
    }
}
