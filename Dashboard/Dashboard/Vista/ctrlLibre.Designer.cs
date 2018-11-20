namespace Dashboard.Vista
{
    partial class ctrlLibre
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grafGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numDe = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grafGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasajeros de carro heridos leves en el  año 2012";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConsultar.Location = new System.Drawing.Point(468, 67);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 41);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Location = new System.Drawing.Point(113, 203);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(121, 24);
            this.cbxSexo.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Edad";
            // 
            // grafGeneral
            // 
            this.grafGeneral.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.grafGeneral.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.grafGeneral.Legends.Add(legend2);
            this.grafGeneral.Location = new System.Drawing.Point(344, 156);
            this.grafGeneral.Name = "grafGeneral";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafGeneral.Series.Add(series2);
            this.grafGeneral.Size = new System.Drawing.Size(726, 420);
            this.grafGeneral.TabIndex = 42;
            this.grafGeneral.Text = "chart2";
            // 
            // numDe
            // 
            this.numDe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDe.Location = new System.Drawing.Point(142, 262);
            this.numDe.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numDe.Name = "numDe";
            this.numDe.Size = new System.Drawing.Size(46, 23);
            this.numDe.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "a";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(219, 262);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown1.TabIndex = 45;
            // 
            // ctrlLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDe);
            this.Controls.Add(this.grafGeneral);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctrlLibre";
            this.Size = new System.Drawing.Size(1080, 620);
            this.Load += new System.EventHandler(this.ctrlLibre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafGeneral;
        private System.Windows.Forms.NumericUpDown numDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
