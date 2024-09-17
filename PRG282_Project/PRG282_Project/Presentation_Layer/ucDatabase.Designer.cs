
namespace PRG282_Project
{
    partial class ucDatabase
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
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchdata = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bntSearch = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.rbxSummary = new System.Windows.Forms.RichTextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvDatabase = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSearch
            // 
            this.cmbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Search for Student ID",
            "Search for Module"});
            this.cmbSearch.Location = new System.Drawing.Point(6, 11);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(223, 31);
            this.cmbSearch.TabIndex = 1;
            this.cmbSearch.Text = "Search Options";
            // 
            // txtSearchdata
            // 
            this.txtSearchdata.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchdata.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSearchdata.Location = new System.Drawing.Point(6, 48);
            this.txtSearchdata.Name = "txtSearchdata";
            this.txtSearchdata.Size = new System.Drawing.Size(223, 31);
            this.txtSearchdata.TabIndex = 2;
            this.txtSearchdata.Text = "Search Here";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLeft.Controls.Add(this.btnDelete);
            this.pnlLeft.Controls.Add(this.bntSearch);
            this.pnlLeft.Controls.Add(this.cmbSearch);
            this.pnlLeft.Controls.Add(this.txtSearchdata);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(235, 494);
            this.pnlLeft.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(6, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Field";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.bntSearch.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bntSearch.FlatAppearance.BorderSize = 2;
            this.bntSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.bntSearch.Location = new System.Drawing.Point(6, 95);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(223, 31);
            this.bntSearch.TabIndex = 3;
            this.bntSearch.Text = "Search";
            this.bntSearch.UseVisualStyleBackColor = false;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // picStudent
            // 
            this.picStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStudent.ErrorImage = global::PRG282_Project.Properties.Resources.DefaultUser;
            this.picStudent.Image = global::PRG282_Project.Properties.Resources.DefaultUser;
            this.picStudent.InitialImage = null;
            this.picStudent.Location = new System.Drawing.Point(244, 11);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(200, 150);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudent.TabIndex = 5;
            this.picStudent.TabStop = false;
            // 
            // rbxSummary
            // 
            this.rbxSummary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbxSummary.Location = new System.Drawing.Point(453, 11);
            this.rbxSummary.Name = "rbxSummary";
            this.rbxSummary.ReadOnly = true;
            this.rbxSummary.Size = new System.Drawing.Size(382, 150);
            this.rbxSummary.TabIndex = 7;
            this.rbxSummary.Text = "Student Summary";
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnFirst.FlatAppearance.BorderSize = 2;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnFirst.Location = new System.Drawing.Point(235, 463);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(154, 31);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrevious.FlatAppearance.BorderSize = 2;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPrevious.Location = new System.Drawing.Point(388, 463);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(154, 31);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLast.FlatAppearance.BorderSize = 2;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLast.Location = new System.Drawing.Point(694, 463);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(154, 31);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.SystemColors.Control;
            this.pnlData.Controls.Add(this.dgvDatabase);
            this.pnlData.Location = new System.Drawing.Point(235, 166);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(613, 294);
            this.pnlData.TabIndex = 11;
            // 
            // dgvDatabase
            // 
            this.dgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatabase.Location = new System.Drawing.Point(0, 0);
            this.dgvDatabase.Name = "dgvDatabase";
            this.dgvDatabase.Size = new System.Drawing.Size(613, 294);
            this.dgvDatabase.TabIndex = 0;
            this.dgvDatabase.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatabase_DataError);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.Location = new System.Drawing.Point(541, 463);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(154, 31);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // ucDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.rbxSummary);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ucDatabase";
            this.Size = new System.Drawing.Size(848, 494);
            this.Load += new System.EventHandler(this.ucDatabase_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearchdata;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.RichTextBox rbxSummary;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvDatabase;
    }
}
