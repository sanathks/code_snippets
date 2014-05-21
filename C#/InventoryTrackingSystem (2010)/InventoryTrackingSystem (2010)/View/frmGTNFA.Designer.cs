namespace InventoryTrackingSystem
{
    partial class frmGTNFA
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gvGTN = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRemark = new gnclib.GotoNextTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dDate = new System.Windows.Forms.DateTimePicker();
            this.txtTransCode = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtNeCode = new SNTXTBX.SNTXTBX();
            this.ntGTN = new NitificationBar.NitificationBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStock = new System.Windows.Forms.ComboBox();
            this.txtNeCompany = new acclib.AutoCompleteTextBox();
            this.txtNeLocation = new acclib.AutoCompleteTextBox();
            this.txtNeCurrentUser = new acclib.AutoCompleteTextBox();
            this.txtExCurrentUser = new acclib.AutoCompleteTextBox();
            this.txtExCompany = new acclib.AutoCompleteTextBox();
            this.txtExLocation = new acclib.AutoCompleteTextBox();
            this.txtItemCode = new acclib.AutoCompleteTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvGTN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 2);
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
            this.panel1.Size = new System.Drawing.Size(994, 38);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::InventoryTrackingSystem.Properties.Resources.allGTN;
            this.pictureBox1.Location = new System.Drawing.Point(960, 4);
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
            this.label8.Size = new System.Drawing.Size(174, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Goods Transfer Note transaction window";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Goods Transfer Note (GTN)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 36);
            this.panel3.TabIndex = 25;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(731, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(553, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(644, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(820, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(911, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvGTN
            // 
            this.gvGTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.gvGTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvGTN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvGTN.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.gvGTN.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.gvGTN.Location = new System.Drawing.Point(0, 270);
            this.gvGTN.MultiSelect = false;
            this.gvGTN.Name = "gvGTN";
            this.gvGTN.ShowEditingIcon = false;
            this.gvGTN.Size = new System.Drawing.Size(994, 265);
            this.gvGTN.TabIndex = 26;
            this.gvGTN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGTN_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code*";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ex: Location*";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ex: Company*";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ex: Current User";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ne: Code*";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ne: Location*";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ne: Company*";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ne: Current User";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Remark";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 183;
            // 
            // txtRemark
            // 
            this.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRemark.GotoNextController = true;
            this.txtRemark.Location = new System.Drawing.Point(811, 245);
            this.txtRemark.Multiline = false;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.PasswordChar = '\0';
            this.txtRemark.Size = new System.Drawing.Size(133, 20);
            this.txtRemark.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(946, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 109;
            this.label9.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 108;
            this.label6.Text = "Description";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 107;
            this.label5.Text = "Trans Code*";
            // 
            // dDate
            // 
            this.dDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dDate.Location = new System.Drawing.Point(137, 74);
            this.dDate.Name = "dDate";
            this.dDate.Size = new System.Drawing.Size(238, 20);
            this.dDate.TabIndex = 115;
            // 
            // txtTransCode
            // 
            this.txtTransCode.Location = new System.Drawing.Point(137, 133);
            this.txtTransCode.Name = "txtTransCode";
            this.txtTransCode.Size = new System.Drawing.Size(238, 20);
            this.txtTransCode.TabIndex = 119;
            this.txtTransCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTransCode_KeyDown);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(137, 162);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(238, 69);
            this.txtDesc.TabIndex = 120;
            this.txtDesc.Visible = false;
            // 
            // txtNeCode
            // 
            this.txtNeCode.GotoNextController = true;
            this.txtNeCode.Location = new System.Drawing.Point(450, 245);
            this.txtNeCode.Name = "txtNeCode";
            this.txtNeCode.Size = new System.Drawing.Size(99, 20);
            this.txtNeCode.TabIndex = 4;
            // 
            // ntGTN
            // 
            this.ntGTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ntGTN.Location = new System.Drawing.Point(0, 40);
            this.ntGTN.Name = "ntGTN";
            this.ntGTN.Size = new System.Drawing.Size(994, 20);
            this.ntGTN.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 123;
            this.label1.Text = "Stock*";
            // 
            // cmdStock
            // 
            this.cmdStock.BackColor = System.Drawing.Color.IndianRed;
            this.cmdStock.ForeColor = System.Drawing.Color.White;
            this.cmdStock.FormattingEnabled = true;
            this.cmdStock.Items.AddRange(new object[] {
            "Fixed Assets",
            "Elec/Communication Divice"});
            this.cmdStock.Location = new System.Drawing.Point(137, 104);
            this.cmdStock.Name = "cmdStock";
            this.cmdStock.Size = new System.Drawing.Size(238, 21);
            this.cmdStock.TabIndex = 124;
            this.cmdStock.SelectedIndexChanged += new System.EventHandler(this.cmdStock_SelectedIndexChanged);
            // 
            // txtNeCompany
            // 
            this.txtNeCompany.CallBackMethod = "";
            this.txtNeCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNeCompany.DataSourceMethod = "neCompany";
            this.txtNeCompany.GotoNextController = true;
            this.txtNeCompany.Location = new System.Drawing.Point(630, 245);
            this.txtNeCompany.Name = "txtNeCompany";
            this.txtNeCompany.Size = new System.Drawing.Size(79, 20);
            this.txtNeCompany.TabIndex = 6;
            // 
            // txtNeLocation
            // 
            this.txtNeLocation.CallBackMethod = "";
            this.txtNeLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNeLocation.DataSourceMethod = "neLocation";
            this.txtNeLocation.GotoNextController = true;
            this.txtNeLocation.Location = new System.Drawing.Point(550, 245);
            this.txtNeLocation.Name = "txtNeLocation";
            this.txtNeLocation.Size = new System.Drawing.Size(79, 20);
            this.txtNeLocation.TabIndex = 5;
            // 
            // txtNeCurrentUser
            // 
            this.txtNeCurrentUser.CallBackMethod = "";
            this.txtNeCurrentUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNeCurrentUser.DataSourceMethod = "neCurrentUser";
            this.txtNeCurrentUser.GotoNextController = true;
            this.txtNeCurrentUser.Location = new System.Drawing.Point(710, 245);
            this.txtNeCurrentUser.Name = "txtNeCurrentUser";
            this.txtNeCurrentUser.Size = new System.Drawing.Size(99, 20);
            this.txtNeCurrentUser.TabIndex = 7;
            // 
            // txtExCurrentUser
            // 
            this.txtExCurrentUser.CallBackMethod = "";
            this.txtExCurrentUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtExCurrentUser.DataSourceMethod = "exCurrentUser";
            this.txtExCurrentUser.Enabled = false;
            this.txtExCurrentUser.GotoNextController = true;
            this.txtExCurrentUser.Location = new System.Drawing.Point(350, 245);
            this.txtExCurrentUser.Name = "txtExCurrentUser";
            this.txtExCurrentUser.Size = new System.Drawing.Size(99, 20);
            this.txtExCurrentUser.TabIndex = 3;
            // 
            // txtExCompany
            // 
            this.txtExCompany.CallBackMethod = "";
            this.txtExCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExCompany.DataSourceMethod = "exCompany";
            this.txtExCompany.Enabled = false;
            this.txtExCompany.GotoNextController = true;
            this.txtExCompany.Location = new System.Drawing.Point(270, 245);
            this.txtExCompany.Name = "txtExCompany";
            this.txtExCompany.Size = new System.Drawing.Size(79, 20);
            this.txtExCompany.TabIndex = 2;
            // 
            // txtExLocation
            // 
            this.txtExLocation.CallBackMethod = "";
            this.txtExLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExLocation.DataSourceMethod = "exLocation";
            this.txtExLocation.Enabled = false;
            this.txtExLocation.GotoNextController = true;
            this.txtExLocation.Location = new System.Drawing.Point(190, 245);
            this.txtExLocation.Name = "txtExLocation";
            this.txtExLocation.Size = new System.Drawing.Size(79, 20);
            this.txtExLocation.TabIndex = 1;
            // 
            // txtItemCode
            // 
            this.txtItemCode.CallBackMethod = "loadExData";
            this.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemCode.DataSourceMethod = "serialCode";
            this.txtItemCode.GotoNextController = true;
            this.txtItemCode.Location = new System.Drawing.Point(42, 245);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(147, 20);
            this.txtItemCode.TabIndex = 0;
            // 
            // frmGTNFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(994, 571);
            this.Controls.Add(this.cmdStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ntGTN);
            this.Controls.Add(this.txtNeCode);
            this.Controls.Add(this.txtNeCompany);
            this.Controls.Add(this.txtNeLocation);
            this.Controls.Add(this.txtNeCurrentUser);
            this.Controls.Add(this.txtExCurrentUser);
            this.Controls.Add(this.txtExCompany);
            this.Controls.Add(this.txtExLocation);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTransCode);
            this.Controls.Add(this.dDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.gvGTN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGTNFA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGTNFA_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvGTN)).EndInit();
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
        private acclib.AutoCompleteTextBox txtItemCode;
        private gnclib.GotoNextTextBox txtRemark;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvGTN;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dDate;
        private System.Windows.Forms.TextBox txtTransCode;
        private System.Windows.Forms.TextBox txtDesc;
        private acclib.AutoCompleteTextBox txtExLocation;
        private acclib.AutoCompleteTextBox txtExCompany;
        private acclib.AutoCompleteTextBox txtExCurrentUser;
        private acclib.AutoCompleteTextBox txtNeCurrentUser;
        private acclib.AutoCompleteTextBox txtNeLocation;
        private acclib.AutoCompleteTextBox txtNeCompany;
        private SNTXTBX.SNTXTBX txtNeCode;
        private NitificationBar.NitificationBar ntGTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdStock;

    }
}

