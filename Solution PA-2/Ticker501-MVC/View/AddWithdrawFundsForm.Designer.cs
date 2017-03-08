namespace Ticker501_MVC.View
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
            this.uxCancel = new System.Windows.Forms.Button();
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
            this.uxOK.Location = new System.Drawing.Point(146, 44);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(76, 35);
            this.uxOK.TabIndex = 9;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            this.uxOK.Click += new System.EventHandler(this.uxOK_Click);
            // 
            // uxAmountTxtBox
            // 
            this.uxAmountTxtBox.Location = new System.Drawing.Point(326, 9);
            this.uxAmountTxtBox.Name = "uxAmountTxtBox";
            this.uxAmountTxtBox.Size = new System.Drawing.Size(127, 22);
            this.uxAmountTxtBox.TabIndex = 8;
            this.uxAmountTxtBox.TextChanged += new System.EventHandler(this.uxAmountTxtBox_TextChanged);
            this.uxAmountTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uxAmountTxtBox_KeyPress);
            // 
            // uxInfoLabel
            // 
            this.uxInfoLabel.AutoSize = true;
            this.uxInfoLabel.Location = new System.Drawing.Point(23, 12);
            this.uxInfoLabel.Name = "uxInfoLabel";
            this.uxInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.uxInfoLabel.TabIndex = 7;
            // 
            // uxCancel
            // 
            this.uxCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancel.Location = new System.Drawing.Point(244, 44);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(76, 35);
            this.uxCancel.TabIndex = 11;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // AddWithdrawFundsForm
            // 
            this.AcceptButton = this.uxOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxCancel;
            this.ClientSize = new System.Drawing.Size(476, 90);
            this.ControlBox = false;
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxAmountTxtBox);
            this.Controls.Add(this.uxInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWithdrawFundsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Transaction";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.TextBox uxAmountTxtBox;
        private System.Windows.Forms.Label uxInfoLabel;
        private System.Windows.Forms.Button uxCancel;
    }
}