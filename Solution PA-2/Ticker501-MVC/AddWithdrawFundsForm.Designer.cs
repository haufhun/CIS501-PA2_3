namespace Ticker501_MVC
{
    partial class AddWithdrawFundsForm
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
            this.uxOK = new System.Windows.Forms.Button();
            this.uxAmountTxtBox = new System.Windows.Forms.TextBox();
            this.uxInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "$";
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Enabled = false;
            this.uxOK.Location = new System.Drawing.Point(202, 47);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(76, 35);
            this.uxOK.TabIndex = 9;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            // 
            // uxAmountTxtBox
            // 
            this.uxAmountTxtBox.Location = new System.Drawing.Point(326, 9);
            this.uxAmountTxtBox.Name = "uxAmountTxtBox";
            this.uxAmountTxtBox.Size = new System.Drawing.Size(127, 22);
            this.uxAmountTxtBox.TabIndex = 8;
            // 
            // uxInfoLabel
            // 
            this.uxInfoLabel.AutoSize = true;
            this.uxInfoLabel.Location = new System.Drawing.Point(23, 12);
            this.uxInfoLabel.Name = "uxInfoLabel";
            this.uxInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.uxInfoLabel.TabIndex = 7;
            // 
            // AddWithdrawFundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 91);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxAmountTxtBox);
            this.Controls.Add(this.uxInfoLabel);
            this.Name = "AddWithdrawFundsForm";
            this.Text = "AddWithdrawFundsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.TextBox uxAmountTxtBox;
        private System.Windows.Forms.Label uxInfoLabel;
    }
}