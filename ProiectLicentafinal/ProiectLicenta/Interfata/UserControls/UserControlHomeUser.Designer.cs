namespace ProiectLicenta.Interfata.UserControls
{
    partial class UserControlHomeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHomeUser));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_numeuser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_time_user = new System.Windows.Forms.Label();
            this.label_date_user = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.MaximumSize = new System.Drawing.Size(460, 100);
            this.label4.MinimumSize = new System.Drawing.Size(460, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 76);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::ProiectLicenta.Properties.Resources.homeuser;
            this.label1.Location = new System.Drawing.Point(327, 246);
            this.label1.MaximumSize = new System.Drawing.Size(160, 100);
            this.label1.MinimumSize = new System.Drawing.Size(160, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 100);
            this.label1.TabIndex = 0;
            // 
            // label_numeuser
            // 
            this.label_numeuser.AutoSize = true;
            this.label_numeuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numeuser.Location = new System.Drawing.Point(119, 60);
            this.label_numeuser.Name = "label_numeuser";
            this.label_numeuser.Size = new System.Drawing.Size(125, 21);
            this.label_numeuser.TabIndex = 8;
            this.label_numeuser.Text = "nume utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bine ai venit, ";
            this.label2.UseMnemonic = false;
            // 
            // label_time_user
            // 
            this.label_time_user.AutoSize = true;
            this.label_time_user.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_time_user.Location = new System.Drawing.Point(13, 334);
            this.label_time_user.Name = "label_time_user";
            this.label_time_user.Size = new System.Drawing.Size(39, 19);
            this.label_time_user.TabIndex = 10;
            this.label_time_user.Text = "Time";
            // 
            // label_date_user
            // 
            this.label_date_user.AutoSize = true;
            this.label_date_user.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_date_user.Location = new System.Drawing.Point(13, 363);
            this.label_date_user.Name = "label_date_user";
            this.label_date_user.Size = new System.Drawing.Size(43, 19);
            this.label_date_user.TabIndex = 9;
            this.label_date_user.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UserControlHomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_time_user);
            this.Controls.Add(this.label_date_user);
            this.Controls.Add(this.label_numeuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "UserControlHomeUser";
            this.Size = new System.Drawing.Size(500, 394);
            this.Load += new System.EventHandler(this.UserControlHomeUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_numeuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_time_user;
        private System.Windows.Forms.Label label_date_user;
        private System.Windows.Forms.Timer timer1;
    }
}
