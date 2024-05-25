using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;
using System.Diagnostics;

namespace ProSalud
{

    public partial class Form1 : Form
    {



        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
            txtUser.BackColor = this.BackColor;
        }
        // Parametros para heredar 
        public string UsuarioActual;

        // Establecer conexion con SQL SERVER
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-OA32ALC;Initial Catalog=ProSalud;Integrated Security=True");

      


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

 



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quieres Cerrar el programa?", "Alerta!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 15;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            this.Region = new Region(path);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            // Inicializar el formulario y enviar parametros
            Registro formulario = new Registro();
            formulario.conexion = conexion;
            formulario.Show();
            this.Hide();
        }

        private void roundedButton1_Click(object sender, EventArgs e)

        {
            try
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand("SELECT [user], [password], role FROM users WHERE [user] = @vusuario AND [password] = @vcontraseña", conexion);
                comando.Parameters.AddWithValue("@vusuario", txtUser.Text);
                comando.Parameters.AddWithValue("@vcontraseña", txtCont.Text);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    string role = lector["role"].ToString();
                    MessageBox.Show(role, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    int isAdmin = 0;
                    if (role != DBNull.Value.ToString())
                    {
                        // Assuming role is a string, convert it to an integer if necessary
                        if (int.TryParse(role, out isAdmin))
                        {
                            // Successful conversion
                        }
                        else
                        {
                            // Handle conversion failure if necessary
                        }
                    }

                    lector.Close();
                    conexion.Close();

                    if (isAdmin == 1)
                    {
                        // User is an admin
                        MenuAdmin formulario = new MenuAdmin();
                        formulario.conexion = conexion;
                        formulario.UsuarioActual = txtUser.Text;
                        formulario.Show();
                    }
                    else if (isAdmin == 2)
                    {
                        // User is a technician
                        AdmResultados formulario = new AdmResultados();
                        formulario.conexion = conexion;
                        formulario.UsuarioActual = txtUser.Text;
                        formulario.Show();
                    }
                    else
                    {
                        // Regular user
                        Menú formulario = new Menú();
                        formulario.conexion = conexion;
                        formulario.UsuarioActual = txtUser.Text;
                        formulario.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lector.Close();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }



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
    }
}
