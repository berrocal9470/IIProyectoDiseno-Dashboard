namespace Dashboard.Vista
{
    partial class ctrlDinamica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlDinamica));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.btnAgregarProvincia = new System.Windows.Forms.Button();
            this.btnQuitarProvincia = new System.Windows.Forms.Button();
            this.lbxProvincia = new System.Windows.Forms.ListBox();
            this.lbxCanton = new System.Windows.Forms.ListBox();
            this.btnQuitarCanton = new System.Windows.Forms.Button();
            this.btnAgregarCanton = new System.Windows.Forms.Button();
            this.cbxCanton = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxDistrito = new System.Windows.Forms.ListBox();
            this.btnQuitarDistrito = new System.Windows.Forms.Button();
            this.btnAgregarDistrito = new System.Windows.Forms.Button();
            this.cbxDistrito = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxAfectado = new System.Windows.Forms.ComboBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.cbxLesion = new System.Windows.Forms.ComboBox();
            this.trckEdadQuinquenal = new System.Windows.Forms.TrackBar();
            this.lblEdadQuinquenal = new System.Windows.Forms.Label();
            this.chkEdadDesconocida = new System.Windows.Forms.CheckBox();
            this.chk2014 = new System.Windows.Forms.CheckBox();
            this.chk2013 = new System.Windows.Forms.CheckBox();
            this.chk2012 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.chkSinEdad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trckEdadQuinquenal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Provincia";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(454, 52);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(140, 29);
            this.cbxProvincia.TabIndex = 3;
            // 
            // btnAgregarProvincia
            // 
            this.btnAgregarProvincia.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProvincia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProvincia.BackgroundImage")));
            this.btnAgregarProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProvincia.FlatAppearance.BorderSize = 0;
            this.btnAgregarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProvincia.Location = new System.Drawing.Point(569, 83);
            this.btnAgregarProvincia.Name = "btnAgregarProvincia";
            this.btnAgregarProvincia.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarProvincia.TabIndex = 4;
            this.btnAgregarProvincia.UseVisualStyleBackColor = false;
            this.btnAgregarProvincia.Click += new System.EventHandler(this.btnAgregarProvincia_Click);
            // 
            // btnQuitarProvincia
            // 
            this.btnQuitarProvincia.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitarProvincia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitarProvincia.BackgroundImage")));
            this.btnQuitarProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarProvincia.FlatAppearance.BorderSize = 0;
            this.btnQuitarProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProvincia.Location = new System.Drawing.Point(538, 82);
            this.btnQuitarProvincia.Name = "btnQuitarProvincia";
            this.btnQuitarProvincia.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarProvincia.TabIndex = 5;
            this.btnQuitarProvincia.UseVisualStyleBackColor = false;
            this.btnQuitarProvincia.Click += new System.EventHandler(this.btnQuitarProvincia_Click);
            // 
            // lbxProvincia
            // 
            this.lbxProvincia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProvincia.FormattingEnabled = true;
            this.lbxProvincia.ItemHeight = 21;
            this.lbxProvincia.Location = new System.Drawing.Point(454, 120);
            this.lbxProvincia.Name = "lbxProvincia";
            this.lbxProvincia.Size = new System.Drawing.Size(140, 67);
            this.lbxProvincia.TabIndex = 6;
            // 
            // lbxCanton
            // 
            this.lbxCanton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCanton.FormattingEnabled = true;
            this.lbxCanton.ItemHeight = 21;
            this.lbxCanton.Location = new System.Drawing.Point(670, 120);
            this.lbxCanton.Name = "lbxCanton";
            this.lbxCanton.Size = new System.Drawing.Size(140, 67);
            this.lbxCanton.TabIndex = 11;
            // 
            // btnQuitarCanton
            // 
            this.btnQuitarCanton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitarCanton.BackgroundImage")));
            this.btnQuitarCanton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarCanton.FlatAppearance.BorderSize = 0;
            this.btnQuitarCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarCanton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarCanton.Location = new System.Drawing.Point(754, 83);
            this.btnQuitarCanton.Name = "btnQuitarCanton";
            this.btnQuitarCanton.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarCanton.TabIndex = 10;
            this.btnQuitarCanton.UseVisualStyleBackColor = true;
            this.btnQuitarCanton.Click += new System.EventHandler(this.btnQuitarCanton_Click);
            // 
            // btnAgregarCanton
            // 
            this.btnAgregarCanton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCanton.BackgroundImage")));
            this.btnAgregarCanton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCanton.FlatAppearance.BorderSize = 0;
            this.btnAgregarCanton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCanton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCanton.Location = new System.Drawing.Point(785, 83);
            this.btnAgregarCanton.Name = "btnAgregarCanton";
            this.btnAgregarCanton.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarCanton.TabIndex = 9;
            this.btnAgregarCanton.UseVisualStyleBackColor = true;
            this.btnAgregarCanton.Click += new System.EventHandler(this.btnAgregarCanton_Click);
            // 
            // cbxCanton
            // 
            this.cbxCanton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCanton.FormattingEnabled = true;
            this.cbxCanton.Location = new System.Drawing.Point(669, 52);
            this.cbxCanton.Name = "cbxCanton";
            this.cbxCanton.Size = new System.Drawing.Size(141, 29);
            this.cbxCanton.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Canton";
            // 
            // lbxDistrito
            // 
            this.lbxDistrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDistrito.FormattingEnabled = true;
            this.lbxDistrito.ItemHeight = 21;
            this.lbxDistrito.Location = new System.Drawing.Point(879, 120);
            this.lbxDistrito.Name = "lbxDistrito";
            this.lbxDistrito.Size = new System.Drawing.Size(140, 67);
            this.lbxDistrito.TabIndex = 16;
            // 
            // btnQuitarDistrito
            // 
            this.btnQuitarDistrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuitarDistrito.BackgroundImage")));
            this.btnQuitarDistrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarDistrito.FlatAppearance.BorderSize = 0;
            this.btnQuitarDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarDistrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDistrito.Location = new System.Drawing.Point(963, 83);
            this.btnQuitarDistrito.Name = "btnQuitarDistrito";
            this.btnQuitarDistrito.Size = new System.Drawing.Size(25, 25);
            this.btnQuitarDistrito.TabIndex = 15;
            this.btnQuitarDistrito.UseVisualStyleBackColor = true;
            this.btnQuitarDistrito.Click += new System.EventHandler(this.btnQuitarDistrito_Click);
            // 
            // btnAgregarDistrito
            // 
            this.btnAgregarDistrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDistrito.BackgroundImage")));
            this.btnAgregarDistrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarDistrito.FlatAppearance.BorderSize = 0;
            this.btnAgregarDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDistrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDistrito.Location = new System.Drawing.Point(994, 83);
            this.btnAgregarDistrito.Name = "btnAgregarDistrito";
            this.btnAgregarDistrito.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarDistrito.TabIndex = 14;
            this.btnAgregarDistrito.UseVisualStyleBackColor = true;
            this.btnAgregarDistrito.Click += new System.EventHandler(this.btnAgregarDistrito_Click);
            // 
            // cbxDistrito
            // 
            this.cbxDistrito.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDistrito.FormattingEnabled = true;
            this.cbxDistrito.Location = new System.Drawing.Point(879, 52);
            this.cbxDistrito.Name = "cbxDistrito";
            this.cbxDistrito.Size = new System.Drawing.Size(140, 29);
            this.cbxDistrito.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(875, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Distrito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Afectado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lesión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Edad Quinquenal";
            // 
            // cbxAfectado
            // 
            this.cbxAfectado.FormattingEnabled = true;
            this.cbxAfectado.Location = new System.Drawing.Point(158, 172);
            this.cbxAfectado.Name = "cbxAfectado";
            this.cbxAfectado.Size = new System.Drawing.Size(121, 27);
            this.cbxAfectado.TabIndex = 22;
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Location = new System.Drawing.Point(158, 219);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(121, 27);
            this.cbxSexo.TabIndex = 23;
            // 
            // cbxLesion
            // 
            this.cbxLesion.FormattingEnabled = true;
            this.cbxLesion.Location = new System.Drawing.Point(158, 267);
            this.cbxLesion.Name = "cbxLesion";
            this.cbxLesion.Size = new System.Drawing.Size(121, 27);
            this.cbxLesion.TabIndex = 24;
            // 
            // trckEdadQuinquenal
            // 
            this.trckEdadQuinquenal.Location = new System.Drawing.Point(16, 417);
            this.trckEdadQuinquenal.Maximum = 75;
            this.trckEdadQuinquenal.Name = "trckEdadQuinquenal";
            this.trckEdadQuinquenal.Size = new System.Drawing.Size(399, 56);
            this.trckEdadQuinquenal.SmallChange = 5;
            this.trckEdadQuinquenal.TabIndex = 25;
            this.trckEdadQuinquenal.Tag = "";
            this.trckEdadQuinquenal.TickFrequency = 5;
            this.trckEdadQuinquenal.Scroll += new System.EventHandler(this.trckEdadQuinquenal_Scroll);
            // 
            // lblEdadQuinquenal
            // 
            this.lblEdadQuinquenal.AutoSize = true;
            this.lblEdadQuinquenal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadQuinquenal.Location = new System.Drawing.Point(158, 327);
            this.lblEdadQuinquenal.Name = "lblEdadQuinquenal";
            this.lblEdadQuinquenal.Size = new System.Drawing.Size(124, 21);
            this.lblEdadQuinquenal.TabIndex = 26;
            this.lblEdadQuinquenal.Text = "De 0 a 4 años";
            // 
            // chkEdadDesconocida
            // 
            this.chkEdadDesconocida.AutoSize = true;
            this.chkEdadDesconocida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEdadDesconocida.Location = new System.Drawing.Point(161, 347);
            this.chkEdadDesconocida.Name = "chkEdadDesconocida";
            this.chkEdadDesconocida.Size = new System.Drawing.Size(194, 25);
            this.chkEdadDesconocida.TabIndex = 27;
            this.chkEdadDesconocida.Text = "Edad Desconocida";
            this.chkEdadDesconocida.UseVisualStyleBackColor = true;
            this.chkEdadDesconocida.CheckedChanged += new System.EventHandler(this.chkEdadDesconocida_CheckedChanged);
            // 
            // chk2014
            // 
            this.chk2014.AutoSize = true;
            this.chk2014.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2014.Location = new System.Drawing.Point(158, 134);
            this.chk2014.Name = "chk2014";
            this.chk2014.Size = new System.Drawing.Size(68, 25);
            this.chk2014.TabIndex = 28;
            this.chk2014.Text = "2014";
            this.chk2014.UseVisualStyleBackColor = true;
            // 
            // chk2013
            // 
            this.chk2013.AutoSize = true;
            this.chk2013.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2013.Location = new System.Drawing.Point(158, 108);
            this.chk2013.Name = "chk2013";
            this.chk2013.Size = new System.Drawing.Size(68, 25);
            this.chk2013.TabIndex = 29;
            this.chk2013.Text = "2013";
            this.chk2013.UseVisualStyleBackColor = true;
            // 
            // chk2012
            // 
            this.chk2012.AutoSize = true;
            this.chk2012.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2012.Location = new System.Drawing.Point(158, 82);
            this.chk2012.Name = "chk2012";
            this.chk2012.Size = new System.Drawing.Size(68, 25);
            this.chk2012.TabIndex = 30;
            this.chk2012.Text = "2012";
            this.chk2012.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Años";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConsultar.Location = new System.Drawing.Point(939, 232);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 41);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // mapa
            // 
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = false;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemmory = 5;
            this.mapa.Location = new System.Drawing.Point(442, 279);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(604, 321);
            this.mapa.TabIndex = 33;
            this.mapa.Zoom = 0D;
            // 
            // chkSinEdad
            // 
            this.chkSinEdad.AutoSize = true;
            this.chkSinEdad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinEdad.Location = new System.Drawing.Point(161, 374);
            this.chkSinEdad.Name = "chkSinEdad";
            this.chkSinEdad.Size = new System.Drawing.Size(105, 25);
            this.chkSinEdad.TabIndex = 34;
            this.chkSinEdad.Text = "Sin edad";
            this.chkSinEdad.UseVisualStyleBackColor = true;
            this.chkSinEdad.CheckedChanged += new System.EventHandler(this.chkSinEdad_CheckedChanged);
            // 
            // ctrlDinamica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkSinEdad);
            this.Controls.Add(this.mapa);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chk2012);
            this.Controls.Add(this.chk2013);
            this.Controls.Add(this.chk2014);
            this.Controls.Add(this.chkEdadDesconocida);
            this.Controls.Add(this.lblEdadQuinquenal);
            this.Controls.Add(this.trckEdadQuinquenal);
            this.Controls.Add(this.cbxLesion);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.cbxAfectado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxDistrito);
            this.Controls.Add(this.btnQuitarDistrito);
            this.Controls.Add(this.btnAgregarDistrito);
            this.Controls.Add(this.cbxDistrito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxCanton);
            this.Controls.Add(this.btnQuitarCanton);
            this.Controls.Add(this.btnAgregarCanton);
            this.Controls.Add(this.cbxCanton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxProvincia);
            this.Controls.Add(this.btnQuitarProvincia);
            this.Controls.Add(this.btnAgregarProvincia);
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ctrlDinamica";
            this.Size = new System.Drawing.Size(1080, 620);
            this.Load += new System.EventHandler(this.ctrlDinamica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trckEdadQuinquenal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProvincia;
        private System.Windows.Forms.Button btnAgregarProvincia;
        private System.Windows.Forms.Button btnQuitarProvincia;
        private System.Windows.Forms.ListBox lbxProvincia;
        private System.Windows.Forms.ListBox lbxCanton;
        private System.Windows.Forms.Button btnQuitarCanton;
        private System.Windows.Forms.Button btnAgregarCanton;
        private System.Windows.Forms.ComboBox cbxCanton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxDistrito;
        private System.Windows.Forms.Button btnQuitarDistrito;
        private System.Windows.Forms.Button btnAgregarDistrito;
        private System.Windows.Forms.ComboBox cbxDistrito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxAfectado;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.ComboBox cbxLesion;
        private System.Windows.Forms.TrackBar trckEdadQuinquenal;
        private System.Windows.Forms.Label lblEdadQuinquenal;
        private System.Windows.Forms.CheckBox chkEdadDesconocida;
        private System.Windows.Forms.CheckBox chk2014;
        private System.Windows.Forms.CheckBox chk2013;
        private System.Windows.Forms.CheckBox chk2012;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsultar;
        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.CheckBox chkSinEdad;
    }
}
