using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ProSalud
{
    public partial class Consulta : Form
    {
        // Conexion con SQL
        public SqlConnection conexion;

        public Consulta()
        {
            InitializeComponent();
        }

        // Parametros heredados 
        public string UsuarioActual;

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnNueva.Enabled = true;
            btnOk.Enabled = false;
            btnDescarga.Enabled = true;
            txtReserva.Enabled = false;

            // abrir conexion
            conexion.Open();

            //Datos del laboratorio
            SqlCommand comando = new SqlCommand($"SELECT * FROM Cita where codigo=@Codigo", conexion);
            comando.Parameters.AddWithValue("Codigo", txtReserva.Text);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                txtFecha.Text = reader[4].ToString();
                txtHora.Text = reader[5].ToString();
                txtEstudio.Text = reader[6].ToString();
                txtTipo.Text = reader[7].ToString();
                
            }
            reader.Close();

            //DFatos del usuario
            SqlCommand comando1 = new SqlCommand($"SELECT * FROM Usuarios where Usuario=@Usuario", conexion);
            comando1.Parameters.AddWithValue("Usuario", UsuarioActual);
            SqlDataReader reader1 = comando1.ExecuteReader();

            while (reader1.Read())
            {
                txtNombre.Text = reader1[1].ToString();
                txtApellido.Text = reader1[2].ToString();
                txtGenero.Text = reader1[5].ToString();
                txtEdad.Text = reader1[3].ToString();
            }
            reader1.Close();

            //Datos de las citas
            SqlCommand comando2 = new SqlCommand($"SELECT * FROM Resultado where codigo=@Codigo", conexion);
            comando2.Parameters.AddWithValue("Codigo", txtReserva.Text);
            SqlDataReader reader2 = comando2.ExecuteReader();
            while (reader2.Read())
            {
                txtDescrip.Text = reader2[4].ToString();
                MemoryStream ms = new MemoryStream(reader2.GetSqlBytes(6).Buffer);
                ptbResultados.Image = Image.FromStream(ms);

            }
            reader.Close();

            //Cierra la conexion
            conexion.Close();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            btnNueva.Enabled = false;
            btnOk.Enabled = true;
            txtReserva.Enabled = true;
            btnDescarga.Enabled = false;

            txtFecha.Clear();
            txtHora.Clear();
            txtEstudio.Clear();
            txtTipo.Clear();
            txtReserva.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtGenero.Clear();
            txtEdad.Clear();
            txtReserva.Clear();
            txtDescrip.Clear();

            ptbResultados.Image = null;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Inicializar el formulario y enviar parametros
            Menú formulario = new Menú();
            formulario.UsuarioActual = UsuarioActual;
            formulario.conexion = conexion;
            formulario.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)ptbResultados.Image.Clone();

            SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
            CajaDeDiaologoGuardar.AddExtension = true;
            CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDeDiaologoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
            {
                imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }
    }
}
