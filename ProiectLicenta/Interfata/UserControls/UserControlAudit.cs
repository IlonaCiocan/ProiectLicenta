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
using System.Collections;

namespace ProiectLicenta.Interfata.UserControls
{
    public partial class UserControlAudit : UserControl
    {
        public UserControlAudit()
        {
            InitializeComponent();
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            CompletaTable();
        }
        public void CompletaTable()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("logfile.txt");
            ArrayList lines = new ArrayList();
            string[] columnnames = file.ReadLine().Split(' ');
            string newline;

            while ((newline = file.ReadLine()) != null)
            {
                lines.Add(newline);
            }
           
            lines.Reverse();
           foreach (string output in lines)
            {
                string[] values = output.Split(' ');
                if(values[0].Contains("Operatiune"))
                {
                    this.dataGridView1.Rows.Add(values[0], "Fisier intrare: "+values[2]+"\nFisier iesire: "+values[4]+"\nStatus:reusit", values[6], values[8] + " " + values[9] + " " + values[10]);
                }
                else if(values[0].Contains("Stergere"))
                {
                    this.dataGridView1.Rows.Add(values[0], "Utilizatorul " + values[2] + " a fost sters cu succes", values[6], values[8] + " " + values[9] + " " + values[10]);
                }
                else if(values[0].Contains("Creare"))
                {
                    this.dataGridView1.Rows.Add(values[0], "Utilizatorul " + values[2] + " a fost creat cu succes", values[6], values[8] + " " + values[9] + " " + values[10]);
                }
                else if (values[0].Contains("Resetare"))
                {
                    this.dataGridView1.Rows.Add(values[0], "Resetare parola pentru ultizatorul " + values[2] , values[6], values[8] + " " + values[9] + " " + values[10]);
                }
                else
                    this.dataGridView1.Rows.Add(values[0], values[4], values[2], values[8] + " " + values[9] + " " + values[10]);
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
