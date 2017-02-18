namespace Portfolio_GUI
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxTabControl = new System.Windows.Forms.TabControl();
            this.uxHomeTab = new System.Windows.Forms.TabPage();
            this.uxAccountTab = new System.Windows.Forms.TabPage();
            this.uxPortfolioTab = new System.Windows.Forms.TabPage();
            this.uxPortfolioToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxPortfolio1 = new System.Windows.Forms.ToolStripSplitButton();
            this.amountInvestedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accvcvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyStockInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gainsLossesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePortfolioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxPortfolio2 = new System.Windows.Forms.ToolStripSplitButton();
            this.portfoliosStandingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyStocksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellStocksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.companyStockInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionBalanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gainsLossesReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePortfolioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxPortfolio3 = new System.Windows.Forms.ToolStripSplitButton();
            this.portfoliosStandingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stocksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buyStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyStockInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.positionBalanceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gainsLossesReportToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uxAddPortfolio = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uxAccBalLabel = new System.Windows.Forms.Label();
            this.uxAccBalTxtBox = new System.Windows.Forms.TextBox();
            this.uxTabControl.SuspendLayout();
            this.uxAccountTab.SuspendLayout();
            this.uxPortfolioTab.SuspendLayout();
            this.uxPortfolioToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTabControl
            // 
            this.uxTabControl.Controls.Add(this.uxHomeTab);
            this.uxTabControl.Controls.Add(this.uxAccountTab);
            this.uxTabControl.Controls.Add(this.uxPortfolioTab);
            this.uxTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.uxTabControl.Location = new System.Drawing.Point(0, 0);
            this.uxTabControl.Name = "uxTabControl";
            this.uxTabControl.SelectedIndex = 0;
            this.uxTabControl.Size = new System.Drawing.Size(1168, 563);
            this.uxTabControl.TabIndex = 2;
            // 
            // uxHomeTab
            // 
            this.uxHomeTab.Location = new System.Drawing.Point(4, 25);
            this.uxHomeTab.Name = "uxHomeTab";
            this.uxHomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxHomeTab.Size = new System.Drawing.Size(1160, 534);
            this.uxHomeTab.TabIndex = 0;
            this.uxHomeTab.Text = "Home";
            this.uxHomeTab.UseVisualStyleBackColor = true;
            // 
            // uxAccountTab
            // 
            this.uxAccountTab.Controls.Add(this.uxAccBalTxtBox);
            this.uxAccountTab.Controls.Add(this.uxAccBalLabel);
            this.uxAccountTab.Location = new System.Drawing.Point(4, 25);
            this.uxAccountTab.Name = "uxAccountTab";
            this.uxAccountTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxAccountTab.Size = new System.Drawing.Size(1160, 534);
            this.uxAccountTab.TabIndex = 1;
            this.uxAccountTab.Text = "Account";
            this.uxAccountTab.UseVisualStyleBackColor = true;
            // 
            // uxPortfolioTab
            // 
            this.uxPortfolioTab.Controls.Add(this.uxPortfolioToolStrip);
            this.uxPortfolioTab.Location = new System.Drawing.Point(4, 25);
            this.uxPortfolioTab.Name = "uxPortfolioTab";
            this.uxPortfolioTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxPortfolioTab.Size = new System.Drawing.Size(1160, 534);
            this.uxPortfolioTab.TabIndex = 2;
            this.uxPortfolioTab.Text = "Portfolios";
            this.uxPortfolioTab.UseVisualStyleBackColor = true;
            // 
            // uxPortfolioToolStrip
            // 
            this.uxPortfolioToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxPortfolioToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxPortfolio1,
            this.uxPortfolio2,
            this.uxPortfolio3,
            this.toolStripSeparator1,
            this.uxAddPortfolio,
            this.helpToolStripButton});
            this.uxPortfolioToolStrip.Location = new System.Drawing.Point(3, 3);
            this.uxPortfolioToolStrip.Name = "uxPortfolioToolStrip";
            this.uxPortfolioToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.uxPortfolioToolStrip.Size = new System.Drawing.Size(1154, 27);
            this.uxPortfolioToolStrip.TabIndex = 3;
            this.uxPortfolioToolStrip.Text = "toolStrip1";
            // 
            // uxPortfolio1
            // 
            this.uxPortfolio1.BackColor = System.Drawing.Color.Maroon;
            this.uxPortfolio1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amountInvestedToolStripMenuItem,
            this.accvcvToolStripMenuItem,
            this.positionBalanceToolStripMenuItem,
            this.gainsLossesReportToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deletePortfolioToolStripMenuItem2});
            this.uxPortfolio1.Image = ((System.Drawing.Image)(resources.GetObject("uxPortfolio1.Image")));
            this.uxPortfolio1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPortfolio1.Name = "uxPortfolio1";
            this.uxPortfolio1.Size = new System.Drawing.Size(117, 24);
            this.uxPortfolio1.Text = "Portfolio 1";
            // 
            // amountInvestedToolStripMenuItem
            // 
            this.amountInvestedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("amountInvestedToolStripMenuItem.Image")));
            this.amountInvestedToolStripMenuItem.Name = "amountInvestedToolStripMenuItem";
            this.amountInvestedToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.amountInvestedToolStripMenuItem.Text = "Portfolio\'s Standing";
            // 
            // accvcvToolStripMenuItem
            // 
            this.accvcvToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyStocksToolStripMenuItem,
            this.sellStocksToolStripMenuItem,
            this.companyStockInformationToolStripMenuItem});
            this.accvcvToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accvcvToolStripMenuItem.Image")));
            this.accvcvToolStripMenuItem.Name = "accvcvToolStripMenuItem";
            this.accvcvToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.accvcvToolStripMenuItem.Text = "Stocks";
            // 
            // buyStocksToolStripMenuItem
            // 
            this.buyStocksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buyStocksToolStripMenuItem.Image")));
            this.buyStocksToolStripMenuItem.Name = "buyStocksToolStripMenuItem";
            this.buyStocksToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.buyStocksToolStripMenuItem.Text = "Buy Stocks";
            // 
            // sellStocksToolStripMenuItem
            // 
            this.sellStocksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sellStocksToolStripMenuItem.Image")));
            this.sellStocksToolStripMenuItem.Name = "sellStocksToolStripMenuItem";
            this.sellStocksToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sellStocksToolStripMenuItem.Text = "Sell Stocks";
            // 
            // companyStockInformationToolStripMenuItem
            // 
            this.companyStockInformationToolStripMenuItem.Name = "companyStockInformationToolStripMenuItem";
            this.companyStockInformationToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.companyStockInformationToolStripMenuItem.Text = "Company Stock Info";
            // 
            // positionBalanceToolStripMenuItem
            // 
            this.positionBalanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("positionBalanceToolStripMenuItem.Image")));
            this.positionBalanceToolStripMenuItem.Name = "positionBalanceToolStripMenuItem";
            this.positionBalanceToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.positionBalanceToolStripMenuItem.Text = "Position Balance";
            // 
            // gainsLossesReportToolStripMenuItem
            // 
            this.gainsLossesReportToolStripMenuItem.Name = "gainsLossesReportToolStripMenuItem";
            this.gainsLossesReportToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.gainsLossesReportToolStripMenuItem.Text = "Gains/Losses Report";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem2.Text = " ";
            // 
            // deletePortfolioToolStripMenuItem2
            // 
            this.deletePortfolioToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("deletePortfolioToolStripMenuItem2.Image")));
            this.deletePortfolioToolStripMenuItem2.Name = "deletePortfolioToolStripMenuItem2";
            this.deletePortfolioToolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.deletePortfolioToolStripMenuItem2.Text = "DeletePortfolio";
            // 
            // uxPortfolio2
            // 
            this.uxPortfolio2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portfoliosStandingToolStripMenuItem,
            this.stocksToolStripMenuItem,
            this.positionBalanceToolStripMenuItem1,
            this.gainsLossesReportToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.deletePortfolioToolStripMenuItem1});
            this.uxPortfolio2.Image = ((System.Drawing.Image)(resources.GetObject("uxPortfolio2.Image")));
            this.uxPortfolio2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPortfolio2.Name = "uxPortfolio2";
            this.uxPortfolio2.Size = new System.Drawing.Size(117, 24);
            this.uxPortfolio2.Text = "Portfolio 2";
            // 
            // portfoliosStandingToolStripMenuItem
            // 
            this.portfoliosStandingToolStripMenuItem.Name = "portfoliosStandingToolStripMenuItem";
            this.portfoliosStandingToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.portfoliosStandingToolStripMenuItem.Text = "Portfolio\'s Standing";
            // 
            // stocksToolStripMenuItem
            // 
            this.stocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyStocksToolStripMenuItem1,
            this.sellStocksToolStripMenuItem1,
            this.companyStockInfoToolStripMenuItem});
            this.stocksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stocksToolStripMenuItem.Image")));
            this.stocksToolStripMenuItem.Name = "stocksToolStripMenuItem";
            this.stocksToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.stocksToolStripMenuItem.Text = "Stocks";
            // 
            // buyStocksToolStripMenuItem1
            // 
            this.buyStocksToolStripMenuItem1.Name = "buyStocksToolStripMenuItem1";
            this.buyStocksToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.buyStocksToolStripMenuItem1.Text = "Buy Stocks";
            // 
            // sellStocksToolStripMenuItem1
            // 
            this.sellStocksToolStripMenuItem1.Name = "sellStocksToolStripMenuItem1";
            this.sellStocksToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.sellStocksToolStripMenuItem1.Text = "Sell Stocks";
            // 
            // companyStockInfoToolStripMenuItem
            // 
            this.companyStockInfoToolStripMenuItem.Name = "companyStockInfoToolStripMenuItem";
            this.companyStockInfoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.companyStockInfoToolStripMenuItem.Text = "Company Stock Info";
            // 
            // positionBalanceToolStripMenuItem1
            // 
            this.positionBalanceToolStripMenuItem1.Name = "positionBalanceToolStripMenuItem1";
            this.positionBalanceToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.positionBalanceToolStripMenuItem1.Text = "Position Balance";
            // 
            // gainsLossesReportToolStripMenuItem1
            // 
            this.gainsLossesReportToolStripMenuItem1.Name = "gainsLossesReportToolStripMenuItem1";
            this.gainsLossesReportToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.gainsLossesReportToolStripMenuItem1.Text = "Gains/Losses Report";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem3.Text = " ";
            // 
            // deletePortfolioToolStripMenuItem1
            // 
            this.deletePortfolioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("deletePortfolioToolStripMenuItem1.Image")));
            this.deletePortfolioToolStripMenuItem1.Name = "deletePortfolioToolStripMenuItem1";
            this.deletePortfolioToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.deletePortfolioToolStripMenuItem1.Text = "Delete Portfolio";
            // 
            // uxPortfolio3
            // 
            this.uxPortfolio3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portfoliosStandingToolStripMenuItem1,
            this.stocksToolStripMenuItem1,
            this.positionBalanceToolStripMenuItem2,
            this.gainsLossesReportToolStripMenuItem2,
            this.toolStripMenuItem4,
            this.deletePortfolioToolStripMenuItem});
            this.uxPortfolio3.Image = ((System.Drawing.Image)(resources.GetObject("uxPortfolio3.Image")));
            this.uxPortfolio3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPortfolio3.Name = "uxPortfolio3";
            this.uxPortfolio3.Size = new System.Drawing.Size(117, 24);
            this.uxPortfolio3.Text = "Portfolio 3";
            // 
            // portfoliosStandingToolStripMenuItem1
            // 
            this.portfoliosStandingToolStripMenuItem1.Name = "portfoliosStandingToolStripMenuItem1";
            this.portfoliosStandingToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.portfoliosStandingToolStripMenuItem1.Text = "Portfolio\'s Standing";
            // 
            // stocksToolStripMenuItem1
            // 
            this.stocksToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyStockToolStripMenuItem,
            this.sellStockToolStripMenuItem,
            this.companyStockInfoToolStripMenuItem1});
            this.stocksToolStripMenuItem1.Name = "stocksToolStripMenuItem1";
            this.stocksToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.stocksToolStripMenuItem1.Text = "Stocks";
            // 
            // buyStockToolStripMenuItem
            // 
            this.buyStockToolStripMenuItem.Name = "buyStockToolStripMenuItem";
            this.buyStockToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.buyStockToolStripMenuItem.Text = "Buy Stock";
            // 
            // sellStockToolStripMenuItem
            // 
            this.sellStockToolStripMenuItem.Name = "sellStockToolStripMenuItem";
            this.sellStockToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.sellStockToolStripMenuItem.Text = "Sell Stock";
            // 
            // companyStockInfoToolStripMenuItem1
            // 
            this.companyStockInfoToolStripMenuItem1.Name = "companyStockInfoToolStripMenuItem1";
            this.companyStockInfoToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.companyStockInfoToolStripMenuItem1.Text = "Company Stock Info";
            // 
            // positionBalanceToolStripMenuItem2
            // 
            this.positionBalanceToolStripMenuItem2.Name = "positionBalanceToolStripMenuItem2";
            this.positionBalanceToolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.positionBalanceToolStripMenuItem2.Text = "Position Balance";
            // 
            // gainsLossesReportToolStripMenuItem2
            // 
            this.gainsLossesReportToolStripMenuItem2.Name = "gainsLossesReportToolStripMenuItem2";
            this.gainsLossesReportToolStripMenuItem2.Size = new System.Drawing.Size(217, 26);
            this.gainsLossesReportToolStripMenuItem2.Text = "Gains/Losses Report";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem4.Text = " ";
            // 
            // deletePortfolioToolStripMenuItem
            // 
            this.deletePortfolioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePortfolioToolStripMenuItem.Image")));
            this.deletePortfolioToolStripMenuItem.Name = "deletePortfolioToolStripMenuItem";
            this.deletePortfolioToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.deletePortfolioToolStripMenuItem.Text = "Delete Portfolio";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // uxAddPortfolio
            // 
            this.uxAddPortfolio.Image = ((System.Drawing.Image)(resources.GetObject("uxAddPortfolio.Image")));
            this.uxAddPortfolio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxAddPortfolio.Name = "uxAddPortfolio";
            this.uxAddPortfolio.Size = new System.Drawing.Size(122, 24);
            this.uxAddPortfolio.Text = "&Add Portfolio";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // uxAccBalLabel
            // 
            this.uxAccBalLabel.AutoSize = true;
            this.uxAccBalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAccBalLabel.Location = new System.Drawing.Point(856, 17);
            this.uxAccBalLabel.Name = "uxAccBalLabel";
            this.uxAccBalLabel.Size = new System.Drawing.Size(166, 25);
            this.uxAccBalLabel.TabIndex = 0;
            this.uxAccBalLabel.Text = "Account Balance:";
            // 
            // uxAccBalTxtBox
            // 
            this.uxAccBalTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxAccBalTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAccBalTxtBox.Location = new System.Drawing.Point(1028, 17);
            this.uxAccBalTxtBox.Name = "uxAccBalTxtBox";
            this.uxAccBalTxtBox.Size = new System.Drawing.Size(124, 23);
            this.uxAccBalTxtBox.TabIndex = 1;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 563);
            this.Controls.Add(this.uxTabControl);
            this.Name = "UserInterface";
            this.Text = "Ticker 501";
            this.uxTabControl.ResumeLayout(false);
            this.uxAccountTab.ResumeLayout(false);
            this.uxAccountTab.PerformLayout();
            this.uxPortfolioTab.ResumeLayout(false);
            this.uxPortfolioTab.PerformLayout();
            this.uxPortfolioToolStrip.ResumeLayout(false);
            this.uxPortfolioToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl uxTabControl;
        private System.Windows.Forms.TabPage uxHomeTab;
        private System.Windows.Forms.TabPage uxAccountTab;
        private System.Windows.Forms.TabPage uxPortfolioTab;
        private System.Windows.Forms.ToolStrip uxPortfolioToolStrip;
        private System.Windows.Forms.ToolStripSplitButton uxPortfolio1;
        private System.Windows.Forms.ToolStripMenuItem amountInvestedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accvcvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyStockInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gainsLossesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deletePortfolioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSplitButton uxPortfolio2;
        private System.Windows.Forms.ToolStripMenuItem portfoliosStandingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyStocksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sellStocksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem companyStockInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionBalanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gainsLossesReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deletePortfolioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton uxPortfolio3;
        private System.Windows.Forms.ToolStripMenuItem portfoliosStandingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stocksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buyStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyStockInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem positionBalanceToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gainsLossesReportToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deletePortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton uxAddPortfolio;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TextBox uxAccBalTxtBox;
        private System.Windows.Forms.Label uxAccBalLabel;
    }
}

