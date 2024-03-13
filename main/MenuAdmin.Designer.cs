
namespace ProSalud
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.Laboratorio = new System.Windows.Forms.LinkLabel();
            this.Ultrasonido = new System.Windows.Forms.LinkLabel();
            this.Electrocardiograma = new System.Windows.Forms.LinkLabel();
            this.RayosX = new System.Windows.Forms.LinkLabel();
            this.Resonancia = new System.Windows.Forms.LinkLabel();
            this.Tomografia = new System.Windows.Forms.LinkLabel();
            this.Resultados = new System.Windows.Forms.LinkLabel();
            this.Correo = new System.Windows.Forms.LinkLabel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡Bienvenido administrador!";
            // 
            // Laboratorio
            // 
            this.Laboratorio.AutoSize = true;
            this.Laboratorio.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Laboratorio.Location = new System.Drawing.Point(78, 208);
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.Size = new System.Drawing.Size(217, 18);
            this.Laboratorio.TabIndex = 3;
            this.Laboratorio.TabStop = true;
            this.Laboratorio.Text = "Administrar Laboratorio";
            this.Laboratorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Laboratorio_LinkClicked);
            // 
            // Ultrasonido
            // 
            this.Ultrasonido.AutoSize = true;
            this.Ultrasonido.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Ultrasonido.Location = new System.Drawing.Point(78, 245);
            this.Ultrasonido.Name = "Ultrasonido";
            this.Ultrasonido.Size = new System.Drawing.Size(214, 18);
            this.Ultrasonido.TabIndex = 4;
            this.Ultrasonido.TabStop = true;
            this.Ultrasonido.Text = "Administrar Ultrasonido";
            this.Ultrasonido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Ultrasonido_LinkClicked);
            // 
            // Electrocardiograma
            // 
            this.Electrocardiograma.AutoSize = true;
            this.Electrocardiograma.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Electrocardiograma.Location = new System.Drawing.Point(46, 275);
            this.Electrocardiograma.Name = "Electrocardiograma";
            this.Electrocardiograma.Size = new System.Drawing.Size(286, 18);
            this.Electrocardiograma.TabIndex = 5;
            this.Electrocardiograma.TabStop = true;
            this.Electrocardiograma.Text = "Administrar Electrocardiograma";
            this.Electrocardiograma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Electrocardiograma_LinkClicked);
            // 
            // RayosX
            // 
            this.RayosX.AutoSize = true;
            this.RayosX.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.RayosX.Location = new System.Drawing.Point(94, 311);
            this.RayosX.Name = "RayosX";
            this.RayosX.Size = new System.Drawing.Size(185, 18);
            this.RayosX.TabIndex = 6;
            this.RayosX.TabStop = true;
            this.RayosX.Text = "Administrar Rayos X";
            this.RayosX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RayosX_LinkClicked);
            // 
            // Resonancia
            // 
            this.Resonancia.AutoSize = true;
            this.Resonancia.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Resonancia.Location = new System.Drawing.Point(36, 344);
            this.Resonancia.Name = "Resonancia";
            this.Resonancia.Size = new System.Drawing.Size(311, 18);
            this.Resonancia.TabIndex = 7;
            this.Resonancia.TabStop = true;
            this.Resonancia.Text = "Administrar Resonancia magnética";
            this.Resonancia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Resonancia_LinkClicked);
            // 
            // Tomografia
            // 
            this.Tomografia.AutoSize = true;
            this.Tomografia.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Tomografia.Location = new System.Drawing.Point(92, 382);
            this.Tomografia.Name = "Tomografia";
            this.Tomografia.Size = new System.Drawing.Size(216, 18);
            this.Tomografia.TabIndex = 8;
            this.Tomografia.TabStop = true;
            this.Tomografia.Text = "Administrar Tomografía";
            this.Tomografia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Tomografia_LinkClicked);
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Resultados.Location = new System.Drawing.Point(91, 422);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(211, 18);
            this.Resultados.TabIndex = 9;
            this.Resultados.TabStop = true;
            this.Resultados.Text = "Administrar Resultados";
            this.Resultados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Resultados_LinkClicked);
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Correo.Location = new System.Drawing.Point(67, 459);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(268, 18);
            this.Correo.TabIndex = 10;
            this.Correo.TabStop = true;
            this.Correo.Text = "Administrar Correspondencia ";
            this.Correo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Correo_LinkClicked);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(118, 502);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(167, 31);
            this.btnCerrar.TabIndex = 136;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.AutoSize = true;
            this.Usuarios.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.Usuarios.Location = new System.Drawing.Point(88, 169);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(190, 18);
            this.Usuarios.TabIndex = 137;
            this.Usuarios.TabStop = true;
            this.Usuarios.Text = "Administrar Usuarios";
            this.Usuarios.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Usuarios_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProSalud.Properties.Resources.ProSalud;
            this.pictureBox1.Location = new System.Drawing.Point(50, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProSalud.Properties.Resources.Fondo_medico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 540);
            this.ControlBox = false;
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Resultados);
            this.Controls.Add(this.Tomografia);
            this.Controls.Add(this.Resonancia);
            this.Controls.Add(this.RayosX);
            this.Controls.Add(this.Electrocardiograma);
            this.Controls.Add(this.Ultrasonido);
            this.Controls.Add(this.Laboratorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú del Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Laboratorio;
        private System.Windows.Forms.LinkLabel Ultrasonido;
        private System.Windows.Forms.LinkLabel Electrocardiograma;
        private System.Windows.Forms.LinkLabel RayosX;
        private System.Windows.Forms.LinkLabel Resonancia;
        private System.Windows.Forms.LinkLabel Tomografia;
        private System.Windows.Forms.LinkLabel Resultados;
        private System.Windows.Forms.LinkLabel Correo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.LinkLabel Usuarios;
    }
}