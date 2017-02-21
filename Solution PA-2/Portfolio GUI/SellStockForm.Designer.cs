﻿namespace Portfolio_GUI
{
    partial class uxSellStockForm
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
            this.uxBuyStockListInfo = new System.Windows.Forms.ListView();
            this.uxTickerNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxCompanyNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxCurrentPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxSharesOwnedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNetWorthCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNumberOfShares = new System.Windows.Forms.NumericUpDown();
            this.uxBuyStockBttn = new System.Windows.Forms.Button();
            this.uxNumberLabel = new System.Windows.Forms.Label();
            this.uxInstructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumberOfShares)).BeginInit();
            this.SuspendLayout();
            // 
            // uxBuyStockListInfo
            // 
            this.uxBuyStockListInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uxBuyStockListInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxTickerNameCol,
            this.uxCompanyNameCol,
            this.uxCurrentPriceCol,
            this.uxSharesOwnedCol,
            this.uxNetWorthCol});
            this.uxBuyStockListInfo.FullRowSelect = true;
            this.uxBuyStockListInfo.GridLines = true;
            this.uxBuyStockListInfo.Location = new System.Drawing.Point(12, 53);
            this.uxBuyStockListInfo.MultiSelect = false;
            this.uxBuyStockListInfo.Name = "uxBuyStockListInfo";
            this.uxBuyStockListInfo.Size = new System.Drawing.Size(698, 323);
            this.uxBuyStockListInfo.TabIndex = 21;
            this.uxBuyStockListInfo.UseCompatibleStateImageBehavior = false;
            this.uxBuyStockListInfo.View = System.Windows.Forms.View.Details;
            // 
            // uxTickerNameCol
            // 
            this.uxTickerNameCol.Text = "Ticker Name";
            this.uxTickerNameCol.Width = 91;
            // 
            // uxCompanyNameCol
            // 
            this.uxCompanyNameCol.Text = "Company Name";
            this.uxCompanyNameCol.Width = 130;
            // 
            // uxCurrentPriceCol
            // 
            this.uxCurrentPriceCol.Text = "Price Per Share";
            this.uxCurrentPriceCol.Width = 107;
            // 
            // uxSharesOwnedCol
            // 
            this.uxSharesOwnedCol.Text = "Shares Owned";
            this.uxSharesOwnedCol.Width = 100;
            // 
            // uxNetWorthCol
            // 
            this.uxNetWorthCol.Text = "Networth of Shares";
            this.uxNetWorthCol.Width = 124;
            // 
            // uxNumberOfShares
            // 
            this.uxNumberOfShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberOfShares.Location = new System.Drawing.Point(1017, 129);
            this.uxNumberOfShares.Name = "uxNumberOfShares";
            this.uxNumberOfShares.Size = new System.Drawing.Size(110, 30);
            this.uxNumberOfShares.TabIndex = 25;
            // 
            // uxBuyStockBttn
            // 
            this.uxBuyStockBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBuyStockBttn.Location = new System.Drawing.Point(716, 199);
            this.uxBuyStockBttn.Name = "uxBuyStockBttn";
            this.uxBuyStockBttn.Size = new System.Drawing.Size(420, 44);
            this.uxBuyStockBttn.TabIndex = 24;
            this.uxBuyStockBttn.Text = "Sell Shares";
            this.uxBuyStockBttn.UseVisualStyleBackColor = true;
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(721, 131);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(276, 25);
            this.uxNumberLabel.TabIndex = 23;
            this.uxNumberLabel.Text = "Number of stocks to purchase:";
            // 
            // uxInstructionLabel
            // 
            this.uxInstructionLabel.AutoSize = true;
            this.uxInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInstructionLabel.Location = new System.Drawing.Point(12, 9);
            this.uxInstructionLabel.Name = "uxInstructionLabel";
            this.uxInstructionLabel.Size = new System.Drawing.Size(274, 29);
            this.uxInstructionLabel.TabIndex = 22;
            this.uxInstructionLabel.Text = "Please select a stock";
            // 
            // uxSellStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 388);
            this.Controls.Add(this.uxBuyStockListInfo);
            this.Controls.Add(this.uxNumberOfShares);
            this.Controls.Add(this.uxBuyStockBttn);
            this.Controls.Add(this.uxNumberLabel);
            this.Controls.Add(this.uxInstructionLabel);
            this.Name = "uxSellStockForm";
            this.Text = "Sell Stocks Form";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumberOfShares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxBuyStockListInfo;
        private System.Windows.Forms.ColumnHeader uxTickerNameCol;
        private System.Windows.Forms.ColumnHeader uxCompanyNameCol;
        private System.Windows.Forms.ColumnHeader uxCurrentPriceCol;
        private System.Windows.Forms.ColumnHeader uxSharesOwnedCol;
        private System.Windows.Forms.ColumnHeader uxNetWorthCol;
        private System.Windows.Forms.NumericUpDown uxNumberOfShares;
        private System.Windows.Forms.Button uxBuyStockBttn;
        private System.Windows.Forms.Label uxNumberLabel;
        private System.Windows.Forms.Label uxInstructionLabel;
    }
}