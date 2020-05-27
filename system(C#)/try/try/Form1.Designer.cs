namespace @try
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.schdtm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Su = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Th = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDay
            // 
            this.dgvDay.AllowUserToAddRows = false;
            this.dgvDay.AllowUserToResizeColumns = false;
            this.dgvDay.AllowUserToResizeRows = false;
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schdtm,
            this.Su,
            this.M,
            this.T,
            this.W,
            this.Th,
            this.F,
            this.S});
            this.dgvDay.Location = new System.Drawing.Point(164, 36);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.ReadOnly = true;
            this.dgvDay.RowHeadersVisible = false;
            this.dgvDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDay.Size = new System.Drawing.Size(804, 310);
            this.dgvDay.TabIndex = 0;
            // 
            // schdtm
            // 
            this.schdtm.HeaderText = "";
            this.schdtm.Name = "schdtm";
            // 
            // Su
            // 
            this.Su.HeaderText = "Sunday";
            this.Su.Name = "Su";
            // 
            // M
            // 
            this.M.HeaderText = "Monday";
            this.M.Name = "M";
            // 
            // T
            // 
            this.T.HeaderText = "Tuesday";
            this.T.Name = "T";
            // 
            // W
            // 
            this.W.HeaderText = "Wednesday";
            this.W.Name = "W";
            // 
            // Th
            // 
            this.Th.HeaderText = "Thursday";
            this.Th.Name = "Th";
            // 
            // F
            // 
            this.F.HeaderText = "Friday";
            this.F.Name = "F";
            // 
            // S
            // 
            this.S.HeaderText = "Saturday";
            this.S.Name = "S";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(164, 435);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(123, 44);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1021, 491);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.dgvDay);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Add Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn schdtm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Su;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn Th;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.Button btnSet;
    }
}

