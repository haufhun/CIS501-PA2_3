namespace Portfolio_GUI
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
            this.uxSellStockListInfo = new System.Windows.Forms.ListView();
            this.uxTickerNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxCompanyNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxCurrentPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxSharesOwnedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNetWorthCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNumberOfShares = new System.Windows.Forms.NumericUpDown();
            this.uxSellStockBttn = new System.Windows.Forms.Button();
            this.uxNumberLabel = new System.Windows.Forms.Label();
            this.uxInstructionLabel = new System.Windows.Forms.Label();
            this.uxCloseBttn = new System.Windows.Forms.Button();
            this.uxResultLabel = new System.Windows.Forms.Label();
            this.uxPotentialAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumberOfShares)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSellStockListInfo
            // 
            this.uxSellStockListInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uxSellStockListInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxTickerNameCol,
            this.uxCompanyNameCol,
            this.uxCurrentPriceCol,
            this.uxSharesOwnedCol,
            this.uxNetWorthCol});
            this.uxSellStockListInfo.FullRowSelect = true;
            this.uxSellStockListInfo.GridLines = true;
            this.uxSellStockListInfo.HideSelection = false;
            this.uxSellStockListInfo.Location = new System.Drawing.Point(12, 53);
            this.uxSellStockListInfo.MultiSelect = false;
            this.uxSellStockListInfo.Name = "uxSellStockListInfo";
            this.uxSellStockListInfo.Size = new System.Drawing.Size(698, 323);
            this.uxSellStockListInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.uxSellStockListInfo.TabIndex = 21;
            this.uxSellStockListInfo.UseCompatibleStateImageBehavior = false;
            this.uxSellStockListInfo.View = System.Windows.Forms.View.Details;
            this.uxSellStockListInfo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.uxSellStockListInfo_ItemSelectionChanged);
            this.uxSellStockListInfo.SelectedIndexChanged += new System.EventHandler(this.uxSellStockListInfo_SelectedIndexChanged);
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
            this.uxNumberOfShares.Location = new System.Drawing.Point(1007, 92);
            this.uxNumberOfShares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumberOfShares.Name = "uxNumberOfShares";
            this.uxNumberOfShares.Size = new System.Drawing.Size(110, 30);
            this.uxNumberOfShares.TabIndex = 25;
            this.uxNumberOfShares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumberOfShares.ValueChanged += new System.EventHandler(this.uxNumberOfShares_ValueChanged);
            // 
            // uxSellStockBttn
            // 
            this.uxSellStockBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSellStockBttn.Location = new System.Drawing.Point(731, 177);
            this.uxSellStockBttn.Name = "uxSellStockBttn";
            this.uxSellStockBttn.Size = new System.Drawing.Size(420, 44);
            this.uxSellStockBttn.TabIndex = 24;
            this.uxSellStockBttn.Text = "Sell Shares";
            this.uxSellStockBttn.UseVisualStyleBackColor = true;
            this.uxSellStockBttn.Click += new System.EventHandler(this.uxSellStockBttn_Click);
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(768, 94);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(224, 25);
            this.uxNumberLabel.TabIndex = 23;
            this.uxNumberLabel.Text = "Number of stocks to sell:";
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
            // uxCloseBttn
            // 
            this.uxCloseBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCloseBttn.Location = new System.Drawing.Point(845, 332);
            this.uxCloseBttn.Name = "uxCloseBttn";
            this.uxCloseBttn.Size = new System.Drawing.Size(203, 44);
            this.uxCloseBttn.TabIndex = 26;
            this.uxCloseBttn.Text = "&Close";
            this.uxCloseBttn.UseVisualStyleBackColor = true;
            this.uxCloseBttn.Click += new System.EventHandler(this.uxCloseBttn_Click);
            // 
            // uxResultLabel
            // 
            this.uxResultLabel.AutoSize = true;
            this.uxResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxResultLabel.Location = new System.Drawing.Point(768, 247);
            this.uxResultLabel.Name = "uxResultLabel";
            this.uxResultLabel.Size = new System.Drawing.Size(0, 25);
            this.uxResultLabel.TabIndex = 27;
            // 
            // uxPotentialAmount
            // 
            this.uxPotentialAmount.AutoSize = true;
            this.uxPotentialAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPotentialAmount.Location = new System.Drawing.Point(799, 134);
            this.uxPotentialAmount.Name = "uxPotentialAmount";
            this.uxPotentialAmount.Size = new System.Drawing.Size(61, 25);
            this.uxPotentialAmount.TabIndex = 28;
            this.uxPotentialAmount.Text = "$0.00";
            // 
            // uxSellStockForm
            // 
            this.AcceptButton = this.uxSellStockBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 388);
            this.Controls.Add(this.uxPotentialAmount);
            this.Controls.Add(this.uxResultLabel);
            this.Controls.Add(this.uxCloseBttn);
            this.Controls.Add(this.uxSellStockListInfo);
            this.Controls.Add(this.uxNumberOfShares);
            this.Controls.Add(this.uxSellStockBttn);
            this.Controls.Add(this.uxNumberLabel);
            this.Controls.Add(this.uxInstructionLabel);
            this.Name = "uxSellStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sell Stocks Form";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumberOfShares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxSellStockListInfo;
        private System.Windows.Forms.ColumnHeader uxTickerNameCol;
        private System.Windows.Forms.ColumnHeader uxCompanyNameCol;
        private System.Windows.Forms.ColumnHeader uxCurrentPriceCol;
        private System.Windows.Forms.ColumnHeader uxSharesOwnedCol;
        private System.Windows.Forms.ColumnHeader uxNetWorthCol;
        private System.Windows.Forms.NumericUpDown uxNumberOfShares;
        private System.Windows.Forms.Button uxSellStockBttn;
        private System.Windows.Forms.Label uxNumberLabel;
        private System.Windows.Forms.Label uxInstructionLabel;
        private System.Windows.Forms.Button uxCloseBttn;
        private System.Windows.Forms.Label uxResultLabel;
        private System.Windows.Forms.Label uxPotentialAmount;
    }
}