
namespace ProSalud
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtCont2 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(16, 482);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Regresar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtUser
            // 
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(19, 321);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(354, 27);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(19, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(354, 27);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(19, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(354, 27);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.Text = "Apellidos";
            this.txtApellido.Enter += new System.EventHandler(this.txtApe_Enter);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApe_KeyPress);
            this.txtApellido.Leave += new System.EventHandler(this.txtApe_Leave);
            // 
            // txtCorreo
            // 
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(19, 283);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(354, 27);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Text = "Correo electrónico";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtCont
            // 
            this.txtCont.ForeColor = System.Drawing.Color.DimGray;
            this.txtCont.Location = new System.Drawing.Point(18, 358);
            this.txtCont.Name = "txtCont";
            this.txtCont.Size = new System.Drawing.Size(354, 27);
            this.txtCont.TabIndex = 6;
            this.txtCont.Text = "Contraseña";
            this.txtCont.Enter += new System.EventHandler(this.txtCont_Enter);
            this.txtCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCont_KeyPress);
            this.txtCont.Leave += new System.EventHandler(this.txtCont_Leave);
            // 
            // txtCont2
            // 
            this.txtCont2.ForeColor = System.Drawing.Color.DimGray;
            this.txtCont2.Location = new System.Drawing.Point(19, 397);
            this.txtCont2.Name = "txtCont2";
            this.txtCont2.Size = new System.Drawing.Size(354, 27);
            this.txtCont2.TabIndex = 7;
            this.txtCont2.Text = "Confirmar contraseña";
            this.txtCont2.Enter += new System.EventHandler(this.txtCont2_Enter);
            this.txtCont2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCont2_KeyPress);
            this.txtCont2.Leave += new System.EventHandler(this.txtCont2_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(253, 475);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 32);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTel
            // 
            this.txtTel.ForeColor = System.Drawing.Color.DimGray;
            this.txtTel.Location = new System.Drawing.Point(19, 168);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(354, 27);
            this.txtTel.TabIndex = 10;
            this.txtTel.Text = "No. Teléfono";
            this.txtTel.Enter += new System.EventHandler(this.txtTel_Enter);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // txtCurp
            // 
            this.txtCurp.ForeColor = System.Drawing.Color.DimGray;
            this.txtCurp.Location = new System.Drawing.Point(19, 205);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(354, 27);
            this.txtCurp.TabIndex = 11;
            this.txtCurp.Text = "CURP";
            this.txtCurp.Enter += new System.EventHandler(this.txtCurp_Enter);
            this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurp_KeyPress);
            this.txtCurp.Leave += new System.EventHandler(this.txtCurp_Leave);
            // 
            // txtDirec
            // 
            this.txtDirec.ForeColor = System.Drawing.Color.DimGray;
            this.txtDirec.Location = new System.Drawing.Point(19, 244);
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(354, 27);
            this.txtDirec.TabIndex = 12;
            this.txtDirec.Text = "Dirección";
            this.txtDirec.Enter += new System.EventHandler(this.txtDirec_Enter);
            this.txtDirec.Leave += new System.EventHandler(this.txtDirec_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 103);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 4, 9, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 2, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 27);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // cmbGen
            // 
            this.cmbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGen.Location = new System.Drawing.Point(94, 136);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(278, 26);
            this.cmbGen.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(16, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 62;
            this.label9.Text = "Genero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProSalud.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 30);
            this.panel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProSalud.Properties.Resources.close_circle_svgrepo_com;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(366, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 30);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRole
            // 
            this.txtRole.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2"});
            this.txtRole.ForeColor = System.Drawing.Color.DimGray;
            this.txtRole.Location = new System.Drawing.Point(19, 430);
            this.txtRole.MaxLength = 10;
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(88, 27);
            this.txtRole.TabIndex = 66;
            this.txtRole.Text = "Role";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 520);
            this.ControlBox = false;
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCont2);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtCont2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRole;
    }
}