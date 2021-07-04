using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlAudit : UserControl
    {
        public UserControlAudit()
        {
            InitializeComponent();
            CompletaTable();
        }
        public void CompletaTable()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("logfile.txt");
            string[] columnnames = file.ReadLine().Split(' ');
         
            string newline;
           
            while ((newline = file.ReadLine()) != null)
            {
              
         
                string[] values = newline.Split(' ');

                this.dataGridView1.Rows.Add(values[0],  values[4], values[2], values[8] + " " + values[9] + " " + values[10]);
               
            }
            file.Close();
      
        }
        private void buttonLog_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "logfile.txt");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
