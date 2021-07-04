using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectLicenta.Business_Layer;
using Mechanisms;
namespace ProiectLicenta.Interfata.UserControls
{
    public partial class but : UserControl
    {
        List<User> _lista_useri;
        List<Button> _lista_butoane;
        Database db;
        string _user;
        FormPrincipal mainForm;

        public but(string user,FormPrincipal mainF)
        {
            InitializeComponent();
            this.title_accounts.Text = "Utilizatori existenți în sistem";
            this._user = user;
            db = new Database("dbtest");
            mainForm = mainF;
            _lista_useri = new List<User>();
            _lista_butoane = new List<Button>();
            GetUsersBD();
            /*
            if (db.isAdmin(user) is true)
            {
                AfisareUsers();
            }
            else
            {
                AfisareSpecificUser();
                this.button1.Visible = false;
            }*/
             AfisareUsers();
        }

        public void GetUsersBD()
        {
            _lista_useri = db.GetAllUsers();
        }
        public void AfisareSpecificUser()
        {
            for (int i = 0; i < _lista_useri.Count; i++)
            {
                if(this._user == _lista_useri[i].getnume())
                {
                    Business_Layer.ButonAccount butonAccount = new Business_Layer.ButonAccount(_lista_useri[i], this,this._user,mainForm);
                    butonAccount.Tag = _lista_useri[i].gettag();
                    this.panel_acc.Controls.Add(butonAccount);
                    this._lista_butoane.Add(butonAccount);
                }
                
            }
        }
        public void AfisareUsers()
        {
            for(int i=0;i<_lista_useri.Count;i++)
            {
                if (_lista_useri[i].getnume() != _user)
                {
                    Business_Layer.ButonAccount butonAccount = new Business_Layer.ButonAccount(_lista_useri[i], this, this._user, mainForm);
                    butonAccount.Tag = _lista_useri[i].gettag();
                    this.panel_acc.Controls.Add(butonAccount);
                    this._lista_butoane.Add(butonAccount);
                }
            }

        }
        public void RemoveUsersInter()
        {
            for(int i=0;i<this._lista_butoane.Count;i++)
            {
                this._lista_butoane[i].Dispose();
            }
            try
            {
                this._lista_butoane.Clear();
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.BringNewAccountToFront();
            /*
            Interfata.Autentificare auth = new Autentificare();
            auth.ShowDialog();
            if(auth.HasReturn() == true)
            {
                //Argon2 a2 = new Argon2();
                //a2.HashArgon2id(auth.ReturnUser().getparole()[0]);
              //  db.CreateNewUser(auth.ReturnUser().getnume(), auth.ReturnUser().getparole()[0], a2.HashArgon2id(auth.ReturnUser().getparole()[0]));
                Business_Layer.ButonAccount butonAccount = new Business_Layer.ButonAccount(auth.ReturnUser(), this, this._user,mainForm);
                butonAccount.Tag = auth.ReturnUser().gettag();
                this.panel_acc.Controls.Add(butonAccount);
                this._lista_butoane.Add(butonAccount);
                RemoveUsersInter();
                GetUsersBD();
                AfisareUsers();
            }
            
            */
      //      mainForm.BringEditUserToFront("Test");
            
            
        }
        public void RemoveUser(User user)
        {
            for(int i=0;i<this._lista_useri.Count;i++)
            {
                if(this._lista_useri[i].gettag() == user.gettag())
                {
                    for(int j=0;j< this._lista_butoane.Count;j++)
                    {
                        if(this._lista_butoane[j].Tag.ToString() == user.gettag())
                        {
                            this._lista_butoane.RemoveAt(j);
                            break;
                        }
                    }
                    this._lista_useri.RemoveAt(i);
                    break;
                }
            }
        }
        public User GetUser(string tag)
        {
            for(int i=0;i<_lista_useri.Count;i++)
            {
                if(_lista_useri[i].gettag() == tag)
                {
                    return _lista_useri[i];
                }
            }
            return new User();
        }
        public void ModifyUserList(string oldtag,User usertemp)
        {
            for(int i=0;i<_lista_useri.Count;i++)
            {
                if(_lista_useri[i].gettag() == oldtag)
                {
                    for(int j=0;j<this.panel_acc.Controls.Count;j++)
                    {
                        if(this.panel_acc.Controls[j].Tag.ToString() == oldtag)
                        {
                            this.panel_acc.Controls[j].Dispose();
                            
                            
                            
                        }
                    }

                    _lista_useri[i] = usertemp;

                    Business_Layer.ButonAccount butonAccount = new Business_Layer.ButonAccount(usertemp, this, this._user,mainForm);
                    butonAccount.Tag = usertemp.gettag();
                    this.panel_acc.Controls.Add(butonAccount);
                    this._lista_butoane.Add(butonAccount);
                    break;
                }
            }
        }

        private void panel_acc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_Load(object sender, EventArgs e)
        {

        }
    }
}
