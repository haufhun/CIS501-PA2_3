namespace Portfolio_GUI
{
    partial class uxBuyStocksForm
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
            this.uxShareaOwnedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNetWorthCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.uxShareaOwnedCol,
            this.uxNetWorthCol});
            this.uxBuyStockListInfo.FullRowSelect = true;
            this.uxBuyStockListInfo.GridLines = true;
            this.uxBuyStockListInfo.Location = new System.Drawing.Point(0, -1);
            this.uxBuyStockListInfo.MultiSelect = false;
            this.uxBuyStockListInfo.Name = "uxBuyStockListInfo";
            this.uxBuyStockListInfo.Size = new System.Drawing.Size(677, 286);
            this.uxBuyStockListInfo.TabIndex = 14;
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
            // uxShareaOwnedCol
            // 
            this.uxShareaOwnedCol.Text = "Shares Owned";
            this.uxShareaOwnedCol.Width = 100;
            // 
            // uxNetWorthCol
            // 
            this.uxNetWorthCol.Text = "Networth of Shares";
            this.uxNetWorthCol.Width = 124;
            // 
            // uxBuyStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 455);
            this.Controls.Add(this.uxBuyStockListInfo);
            this.Name = "uxBuyStocksForm";
            this.Text = "Buy Stocks Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView uxBuyStockListInfo;
        private System.Windows.Forms.ColumnHeader uxTickerNameCol;
        private System.Windows.Forms.ColumnHeader uxCompanyNameCol;
        private System.Windows.Forms.ColumnHeader uxCurrentPriceCol;
        private System.Windows.Forms.ColumnHeader uxShareaOwnedCol;
        private System.Windows.Forms.ColumnHeader uxNetWorthCol;
    }
}