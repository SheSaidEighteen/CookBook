namespace CookBook
{
    partial class NewRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRecipe));
            groupBox1 = new GroupBox();
            txtCulture = new TextBox();
            txtType = new TextBox();
            label8 = new Label();
            txtTill = new TextBox();
            label7 = new Label();
            txtFrom = new TextBox();
            rtxtIngrediënts = new RichTextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            btnNew = new Button();
            pbItem = new PictureBox();
            txtAmount = new TextBox();
            label5 = new Label();
            cbCulture = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cbDishType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbItem).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCulture);
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTill);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFrom);
            groupBox1.Controls.Add(rtxtIngrediënts);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(pbItem);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbCulture);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbDishType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1043, 485);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recept omschrijvingen";
            // 
            // txtCulture
            // 
            txtCulture.Font = new Font("Segoe UI", 12F);
            txtCulture.Location = new Point(380, 74);
            txtCulture.Name = "txtCulture";
            txtCulture.Size = new Size(152, 34);
            txtCulture.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Font = new Font("Segoe UI", 12F);
            txtType.Location = new Point(127, 74);
            txtType.Name = "txtType";
            txtType.Size = new Size(151, 34);
            txtType.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(473, 121);
            label8.Name = "label8";
            label8.Size = new Size(45, 28);
            label8.TabIndex = 17;
            label8.Text = "min";
            // 
            // txtTill
            // 
            txtTill.Font = new Font("Segoe UI", 12F);
            txtTill.Location = new Point(333, 118);
            txtTill.Name = "txtTill";
            txtTill.Size = new Size(134, 34);
            txtTill.TabIndex = 6;
            txtTill.KeyPress += TxtAmount_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(284, 121);
            label7.Name = "label7";
            label7.Size = new Size(43, 28);
            label7.TabIndex = 15;
            label7.Text = "Tot:";
            // 
            // txtFrom
            // 
            txtFrom.Font = new Font("Segoe UI", 12F);
            txtFrom.Location = new Point(144, 118);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(134, 34);
            txtFrom.TabIndex = 5;
            txtFrom.KeyPress += TxtAmount_KeyPress;
            // 
            // rtxtIngrediënts
            // 
            rtxtIngrediënts.Font = new Font("Segoe UI", 12F);
            rtxtIngrediënts.Location = new Point(6, 239);
            rtxtIngrediënts.Name = "rtxtIngrediënts";
            rtxtIngrediënts.Size = new Size(526, 232);
            rtxtIngrediënts.TabIndex = 99;
            rtxtIngrediënts.Text = "";
            rtxtIngrediënts.KeyUp += RtxtIngrediënts_KeyUp;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(6, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 2);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 208);
            label6.Name = "label6";
            label6.Size = new Size(127, 28);
            label6.TabIndex = 11;
            label6.Text = "Ingrediënten:";
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(551, 410);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(137, 37);
            btnNew.TabIndex = 9;
            btnNew.Text = "Foto";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += BtnNew_Click;
            // 
            // pbItem
            // 
            pbItem.Image = (Image)resources.GetObject("pbItem.Image");
            pbItem.Location = new Point(551, 30);
            pbItem.Name = "pbItem";
            pbItem.Size = new Size(486, 374);
            pbItem.SizeMode = PictureBoxSizeMode.CenterImage;
            pbItem.TabIndex = 9;
            pbItem.TabStop = false;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 12F);
            txtAmount.Location = new Point(170, 162);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(134, 34);
            txtAmount.TabIndex = 7;
            txtAmount.TextChanged += TextBox_Changed;
            txtAmount.KeyPress += TxtAmount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 165);
            label5.Name = "label5";
            label5.Size = new Size(158, 28);
            label5.TabIndex = 7;
            label5.Text = "Aantal personen:";
            // 
            // cbCulture
            // 
            cbCulture.Font = new Font("Segoe UI", 12F);
            cbCulture.FormattingEnabled = true;
            cbCulture.Location = new Point(380, 74);
            cbCulture.Name = "cbCulture";
            cbCulture.Size = new Size(152, 36);
            cbCulture.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(294, 77);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 5;
            label4.Text = "Cultuur:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 4;
            label3.Text = "Bereidtijd van:";
            // 
            // cbDishType
            // 
            cbDishType.Font = new Font("Segoe UI", 12F);
            cbDishType.FormattingEnabled = true;
            cbDishType.Location = new Point(127, 74);
            cbDishType.Name = "cbDishType";
            cbDishType.Size = new Size(151, 36);
            cbDishType.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 1;
            label1.Text = "Naam:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(127, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(405, 34);
            txtName.TabIndex = 0;
            txtName.TextChanged += TextBox_Changed;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(918, 503);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 37);
            btnSave.TabIndex = 10;
            btnSave.Text = "Opslaan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(12, 503);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 37);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Annuleren";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // NewRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 555);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "NewRecipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nieuw recept";
            Load += NewRecipe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private ComboBox cbDishType;
        private Label label3;
        private ComboBox cbCulture;
        private Label label4;
        private Label label5;
        private TextBox txtAmount;
        private PictureBox pbItem;
        private Button btnNew;
        private Label label6;
        private GroupBox groupBox2;
        private RichTextBox rtxtIngrediënts;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtTill;
        private Label label7;
        private TextBox txtFrom;
        private Label label8;
        private TextBox txtType;
        private TextBox txtCulture;
    }
}