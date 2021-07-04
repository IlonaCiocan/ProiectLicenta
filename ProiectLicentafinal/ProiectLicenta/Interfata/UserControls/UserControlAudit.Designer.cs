namespace ProiectLicenta.Interfata.UserControls
{
    partial class UserControlAudit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnWho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParametru1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWho2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWho,
            this.ColumnParametru1,
            this.ColumnWho2,
            this.ColumnDate});
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.Size = new System.Drawing.Size(663, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ColumnWho
            // 
            this.ColumnWho.FillWeight = 200F;
            this.ColumnWho.Frozen = true;
            this.ColumnWho.HeaderText = "Acțiune";
            this.ColumnWho.MinimumWidth = 6;
            this.ColumnWho.Name = "ColumnWho";
            this.ColumnWho.ReadOnly = true;
            this.ColumnWho.Width = 145;
            // 
            // ColumnParametru1
            // 
            this.ColumnParametru1.Frozen = true;
            this.ColumnParametru1.HeaderText = "Mesaj";
            this.ColumnParametru1.MinimumWidth = 6;
            this.ColumnParametru1.Name = "ColumnParametru1";
            this.ColumnParametru1.ReadOnly = true;
            this.ColumnParametru1.Width = 125;
            // 
            // ColumnWho2
            // 
            this.ColumnWho2.Frozen = true;
            this.ColumnWho2.HeaderText = "Utilizator";
            this.ColumnWho2.MinimumWidth = 6;
            this.ColumnWho2.Name = "ColumnWho2";
            this.ColumnWho2.ReadOnly = true;
            this.ColumnWho2.Width = 125;
            // 
            // ColumnDate
            // 
            this.ColumnDate.FillWeight = 150F;
            this.ColumnDate.Frozen = true;
            this.ColumnDate.HeaderText = "Data";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 150;
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(129)))));
            this.buttonLog.FlatAppearance.BorderSize = 0;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLog.Location = new System.Drawing.Point(4, 432);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(659, 49);
            this.buttonLog.TabIndex = 13;
            this.buttonLog.Text = "Deschidere fișier jurnal";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // UserControlAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlAudit";
            this.Size = new System.Drawing.Size(667, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParametru1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWho2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
    }
}
