using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProSalud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Parametros para heredar 
        public string UsuarioActual;

        // Establecer conexion con SQL SERVER
        SqlConnection conexion = new SqlConnection("Data Source=ESTEVEZ;Initial Catalog=ProSalud;Integrated Security=True");

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Abrir la conexion
            conexion.Open();
            // Comando para seleccionar el Usuario y su contraseña
            SqlCommand comando = new SqlCommand("SELECT Usuario, Contraseña FROM USUARIOS WHERE Usuario = @vusuario AND Contraseña = @vcontraseña", conexion);

            // Añadir valores al comando
            comando.Parameters.AddWithValue("@vusuario", txtUser.Text);
            comando.Parameters.AddWithValue("@vcontraseña", txtCont.Text);

            // Lector de datos sql
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                // Cerrar conexion
                conexion.Close();

                //Ingresar como modo "Admin" si se cumple con la condicion
               if (txtUser.Text == "Admin" && txtCont.Text == "123")
               {
                     //Inicializar el formulario y enviar parametros
                    MenuAdmin formulario = new MenuAdmin();
                    formulario.conexion = conexion;
                    formulario.UsuarioActual = txtUser.Text;
                    formulario.Show();
               }
               else if (txtUser.Text == "Tecnico" && txtCont.Text == "123")
               {
                    AdmResultados formulario = new AdmResultados();
                    formulario.conexion = conexion;
                    formulario.UsuarioActual = txtUser.Text;
                    formulario.Show();
               }
               else
               {
                    Menú formulario = new Menú();
                    formulario.conexion = conexion;
                    formulario.UsuarioActual = txtUser.Text;
                    formulario.Show();
               }
                this.Hide();
            }
            else
            {
                // Cerrar conexion
                conexion.Close();
                // Alerta
                MessageBox.Show("Usuario o contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLblRegristro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inicializar el formulario y enviar parametros
            Registro formulario = new Registro();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        // Eventos para la salida o entrada a los cuadros de texto
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Clear();
                txtUser.ForeColor = Color.Black;
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtCont_Enter(object sender, EventArgs e)
        {
            if (txtCont.Text == "Contraseña")
            {
                txtCont.Clear();
                txtCont.ForeColor = Color.Black;
                txtCont.UseSystemPasswordChar = true;
            }
        }
        private void txtCont_Leave(object sender, EventArgs e)
        {
            if (txtCont.Text == "")
            {
                txtCont.Text = "Contraseña";
                txtCont.ForeColor = Color.DimGray;
                txtCont.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
