namespace Dashboard.Vista
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIndicador = new System.Windows.Forms.ComboBox();
            this.cbxIndicadorEspecifico = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grafGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf2012 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf2013 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graf2014 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indicador";
            // 
            // cbxIndicador
            // 
            this.cbxIndicador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIndicador.FormattingEnabled = true;
            this.cbxIndicador.Location = new System.Drawing.Point(353, 35);
            this.cbxIndicador.Name = "cbxIndicador";
            this.cbxIndicador.Size = new System.Drawing.Size(147, 29);
            this.cbxIndicador.TabIndex = 3;
            this.cbxIndicador.SelectedIndexChanged += new System.EventHandler(this.cbxIndicador_SelectedIndexChanged);
            // 
            // cbxIndicadorEspecifico
            // 
            this.cbxIndicadorEspecifico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIndicadorEspecifico.FormattingEnabled = true;
            this.cbxIndicadorEspecifico.Location = new System.Drawing.Point(515, 35);
            this.cbxIndicadorEspecifico.Name = "cbxIndicadorEspecifico";
            this.cbxIndicadorEspecifico.Size = new System.Drawing.Size(121, 29);
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
            chartArea9.BackColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.grafGeneral.ChartAreas.Add(chartArea9);
            legend9.BackColor = System.Drawing.Color.Transparent;
            legend9.Name = "Legend1";
            this.grafGeneral.Legends.Add(legend9);
            this.grafGeneral.Location = new System.Drawing.Point(36, 87);
            this.grafGeneral.Name = "grafGeneral";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.grafGeneral.Series.Add(series9);
            this.grafGeneral.Size = new System.Drawing.Size(338, 215);
            this.grafGeneral.TabIndex = 34;
            this.grafGeneral.Text = "chart1";
            // 
            // graf2012
            // 
            this.graf2012.BackColor = System.Drawing.Color.Transparent;
            chartArea10.AxisX.MajorGrid.LineWidth = 0;
            chartArea10.AxisY.MajorGrid.LineWidth = 0;
            chartArea10.BackColor = System.Drawing.Color.Transparent;
            chartArea10.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea10.Name = "ChartArea1";
            this.graf2012.ChartAreas.Add(chartArea10);
            legend10.BackColor = System.Drawing.Color.Transparent;
            legend10.Name = "Legend1";
            this.graf2012.Legends.Add(legend10);
            this.graf2012.Location = new System.Drawing.Point(16, 364);
            this.graf2012.Name = "graf2012";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.IsValueShownAsLabel = true;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.graf2012.Series.Add(series10);
            this.graf2012.Size = new System.Drawing.Size(322, 215);
            this.graf2012.TabIndex = 35;
            this.graf2012.Text = "chart2";
            // 
            // graf2013
            // 
            this.graf2013.BackColor = System.Drawing.Color.Transparent;
            chartArea11.AxisX.MajorGrid.LineWidth = 0;
            chartArea11.AxisY.MajorGrid.LineWidth = 0;
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.graf2013.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.Color.Transparent;
            legend11.Name = "Legend1";
            this.graf2013.Legends.Add(legend11);
            this.graf2013.Location = new System.Drawing.Point(391, 364);
            this.graf2013.Name = "graf2013";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.IsValueShownAsLabel = true;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.graf2013.Series.Add(series11);
            this.graf2013.Size = new System.Drawing.Size(322, 215);
            this.graf2013.TabIndex = 38;
            this.graf2013.Text = "chart3";
            // 
            // graf2014
            // 
            this.graf2014.BackColor = System.Drawing.Color.Transparent;
            chartArea12.AxisX.MajorGrid.LineWidth = 0;
            chartArea12.AxisY.MajorGrid.LineWidth = 0;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.graf2014.ChartAreas.Add(chartArea12);
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.Name = "Legend1";
            this.graf2014.Legends.Add(legend12);
            this.graf2014.Location = new System.Drawing.Point(739, 364);
            this.graf2014.Name = "graf2014";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series12.IsValueShownAsLabel = true;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.graf2014.Series.Add(series12);
            this.graf2014.Size = new System.Drawing.Size(322, 215);
            this.graf2014.TabIndex = 39;
            this.graf2014.Text = "chart4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "2012";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "2013";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(886, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "2014";
            // 
            // ctrlIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
