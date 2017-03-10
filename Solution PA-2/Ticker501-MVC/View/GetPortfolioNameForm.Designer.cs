namespace Ticker501_MVC.View
{
    partial class GetPortfolioNameForm
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
            this.uxOK = new System.Windows.Forms.Button();
            this.uxPNameTxtBox = new System.Windows.Forms.TextBox();
            this.uxPortLabel = new System.Windows.Forms.Label();
            this.uxCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Enabled = false;
            this.uxOK.Location = new System.Drawing.Point(127, 47);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(100, 35);
            this.uxOK.TabIndex = 5;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            this.uxOK.Click += new System.EventHandler(this.uxOK_Click);
            // 
            // uxPNameTxtBox
            // 
            this.uxPNameTxtBox.Location = new System.Drawing.Point(317, 9);
            this.uxPNameTxtBox.Name = "uxPNameTxtBox";
            this.uxPNameTxtBox.Size = new System.Drawing.Size(127, 22);
            this.uxPNameTxtBox.TabIndex = 4;
            this.uxPNameTxtBox.TextChanged += new System.EventHandler(this.uxPNameTxtBox_TextChanged);
            // 
            // uxPortLabel
            // 
            this.uxPortLabel.AutoSize = true;
            this.uxPortLabel.Location = new System.Drawing.Point(14, 12);
            this.uxPortLabel.Name = "uxPortLabel";
            this.uxPortLabel.Size = new System.Drawing.Size(284, 17);
            this.uxPortLabel.TabIndex = 3;
            this.uxPortLabel.Text = "What would you like to name your Portfolio?";
            // 
            // uxCancel
            // 
            this.uxCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancel.Location = new System.Drawing.Point(263, 47);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(100, 35);
            this.uxCancel.TabIndex = 6;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // GetPortfolioNameForm
            // 
            this.AcceptButton = this.uxOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 133);
            this.ControlBox = false;
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxPNameTxtBox);
            this.Controls.Add(this.uxPortLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(504, 180);
            this.Name = "GetPortfolioNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portfolio Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.TextBox uxPNameTxtBox;
        private System.Windows.Forms.Label uxPortLabel;
        private System.Windows.Forms.Button uxCancel;
    }
}