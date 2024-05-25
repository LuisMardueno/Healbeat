using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProSalud
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        // Conexion con SQL
        public SqlConnection conexion;

        // Boton para insertar un usuario
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Comando para insertar datos
            SqlCommand altas = new SqlCommand("INSERT INTO users (nombre, apellido, fecha_nacimiento, genero, tel, curp, direccion, correo, [user], [password], [role]) values( @nombre, @apellido, @fecha_nacimiento, @genero, @tel, @curp, @direccion, @correo, @usuario, @user_password, @user_role)", conexion);

            // Añadir datos
            altas.Parameters.AddWithValue("@usuario", txtUser.Text);
            altas.Parameters.AddWithValue("@nombre", txtNombre.Text);
            altas.Parameters.AddWithValue("@apellido", txtApellido.Text);
            altas.Parameters.AddWithValue("@fecha_nacimiento", dateTimePicker1.Text);
            altas.Parameters.AddWithValue("@genero", cmbGen.Text);
            altas.Parameters.AddWithValue("@tel", txtTel.Text);
            altas.Parameters.AddWithValue("@curp", txtCurp.Text);
            altas.Parameters.AddWithValue("@direccion", txtDirec.Text);
            altas.Parameters.AddWithValue("@correo", txtCorreo.Text);
            altas.Parameters.AddWithValue("@user_password", txtCont.Text);
            altas.Parameters.AddWithValue("@user_role", txtCont.Text);

            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(cmbGen.Text) || String.IsNullOrEmpty(txtTel.Text) || String.IsNullOrEmpty(txtCurp.Text) || String.IsNullOrEmpty(txtDirec.Text) || String.IsNullOrEmpty(txtCorreo.Text) || String.IsNullOrEmpty(txtCont.Text))
            {
                MessageBox.Show("Falta información", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Condicion para confirmar contraseñas
                if (txtCont.Text == txtCont2.Text)
                {
                    // Ejecutar el comnado
                    altas.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Usuario creado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Inicalizar el formulario
                    Form1 formulario = new Form1();
                    formulario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Cerrar conexion
                conexion.Close();
                this.Close();
            }
            
        }

        // Eventos para la salida o entrada a los cuadros de texto y para ingresar datos correctos
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Clear();
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtApe_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellidos")
            {
                txtApellido.Clear();
                txtApellido.ForeColor = Color.Black;
            }
        }


        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtTel.Text == "No. Teléfono")
            {
                txtTel.Clear();
                txtTel.ForeColor = Color.Black;
            }
        }

        private void txtCurp_Enter(object sender, EventArgs e)
        {
            if (txtCurp.Text == "CURP")
            {
                txtCurp.Clear();
                txtCurp.ForeColor = Color.Black;
            }
        }

        private void txtDirec_Enter(object sender, EventArgs e)
        {
            if (txtDirec.Text == "Dirección")
            {
                txtDirec.Clear();
                txtDirec.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo electrónico")
            {
                txtCorreo.Clear();
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Clear();
                txtUser.ForeColor = Color.Black;
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

        private void txtCont2_Enter(object sender, EventArgs e)
        {
            if (txtCont2.Text == "Confirmar contraseña")
            {
                txtCont2.Clear();
                txtCont2.ForeColor = Color.Black;
                txtCont2.UseSystemPasswordChar = true;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
            }
        }

        private void txtApe_Leave(object sender, EventArgs e)
        {
            if(txtApellido.Text == "")
            {
                txtApellido.Text = "Apellidos";
                txtApellido.ForeColor = Color.DimGray;
            }
        }


        private void txtTel_Leave(object sender, EventArgs e)
        {
            if(txtTel.Text == "")
            {
                txtTel.Text = "No. Teléfono";
                txtTel.ForeColor = Color.DimGray;
            }
        }

        private void txtCurp_Leave(object sender, EventArgs e)
        {
            if(txtCurp.Text == "")
            {
                txtCurp.Text = "CURP";
                txtCurp.ForeColor = Color.DimGray;
            }
        }

        private void txtDirec_Leave(object sender, EventArgs e)
        {
            if (txtDirec.Text == "")
            {
                txtDirec.Text = "Dirección";
                txtDirec.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo electrónico";
                txtCorreo.ForeColor = Color.DimGray;
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

        private void txtCont_Leave(object sender, EventArgs e)
        {
            if (txtCont.Text == "")
            {
                txtCont.Text = "Contraseña";
                txtCont.ForeColor = Color.DimGray;
                txtCont.UseSystemPasswordChar = false;
            }
        }

        private void txtCont2_Leave(object sender, EventArgs e)
        {
            if (txtCont2.Text == "")
            {
                txtCont2.Text = "Confirmar contraseña";
                txtCont2.ForeColor = Color.DimGray;
                txtCont2.UseSystemPasswordChar = false;
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
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


        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar valores numéricos",
                "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            int limite = 18;
            if (txtCurp.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtCurp.Text.Trim().Length > limite)
            {
                txtCurp.Clear();
                MessageBox.Show(txtCurp, $"No puede superar el maximo de {limite} digitos","Alerta",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCorreo.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar valores numéricos",
                "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCont2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permite ingresar valores numéricos",
                "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Link label para regresar al form principal
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inicializar el formulario
            Form1 formulario = new Form1();
            formulario.Show();
            this.Close();
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
