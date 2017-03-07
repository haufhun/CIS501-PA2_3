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
            this.label1.Location = new System.Drawing.Point(228, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "$";
            // 
            // uxOK
            // 
            this.uxOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOK.Enabled = false;
            this.uxOK.Location = new System.Drawing.Point(152, 38);
            this.uxOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(57, 28);
            this.uxOK.TabIndex = 9;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            this.uxOK.Click += new System.EventHandler(this.uxOK_Click);
            // 
            // uxAmountTxtBox
            // 
            this.uxAmountTxtBox.Location = new System.Drawing.Point(244, 7);
            this.uxAmountTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAmountTxtBox.Name = "uxAmountTxtBox";
            this.uxAmountTxtBox.Size = new System.Drawing.Size(96, 20);
            this.uxAmountTxtBox.TabIndex = 8;
            this.uxAmountTxtBox.TextChanged += new System.EventHandler(this.uxAmountTxtBox_TextChanged);
            // 
            // uxInfoLabel
            // 
            this.uxInfoLabel.AutoSize = true;
            this.uxInfoLabel.Location = new System.Drawing.Point(17, 10);
            this.uxInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxInfoLabel.Name = "uxInfoLabel";
            this.uxInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.uxInfoLabel.TabIndex = 7;
            // 
            // AddWithdrawFundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxAmountTxtBox);
            this.Controls.Add(this.uxInfoLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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