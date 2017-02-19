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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxTabControl = new System.Windows.Forms.TabControl();
            this.uxHomeTab = new System.Windows.Forms.TabPage();
            this.uxAccountTab = new System.Windows.Forms.TabPage();
            this.uxInfoListView = new System.Windows.Forms.ListView();
            this.uxTickerNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxFullNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxCurrentPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNumOfSharesOwned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNetworthOfSharesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxPositionBalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxAccBalLabel = new System.Windows.Forms.Label();
            this.uxPortfolioTab = new System.Windows.Forms.TabPage();
            this.uxPortfolioToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uxTotalInvestedLabel = new System.Windows.Forms.Label();
            this.uxAccBalOutput = new System.Windows.Forms.Label();
            this.uxTotalInvestedOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uxPortfolioName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.uxPortfolio1 = new System.Windows.Forms.ToolStripSplitButton();
            this.buyStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePortfolioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxPortfolio2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePortfolioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxPortfolio3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddPortfolio = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.uxTabControl.SuspendLayout();
            this.uxHomeTab.SuspendLayout();
            this.uxAccountTab.SuspendLayout();
            this.uxPortfolioTab.SuspendLayout();
            this.uxPortfolioToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTabControl
            // 
            this.uxTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTabControl.Controls.Add(this.uxHomeTab);
            this.uxTabControl.Controls.Add(this.uxAccountTab);
            this.uxTabControl.Controls.Add(this.uxPortfolioTab);
            this.uxTabControl.Location = new System.Drawing.Point(0, 0);
            this.uxTabControl.Name = "uxTabControl";
            this.uxTabControl.SelectedIndex = 0;
            this.uxTabControl.Size = new System.Drawing.Size(1245, 571);
            this.uxTabControl.TabIndex = 2;
            // 
            // uxHomeTab
            // 
            this.uxHomeTab.Controls.Add(this.toolStrip1);
            this.uxHomeTab.Location = new System.Drawing.Point(4, 25);
            this.uxHomeTab.Name = "uxHomeTab";
            this.uxHomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxHomeTab.Size = new System.Drawing.Size(1237, 542);
            this.uxHomeTab.TabIndex = 0;
            this.uxHomeTab.Text = "Home";
            this.uxHomeTab.UseVisualStyleBackColor = true;
            // 
            // uxAccountTab
            // 
            this.uxAccountTab.Controls.Add(this.label5);
            this.uxAccountTab.Controls.Add(this.label6);
            this.uxAccountTab.Controls.Add(this.label3);
            this.uxAccountTab.Controls.Add(this.label4);
            this.uxAccountTab.Controls.Add(this.label1);
            this.uxAccountTab.Controls.Add(this.label2);
            this.uxAccountTab.Controls.Add(this.uxTotalInvestedOutput);
            this.uxAccountTab.Controls.Add(this.uxAccBalOutput);
            this.uxAccountTab.Controls.Add(this.uxTotalInvestedLabel);
            this.uxAccountTab.Controls.Add(this.uxInfoListView);
            this.uxAccountTab.Controls.Add(this.uxAccBalLabel);
            this.uxAccountTab.Location = new System.Drawing.Point(4, 25);
            this.uxAccountTab.Name = "uxAccountTab";
            this.uxAccountTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxAccountTab.Size = new System.Drawing.Size(1237, 542);
            this.uxAccountTab.TabIndex = 1;
            this.uxAccountTab.Text = "Account";
            this.uxAccountTab.UseVisualStyleBackColor = true;
            this.uxAccountTab.Click += new System.EventHandler(this.uxAccountTab_Click);
            // 
            // uxInfoListView
            // 
            this.uxInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxTickerNameCol,
            this.uxFullNameCol,
            this.uxCurrentPriceCol,
            this.uxNumOfSharesOwned,
            this.uxNetworthOfSharesCol,
            this.uxPositionBalCol});
            this.uxInfoListView.GridLines = true;
            this.uxInfoListView.Location = new System.Drawing.Point(0, 0);
            this.uxInfoListView.Name = "uxInfoListView";
            this.uxInfoListView.Size = new System.Drawing.Size(859, 286);
            this.uxInfoListView.TabIndex = 2;
            this.uxInfoListView.UseCompatibleStateImageBehavior = false;
            this.uxInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // uxTickerNameCol
            // 
            this.uxTickerNameCol.Text = "Ticker Name";
            this.uxTickerNameCol.Width = 91;
            // 
            // uxFullNameCol
            // 
            this.uxFullNameCol.Text = "Company Name";
            this.uxFullNameCol.Width = 130;
            // 
            // uxCurrentPriceCol
            // 
            this.uxCurrentPriceCol.Text = "Price Per Share";
            this.uxCurrentPriceCol.Width = 107;
            // 
            // uxNumOfSharesOwned
            // 
            this.uxNumOfSharesOwned.Text = "Shares Owned";
            this.uxNumOfSharesOwned.Width = 100;
            // 
            // uxNetworthOfSharesCol
            // 
            this.uxNetworthOfSharesCol.Text = "Networth of Shares";
            this.uxNetworthOfSharesCol.Width = 124;
            // 
            // uxPositionBalCol
            // 
            this.uxPositionBalCol.Text = "Position Balance";
            this.uxPositionBalCol.Width = 114;
            // 
            // uxAccBalLabel
            // 
            this.uxAccBalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAccBalLabel.AutoSize = true;
            this.uxAccBalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAccBalLabel.Location = new System.Drawing.Point(924, 0);
            this.uxAccBalLabel.Name = "uxAccBalLabel";
            this.uxAccBalLabel.Size = new System.Drawing.Size(157, 20);
            this.uxAccBalLabel.TabIndex = 0;
            this.uxAccBalLabel.Text = "Account Balance:";
            // 
            // uxPortfolioTab
            // 
            this.uxPortfolioTab.Controls.Add(this.uxPortfolioName);
            this.uxPortfolioTab.Controls.Add(this.label17);
            this.uxPortfolioTab.Controls.Add(this.chart1);
            this.uxPortfolioTab.Controls.Add(this.label7);
            this.uxPortfolioTab.Controls.Add(this.label8);
            this.uxPortfolioTab.Controls.Add(this.label9);
            this.uxPortfolioTab.Controls.Add(this.label10);
            this.uxPortfolioTab.Controls.Add(this.label11);
            this.uxPortfolioTab.Controls.Add(this.label12);
            this.uxPortfolioTab.Controls.Add(this.label13);
            this.uxPortfolioTab.Controls.Add(this.label14);
            this.uxPortfolioTab.Controls.Add(this.label15);
            this.uxPortfolioTab.Controls.Add(this.listView1);
            this.uxPortfolioTab.Controls.Add(this.label16);
            this.uxPortfolioTab.Controls.Add(this.uxPortfolioToolStrip);
            this.uxPortfolioTab.Location = new System.Drawing.Point(4, 25);
            this.uxPortfolioTab.Name = "uxPortfolioTab";
            this.uxPortfolioTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxPortfolioTab.Size = new System.Drawing.Size(1237, 542);
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
            this.uxPortfolioToolStrip.Size = new System.Drawing.Size(1231, 27);
            this.uxPortfolioToolStrip.TabIndex = 3;
            this.uxPortfolioToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // uxTotalInvestedLabel
            // 
            this.uxTotalInvestedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTotalInvestedLabel.AutoSize = true;
            this.uxTotalInvestedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTotalInvestedLabel.Location = new System.Drawing.Point(948, 189);
            this.uxTotalInvestedLabel.Name = "uxTotalInvestedLabel";
            this.uxTotalInvestedLabel.Size = new System.Drawing.Size(133, 20);
            this.uxTotalInvestedLabel.TabIndex = 3;
            this.uxTotalInvestedLabel.Text = "Total Invested:";
            this.uxTotalInvestedLabel.Click += new System.EventHandler(this.uxTotalInvestedLabel_Click);
            // 
            // uxAccBalOutput
            // 
            this.uxAccBalOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAccBalOutput.AutoSize = true;
            this.uxAccBalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAccBalOutput.Location = new System.Drawing.Point(1109, 3);
            this.uxAccBalOutput.Name = "uxAccBalOutput";
            this.uxAccBalOutput.Size = new System.Drawing.Size(49, 20);
            this.uxAccBalOutput.TabIndex = 4;
            this.uxAccBalOutput.Text = "$0.00";
            // 
            // uxTotalInvestedOutput
            // 
            this.uxTotalInvestedOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTotalInvestedOutput.AutoSize = true;
            this.uxTotalInvestedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTotalInvestedOutput.Location = new System.Drawing.Point(1109, 189);
            this.uxTotalInvestedOutput.Name = "uxTotalInvestedOutput";
            this.uxTotalInvestedOutput.Size = new System.Drawing.Size(49, 20);
            this.uxTotalInvestedOutput.TabIndex = 5;
            this.uxTotalInvestedOutput.Text = "$0.00";
            this.uxTotalInvestedOutput.Click += new System.EventHandler(this.uxTotalInvestedOutput_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1109, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(896, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Net Worth of Stocks:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1109, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "$0.00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(885, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Net Worth of Account:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1109, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(919, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Account Standing:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1109, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(919, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Account Standing:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1109, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "100.00 %";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(885, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Percentage of Account:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1109, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "$0.00";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(896, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Net Worth of Stocks:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1109, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "$0.00";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1109, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "$0.00";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(948, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Total Invested:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(859, 286);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ticker Name";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Company Name";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price Per Share";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Shares Owned";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Networth of Shares";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Position Balance";
            this.columnHeader6.Width = 114;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(924, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(157, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Account Balance:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(900, 337);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(288, 173);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // uxPortfolioName
            // 
            this.uxPortfolioName.AutoSize = true;
            this.uxPortfolioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPortfolioName.Location = new System.Drawing.Point(8, 36);
            this.uxPortfolioName.Name = "uxPortfolioName";
            this.uxPortfolioName.Size = new System.Drawing.Size(256, 39);
            this.uxPortfolioName.TabIndex = 24;
            this.uxPortfolioName.Text = "Portfolio Name";
            this.uxPortfolioName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1205, 2);
            this.label17.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1231, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(139, 24);
            this.toolStripButton1.Text = "Open Ticker File";
            // 
            // uxPortfolio1
            // 
            this.uxPortfolio1.BackColor = System.Drawing.Color.Maroon;
            this.uxPortfolio1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyStocksToolStripMenuItem,
            this.sellStocksToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deletePortfolioToolStripMenuItem2});
            this.uxPortfolio1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uxPortfolio1.Image = ((System.Drawing.Image)(resources.GetObject("uxPortfolio1.Image")));
            this.uxPortfolio1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPortfolio1.Name = "uxPortfolio1";
            this.uxPortfolio1.Size = new System.Drawing.Size(117, 24);
            this.uxPortfolio1.Text = "Portfolio 1";
            this.uxPortfolio1.Visible = false;
            this.uxPortfolio1.ButtonClick += new System.EventHandler(this.uxPortfolio1_ButtonClick);
            // 
            // buyStocksToolStripMenuItem
            // 
            this.buyStocksToolStripMenuItem.Name = "buyStocksToolStripMenuItem";
            this.buyStocksToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.buyStocksToolStripMenuItem.Text = "Buy Stocks";
            // 
            // sellStocksToolStripMenuItem
            // 
            this.sellStocksToolStripMenuItem.Name = "sellStocksToolStripMenuItem";
            this.sellStocksToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.sellStocksToolStripMenuItem.Text = "Sell Stocks";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 26);
            this.toolStripMenuItem2.Text = " ";
            // 
            // deletePortfolioToolStripMenuItem2
            // 
            this.deletePortfolioToolStripMenuItem2.Name = "deletePortfolioToolStripMenuItem2";
            this.deletePortfolioToolStripMenuItem2.Size = new System.Drawing.Size(185, 26);
            this.deletePortfolioToolStripMenuItem2.Text = "DeletePortfolio";
            // 
            // uxPortfolio2
            // 
            this.uxPortfolio2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.deletePortfolioToolStripMenuItem1});
            this.uxPortfolio2.Image = ((System.Drawing.Image)(resources.GetObject("uxPortfolio2.Image")));
            this.uxPortfolio2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPortfolio2.Name = "uxPortfolio2";
            this.uxPortfolio2.Size = new System.Drawing.Size(117, 24);
            this.uxPortfolio2.Text = "Portfolio 2";
            this.uxPortfolio2.Visible = false;
            this.uxPortfolio2.ButtonClick += new System.EventHandler(this.uxPortfolio2_ButtonClick);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem5.Text = "Buy Stocks";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem1.Text = "Sell Stocks";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem3.Text = " ";
            // 
            // deletePortfolioToolStripMenuItem1
            // 
            this.deletePortfolioToolStripMenuItem1.Name = "deletePortfolioToolStripMenuItem1";
            this.deletePortfolioToolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.deletePortfolioToolStripMenuItem1.Text = "Delete Portfolio";
            // 
            // uxPortfolio3
            // 
            this.uxPortfolio3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem4,
            this.deletePortfolioToolStripMenuItem});
            this.uxPortfolio3.Image = ((System.Drawing.Image)(resources.GetObject("uxPortfolio3.Image")));
            this.uxPortfolio3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxPortfolio3.Name = "uxPortfolio3";
            this.uxPortfolio3.Size = new System.Drawing.Size(117, 24);
            this.uxPortfolio3.Text = "Portfolio 3";
            this.uxPortfolio3.Visible = false;
            this.uxPortfolio3.ButtonClick += new System.EventHandler(this.uxPortfolio3_ButtonClick);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem6.Text = "Buy Stocks";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem7.Text = "Sell Stocks";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 26);
            this.toolStripMenuItem4.Text = " ";
            // 
            // deletePortfolioToolStripMenuItem
            // 
            this.deletePortfolioToolStripMenuItem.Name = "deletePortfolioToolStripMenuItem";
            this.deletePortfolioToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.deletePortfolioToolStripMenuItem.Text = "Delete Portfolio";
            // 
            // uxAddPortfolio
            // 
            this.uxAddPortfolio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxAddPortfolio.Name = "uxAddPortfolio";
            this.uxAddPortfolio.Size = new System.Drawing.Size(122, 24);
            this.uxAddPortfolio.Text = "&Add Portfolio";
            this.uxAddPortfolio.Click += new System.EventHandler(this.uxAddPortfolio_Click);
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
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(164, 24);
            this.toolStripButton2.Text = "Update Stock Prices";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 571);
            this.Controls.Add(this.uxTabControl);
            this.MinimumSize = new System.Drawing.Size(1201, 618);
            this.Name = "UserInterface";
            this.Text = "Ticker 501";
            this.uxTabControl.ResumeLayout(false);
            this.uxHomeTab.ResumeLayout(false);
            this.uxHomeTab.PerformLayout();
            this.uxAccountTab.ResumeLayout(false);
            this.uxAccountTab.PerformLayout();
            this.uxPortfolioTab.ResumeLayout(false);
            this.uxPortfolioTab.PerformLayout();
            this.uxPortfolioToolStrip.ResumeLayout(false);
            this.uxPortfolioToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl uxTabControl;
        private System.Windows.Forms.TabPage uxHomeTab;
        private System.Windows.Forms.TabPage uxAccountTab;
        private System.Windows.Forms.TabPage uxPortfolioTab;
        private System.Windows.Forms.ToolStrip uxPortfolioToolStrip;
        private System.Windows.Forms.ToolStripSplitButton uxPortfolio1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deletePortfolioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSplitButton uxPortfolio2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deletePortfolioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton uxPortfolio3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deletePortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton uxAddPortfolio;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Label uxAccBalLabel;
        private System.Windows.Forms.ListView uxInfoListView;
        private System.Windows.Forms.ColumnHeader uxTickerNameCol;
        private System.Windows.Forms.ColumnHeader uxFullNameCol;
        private System.Windows.Forms.ColumnHeader uxCurrentPriceCol;
        private System.Windows.Forms.ColumnHeader uxNumOfSharesOwned;
        private System.Windows.Forms.ColumnHeader uxNetworthOfSharesCol;
        private System.Windows.Forms.ColumnHeader uxPositionBalCol;
        private System.Windows.Forms.Label uxTotalInvestedLabel;
        private System.Windows.Forms.Label uxAccBalOutput;
        private System.Windows.Forms.Label uxTotalInvestedOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem buyStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Label uxPortfolioName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

