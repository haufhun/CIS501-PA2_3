namespace Portfolio_GUI
{
    partial class uxGetPortfolioNameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxPNameTxtBox = new System.Windows.Forms.TextBox();
            this.uxOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would you like to name your Portfolio?";
            // 
            // uxPNameTxtBox
            // 
            this.uxPNameTxtBox.Location = new System.Drawing.Point(315, 6);
            this.uxPNameTxtBox.Name = "uxPNameTxtBox";
            this.uxPNameTxtBox.Size = new System.Drawing.Size(127, 22);
            this.uxPNameTxtBox.TabIndex = 1;
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Location = new System.Drawing.Point(191, 44);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(76, 35);
            this.uxOK.TabIndex = 2;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            // 
            // uxGetPortfolioNameForm
            // 
            this.AcceptButton = this.uxOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 91);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxPNameTxtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uxGetPortfolioNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxPNameTxtBox;
        private System.Windows.Forms.Button uxOK;
    }
}