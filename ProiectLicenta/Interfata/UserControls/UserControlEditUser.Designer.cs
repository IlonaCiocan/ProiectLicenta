namespace ProiectLicenta.Interfata.UserControls
{
    partial class UserControlEditUser
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
            this.label_serviciu_edit = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBox_editD = new System.Windows.Forms.CheckBox();
            this.label_serviciu1 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_user_edit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox_Yes = new System.Windows.Forms.CheckBox();
            this.checkBox_No = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_serviciu_edit
            // 
            this.label_serviciu_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.label_serviciu_edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_serviciu_edit.Enabled = false;
            this.label_serviciu_edit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serviciu_edit.ForeColor = System.Drawing.SystemColors.Window;
            this.label_serviciu_edit.Location = new System.Drawing.Point(95, 122);
            this.label_serviciu_edit.Name = "label_serviciu_edit";
            this.label_serviciu_edit.Size = new System.Drawing.Size(304, 16);
            this.label_serviciu_edit.TabIndex = 46;
            this.label_serviciu_edit.TextChanged += new System.EventHandler(this.label_serviciu_edit_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBox_editD
            // 
            this.checkBox_editD.AutoSize = true;
            this.checkBox_editD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_editD.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox_editD.Location = new System.Drawing.Point(401, 125);
            this.checkBox_editD.Name = "checkBox_editD";
            this.checkBox_editD.Size = new System.Drawing.Size(72, 21);
            this.checkBox_editD.TabIndex = 45;
            this.checkBox_editD.Text = "Editare";
            this.checkBox_editD.UseVisualStyleBackColor = true;
            this.checkBox_editD.Click += new System.EventHandler(this.Enable_Departament);
            // 
            // label_serviciu1
            // 
            this.label_serviciu1.AutoSize = true;
            this.label_serviciu1.BackColor = System.Drawing.SystemColors.Window;
            this.label_serviciu1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_serviciu1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label_serviciu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.label_serviciu1.Location = new System.Drawing.Point(3, 12);
            this.label_serviciu1.Name = "label_serviciu1";
            this.label_serviciu1.Size = new System.Drawing.Size(134, 17);
            this.label_serviciu1.TabIndex = 41;
            this.label_serviciu1.Text = "Rol de aministrator";
            this.label_serviciu1.Click += new System.EventHandler(this.Label_serviciu1_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.button_save.Location = new System.Drawing.Point(236, 273);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(163, 30);
            this.button_save.TabIndex = 39;
            this.button_save.Text = "Salvează modificările";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.Window;
            this.button_cancel.Location = new System.Drawing.Point(52, 273);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(163, 30);
            this.button_cancel.TabIndex = 38;
            this.button_cancel.Text = "Renunță";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // label_user_edit
            // 
            this.label_user_edit.AutoSize = true;
            this.label_user_edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_user_edit.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label_user_edit.ForeColor = System.Drawing.SystemColors.Control;
            this.label_user_edit.Location = new System.Drawing.Point(92, 76);
            this.label_user_edit.Name = "label_user_edit";
            this.label_user_edit.Size = new System.Drawing.Size(111, 19);
            this.label_user_edit.TabIndex = 34;
            this.label_user_edit.Text = "Nume utilizator";
            this.label_user_edit.Click += new System.EventHandler(this.Label_user_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(174, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Editare date generale";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::ProiectLicenta.Properties.Resources.reset_psw;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(44, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "        Resetare parolă";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProiectLicenta.Properties.Resources.serviciu;
            this.pictureBox5.Location = new System.Drawing.Point(52, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProiectLicenta.Properties.Resources.accountsmall;
            this.pictureBox2.Location = new System.Drawing.Point(52, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox_Yes
            // 
            this.checkBox_Yes.AutoSize = true;
            this.checkBox_Yes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.checkBox_Yes.Location = new System.Drawing.Point(143, 11);
            this.checkBox_Yes.Name = "checkBox_Yes";
            this.checkBox_Yes.Size = new System.Drawing.Size(46, 21);
            this.checkBox_Yes.TabIndex = 47;
            this.checkBox_Yes.Text = "Da";
            this.checkBox_Yes.UseVisualStyleBackColor = true;
            this.checkBox_Yes.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox_No
            // 
            this.checkBox_No.AutoSize = true;
            this.checkBox_No.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.checkBox_No.Location = new System.Drawing.Point(232, 11);
            this.checkBox_No.Name = "checkBox_No";
            this.checkBox_No.Size = new System.Drawing.Size(45, 21);
            this.checkBox_No.TabIndex = 48;
            this.checkBox_No.Text = "Nu";
            this.checkBox_No.UseVisualStyleBackColor = true;
            this.checkBox_No.CheckedChanged += new System.EventHandler(this.CheckBox_No_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label_serviciu1);
            this.panel3.Controls.Add(this.checkBox_No);
            this.panel3.Controls.Add(this.checkBox_Yes);
            this.panel3.Location = new System.Drawing.Point(52, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 40);
            this.panel3.TabIndex = 49;
            // 
            // UserControlEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_serviciu_edit);
            this.Controls.Add(this.checkBox_editD);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label_user_edit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Name = "UserControlEditUser";
            this.Size = new System.Drawing.Size(500, 394);
            this.Load += new System.EventHandler(this.UserControlEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox label_serviciu_edit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBox_editD;
        private System.Windows.Forms.Label label_serviciu1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label_user_edit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Yes;
        private System.Windows.Forms.CheckBox checkBox_No;
        private System.Windows.Forms.Panel panel3;
    }
}
