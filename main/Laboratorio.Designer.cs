
namespace ProSalud
{
    partial class Laboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorio));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClinica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnQR = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sucursal";
            // 
            // cmbClinica
            // 
            this.cmbClinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClinica.FormattingEnabled = true;
            this.cmbClinica.Items.AddRange(new object[] {
            "Otay",
            "Plaza Juventud",
            "Pueblo Nuevo",
            "Tomas Aquino"});
            this.cmbClinica.Location = new System.Drawing.Point(124, 35);
            this.cmbClinica.Name = "cmbClinica";
            this.cmbClinica.Size = new System.Drawing.Size(208, 26);
            this.cmbClinica.TabIndex = 4;
            this.cmbClinica.SelectedIndexChanged += new System.EventHandler(this.cmbClinica_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(57, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(124, 144);
            this.dtpFecha.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(208, 27);
            this.dtpFecha.TabIndex = 15;
            this.dtpFecha.Value = new System.DateTime(2023, 3, 3, 0, 0, 0, 0);
            this.dtpFecha.CloseUp += new System.EventHandler(this.dtpFecha_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Realiza la toma de muestra en un \r\nhorario de 6:00am a 12:00pm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(26, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de \r\nestudio";
            // 
            // cmbEstudio
            // 
            this.cmbEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudio.Enabled = false;
            this.cmbEstudio.FormattingEnabled = true;
            this.cmbEstudio.Location = new System.Drawing.Point(124, 303);
            this.cmbEstudio.Name = "cmbEstudio";
            this.cmbEstudio.Size = new System.Drawing.Size(232, 26);
            this.cmbEstudio.TabIndex = 18;
            this.cmbEstudio.SelectedIndexChanged += new System.EventHandler(this.cmbEstudio_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(699, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Datos personales";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(703, 130);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 27);
            this.txtNombre.TabIndex = 54;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Enabled = false;
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(703, 183);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(230, 27);
            this.txtApellido.TabIndex = 55;
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Enabled = false;
            this.txtFecha.ForeColor = System.Drawing.Color.DimGray;
            this.txtFecha.Location = new System.Drawing.Point(702, 296);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(230, 27);
            this.txtFecha.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(703, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(703, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(698, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 18);
            this.label8.TabIndex = 59;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(702, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 18);
            this.label10.TabIndex = 62;
            this.label10.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(702, 404);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(230, 27);
            this.txtCorreo.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 66;
            this.label12.Text = "Hora";
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.Enabled = false;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "6:00 am",
            "6:15 am",
            "6:30 am",
            "6:45 am",
            "07:00 am",
            "07:15 am",
            "07:30 am",
            "07:45 am",
            "08:00 am",
            "08:15 am",
            "08:30 am",
            "08:45 am",
            "09:00 am",
            "09:15 am",
            "09:30 am",
            "09:45 am",
            "10:00 am",
            "10:15 am",
            "10:30 am",
            "10:45 am",
            "11:00 am",
            "11:15 am",
            "11:30 am",
            "11:45 am",
            "12:00 pm"});
            this.cmbHora.Location = new System.Drawing.Point(124, 224);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(208, 26);
            this.cmbHora.TabIndex = 67;
            this.cmbHora.SelectedIndexChanged += new System.EventHandler(this.cmbHora_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(392, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 68;
            this.label13.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Enabled = false;
            this.txtPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecio.Location = new System.Drawing.Point(464, 103);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(208, 27);
            this.txtPrecio.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(363, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 36);
            this.label14.TabIndex = 70;
            this.label14.Text = "Código de \r\nla reserva";
            // 
            // txtReserva
            // 
            this.txtReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReserva.Enabled = false;
            this.txtReserva.ForeColor = System.Drawing.Color.DimGray;
            this.txtReserva.Location = new System.Drawing.Point(477, 206);
            this.txtReserva.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(195, 27);
            this.txtReserva.TabIndex = 71;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(464, 149);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(208, 35);
            this.btnAceptar.TabIndex = 72;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(121, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 32);
            this.label15.TabIndex = 73;
            this.label15.Text = "Llegar 10 minutos antes de la \r\nhora seleccionada.";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(377, 456);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(161, 28);
            this.btnMenu.TabIndex = 74;
            this.btnMenu.Text = "Volver al menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(559, 461);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 18);
            this.linkLabel1.TabIndex = 75;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar sesión";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQR.Enabled = false;
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQR.Location = new System.Drawing.Point(504, 389);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(125, 35);
            this.btnQR.TabIndex = 94;
            this.btnQR.Text = "Guardar QR";
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(698, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Genero";
            // 
            // txtGenero
            // 
            this.txtGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenero.Enabled = false;
            this.txtGenero.ForeColor = System.Drawing.Color.DimGray;
            this.txtGenero.Location = new System.Drawing.Point(702, 349);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(230, 27);
            this.txtGenero.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(26, 332);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 18);
            this.label16.TabIndex = 96;
            this.label16.Text = "Descripción:";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Enabled = false;
            this.txtDescrip.Location = new System.Drawing.Point(30, 353);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(326, 131);
            this.txtDescrip.TabIndex = 98;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(703, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 18);
            this.label17.TabIndex = 99;
            this.label17.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Enabled = false;
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.Location = new System.Drawing.Point(703, 237);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(230, 27);
            this.txtEdad.TabIndex = 100;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Location = new System.Drawing.Point(31, 112);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(68, 18);
            this.Estado.TabIndex = 102;
            this.Estado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Enabled = false;
            this.txtEstado.ForeColor = System.Drawing.Color.DimGray;
            this.txtEstado.Location = new System.Drawing.Point(124, 109);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(208, 27);
            this.txtEstado.TabIndex = 101;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(31, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 18);
            this.label19.TabIndex = 104;
            this.label19.Text = "Municipio";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMunicipio.Enabled = false;
            this.txtMunicipio.ForeColor = System.Drawing.Color.DimGray;
            this.txtMunicipio.Location = new System.Drawing.Point(124, 74);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(208, 27);
            this.txtMunicipio.TabIndex = 103;
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.Transparent;
            this.pbQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbQR.Location = new System.Drawing.Point(477, 241);
            this.pbQR.Margin = new System.Windows.Forms.Padding(2);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(195, 143);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQR.TabIndex = 93;
            this.pbQR.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProSalud.Properties.Resources.ProSalud;
            this.pictureBox1.Location = new System.Drawing.Point(377, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProSalud.Properties.Resources.Fondo_medico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 490);
            this.ControlBox = false;
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEstudio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClinica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Laboratorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClinica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstudio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMunicipio;
    }
}