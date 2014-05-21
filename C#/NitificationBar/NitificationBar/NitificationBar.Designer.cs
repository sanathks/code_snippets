namespace NitificationBar
{
    partial class NitificationBar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ntContainer = new System.Windows.Forms.Panel();
            this.ntLable = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.animate = new System.Windows.Forms.Timer(this.components);
            this.ntContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntContainer
            // 
            this.ntContainer.Controls.Add(this.ntLable);
            this.ntContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.ntContainer.Location = new System.Drawing.Point(0, 0);
            this.ntContainer.Name = "ntContainer";
            this.ntContainer.Size = new System.Drawing.Size(200, 20);
            this.ntContainer.TabIndex = 0;
            // 
            // ntLable
            // 
            this.ntLable.AutoSize = true;
            this.ntLable.Location = new System.Drawing.Point(7, 3);
            this.ntLable.Name = "ntLable";
            this.ntLable.Size = new System.Drawing.Size(26, 13);
            this.ntLable.TabIndex = 0;
            this.ntLable.Text = "msg";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // animate
            // 
            this.animate.Interval = 500;
            this.animate.Tick += new System.EventHandler(this.animate_Tick);
            // 
            // NitificationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ntContainer);
            this.Name = "NitificationBar";
            this.Size = new System.Drawing.Size(200, 20);
            this.Load += new System.EventHandler(this.NitificationBar_Load);
            this.ntContainer.ResumeLayout(false);
            this.ntContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ntContainer;
        private System.Windows.Forms.Label ntLable;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer animate;
    }
}
