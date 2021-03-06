﻿namespace Dashboard.Vista
{
    partial class ctrlIndicador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIndicador = new System.Windows.Forms.ComboBox();
            this.cbxIndicadorEspecifico = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grafGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf2012 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf2013 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf2014 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2012)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2013)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2014)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indicador";
            // 
            // cbxIndicador
            // 
            this.cbxIndicador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIndicador.FormattingEnabled = true;
            this.cbxIndicador.Location = new System.Drawing.Point(353, 35);
            this.cbxIndicador.Name = "cbxIndicador";
            this.cbxIndicador.Size = new System.Drawing.Size(147, 25);
            this.cbxIndicador.TabIndex = 3;
            this.cbxIndicador.SelectedIndexChanged += new System.EventHandler(this.cbxIndicador_SelectedIndexChanged);
            // 
            // cbxIndicadorEspecifico
            // 
            this.cbxIndicadorEspecifico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIndicadorEspecifico.FormattingEnabled = true;
            this.cbxIndicadorEspecifico.Location = new System.Drawing.Point(515, 35);
            this.cbxIndicadorEspecifico.Name = "cbxIndicadorEspecifico";
            this.cbxIndicadorEspecifico.Size = new System.Drawing.Size(121, 25);
            this.cbxIndicadorEspecifico.TabIndex = 4;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConsultar.Location = new System.Drawing.Point(668, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 41);
            this.btnConsultar.TabIndex = 33;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grafGeneral
            // 
            this.grafGeneral.BackColor = System.Drawing.Color.Transparent;
            this.grafGeneral.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.grafGeneral.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.grafGeneral.Legends.Add(legend1);
            this.grafGeneral.Location = new System.Drawing.Point(36, 87);
            this.grafGeneral.Name = "grafGeneral";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafGeneral.Series.Add(series1);
            this.grafGeneral.Size = new System.Drawing.Size(392, 271);
            this.grafGeneral.TabIndex = 34;
            this.grafGeneral.Text = "chart1";
            // 
            // graf2012
            // 
            this.graf2012.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.graf2012.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.graf2012.Legends.Add(legend2);
            this.graf2012.Location = new System.Drawing.Point(573, 97);
            this.graf2012.Name = "graf2012";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graf2012.Series.Add(series2);
            this.graf2012.Size = new System.Drawing.Size(504, 261);
            this.graf2012.TabIndex = 35;
            this.graf2012.Text = "chart2";
            // 
            // graf2013
            // 
            this.graf2013.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineWidth = 0;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.graf2013.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.graf2013.Legends.Add(legend3);
            this.graf2013.Location = new System.Drawing.Point(3, 364);
            this.graf2013.Name = "graf2013";
            this.graf2013.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graf2013.Series.Add(series3);
            this.graf2013.Size = new System.Drawing.Size(564, 253);
            this.graf2013.TabIndex = 38;
            this.graf2013.Text = "chart3";
            // 
            // graf2014
            // 
            this.graf2014.BackColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.MajorGrid.LineWidth = 0;
            chartArea4.AxisY.MajorGrid.LineWidth = 0;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.graf2014.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Name = "Legend1";
            this.graf2014.Legends.Add(legend4);
            this.graf2014.Location = new System.Drawing.Point(573, 364);
            this.graf2014.Name = "graf2014";
            this.graf2014.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.graf2014.Series.Add(series4);
            this.graf2014.Size = new System.Drawing.Size(507, 253);
            this.graf2014.TabIndex = 39;
            this.graf2014.Text = "chart4";
            // 
            // ctrlIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graf2014);
            this.Controls.Add(this.graf2013);
            this.Controls.Add(this.graf2012);
            this.Controls.Add(this.grafGeneral);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbxIndicadorEspecifico);
            this.Controls.Add(this.cbxIndicador);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctrlIndicador";
            this.Size = new System.Drawing.Size(1080, 620);
            this.Load += new System.EventHandler(this.ctrlIndicador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2012)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2013)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2014)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxIndicador;
        private System.Windows.Forms.ComboBox cbxIndicadorEspecifico;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafGeneral;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf2012;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf2013;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf2014;
    }
}
