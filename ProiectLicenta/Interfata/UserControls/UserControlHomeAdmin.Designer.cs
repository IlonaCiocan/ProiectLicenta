namespace ProiectLicenta.Interfata.UserControls
{
    partial class UserControlHomeAdmin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_date = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label_numeadm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_dep = new System.Windows.Forms.Label();
            this.label_countacc = new System.Windows.Forms.Label();
            this.label_countadm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_date.Location = new System.Drawing.Point(10, 351);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(43, 19);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Date";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_time.Location = new System.Drawing.Point(10, 322);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(39, 19);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bine ai venit, ";
            this.label2.UseMnemonic = false;
            // 
            // label_numeadm
            // 
            this.label_numeadm.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label_numeadm.AutoSize = true;
            this.label_numeadm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeadm.Location = new System.Drawing.Point(118, 31);
            this.label_numeadm.Name = "label_numeadm";
            this.label_numeadm.Size = new System.Drawing.Size(125, 21);
            this.label_numeadm.TabIndex = 6;
            this.label_numeadm.Text = "nume utilizator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Utilizatori înregistrati: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Utilizatori cu roluri de adminstrator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departamente existente: ";
            // 
            // label_dep
            // 
            this.label_dep.AutoSize = true;
            this.label_dep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dep.Location = new System.Drawing.Point(179, 172);
            this.label_dep.Name = "label_dep";
            this.label_dep.Size = new System.Drawing.Size(104, 17);
            this.label_dep.TabIndex = 10;
            this.label_dep.Text = "Departamente";
            // 
            // label_countacc
            // 
            this.label_countacc.AutoSize = true;
            this.label_countacc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countacc.Location = new System.Drawing.Point(158, 111);
            this.label_countacc.Name = "label_countacc";
            this.label_countacc.Size = new System.Drawing.Size(47, 17);
            this.label_countacc.TabIndex = 11;
            this.label_countacc.Text = "label5";
            // 
            // label_countadm
            // 
            this.label_countadm.AutoSize = true;
            this.label_countadm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countadm.Location = new System.Drawing.Point(243, 142);
            this.label_countadm.Name = "label_countadm";
            this.label_countadm.Size = new System.Drawing.Size(47, 17);
            this.label_countadm.TabIndex = 12;
            this.label_countadm.Text = "label6";
            this.label_countadm.Click += new System.EventHandler(this.Label_countadm_Click);
            // 
            // UserControlHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label_countadm);
            this.Controls.Add(this.label_countacc);
            this.Controls.Add(this.label_dep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_numeadm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_date);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "UserControlHomeAdmin";
            this.Size = new System.Drawing.Size(500, 394);
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_numeadm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_dep;
        private System.Windows.Forms.Label label_countacc;
        private System.Windows.Forms.Label label_countadm;
    }
}
