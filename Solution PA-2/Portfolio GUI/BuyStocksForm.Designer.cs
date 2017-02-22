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
            this.uxInstructionLabel = new System.Windows.Forms.Label();
            this.uxNumberLabel = new System.Windows.Forms.Label();
            this.uxBuyStockBttn = new System.Windows.Forms.Button();
            this.uxNumberOfShares = new System.Windows.Forms.NumericUpDown();
            this.uxCloseBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxBuyBySharesOrPrice = new System.Windows.Forms.ComboBox();
            this.uxDollarToPurchase = new System.Windows.Forms.Label();
            this.uxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.uxCurrentPriceCol});
            this.uxBuyStockListInfo.FullRowSelect = true;
            this.uxBuyStockListInfo.GridLines = true;
            this.uxBuyStockListInfo.HideSelection = false;
            this.uxBuyStockListInfo.Location = new System.Drawing.Point(25, 60);
            this.uxBuyStockListInfo.MultiSelect = false;
            this.uxBuyStockListInfo.Name = "uxBuyStockListInfo";
            this.uxBuyStockListInfo.Size = new System.Drawing.Size(478, 285);
            this.uxBuyStockListInfo.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.uxBuyStockListInfo.TabIndex = 14;
            this.uxBuyStockListInfo.UseCompatibleStateImageBehavior = false;
            this.uxBuyStockListInfo.View = System.Windows.Forms.View.Details;
            this.uxBuyStockListInfo.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.uxBuyStockListInfo_ItemSelectionChanged);
            // 
            // uxTickerNameCol
            // 
            this.uxTickerNameCol.Text = "Ticker Name";
            this.uxTickerNameCol.Width = 91;
            // 
            // uxCompanyNameCol
            // 
            this.uxCompanyNameCol.Text = "Company Name";
            this.uxCompanyNameCol.Width = 146;
            // 
            // uxCurrentPriceCol
            // 
            this.uxCurrentPriceCol.Text = "Price Per Share";
            this.uxCurrentPriceCol.Width = 107;
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
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(552, 86);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(276, 25);
            this.uxNumberLabel.TabIndex = 16;
            this.uxNumberLabel.Text = "Number of stocks to purchase:";
            // 
            // uxBuyStockBttn
            // 
            this.uxBuyStockBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxBuyStockBttn.Location = new System.Drawing.Point(538, 189);
            this.uxBuyStockBttn.Name = "uxBuyStockBttn";
            this.uxBuyStockBttn.Size = new System.Drawing.Size(420, 44);
            this.uxBuyStockBttn.TabIndex = 18;
            this.uxBuyStockBttn.Text = "&Buy Shares";
            this.uxBuyStockBttn.UseVisualStyleBackColor = true;
            this.uxBuyStockBttn.Click += new System.EventHandler(this.uxBuyStockBttn_Click);
            // 
            // uxNumberOfShares
            // 
            this.uxNumberOfShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberOfShares.Location = new System.Drawing.Point(848, 84);
            this.uxNumberOfShares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumberOfShares.Name = "uxNumberOfShares";
            this.uxNumberOfShares.Size = new System.Drawing.Size(110, 30);
            this.uxNumberOfShares.TabIndex = 20;
            this.uxNumberOfShares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumberOfShares.ValueChanged += new System.EventHandler(this.uxNumberOfShares_ValueChanged);
            // 
            // uxCloseBttn
            // 
            this.uxCloseBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCloseBttn.Location = new System.Drawing.Point(633, 301);
            this.uxCloseBttn.Name = "uxCloseBttn";
            this.uxCloseBttn.Size = new System.Drawing.Size(203, 44);
            this.uxCloseBttn.TabIndex = 21;
            this.uxCloseBttn.Text = "&Close";
            this.uxCloseBttn.UseVisualStyleBackColor = true;
            this.uxCloseBttn.Click += new System.EventHandler(this.uxCloseBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 22;
            // 
            // uxBuyBySharesOrPrice
            // 
            this.uxBuyBySharesOrPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxBuyBySharesOrPrice.FormattingEnabled = true;
            this.uxBuyBySharesOrPrice.Items.AddRange(new object[] {
            "Buy by number of shares",
            "Buy by price"});
            this.uxBuyBySharesOrPrice.Location = new System.Drawing.Point(557, 17);
            this.uxBuyBySharesOrPrice.Name = "uxBuyBySharesOrPrice";
            this.uxBuyBySharesOrPrice.Size = new System.Drawing.Size(401, 24);
            this.uxBuyBySharesOrPrice.TabIndex = 23;
            this.uxBuyBySharesOrPrice.SelectedIndexChanged += new System.EventHandler(this.uxBuyBySharesOrPrice_SelectedIndexChanged);
            // 
            // uxDollarToPurchase
            // 
            this.uxDollarToPurchase.AutoSize = true;
            this.uxDollarToPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDollarToPurchase.Location = new System.Drawing.Point(552, 126);
            this.uxDollarToPurchase.Name = "uxDollarToPurchase";
            this.uxDollarToPurchase.Size = new System.Drawing.Size(327, 25);
            this.uxDollarToPurchase.TabIndex = 24;
            this.uxDollarToPurchase.Text = "Dollar amount of stocks to purchase:";
            // 
            // uxAmount
            // 
            this.uxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAmount.Location = new System.Drawing.Point(933, 123);
            this.uxAmount.Name = "uxAmount";
            this.uxAmount.Size = new System.Drawing.Size(115, 30);
            this.uxAmount.TabIndex = 25;
            this.uxAmount.TextChanged += new System.EventHandler(this.uxAmount_TextChanged);
            this.uxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(904, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "$";
            // 
            // uxResultLabel
            // 
            this.uxResultLabel.AutoSize = true;
            this.uxResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxResultLabel.Location = new System.Drawing.Point(557, 249);
            this.uxResultLabel.Name = "uxResultLabel";
            this.uxResultLabel.Size = new System.Drawing.Size(0, 25);
            this.uxResultLabel.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 28;
            this.label3.Visible = false;
            // 
            // uxBuyStocksForm
            // 
            this.AcceptButton = this.uxBuyStockBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxAmount);
            this.Controls.Add(this.uxDollarToPurchase);
            this.Controls.Add(this.uxBuyBySharesOrPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxCloseBttn);
            this.Controls.Add(this.uxNumberOfShares);
            this.Controls.Add(this.uxBuyStockBttn);
            this.Controls.Add(this.uxNumberLabel);
            this.Controls.Add(this.uxInstructionLabel);
            this.Controls.Add(this.uxBuyStockListInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "uxBuyStocksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buy Stocks Form";
            ((System.ComponentModel.ISupportInitialize)(this.uxNumberOfShares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxBuyStockListInfo;
        private System.Windows.Forms.ColumnHeader uxTickerNameCol;
        private System.Windows.Forms.ColumnHeader uxCompanyNameCol;
        private System.Windows.Forms.ColumnHeader uxCurrentPriceCol;
        private System.Windows.Forms.Label uxInstructionLabel;
        private System.Windows.Forms.Label uxNumberLabel;
        private System.Windows.Forms.Button uxBuyStockBttn;
        private System.Windows.Forms.NumericUpDown uxNumberOfShares;
        private System.Windows.Forms.Button uxCloseBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxBuyBySharesOrPrice;
        private System.Windows.Forms.Label uxDollarToPurchase;
        private System.Windows.Forms.TextBox uxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uxResultLabel;
        private System.Windows.Forms.Label label3;
    }
}