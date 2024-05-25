using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProSalud
{
    public partial class Contáctanos : Form
    {
        // Parametros heredados 
        public string UsuarioActual;

        public Contáctanos()
        {
            InitializeComponent();
        }
        // Conexion con SQL
        public SqlConnection conexion;

        private void Contáctanos_Load(object sender, EventArgs e)
        {
            // Verifica que UsuarioActual no sea nulo o vacío antes de usarlo
            if (string.IsNullOrEmpty(UsuarioActual))
            {
                return;
            }

            // Crea una nueva conexión en lugar de usar la conexión global
            using (SqlConnection conexion = new SqlConnection("Data Source=ESTEVEZ;Initial Catalog=ProSalud;Integrated Security=True"))
            {
                // Abre la conexión
                conexion.Open();

                SqlCommand comando = new SqlCommand("SELECT * FROM Usuarios WHERE Usuario = @Usuario", conexion);
                comando.Parameters.AddWithValue("@Usuario", UsuarioActual);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    // Lee los resultados solo si hay datos
                    txtCorreo.Text = reader[9].ToString();
                }
                reader.Close();
            } // La conexión se cerrará automáticamente al salir del bloque using
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Comando para insertar datos
            SqlCommand altas = new SqlCommand("insert into Contacto(Estado, Municipio, Sucursal, Asunto, Correo, Comentario) values( @Estado, @Municipio, @Sucursal, @Asunto, @Correo, @Comentario)", conexion);

            // Añadir datos
            altas.Parameters.AddWithValue("Estado", cmbEstado.Text);
            altas.Parameters.AddWithValue("Municipio", cmbMunicipio.Text);
            altas.Parameters.AddWithValue("Sucursal", cmbSucursal.Text);
            altas.Parameters.AddWithValue("Asunto", txtAsunto.Text);
            altas.Parameters.AddWithValue("Correo", txtCorreo.Text);
            altas.Parameters.AddWithValue("Comentario", txtComentario.Text);

            // Condicion para confirmar contraseñas
            if (cmbEstado.Text == "Estado" || cmbMunicipio.Text == "Municipio" || cmbSucursal.Text == "Sucursal" || txtAsunto.Text == "Asunto" || txtCorreo.Text == "Correo electrónico" || txtComentario.Text == "Escribe aquí tus comentarios")
            {
                MessageBox.Show("Falta información por ingresar. Intentalo nuevamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                 try
                 {
                    // smtp.Send(correo);
                     MessageBox.Show("Mensaje enviado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 catch
                 {
                     MessageBox.Show("Mensaje no enviado con exito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                // Ejecutar el comnado
                altas.ExecuteNonQuery();
                conexion.Close();
                // Inicalizar el formulario
                Menú formulario = new Menú();
                formulario.Show();
                this.Close();
            }
            
            // Cerrar conexion
            conexion.Close();
            //this.Close();
        }
        
        // Eventos para la salida o entrada a los cuadros de texto y para ingresar datos correctos
        private void txtAsunto_Enter(object sender, EventArgs e)
        {
            if (txtAsunto.Text == "Asunto")
            {
                txtAsunto.Clear();
                txtAsunto.ForeColor = Color.Black;
            }
        }

        private void txtComentario_Enter(object sender, EventArgs e)
        {
            if (txtComentario.Text == "Escribe aquí tus comentarios")
            {
                txtComentario.Clear();
                txtComentario.ForeColor = Color.Black;
            }
        }
        private void txtAsunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite letras
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar
            <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                //Permite el espacio entre palabras
                if (Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se permite ingresar letras", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite letras
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar
            <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                //Permite el espacio entre palabras
                if (Char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se permite ingresar letras", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtAsunto_Leave(object sender, EventArgs e)
        {
            if (txtAsunto.Text == "")
            {
                txtAsunto.Text = "Asunto";
                txtAsunto.ForeColor = Color.DimGray;
            }
        }

        private void txtComentario_Leave(object sender, EventArgs e)
        {
            if (txtComentario.Text == "")
            {
                txtComentario.Text = "Escribe aquí tus comentarios";
                txtComentario.ForeColor = Color.DimGray;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inicalizar el formulario
            Menú formulario = new Menú();
            formulario.conexion = conexion;
            formulario.Show();
            this.Close();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex == 0)
            {
                cmbMunicipio.Items.Add("Mexicali");
                cmbMunicipio.Items.Add("Tijuana");
            }
            else
            {
                cmbMunicipio.Items.Add("La Paz");
            }
            cmbEstado.Enabled = false;
            btnCancelar.Visible = true;
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMunicipio.Text == "Mexicali")
            {
                cmbSucursal.Items.Add("Plaza Juventud");
                cmbMunicipio.Enabled = false;
            }
            else if (cmbMunicipio.Text == "Tijuana")
            {
                cmbSucursal.Items.Add("Otay");
                cmbSucursal.Items.Add("Tomas Aquino");
                cmbMunicipio.Enabled = false;
            }
            else
            {
                cmbSucursal.Items.Add("Pueblo Nuevo");
                cmbMunicipio.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbEstado.SelectedItem = null;
            cmbMunicipio.SelectedItem = null;
            cmbSucursal.SelectedItem = null;
            cmbEstado.Enabled = true;
            cmbMunicipio.Enabled = true;
            cmbSucursal.Enabled = true;
            cmbMunicipio.Items.Clear();
            cmbSucursal.Items.Clear();
            btnCancelar.Visible = false;
        }
    }
}
