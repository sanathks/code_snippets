namespace InventoryTrackingSystem
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuXml = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signout = new System.Windows.Forms.LinkLabel();
            this.toolBarGeneral = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.miscContainerPanel = new System.Windows.Forms.Panel();
            this.miscCloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.isLoggedin = new System.Windows.Forms.Timer(this.components);
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.stSave = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.byEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBack = new System.Windows.Forms.ToolStripButton();
            this.tsNext = new System.Windows.Forms.ToolStripButton();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsSendMail = new System.Windows.Forms.ToolStripButton();
            this.tsBackup = new System.Windows.Forms.ToolStripButton();
            this.tsChart = new System.Windows.Forms.ToolStripButton();
            this.tsDatabaseregister = new System.Windows.Forms.ToolStripButton();
            this.tsUserControl = new System.Windows.Forms.ToolStripButton();
            this.tsSetting = new System.Windows.Forms.ToolStripButton();
            this.tsAddMisc = new System.Windows.Forms.ToolStripButton();
            this.miscPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.toolBarGeneral.SuspendLayout();
            this.miscContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuXml
            // 
            this.menuXml.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuXml.Location = new System.Drawing.Point(0, 0);
            this.menuXml.Name = "menuXml";
            this.menuXml.Size = new System.Drawing.Size(1152, 24);
            this.menuXml.TabIndex = 1;
            this.menuXml.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.signout);
            this.panel1.Controls.Add(this.toolBarGeneral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 29);
            this.panel1.TabIndex = 3;
            // 
            // signout
            // 
            this.signout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signout.AutoSize = true;
            this.signout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.signout.Location = new System.Drawing.Point(1094, 9);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(48, 13);
            this.signout.TabIndex = 11;
            this.signout.TabStop = true;
            this.signout.Text = "Sign Out";
            this.signout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signout_LinkClicked);
            // 
            // toolBarGeneral
            // 
            this.toolBarGeneral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolBarGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEdit,
            this.stSave,
            this.tsDelete,
            this.tsPrint,
            this.toolStripSeparator1,
            this.tsReload,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.tsBack,
            this.tsNext,
            this.tsClose,
            this.toolStripSeparator3,
            this.tsSendMail,
            this.tsBackup,
            this.tsChart,
            this.toolStripSeparator4,
            this.tsDatabaseregister,
            this.tsUserControl,
            this.tsSetting,
            this.tsAddMisc});
            this.toolBarGeneral.Location = new System.Drawing.Point(0, 0);
            this.toolBarGeneral.Name = "toolBarGeneral";
            this.toolBarGeneral.Size = new System.Drawing.Size(1152, 25);
            this.toolBarGeneral.TabIndex = 0;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 1);
            this.panel2.TabIndex = 8;
            // 
            // miscContainerPanel
            // 
            this.miscContainerPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.miscContainerPanel.Controls.Add(this.miscCloseButton);
            this.miscContainerPanel.Controls.Add(this.label1);
            this.miscContainerPanel.Controls.Add(this.miscPanel);
            this.miscContainerPanel.Controls.Add(this.textBox1);
            this.miscContainerPanel.Controls.Add(this.panel5);
            this.miscContainerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.miscContainerPanel.Location = new System.Drawing.Point(0, 54);
            this.miscContainerPanel.Name = "miscContainerPanel";
            this.miscContainerPanel.Size = new System.Drawing.Size(202, 605);
            this.miscContainerPanel.TabIndex = 9;
            // 
            // miscCloseButton
            // 
            this.miscCloseButton.AutoSize = true;
            this.miscCloseButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscCloseButton.Location = new System.Drawing.Point(177, 10);
            this.miscCloseButton.Name = "miscCloseButton";
            this.miscCloseButton.Size = new System.Drawing.Size(15, 13);
            this.miscCloseButton.TabIndex = 5;
            this.miscCloseButton.Text = "X";
            this.miscCloseButton.Click += new System.EventHandler(this.miscCloseButton_Click);
            this.miscCloseButton.MouseLeave += new System.EventHandler(this.miscCloseButton_MouseLeave);
            this.miscCloseButton.MouseHover += new System.EventHandler(this.miscCloseButton_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Miscellaneous";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 605);
            this.panel5.TabIndex = 1;
            // 
            // isLoggedin
            // 
            this.isLoggedin.Enabled = true;
            this.isLoggedin.Interval = 50;
            this.isLoggedin.Tick += new System.EventHandler(this.isLoggedin_Tick);
            // 
            // tsEdit
            // 
            this.tsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEdit.Image = global::InventoryTrackingSystem.Properties.Resources.edit;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(23, 22);
            this.tsEdit.Text = "Edit";
            // 
            // stSave
            // 
            this.stSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stSave.Image = global::InventoryTrackingSystem.Properties.Resources.save__2_;
            this.stSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stSave.Name = "stSave";
            this.stSave.Size = new System.Drawing.Size(23, 22);
            this.stSave.Text = "Save";
            // 
            // tsDelete
            // 
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = global::InventoryTrackingSystem.Properties.Resources.trash;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(23, 22);
            this.tsDelete.Text = "Delete";
            // 
            // tsPrint
            // 
            this.tsPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPrint.Image = global::InventoryTrackingSystem.Properties.Resources.printer;
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(23, 22);
            this.tsPrint.Text = "Print";
            // 
            // tsReload
            // 
            this.tsReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsReload.Image = global::InventoryTrackingSystem.Properties.Resources.refresh;
            this.tsReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReload.Name = "tsReload";
            this.tsReload.Size = new System.Drawing.Size(23, 22);
            this.tsReload.Text = "Reload";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byEmployeeToolStripMenuItem,
            this.byLocationToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::InventoryTrackingSystem.Properties.Resources.search;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // byEmployeeToolStripMenuItem
            // 
            this.byEmployeeToolStripMenuItem.Name = "byEmployeeToolStripMenuItem";
            this.byEmployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byEmployeeToolStripMenuItem.Text = "By Employee";
            // 
            // byLocationToolStripMenuItem
            // 
            this.byLocationToolStripMenuItem.Name = "byLocationToolStripMenuItem";
            this.byLocationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byLocationToolStripMenuItem.Text = "By Location";
            // 
            // tsBack
            // 
            this.tsBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBack.Image = global::InventoryTrackingSystem.Properties.Resources.back;
            this.tsBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBack.Name = "tsBack";
            this.tsBack.Size = new System.Drawing.Size(23, 22);
            this.tsBack.Text = "Back";
            // 
            // tsNext
            // 
            this.tsNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNext.Image = global::InventoryTrackingSystem.Properties.Resources.next;
            this.tsNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNext.Name = "tsNext";
            this.tsNext.Size = new System.Drawing.Size(23, 22);
            this.tsNext.Text = "Next";
            this.tsNext.Click += new System.EventHandler(this.tsNext_Click);
            // 
            // tsClose
            // 
            this.tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsClose.Image = global::InventoryTrackingSystem.Properties.Resources.close;
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(23, 22);
            this.tsClose.Text = "Close";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsSendMail
            // 
            this.tsSendMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSendMail.Image = global::InventoryTrackingSystem.Properties.Resources._64_email;
            this.tsSendMail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSendMail.Name = "tsSendMail";
            this.tsSendMail.Size = new System.Drawing.Size(23, 22);
            this.tsSendMail.Text = "Send Mail";
            // 
            // tsBackup
            // 
            this.tsBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBackup.Image = global::InventoryTrackingSystem.Properties.Resources.backup;
            this.tsBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBackup.Name = "tsBackup";
            this.tsBackup.Size = new System.Drawing.Size(23, 22);
            this.tsBackup.Text = "Backup";
            // 
            // tsChart
            // 
            this.tsChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsChart.Image = global::InventoryTrackingSystem.Properties.Resources.statistics;
            this.tsChart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChart.Name = "tsChart";
            this.tsChart.Size = new System.Drawing.Size(23, 22);
            this.tsChart.Text = "Graph";
            // 
            // tsDatabaseregister
            // 
            this.tsDatabaseregister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDatabaseregister.Image = global::InventoryTrackingSystem.Properties.Resources.server;
            this.tsDatabaseregister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDatabaseregister.Name = "tsDatabaseregister";
            this.tsDatabaseregister.Size = new System.Drawing.Size(23, 22);
            this.tsDatabaseregister.Text = "Database Register";
            this.tsDatabaseregister.Click += new System.EventHandler(this.tsDatabaseregister_Click);
            // 
            // tsUserControl
            // 
            this.tsUserControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUserControl.Image = global::InventoryTrackingSystem.Properties.Resources.users;
            this.tsUserControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUserControl.Name = "tsUserControl";
            this.tsUserControl.Size = new System.Drawing.Size(23, 22);
            this.tsUserControl.Text = "User Control";
            // 
            // tsSetting
            // 
            this.tsSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSetting.Image = global::InventoryTrackingSystem.Properties.Resources.settings;
            this.tsSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSetting.Name = "tsSetting";
            this.tsSetting.Size = new System.Drawing.Size(23, 22);
            this.tsSetting.Text = "Settings";
            // 
            // tsAddMisc
            // 
            this.tsAddMisc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddMisc.Image = global::InventoryTrackingSystem.Properties.Resources.star;
            this.tsAddMisc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddMisc.Name = "tsAddMisc";
            this.tsAddMisc.Size = new System.Drawing.Size(23, 22);
            this.tsAddMisc.Text = "Add Misc";
            // 
            // miscPanel
            // 
            this.miscPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.miscPanel.BackColor = System.Drawing.Color.White;
            this.miscPanel.Location = new System.Drawing.Point(10, 63);
            this.miscPanel.Name = "miscPanel";
            this.miscPanel.Size = new System.Drawing.Size(181, 526);
            this.miscPanel.TabIndex = 3;
            this.miscPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.miscPanel_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1152, 681);
            this.Controls.Add(this.miscContainerPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuXml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuXml;
            this.Name = "frmMain";
            this.Text = "Inventory Tracking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolBarGeneral.ResumeLayout(false);
            this.toolBarGeneral.PerformLayout();
            this.miscContainerPanel.ResumeLayout(false);
            this.miscContainerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuXml;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label miscCloseButton;
        public System.Windows.Forms.Panel miscContainerPanel;
        private System.Windows.Forms.ToolStrip toolBarGeneral;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer isLoggedin;
        private System.Windows.Forms.LinkLabel signout;
        private System.Windows.Forms.ToolStripButton tsReload;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripButton tsSendMail;
        private System.Windows.Forms.ToolStripButton tsDatabaseregister;
        private System.Windows.Forms.ToolStripButton tsChart;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripButton stSave;
        private System.Windows.Forms.ToolStripButton tsBack;
        private System.Windows.Forms.ToolStripButton tsNext;
        private System.Windows.Forms.ToolStripButton tsBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsUserControl;
        private System.Windows.Forms.ToolStripButton tsSetting;
        private System.Windows.Forms.ToolStripButton tsAddMisc;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem byEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byLocationToolStripMenuItem;
        private System.Windows.Forms.Panel miscPanel;
        private System.Windows.Forms.TextBox textBox1;



    }
}

