namespace InventoryTrackingSystem
{
    partial class frmGTNGen
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRemark = new gnclib.GotoNextTextBox();
            this.txtItemName = new acclib.AutoCompleteTextBox();
            this.gvGTN = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ne_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQty = new gnclib.GotoNextTextBox();
            this.txtTransCode = new System.Windows.Forms.TextBox();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.txtExLocation = new acclib.AutoCompleteTextBox();
            this.txtExCompany = new acclib.AutoCompleteTextBox();
            this.txtNewLocation = new acclib.AutoCompleteTextBox();
            this.txtNewCompany = new acclib.AutoCompleteTextBox();
            this.ntGTN = new NitificationBar.NitificationBar();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Size = new System.Drawing.Size(794, 2);
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
            this.panel1.Size = new System.Drawing.Size(794, 38);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::InventoryTrackingSystem.Properties.Resources.genGTN;
            this.pictureBox1.Location = new System.Drawing.Point(760, 4);
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
            this.label8.Size = new System.Drawing.Size(201, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "General Item Transfer Note transaction window";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Genaral Item Transfer Note";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 535);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 36);
            this.panel3.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(438, 7);
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
            this.btnDelete.Location = new System.Drawing.Point(529, 7);
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
            this.btnCancel.Location = new System.Drawing.Point(620, 7);
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
            this.btnExit.Location = new System.Drawing.Point(711, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dDate
            // 
            this.dDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dDate.Location = new System.Drawing.Point(142, 74);
            this.dDate.Name = "dDate";
            this.dDate.Size = new System.Drawing.Size(601, 20);
            this.dDate.TabIndex = 135;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 132;
            this.label9.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 131;
            this.label6.Text = "Ref No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 130;
            this.label5.Text = "Trans Code*";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(746, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRemark.GotoNextController = true;
            this.txtRemark.Location = new System.Drawing.Point(561, 246);
            this.txtRemark.Multiline = false;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.PasswordChar = '\0';
            this.txtRemark.Size = new System.Drawing.Size(182, 20);
            this.txtRemark.TabIndex = 6;
            // 
            // txtItemName
            // 
            this.txtItemName.CallBackMethod = "";
            this.txtItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemName.DataSourceMethod = "getItemName";
            this.txtItemName.GotoNextController = true;
            this.txtItemName.Location = new System.Drawing.Point(41, 246);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(99, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // gvGTN
            // 
            this.gvGTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.ex_location,
            this.ex_company,
            this.qty,
            this.ne_location,
            this.ne_company,
            this.remark});
            this.gvGTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvGTN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvGTN.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.gvGTN.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.gvGTN.Location = new System.Drawing.Point(0, 269);
            this.gvGTN.MultiSelect = false;
            this.gvGTN.Name = "gvGTN";
            this.gvGTN.ShowEditingIcon = false;
            this.gvGTN.Size = new System.Drawing.Size(794, 266);
            this.gvGTN.TabIndex = 126;
            this.gvGTN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGTN_CellDoubleClick);
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name*";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // ex_location
            // 
            this.ex_location.HeaderText = "Ex: Location*";
            this.ex_location.Name = "ex_location";
            this.ex_location.ReadOnly = true;
            this.ex_location.Width = 95;
            // 
            // ex_company
            // 
            this.ex_company.HeaderText = "Ex: Company*";
            this.ex_company.Name = "ex_company";
            this.ex_company.ReadOnly = true;
            this.ex_company.Width = 95;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty*";
            this.qty.Name = "qty";
            this.qty.Width = 40;
            // 
            // ne_location
            // 
            this.ne_location.HeaderText = "Ne: Location*";
            this.ne_location.Name = "ne_location";
            this.ne_location.ReadOnly = true;
            this.ne_location.Width = 95;
            // 
            // ne_company
            // 
            this.ne_company.HeaderText = "Ne: Company*";
            this.ne_company.Name = "ne_company";
            this.ne_company.ReadOnly = true;
            this.ne_company.Width = 95;
            // 
            // remark
            // 
            this.remark.HeaderText = "Remark";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 233;
            // 
            // txtQty
            // 
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQty.GotoNextController = true;
            this.txtQty.Location = new System.Drawing.Point(331, 246);
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.Size = new System.Drawing.Size(39, 20);
            this.txtQty.TabIndex = 3;
            // 
            // txtTransCode
            // 
            this.txtTransCode.Location = new System.Drawing.Point(142, 100);
            this.txtTransCode.Name = "txtTransCode";
            this.txtTransCode.Size = new System.Drawing.Size(601, 20);
            this.txtTransCode.TabIndex = 149;
            this.txtTransCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTranceCode_KeyDown);
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(142, 127);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(601, 20);
            this.txtRefNo.TabIndex = 152;
            // 
            // txtExLocation
            // 
            this.txtExLocation.CallBackMethod = "";
            this.txtExLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExLocation.DataSourceMethod = "getLocationEx";
            this.txtExLocation.GotoNextController = true;
            this.txtExLocation.Location = new System.Drawing.Point(142, 246);
            this.txtExLocation.Name = "txtExLocation";
            this.txtExLocation.Size = new System.Drawing.Size(93, 20);
            this.txtExLocation.TabIndex = 1;
            // 
            // txtExCompany
            // 
            this.txtExCompany.CallBackMethod = "";
            this.txtExCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExCompany.DataSourceMethod = "getComapanyEx";
            this.txtExCompany.GotoNextController = true;
            this.txtExCompany.Location = new System.Drawing.Point(237, 246);
            this.txtExCompany.Name = "txtExCompany";
            this.txtExCompany.Size = new System.Drawing.Size(93, 20);
            this.txtExCompany.TabIndex = 2;
            // 
            // txtNewLocation
            // 
            this.txtNewLocation.CallBackMethod = "";
            this.txtNewLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewLocation.DataSourceMethod = "getLocationNe";
            this.txtNewLocation.GotoNextController = true;
            this.txtNewLocation.Location = new System.Drawing.Point(371, 246);
            this.txtNewLocation.Name = "txtNewLocation";
            this.txtNewLocation.Size = new System.Drawing.Size(94, 20);
            this.txtNewLocation.TabIndex = 4;
            // 
            // txtNewCompany
            // 
            this.txtNewCompany.CallBackMethod = "";
            this.txtNewCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewCompany.DataSourceMethod = "getComapanyNe";
            this.txtNewCompany.GotoNextController = true;
            this.txtNewCompany.Location = new System.Drawing.Point(466, 246);
            this.txtNewCompany.Name = "txtNewCompany";
            this.txtNewCompany.Size = new System.Drawing.Size(94, 20);
            this.txtNewCompany.TabIndex = 5;
            // 
            // ntGTN
            // 
            this.ntGTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ntGTN.Location = new System.Drawing.Point(0, 40);
            this.ntGTN.Name = "ntGTN";
            this.ntGTN.Size = new System.Drawing.Size(794, 20);
            this.ntGTN.TabIndex = 160;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(142, 153);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(601, 79);
            this.txtDescription.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 166;
            this.label1.Text = "Description";
            // 
            // frmGTNGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ntGTN);
            this.Controls.Add(this.txtNewCompany);
            this.Controls.Add(this.txtNewLocation);
            this.Controls.Add(this.txtExCompany);
            this.Controls.Add(this.txtExLocation);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.txtTransCode);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.dDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.gvGTN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGTNGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmGTNGen_Load);
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
        private System.Windows.Forms.DateTimePicker dDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private gnclib.GotoNextTextBox txtRemark;
        private acclib.AutoCompleteTextBox txtItemName;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvGTN;
        private gnclib.GotoNextTextBox txtQty;
        private System.Windows.Forms.TextBox txtTransCode;
        private System.Windows.Forms.TextBox txtRefNo;
        private acclib.AutoCompleteTextBox txtExLocation;
        private acclib.AutoCompleteTextBox txtExCompany;
        private acclib.AutoCompleteTextBox txtNewLocation;
        private acclib.AutoCompleteTextBox txtNewCompany;
        private NitificationBar.NitificationBar ntGTN;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ne_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;

    }
}

