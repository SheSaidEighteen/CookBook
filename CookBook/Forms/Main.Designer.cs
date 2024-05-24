namespace CookBook
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnNew = new Button();
            dgvRecepts = new DataGridView();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecepts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 2);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(651, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(137, 37);
            btnNew.TabIndex = 2;
            btnNew.Text = "Nieuw recept";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += BtnNew_Click;
            // 
            // dgvRecepts
            // 
            dgvRecepts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecepts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvRecepts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecepts.Location = new Point(12, 63);
            dgvRecepts.Name = "dgvRecepts";
            dgvRecepts.RowHeadersWidth = 51;
            dgvRecepts.Size = new Size(776, 375);
            dgvRecepts.TabIndex = 3;
            dgvRecepts.CellClick += DgvRecepts_CellClick;
            dgvRecepts.DoubleClick += DgvRecepts_DoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(12, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(293, 34);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(508, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 37);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Aanpassen";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtSearch);
            Controls.Add(dgvRecepts);
            Controls.Add(btnNew);
            Controls.Add(groupBox1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecepts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnNew;
        private DataGridView dgvRecepts;
        private TextBox txtSearch;
        private Button btnUpdate;
    }
}
