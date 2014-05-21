namespace SNTXTBX
{
    partial class SNTXTBX
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
            this.SeriamNoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SeriamNoBox
            // 
            this.SeriamNoBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SeriamNoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeriamNoBox.Location = new System.Drawing.Point(0, 0);
            this.SeriamNoBox.Name = "SeriamNoBox";
            this.SeriamNoBox.Size = new System.Drawing.Size(200, 20);
            this.SeriamNoBox.TabIndex = 0;
            this.SeriamNoBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SeriamNoBox_KeyDown);
            // 
            // SNTXTBX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeriamNoBox);
            this.Name = "SNTXTBX";
            this.Size = new System.Drawing.Size(200, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeriamNoBox;
    }
}
