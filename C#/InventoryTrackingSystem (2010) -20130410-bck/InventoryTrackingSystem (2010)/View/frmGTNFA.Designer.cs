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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gvGTN = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.autoCompleteTextBox1 = new acclib.AutoCompleteTextBox();
            this.gotoNextTextBox1 = new gnclib.GotoNextTextBox();
            this.gotoNextTextBox2 = new gnclib.GotoNextTextBox();
            this.gotoNextTextBox3 = new gnclib.GotoNextTextBox();
            this.gotoNextTextBox4 = new gnclib.GotoNextTextBox();
            this.gotoNextTextBox5 = new gnclib.GotoNextTextBox();
            this.gotoNextTextBox6 = new gnclib.GotoNextTextBox();
            this.gotoNextTextBox7 = new gnclib.GotoNextTextBox();
            this.gotoNextTextBox8 = new gnclib.GotoNextTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.autoCompleteTextBox5 = new acclib.AutoCompleteTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox4 = new acclib.AutoCompleteTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.panel3.Location = new System.Drawing.Point(0, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 36);
            this.panel3.TabIndex = 25;
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
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(644, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(911, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
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
            this.Column9,
            this.Column10});
            this.gvGTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvGTN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gvGTN.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.gvGTN.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.gvGTN.Location = new System.Drawing.Point(0, 197);
            this.gvGTN.MultiSelect = false;
            this.gvGTN.Name = "gvGTN";
            this.gvGTN.ShowEditingIcon = false;
            this.gvGTN.Size = new System.Drawing.Size(994, 265);
            this.gvGTN.TabIndex = 26;
            // 
            // autoCompleteTextBox1
            // 
            this.autoCompleteTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox1.DataSourceMethod = "";
            this.autoCompleteTextBox1.GotoNextController = false;
            this.autoCompleteTextBox1.Location = new System.Drawing.Point(41, 172);
            this.autoCompleteTextBox1.Name = "autoCompleteTextBox1";
            this.autoCompleteTextBox1.Size = new System.Drawing.Size(99, 20);
            this.autoCompleteTextBox1.TabIndex = 1;
            // 
            // gotoNextTextBox1
            // 
            this.gotoNextTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox1.Enabled = false;
            this.gotoNextTextBox1.GotoNextController = true;
            this.gotoNextTextBox1.Location = new System.Drawing.Point(141, 172);
            this.gotoNextTextBox1.Multiline = false;
            this.gotoNextTextBox1.Name = "gotoNextTextBox1";
            this.gotoNextTextBox1.PasswordChar = '\0';
            this.gotoNextTextBox1.Size = new System.Drawing.Size(79, 20);
            this.gotoNextTextBox1.TabIndex = 31;
            // 
            // gotoNextTextBox2
            // 
            this.gotoNextTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox2.Enabled = false;
            this.gotoNextTextBox2.GotoNextController = true;
            this.gotoNextTextBox2.Location = new System.Drawing.Point(221, 172);
            this.gotoNextTextBox2.Multiline = false;
            this.gotoNextTextBox2.Name = "gotoNextTextBox2";
            this.gotoNextTextBox2.PasswordChar = '\0';
            this.gotoNextTextBox2.Size = new System.Drawing.Size(79, 20);
            this.gotoNextTextBox2.TabIndex = 32;
            // 
            // gotoNextTextBox3
            // 
            this.gotoNextTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox3.Enabled = false;
            this.gotoNextTextBox3.GotoNextController = true;
            this.gotoNextTextBox3.Location = new System.Drawing.Point(301, 172);
            this.gotoNextTextBox3.Multiline = false;
            this.gotoNextTextBox3.Name = "gotoNextTextBox3";
            this.gotoNextTextBox3.PasswordChar = '\0';
            this.gotoNextTextBox3.Size = new System.Drawing.Size(99, 20);
            this.gotoNextTextBox3.TabIndex = 33;
            // 
            // gotoNextTextBox4
            // 
            this.gotoNextTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox4.GotoNextController = true;
            this.gotoNextTextBox4.Location = new System.Drawing.Point(401, 172);
            this.gotoNextTextBox4.Multiline = false;
            this.gotoNextTextBox4.Name = "gotoNextTextBox4";
            this.gotoNextTextBox4.PasswordChar = '\0';
            this.gotoNextTextBox4.Size = new System.Drawing.Size(99, 20);
            this.gotoNextTextBox4.TabIndex = 2;
            // 
            // gotoNextTextBox5
            // 
            this.gotoNextTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox5.GotoNextController = true;
            this.gotoNextTextBox5.Location = new System.Drawing.Point(501, 172);
            this.gotoNextTextBox5.Multiline = false;
            this.gotoNextTextBox5.Name = "gotoNextTextBox5";
            this.gotoNextTextBox5.PasswordChar = '\0';
            this.gotoNextTextBox5.Size = new System.Drawing.Size(79, 20);
            this.gotoNextTextBox5.TabIndex = 3;
            // 
            // gotoNextTextBox6
            // 
            this.gotoNextTextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox6.GotoNextController = true;
            this.gotoNextTextBox6.Location = new System.Drawing.Point(581, 172);
            this.gotoNextTextBox6.Multiline = false;
            this.gotoNextTextBox6.Name = "gotoNextTextBox6";
            this.gotoNextTextBox6.PasswordChar = '\0';
            this.gotoNextTextBox6.Size = new System.Drawing.Size(79, 20);
            this.gotoNextTextBox6.TabIndex = 4;
            // 
            // gotoNextTextBox7
            // 
            this.gotoNextTextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox7.GotoNextController = true;
            this.gotoNextTextBox7.Location = new System.Drawing.Point(661, 172);
            this.gotoNextTextBox7.Multiline = false;
            this.gotoNextTextBox7.Name = "gotoNextTextBox7";
            this.gotoNextTextBox7.PasswordChar = '\0';
            this.gotoNextTextBox7.Size = new System.Drawing.Size(99, 20);
            this.gotoNextTextBox7.TabIndex = 5;
            // 
            // gotoNextTextBox8
            // 
            this.gotoNextTextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gotoNextTextBox8.GotoNextController = true;
            this.gotoNextTextBox8.Location = new System.Drawing.Point(761, 172);
            this.gotoNextTextBox8.Multiline = false;
            this.gotoNextTextBox8.Name = "gotoNextTextBox8";
            this.gotoNextTextBox8.PasswordChar = '\0';
            this.gotoNextTextBox8.Size = new System.Drawing.Size(182, 20);
            this.gotoNextTextBox8.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // autoCompleteTextBox5
            // 
            this.autoCompleteTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox5.DataSourceMethod = "";
            this.autoCompleteTextBox5.GotoNextController = true;
            this.autoCompleteTextBox5.Location = new System.Drawing.Point(137, 126);
            this.autoCompleteTextBox5.Name = "autoCompleteTextBox5";
            this.autoCompleteTextBox5.Size = new System.Drawing.Size(238, 20);
            this.autoCompleteTextBox5.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 109;
            this.label9.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 108;
            this.label6.Text = "Ref No";
            // 
            // autoCompleteTextBox4
            // 
            this.autoCompleteTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox4.DataSourceMethod = "";
            this.autoCompleteTextBox4.GotoNextController = false;
            this.autoCompleteTextBox4.Location = new System.Drawing.Point(137, 95);
            this.autoCompleteTextBox4.Name = "autoCompleteTextBox4";
            this.autoCompleteTextBox4.Size = new System.Drawing.Size(238, 20);
            this.autoCompleteTextBox4.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 107;
            this.label5.Text = "Trans Code";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(731, 7);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 115;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ex: Location";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ex: Company";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Belongs to";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ne: Code";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ne: Location";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ne: Company";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Belong";
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
            // Column10
            // 
            this.Column10.HeaderText = "Action";
            this.Column10.Items.AddRange(new object[] {
            "None",
            "Edit",
            "Delete"});
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column10.Width = 50;
            // 
            // frmGTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(994, 498);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.autoCompleteTextBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.autoCompleteTextBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gotoNextTextBox8);
            this.Controls.Add(this.gotoNextTextBox7);
            this.Controls.Add(this.gotoNextTextBox6);
            this.Controls.Add(this.gotoNextTextBox5);
            this.Controls.Add(this.gotoNextTextBox4);
            this.Controls.Add(this.gotoNextTextBox3);
            this.Controls.Add(this.gotoNextTextBox2);
            this.Controls.Add(this.gotoNextTextBox1);
            this.Controls.Add(this.autoCompleteTextBox1);
            this.Controls.Add(this.gvGTN);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmGTN";
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
        private acclib.AutoCompleteTextBox autoCompleteTextBox1;
        private gnclib.GotoNextTextBox gotoNextTextBox1;
        private gnclib.GotoNextTextBox gotoNextTextBox2;
        private gnclib.GotoNextTextBox gotoNextTextBox3;
        private gnclib.GotoNextTextBox gotoNextTextBox4;
        private gnclib.GotoNextTextBox gotoNextTextBox5;
        private gnclib.GotoNextTextBox gotoNextTextBox6;
        private gnclib.GotoNextTextBox gotoNextTextBox7;
        private gnclib.GotoNextTextBox gotoNextTextBox8;
        private System.Windows.Forms.Button button1;
        private acclib.AutoCompleteTextBox autoCompleteTextBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private acclib.AutoCompleteTextBox autoCompleteTextBox4;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView gvGTN;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column10;

    }
}

