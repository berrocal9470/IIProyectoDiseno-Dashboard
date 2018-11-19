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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkEdadDesconocida = new System.Windows.Forms.CheckBox();
            this.lblEdadQuinquenal = new System.Windows.Forms.Label();
            this.trckEdadQuinquenal = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.grafGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.trckEdadQuinquenal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafGeneral)).BeginInit();
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
            this.cbxSexo.Location = new System.Drawing.Point(190, 228);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(121, 24);
            this.cbxSexo.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Sexo";
            // 
            // chkEdadDesconocida
            // 
            this.chkEdadDesconocida.AutoSize = true;
            this.chkEdadDesconocida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEdadDesconocida.Location = new System.Drawing.Point(193, 304);
            this.chkEdadDesconocida.Name = "chkEdadDesconocida";
            this.chkEdadDesconocida.Size = new System.Drawing.Size(151, 21);
            this.chkEdadDesconocida.TabIndex = 40;
            this.chkEdadDesconocida.Text = "Edad Desconocida";
            this.chkEdadDesconocida.UseVisualStyleBackColor = true;
            this.chkEdadDesconocida.CheckedChanged += new System.EventHandler(this.chkEdadDesconocida_CheckedChanged);
            // 
            // lblEdadQuinquenal
            // 
            this.lblEdadQuinquenal.AutoSize = true;
            this.lblEdadQuinquenal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadQuinquenal.Location = new System.Drawing.Point(190, 284);
            this.lblEdadQuinquenal.Name = "lblEdadQuinquenal";
            this.lblEdadQuinquenal.Size = new System.Drawing.Size(96, 17);
            this.lblEdadQuinquenal.TabIndex = 39;
            this.lblEdadQuinquenal.Text = "De 0 a 4 años";
            // 
            // trckEdadQuinquenal
            // 
            this.trckEdadQuinquenal.Location = new System.Drawing.Point(48, 343);
            this.trckEdadQuinquenal.Maximum = 75;
            this.trckEdadQuinquenal.Name = "trckEdadQuinquenal";
            this.trckEdadQuinquenal.Size = new System.Drawing.Size(399, 45);
            this.trckEdadQuinquenal.SmallChange = 5;
            this.trckEdadQuinquenal.TabIndex = 38;
            this.trckEdadQuinquenal.Tag = "";
            this.trckEdadQuinquenal.TickFrequency = 5;
            this.trckEdadQuinquenal.Scroll += new System.EventHandler(this.trckEdadQuinquenal_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Edad Quinquenal";
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
            this.grafGeneral.Location = new System.Drawing.Point(555, 213);
            this.grafGeneral.Name = "grafGeneral";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafGeneral.Series.Add(series1);
            this.grafGeneral.Size = new System.Drawing.Size(470, 319);
            this.grafGeneral.TabIndex = 41;
            this.grafGeneral.Text = "chart1";
            // 
            // ctrlLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grafGeneral);
            this.Controls.Add(this.chkEdadDesconocida);
            this.Controls.Add(this.lblEdadQuinquenal);
            this.Controls.Add(this.trckEdadQuinquenal);
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
            ((System.ComponentModel.ISupportInitialize)(this.trckEdadQuinquenal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEdadDesconocida;
        private System.Windows.Forms.Label lblEdadQuinquenal;
        private System.Windows.Forms.TrackBar trckEdadQuinquenal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafGeneral;
    }
}
