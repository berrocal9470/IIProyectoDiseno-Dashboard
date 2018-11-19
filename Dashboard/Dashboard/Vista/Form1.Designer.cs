namespace Dashboard
{
    partial class Form1
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlConsultaSeleccionada = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLibre = new System.Windows.Forms.Button();
            this.btnIndicador = new System.Windows.Forms.Button();
            this.btnDinamica = new System.Windows.Forms.Button();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.pnlVistas = new System.Windows.Forms.Panel();
            this.ctrlLibre1 = new Dashboard.Vista.ctrlLibre();
            this.ctrlIndicador1 = new Dashboard.Vista.ctrlIndicador();
            this.ctrlDinamica1 = new Dashboard.Vista.ctrlDinamica();
            this.dragControl1 = new Dashboard.Vista.DragControl();
            this.pnlMenu.SuspendLayout();
            this.pnlVistas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlMenu.Controls.Add(this.pnlConsultaSeleccionada);
            this.pnlMenu.Controls.Add(this.btnMinimizar);
            this.pnlMenu.Controls.Add(this.btnMaximizar);
            this.pnlMenu.Controls.Add(this.btnSalir);
            this.pnlMenu.Controls.Add(this.btnLibre);
            this.pnlMenu.Controls.Add(this.btnIndicador);
            this.pnlMenu.Controls.Add(this.btnDinamica);
            this.pnlMenu.Controls.Add(this.pnlImagen);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1080, 104);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlConsultaSeleccionada
            // 
            this.pnlConsultaSeleccionada.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlConsultaSeleccionada.Location = new System.Drawing.Point(177, 93);
            this.pnlConsultaSeleccionada.Name = "pnlConsultaSeleccionada";
            this.pnlConsultaSeleccionada.Size = new System.Drawing.Size(154, 7);
            this.pnlConsultaSeleccionada.TabIndex = 7;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(918, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(54, 104);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(972, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(54, 104);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.Text = "□";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1026, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(54, 104);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLibre
            // 
            this.btnLibre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibre.Location = new System.Drawing.Point(497, 0);
            this.btnLibre.Name = "btnLibre";
            this.btnLibre.Size = new System.Drawing.Size(154, 100);
            this.btnLibre.TabIndex = 3;
            this.btnLibre.Text = "Consulta Libre";
            this.btnLibre.UseVisualStyleBackColor = true;
            this.btnLibre.Click += new System.EventHandler(this.btnLibre_Click);
            // 
            // btnIndicador
            // 
            this.btnIndicador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIndicador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndicador.Location = new System.Drawing.Point(337, 0);
            this.btnIndicador.Name = "btnIndicador";
            this.btnIndicador.Size = new System.Drawing.Size(154, 100);
            this.btnIndicador.TabIndex = 2;
            this.btnIndicador.Text = "Consulta Indicador";
            this.btnIndicador.UseVisualStyleBackColor = true;
            this.btnIndicador.Click += new System.EventHandler(this.btnIndicador_Click);
            // 
            // btnDinamica
            // 
            this.btnDinamica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDinamica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDinamica.Location = new System.Drawing.Point(177, 0);
            this.btnDinamica.Name = "btnDinamica";
            this.btnDinamica.Size = new System.Drawing.Size(154, 100);
            this.btnDinamica.TabIndex = 1;
            this.btnDinamica.Text = "Consulta Dinámica";
            this.btnDinamica.UseVisualStyleBackColor = true;
            this.btnDinamica.Click += new System.EventHandler(this.btnDinamica_Click);
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(132, 104);
            this.pnlImagen.TabIndex = 0;
            // 
            // pnlVistas
            // 
            this.pnlVistas.Controls.Add(this.ctrlLibre1);
            this.pnlVistas.Controls.Add(this.ctrlIndicador1);
            this.pnlVistas.Controls.Add(this.ctrlDinamica1);
            this.pnlVistas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlVistas.Location = new System.Drawing.Point(0, 100);
            this.pnlVistas.Name = "pnlVistas";
            this.pnlVistas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlVistas.Size = new System.Drawing.Size(1080, 620);
            this.pnlVistas.TabIndex = 1;
            // 
            // ctrlLibre1
            // 
            this.ctrlLibre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlLibre1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlLibre1.Location = new System.Drawing.Point(0, 0);
            this.ctrlLibre1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlLibre1.Name = "ctrlLibre1";
            this.ctrlLibre1.Size = new System.Drawing.Size(1080, 620);
            this.ctrlLibre1.TabIndex = 2;
            // 
            // ctrlIndicador1
            // 
            this.ctrlIndicador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlIndicador1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlIndicador1.Location = new System.Drawing.Point(0, 0);
            this.ctrlIndicador1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlIndicador1.Name = "ctrlIndicador1";
            this.ctrlIndicador1.Size = new System.Drawing.Size(1080, 620);
            this.ctrlIndicador1.TabIndex = 1;
            // 
            // ctrlDinamica1
            // 
            this.ctrlDinamica1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDinamica1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDinamica1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDinamica1.Margin = new System.Windows.Forms.Padding(6);
            this.ctrlDinamica1.Name = "ctrlDinamica1";
            this.ctrlDinamica1.Size = new System.Drawing.Size(1080, 620);
            this.ctrlDinamica1.TabIndex = 0;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnlMenu;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pnlVistas);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlVistas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLibre;
        private System.Windows.Forms.Button btnIndicador;
        private System.Windows.Forms.Button btnDinamica;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Button btnSalir;
        private Vista.DragControl dragControl1;
        private System.Windows.Forms.Panel pnlVistas;
        private Vista.ctrlLibre ctrlLibre1;
        private Vista.ctrlIndicador ctrlIndicador1;
        private Vista.ctrlDinamica ctrlDinamica1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel pnlConsultaSeleccionada;
    }
}

