namespace LKS_Prov.GUI
{
    partial class RoomAvailble
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ck1 = new System.Windows.Forms.CheckBox();
            this.ck5 = new System.Windows.Forms.CheckBox();
            this.ck4 = new System.Windows.Forms.CheckBox();
            this.ck3 = new System.Windows.Forms.CheckBox();
            this.ck2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "a";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(282, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "a";
            series1.LegendText = "All";
            series1.LegendToolTip = "ffffff";
            series1.Name = "All";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "a";
            series2.Name = "Standar";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "a";
            series3.Name = "Super";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "a";
            series4.Name = "Deluxe";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "a";
            series5.Name = "Excekutif";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(569, 319);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Transaction Data";
            title2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Title2";
            title2.Text = "Transaction Date";
            title3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            title3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title3.Name = "Title3";
            title3.Text = "Total Incoming";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "label4";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(95, 55);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(138, 21);
            this.cb.TabIndex = 23;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(95, 99);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(138, 21);
            this.cb2.TabIndex = 24;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(118, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 175);
            this.vScrollBar1.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ck1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(95, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 140);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ck1
            // 
            this.ck1.AutoSize = true;
            this.ck1.Location = new System.Drawing.Point(19, 13);
            this.ck1.Name = "ck1";
            this.ck1.Size = new System.Drawing.Size(45, 17);
            this.ck1.TabIndex = 26;
            this.ck1.Text = "ALL";
            this.ck1.UseVisualStyleBackColor = true;
            this.ck1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ck5
            // 
            this.ck5.AutoSize = true;
            this.ck5.Location = new System.Drawing.Point(115, 232);
            this.ck5.Name = "ck5";
            this.ck5.Size = new System.Drawing.Size(70, 17);
            this.ck5.TabIndex = 29;
            this.ck5.Text = "Excekutif";
            this.ck5.UseVisualStyleBackColor = true;
            this.ck5.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ck4
            // 
            this.ck4.AutoSize = true;
            this.ck4.Location = new System.Drawing.Point(115, 209);
            this.ck4.Name = "ck4";
            this.ck4.Size = new System.Drawing.Size(59, 17);
            this.ck4.TabIndex = 30;
            this.ck4.Text = "Deluxe";
            this.ck4.UseVisualStyleBackColor = true;
            // 
            // ck3
            // 
            this.ck3.AutoSize = true;
            this.ck3.Location = new System.Drawing.Point(115, 186);
            this.ck3.Name = "ck3";
            this.ck3.Size = new System.Drawing.Size(54, 17);
            this.ck3.TabIndex = 31;
            this.ck3.Text = "Super";
            this.ck3.UseVisualStyleBackColor = true;
            // 
            // ck2
            // 
            this.ck2.AutoSize = true;
            this.ck2.Location = new System.Drawing.Point(115, 163);
            this.ck2.Name = "ck2";
            this.ck2.Size = new System.Drawing.Size(63, 17);
            this.ck2.TabIndex = 32;
            this.ck2.Text = "Standar";
            this.ck2.UseVisualStyleBackColor = true;
            // 
            // RoomAvailble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 382);
            this.Controls.Add(this.ck5);
            this.Controls.Add(this.ck4);
            this.Controls.Add(this.ck3);
            this.Controls.Add(this.ck2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "RoomAvailble";
            this.Text = "RoomAvailble";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ck1;
        private System.Windows.Forms.CheckBox ck2;
        private System.Windows.Forms.CheckBox ck3;
        private System.Windows.Forms.CheckBox ck4;
        private System.Windows.Forms.CheckBox ck5;
    }
}