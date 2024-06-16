namespace Inventory_Management_System
{
    partial class AdminDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.totalProductsPanel = new System.Windows.Forms.Panel();
            this.totalProductsAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productsOutofStock = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productsLowOfStocks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart_categories = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_stocks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalProductsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_categories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stocks)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalProductsPanel
            // 
            this.totalProductsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(204)))), ((int)(((byte)(252)))));
            this.totalProductsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.totalProductsPanel.Controls.Add(this.totalProductsAmountLabel);
            this.totalProductsPanel.Controls.Add(this.label1);
            this.totalProductsPanel.Location = new System.Drawing.Point(37, 97);
            this.totalProductsPanel.Name = "totalProductsPanel";
            this.totalProductsPanel.Size = new System.Drawing.Size(206, 111);
            this.totalProductsPanel.TabIndex = 0;
            this.totalProductsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // totalProductsAmountLabel
            // 
            this.totalProductsAmountLabel.AutoSize = true;
            this.totalProductsAmountLabel.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductsAmountLabel.Location = new System.Drawing.Point(13, 17);
            this.totalProductsAmountLabel.Name = "totalProductsAmountLabel";
            this.totalProductsAmountLabel.Size = new System.Drawing.Size(39, 47);
            this.totalProductsAmountLabel.TabIndex = 1;
            this.totalProductsAmountLabel.Text = "0";
            this.totalProductsAmountLabel.Click += new System.EventHandler(this.totalProductsAmountLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Products";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.productsOutofStock);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(283, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 111);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productsOutofStock
            // 
            this.productsOutofStock.AutoSize = true;
            this.productsOutofStock.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsOutofStock.Location = new System.Drawing.Point(12, 16);
            this.productsOutofStock.Name = "productsOutofStock";
            this.productsOutofStock.Size = new System.Drawing.Size(39, 47);
            this.productsOutofStock.TabIndex = 3;
            this.productsOutofStock.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Products Out of Stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.productsLowOfStocks);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(534, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 111);
            this.panel2.TabIndex = 1;
            // 
            // productsLowOfStocks
            // 
            this.productsLowOfStocks.AutoSize = true;
            this.productsLowOfStocks.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLowOfStocks.Location = new System.Drawing.Point(17, 17);
            this.productsLowOfStocks.Name = "productsLowOfStocks";
            this.productsLowOfStocks.Size = new System.Drawing.Size(39, 47);
            this.productsLowOfStocks.TabIndex = 3;
            this.productsLowOfStocks.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Low on Stock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Products by Categories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(456, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Products by Stocks";
            // 
            // chart_categories
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_categories.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_categories.Legends.Add(legend1);
            this.chart_categories.Location = new System.Drawing.Point(37, 285);
            this.chart_categories.Name = "chart_categories";
            this.chart_categories.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_categories.Series.Add(series1);
            this.chart_categories.Size = new System.Drawing.Size(300, 300);
            this.chart_categories.TabIndex = 6;
            this.chart_categories.Text = "chart1";
            this.chart_categories.Click += new System.EventHandler(this.chart_categories_Click);
            // 
            // chart_stocks
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_stocks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_stocks.Legends.Add(legend2);
            this.chart_stocks.Location = new System.Drawing.Point(424, 285);
            this.chart_stocks.Name = "chart_stocks";
            this.chart_stocks.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chart_stocks.Series.Add(series2);
            this.chart_stocks.Size = new System.Drawing.Size(300, 300);
            this.chart_stocks.TabIndex = 7;
            this.chart_stocks.Text = "chart2";
            this.chart_stocks.Click += new System.EventHandler(this.chart_stocks_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart_stocks);
            this.Controls.Add(this.chart_categories);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalProductsPanel);
            this.Name = "AdminDashboard";
            this.Size = new System.Drawing.Size(769, 600);
            this.totalProductsPanel.ResumeLayout(false);
            this.totalProductsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_categories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel totalProductsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalProductsAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productsOutofStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label productsLowOfStocks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_categories;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stocks;
    }
}
