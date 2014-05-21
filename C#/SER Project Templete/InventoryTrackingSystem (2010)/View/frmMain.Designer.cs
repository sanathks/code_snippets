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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuXml = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolBarGeneral = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.miscContainerPanel = new System.Windows.Forms.Panel();
            this.miscCloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.miscPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.toolBarGeneral.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.panel1.Controls.Add(this.toolBarGeneral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 29);
            this.panel1.TabIndex = 3;
            // 
            // toolBarGeneral
            // 
            this.toolBarGeneral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolBarGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolBarGeneral.Location = new System.Drawing.Point(0, 0);
            this.toolBarGeneral.Name = "toolBarGeneral";
            this.toolBarGeneral.Size = new System.Drawing.Size(1152, 25);
            this.toolBarGeneral.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::InventoryTrackingSystem.Properties.Resources.edit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeArea});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1152, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeArea
            // 
            this.timeArea.Name = "timeArea";
            this.timeArea.Size = new System.Drawing.Size(55, 17);
            this.timeArea.Text = "04.05 PM";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 605);
            this.panel5.TabIndex = 1;
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.miscContainerPanel.ResumeLayout(false);
            this.miscContainerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuXml;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timeArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel miscPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label miscCloseButton;
        public System.Windows.Forms.Panel miscContainerPanel;
        private System.Windows.Forms.ToolStrip toolBarGeneral;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;



    }
}

