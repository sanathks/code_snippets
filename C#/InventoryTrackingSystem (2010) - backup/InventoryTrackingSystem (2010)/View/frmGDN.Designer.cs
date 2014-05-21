namespace InventoryTrackingSystem
{
    partial class frmGDN
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gvGDN = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtItemCode = new acclib.AutoCompleteTextBox();
            this.txtValue = new gnclib.GotoNextTextBox();
            this.txtDescription = new gnclib.GotoNextTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new gnclib.GotoNextTextBox();
            this.txtTransCode = new System.Windows.Forms.TextBox();
            this.cmdStock = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ntGDN = new NitificationBar.NitificationBar();
            this.txtExLocation = new acclib.AutoCompleteTextBox();
            this.txtExCompany = new acclib.AutoCompleteTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGDN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 2);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 38);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::InventoryTrackingSystem.Properties.Resources._64_trash;
            this.pictureBox1.Location = new System.Drawing.Point(857, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Goods Disposal Note transaction window";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Goods Disposal Note (GDN)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 36);
            this.panel3.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(535, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(626, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(717, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(808, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dDate
            // 
            this.dDate.Location = new System.Drawing.Point(137, 76);
            this.dDate.Name = "dDate";
            this.dDate.Size = new System.Drawing.Size(238, 20);
            this.dDate.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 120;
            this.label9.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Trans Code";
            // 
            // gvGDN
            // 
            this.gvGDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5});
            this.gvGDN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvGDN.Location = new System.Drawing.Point(0, 193);
            this.gvGDN.Name = "gvGDN";
            this.gvGDN.Size = new System.Drawing.Size(891, 242);
            this.gvGDN.TabIndex = 124;
            this.gvGDN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGTN_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Location";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Company";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qty";
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Value";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Remark";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // txtItemCode
            // 
            this.txtItemCode.CallBackMethod = "callback";
            this.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemCode.DataSourceMethod = "serialCode";
            this.txtItemCode.GotoNextController = true;
            this.txtItemCode.Location = new System.Drawing.Point(40, 166);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(147, 20);
            this.txtItemCode.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtValue.Enabled = false;
            this.txtValue.GotoNextController = true;
            this.txtValue.Location = new System.Drawing.Point(492, 166);
            this.txtValue.Multiline = false;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.Size = new System.Drawing.Size(99, 20);
            this.txtValue.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescription.GotoNextController = true;
            this.txtDescription.Location = new System.Drawing.Point(593, 166);
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Size = new System.Drawing.Size(246, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(845, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQty
            // 
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQty.GotoNextController = true;
            this.txtQty.Location = new System.Drawing.Point(391, 166);
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.Size = new System.Drawing.Size(99, 20);
            this.txtQty.TabIndex = 3;
            // 
            // txtTransCode
            // 
            this.txtTransCode.Location = new System.Drawing.Point(137, 105);
            this.txtTransCode.Name = "txtTransCode";
            this.txtTransCode.Size = new System.Drawing.Size(238, 20);
            this.txtTransCode.TabIndex = 139;
            this.txtTransCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransCode_KeyDown);
            // 
            // cmdStock
            // 
            this.cmdStock.BackColor = System.Drawing.Color.IndianRed;
            this.cmdStock.ForeColor = System.Drawing.Color.White;
            this.cmdStock.FormattingEnabled = true;
            this.cmdStock.Items.AddRange(new object[] {
            "Genaral",
            "Fixed Assets",
            "Elec/Communication Divice"});
            this.cmdStock.Location = new System.Drawing.Point(137, 134);
            this.cmdStock.Name = "cmdStock";
            this.cmdStock.Size = new System.Drawing.Size(238, 21);
            this.cmdStock.TabIndex = 141;
            this.cmdStock.SelectedIndexChanged += new System.EventHandler(this.cmdStock_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 140;
            this.label1.Text = "Stock*";
            // 
            // ntGDN
            // 
            this.ntGDN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ntGDN.Location = new System.Drawing.Point(0, 40);
            this.ntGDN.Name = "ntGDN";
            this.ntGDN.Size = new System.Drawing.Size(891, 20);
            this.ntGDN.TabIndex = 143;
            // 
            // txtExLocation
            // 
            this.txtExLocation.CallBackMethod = "";
            this.txtExLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExLocation.DataSourceMethod = "exLocation";
            this.txtExLocation.Enabled = false;
            this.txtExLocation.GotoNextController = true;
            this.txtExLocation.Location = new System.Drawing.Point(189, 166);
            this.txtExLocation.Name = "txtExLocation";
            this.txtExLocation.Size = new System.Drawing.Size(99, 20);
            this.txtExLocation.TabIndex = 1;
            // 
            // txtExCompany
            // 
            this.txtExCompany.CallBackMethod = "";
            this.txtExCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExCompany.DataSourceMethod = "exCompany";
            this.txtExCompany.Enabled = false;
            this.txtExCompany.GotoNextController = true;
            this.txtExCompany.Location = new System.Drawing.Point(290, 166);
            this.txtExCompany.Name = "txtExCompany";
            this.txtExCompany.Size = new System.Drawing.Size(99, 20);
            this.txtExCompany.TabIndex = 2;
            // 
            // frmGDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(891, 471);
            this.Controls.Add(this.txtExCompany);
            this.Controls.Add(this.txtExLocation);
            this.Controls.Add(this.ntGDN);
            this.Controls.Add(this.cmdStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransCode);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.gvGDN);
            this.Controls.Add(this.dDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGDN";
            this.Load += new System.EventHandler(this.frmGDN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvGDN;
        private acclib.AutoCompleteTextBox txtItemCode;
        private gnclib.GotoNextTextBox txtValue;
        private gnclib.GotoNextTextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private gnclib.GotoNextTextBox txtQty;
        private System.Windows.Forms.TextBox txtTransCode;
        private System.Windows.Forms.ComboBox cmdStock;
        private System.Windows.Forms.Label label1;
        private NitificationBar.NitificationBar ntGDN;
        private acclib.AutoCompleteTextBox txtExLocation;
        private acclib.AutoCompleteTextBox txtExCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}

