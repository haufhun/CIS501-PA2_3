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
            this.uxInstructionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxBuyStockBttn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.uxBuyStockListInfo.Location = new System.Drawing.Point(25, 61);
            this.uxBuyStockListInfo.MultiSelect = false;
            this.uxBuyStockListInfo.Name = "uxBuyStockListInfo";
            this.uxBuyStockListInfo.Size = new System.Drawing.Size(698, 285);
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
            // uxInstructionLabel
            // 
            this.uxInstructionLabel.AutoSize = true;
            this.uxInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInstructionLabel.Location = new System.Drawing.Point(20, 9);
            this.uxInstructionLabel.Name = "uxInstructionLabel";
            this.uxInstructionLabel.Size = new System.Drawing.Size(274, 29);
            this.uxInstructionLabel.TabIndex = 15;
            this.uxInstructionLabel.Text = "Please select a stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(734, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number of stocks to purchase:";
            // 
            // uxBuyStockBttn
            // 
            this.uxBuyStockBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBuyStockBttn.Location = new System.Drawing.Point(729, 206);
            this.uxBuyStockBttn.Name = "uxBuyStockBttn";
            this.uxBuyStockBttn.Size = new System.Drawing.Size(420, 44);
            this.uxBuyStockBttn.TabIndex = 18;
            this.uxBuyStockBttn.Text = "Buy Stock";
            this.uxBuyStockBttn.UseVisualStyleBackColor = true;
            this.uxBuyStockBttn.Click += new System.EventHandler(this.uxBuyStockBttn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1030, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 30);
            this.numericUpDown1.TabIndex = 20;
            // 
            // uxBuyStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 388);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.uxBuyStockBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxInstructionLabel);
            this.Controls.Add(this.uxBuyStockListInfo);
            this.Name = "uxBuyStocksForm";
            this.Text = "Buy Stocks Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxBuyStockListInfo;
        private System.Windows.Forms.ColumnHeader uxTickerNameCol;
        private System.Windows.Forms.ColumnHeader uxCompanyNameCol;
        private System.Windows.Forms.ColumnHeader uxCurrentPriceCol;
        private System.Windows.Forms.ColumnHeader uxShareaOwnedCol;
        private System.Windows.Forms.ColumnHeader uxNetWorthCol;
        private System.Windows.Forms.Label uxInstructionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxBuyStockBttn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}