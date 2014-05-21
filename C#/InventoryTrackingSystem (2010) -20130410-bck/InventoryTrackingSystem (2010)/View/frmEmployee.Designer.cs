namespace InventoryTrackingSystem
{
    partial class frmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox1 = new acclib.AutoCompleteTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox2 = new acclib.AutoCompleteTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox3 = new acclib.AutoCompleteTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox4 = new acclib.AutoCompleteTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoCompleteTextBox5 = new acclib.AutoCompleteTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.autoCompleteTextBox6 = new acclib.AutoCompleteTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 2);
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
            this.panel1.Size = new System.Drawing.Size(483, 38);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::InventoryTrackingSystem.Properties.Resources.emp;
            this.pictureBox1.Location = new System.Drawing.Point(449, 4);
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
            this.label8.Size = new System.Drawing.Size(149, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Employee basic info setup window";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 36);
            this.panel3.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(127, 7);
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
            this.btnDelete.Location = new System.Drawing.Point(218, 7);
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
            this.btnCancel.Location = new System.Drawing.Point(309, 7);
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
            this.btnExit.Location = new System.Drawing.Point(400, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Title";
            // 
            // autoCompleteTextBox1
            // 
            this.autoCompleteTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox1.DataSourceMethod = "";
            this.autoCompleteTextBox1.GotoNextController = true;
            this.autoCompleteTextBox1.Location = new System.Drawing.Point(138, 131);
            this.autoCompleteTextBox1.Name = "autoCompleteTextBox1";
            this.autoCompleteTextBox1.Size = new System.Drawing.Size(330, 20);
            this.autoCompleteTextBox1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Designation";
            // 
            // autoCompleteTextBox2
            // 
            this.autoCompleteTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox2.DataSourceMethod = "";
            this.autoCompleteTextBox2.GotoNextController = true;
            this.autoCompleteTextBox2.Location = new System.Drawing.Point(137, 170);
            this.autoCompleteTextBox2.Name = "autoCompleteTextBox2";
            this.autoCompleteTextBox2.Size = new System.Drawing.Size(330, 20);
            this.autoCompleteTextBox2.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Company Name";
            // 
            // autoCompleteTextBox3
            // 
            this.autoCompleteTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox3.DataSourceMethod = "";
            this.autoCompleteTextBox3.GotoNextController = true;
            this.autoCompleteTextBox3.Location = new System.Drawing.Point(137, 92);
            this.autoCompleteTextBox3.Name = "autoCompleteTextBox3";
            this.autoCompleteTextBox3.Size = new System.Drawing.Size(330, 20);
            this.autoCompleteTextBox3.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Employee Code";
            // 
            // autoCompleteTextBox4
            // 
            this.autoCompleteTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox4.DataSourceMethod = "";
            this.autoCompleteTextBox4.GotoNextController = false;
            this.autoCompleteTextBox4.Location = new System.Drawing.Point(137, 57);
            this.autoCompleteTextBox4.Name = "autoCompleteTextBox4";
            this.autoCompleteTextBox4.Size = new System.Drawing.Size(141, 20);
            this.autoCompleteTextBox4.TabIndex = 40;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(329, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // autoCompleteTextBox5
            // 
            this.autoCompleteTextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox5.DataSourceMethod = "";
            this.autoCompleteTextBox5.GotoNextController = false;
            this.autoCompleteTextBox5.Location = new System.Drawing.Point(137, 211);
            this.autoCompleteTextBox5.Name = "autoCompleteTextBox5";
            this.autoCompleteTextBox5.Size = new System.Drawing.Size(141, 20);
            this.autoCompleteTextBox5.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(284, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Email";
            // 
            // autoCompleteTextBox6
            // 
            this.autoCompleteTextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.autoCompleteTextBox6.DataSourceMethod = "";
            this.autoCompleteTextBox6.GotoNextController = false;
            this.autoCompleteTextBox6.Location = new System.Drawing.Point(329, 211);
            this.autoCompleteTextBox6.Name = "autoCompleteTextBox6";
            this.autoCompleteTextBox6.Size = new System.Drawing.Size(138, 20);
            this.autoCompleteTextBox6.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "Employee Name";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(483, 286);
            this.Controls.Add(this.autoCompleteTextBox6);
            this.Controls.Add(this.autoCompleteTextBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.autoCompleteTextBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.autoCompleteTextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.autoCompleteTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autoCompleteTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private acclib.AutoCompleteTextBox autoCompleteTextBox1;
        private System.Windows.Forms.Label label2;
        private acclib.AutoCompleteTextBox autoCompleteTextBox2;
        private System.Windows.Forms.Label label3;
        private acclib.AutoCompleteTextBox autoCompleteTextBox3;
        private System.Windows.Forms.Label label5;
        private acclib.AutoCompleteTextBox autoCompleteTextBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private acclib.AutoCompleteTextBox autoCompleteTextBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private acclib.AutoCompleteTextBox autoCompleteTextBox6;
        private System.Windows.Forms.Label label4;

    }
}

