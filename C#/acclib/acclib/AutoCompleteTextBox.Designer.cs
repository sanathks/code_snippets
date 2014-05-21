namespace acclib
{
    partial class AutoCompleteTextBox
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
            this.autoCompleteBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // autoCompleteBox
            // 
            this.autoCompleteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoCompleteBox.Location = new System.Drawing.Point(0, 0);
            this.autoCompleteBox.Name = "autoCompleteBox";
            this.autoCompleteBox.Size = new System.Drawing.Size(200, 20);
            this.autoCompleteBox.TabIndex = 0;
            this.autoCompleteBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.autoCompleteBox_KeyDown);
            this.autoCompleteBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.autoCompleteBox_KeyUp);
            //this.autoCompleteBox.LostFocus += new System.EventHandler(adfHiden);
            // 

            // AutoCompleteTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.autoCompleteBox);
            this.Name = "AutoCompleteTextBox";
            this.Size = new System.Drawing.Size(200, 20);
            this.Load += new System.EventHandler(this.AutoCompleteTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox autoCompleteBox;
    }
}
