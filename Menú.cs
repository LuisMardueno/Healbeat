using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProSalud
{

    public partial class Menú : Form
    {
        public Point mouseLocation;

        public Menú()
        {
            InitializeComponent();
        }
        // Parametros heredados 
        public string UsuarioActual;

        // Conexion con SQL
        public SqlConnection conexion;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (cmbServicios.SelectedIndex == 0)
            {
                // Inicializar el formulario y enviar parametros
                Laboratorio formulario = new Laboratorio();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
            else if (cmbServicios.SelectedIndex == 1)
            {
                // Inicializar el formulario y enviar parametros
                Ultrasonido formulario = new Ultrasonido();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
            else if (cmbServicios.SelectedIndex == 2)
            {
                // Inicializar el formulario y enviar parametros
                Electrocardiograma formulario = new Electrocardiograma();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
            else if (cmbServicios.SelectedIndex == 3)
            {
                // Inicializar el formulario y enviar parametros
                RayosX formulario = new RayosX();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
            else if (cmbServicios.SelectedIndex == 4)
            {
                // Inicializar el formulario y enviar parametros
                Resonancia formulario = new Resonancia();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
            else if (cmbServicios.SelectedIndex == 5)
            {
                // Inicializar el formulario y enviar parametros
                Tomografia formulario = new Tomografia();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
            else if (cmbPaciente.SelectedIndex == 0)
            {
                Cita formulario = new Cita();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
            else //modificar
            {
                Consulta formulario = new Consulta();
                formulario.UsuarioActual = UsuarioActual;
                formulario.conexion = conexion;
                formulario.Show();
                this.Hide();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inicalizar el formulario
            Form1 formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void cmbConocer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServicios.Enabled = false;
            cmbPaciente.Enabled = false;
            btnCancelar.Visible = true;
        }

        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServicios.Enabled = false;
            cmbPaciente.Enabled = false;
            btnCancelar.Visible = true;
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServicios.Enabled = false;
            cmbPaciente.Enabled = false;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbPaciente.SelectedItem = null;
            cmbServicios.SelectedItem = null;
            cmbPaciente.Enabled = true;
            cmbServicios.Enabled = true;
            btnCancelar.Visible = false;
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quieres Cerrar el programa?", "Alerta!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
