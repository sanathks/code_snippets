namespace InventoryTrackingSystem
{
    partial class Splashscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
            this.proCom = new System.Windows.Forms.ProgressBar();
            this.lbAction = new System.Windows.Forms.Label();
            this.comName = new System.Windows.Forms.Label();
            this.allFilesExist = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // proCom
            // 
            this.proCom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proCom.Location = new System.Drawing.Point(0, 197);
            this.proCom.Name = "proCom";
            this.proCom.Size = new System.Drawing.Size(450, 3);
            this.proCom.TabIndex = 0;
            // 
            // lbAction
            // 
            this.lbAction.AutoSize = true;
            this.lbAction.BackColor = System.Drawing.Color.Transparent;
            this.lbAction.Location = new System.Drawing.Point(12, 174);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(103, 13);
            this.lbAction.TabIndex = 1;
            this.lbAction.Text = "Loading Modules ....";
            // 
            // comName
            // 
            this.comName.AutoSize = true;
            this.comName.BackColor = System.Drawing.Color.Transparent;
            this.comName.Location = new System.Drawing.Point(135, 174);
            this.comName.Name = "comName";
            this.comName.Size = new System.Drawing.Size(0, 13);
            this.comName.TabIndex = 2;
            // 
            // allFilesExist
            // 
            this.allFilesExist.Interval = 200;
            this.allFilesExist.Tick += new System.EventHandler(this.allFilesExist_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::InventoryTrackingSystem.Properties.Resources.mIcon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inventory Tracking System 1.2v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "©  2013 SER. All rights Reserverd. ";
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoryTrackingSystem.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comName);
            this.Controls.Add(this.lbAction);
            this.Controls.Add(this.proCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splashscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar proCom;
        private System.Windows.Forms.Label lbAction;
        private System.Windows.Forms.Label comName;
        private System.Windows.Forms.Timer allFilesExist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}