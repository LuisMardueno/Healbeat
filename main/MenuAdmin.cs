using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProSalud
{
    public partial class MenuAdmin : Form
    {
        // Parametros heredados 
        public string UsuarioActual;

        public MenuAdmin()
        {
            InitializeComponent();
        }

        // Conexion con SQL
        public SqlConnection conexion;

        private void Usuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmUsuarios formulario = new AdmUsuarios();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }
        private void Laboratorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmLaboratorio formulario = new AdmLaboratorio();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void Ultrasonido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmUltrasonido formulario = new AdmUltrasonido();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void Electrocardiograma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmElectro formulario = new AdmElectro();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void RayosX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmRayosX formulario = new AdmRayosX();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void Resonancia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmResonancia formulario = new AdmResonancia();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void Tomografia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmTomografia formulario = new AdmTomografia();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void Resultados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Resultados formulario = new Resultados();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void Correo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmCorrespondencia formulario = new AdmCorrespondencia();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Inicalizar el formulario
            Form1 formulario = new Form1();
            formulario.Show();
            this.Close();
        }

    }
}
