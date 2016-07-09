namespace Blood_Bank_Manager {
    partial class HomeUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.donor_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.stock_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
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
            this.circularProgressBar3 = new Blood_Bank_Manager.CircularProgressBar();
            this.circularProgressBar2 = new Blood_Bank_Manager.CircularProgressBar();
            this.circularProgressBar1 = new Blood_Bank_Manager.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.donor_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // donor_chart
            // 
            this.donor_chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.donor_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.donor_chart.Legends.Add(legend1);
            this.donor_chart.Location = new System.Drawing.Point(17, 259);
            this.donor_chart.Name = "donor_chart";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Donors";
            this.donor_chart.Series.Add(series1);
            this.donor_chart.Size = new System.Drawing.Size(389, 233);
            this.donor_chart.TabIndex = 0;
            this.donor_chart.Text = "Donor Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(37)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Blood Bank Manager";
            // 
            // date_label
            // 
            this.date_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.date_label.Location = new System.Drawing.Point(485, 10);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(199, 25);
            this.date_label.TabIndex = 7;
            this.date_label.Text = "7-Jul-16";
            this.date_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label
            // 
            this.time_label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(102)))), ((int)(((byte)(169)))));
            this.time_label.Location = new System.Drawing.Point(690, 10);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(115, 25);
            this.time_label.TabIndex = 8;
            this.time_label.Text = "11:50 AM";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stock_chart
            // 
            this.stock_chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.stock_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.stock_chart.Legends.Add(legend2);
            this.stock_chart.Location = new System.Drawing.Point(412, 259);
            this.stock_chart.Name = "stock_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Stock";
            this.stock_chart.Series.Add(series2);
            this.stock_chart.Size = new System.Drawing.Size(389, 233);
            this.stock_chart.TabIndex = 9;
            this.stock_chart.Text = "Donor Statistics";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(35, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Donor Statistics Chart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(412, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stock Statistics Chart";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(42)))), ((int)(((byte)(135)))));
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 63);
            this.label4.TabIndex = 13;
            this.label4.Text = "536";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(7, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Registered donors";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(174, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Blood bags in stock";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(26)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(170, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 63);
            this.label7.TabIndex = 15;
            this.label7.Text = "306";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(338, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Donors available";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(338, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "currently";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(497, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "donors";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(497, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Monthly new";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(651, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "stock";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(651, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Monthly new";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.BarWidth = 15;
            this.circularProgressBar3.EmptyBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.circularProgressBar3.Location = new System.Drawing.Point(655, 74);
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(182)))), ((int)(((byte)(132)))));
            this.circularProgressBar3.ProgressValue = 60;
            this.circularProgressBar3.Size = new System.Drawing.Size(130, 130);
            this.circularProgressBar3.StatusFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(182)))), ((int)(((byte)(132)))));
            this.circularProgressBar3.TabIndex = 22;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.BarWidth = 15;
            this.circularProgressBar2.EmptyBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.circularProgressBar2.Location = new System.Drawing.Point(501, 74);
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.circularProgressBar2.ProgressValue = 32;
            this.circularProgressBar2.Size = new System.Drawing.Size(130, 130);
            this.circularProgressBar2.StatusFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(181)))));
            this.circularProgressBar2.TabIndex = 19;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.BarWidth = 15;
            this.circularProgressBar1.EmptyBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.circularProgressBar1.Location = new System.Drawing.Point(342, 74);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.circularProgressBar1.ProgressValue = 73;
            this.circularProgressBar1.Size = new System.Drawing.Size(130, 130);
            this.circularProgressBar1.StatusFont = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.circularProgressBar1.TabIndex = 12;
            // 
            // HomeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.circularProgressBar3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stock_chart);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.donor_chart);
            this.Name = "HomeUC";
            this.Size = new System.Drawing.Size(808, 529);
            ((System.ComponentModel.ISupportInitialize)(this.donor_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart donor_chart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart stock_chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CircularProgressBar circularProgressBar2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private CircularProgressBar circularProgressBar3;

    }
}
