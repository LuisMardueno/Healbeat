using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Drawing.Imaging;

namespace ProSalud
{
    public partial class Cita : Form
    {
        // Conexion con SQL
        public SqlConnection conexion;

        public Cita()
        {
            InitializeComponent();

            //No permite hacer visible fechas anteriores
            dtpFecha.MinDate = DateTime.Today.AddDays(2);
        }

        // Parametros heredados 
        public string UsuarioActual;

        private void dtpFecha_CloseUp(object sender, EventArgs e)
        {
            string[] dias = { "12/03", "19/03", "20/03", "26/03", "02/04", "09/04", "10/04", "16/04",
                    "23/04", "30/04", "01/05", "05/05", "07/05", "15/05", "21/05", "28/05", "04/06", "11/06",
                    "18/06", "25/06", "02/07", "09/07", "16/07", "23/07", "30/07", "06/08", "13/08", "20/08",
                    "27/08", "03/09", "10/09", "16/09", "17/09", "24/09", "01/10", "08/10", "15/10", "22/10",
                    "29/10", "02/11", "05/11", "12/11", "19/11", "20/11", "26/11", "03/12", "10/12", "17/12",
                    "24/12", "25/12", "30/12", "01/01", "07/01", "14/01", "21/01", "28/01", "04/02", "05/02",
                    "11/02", "18/02", "25/02", "03/03", "10/03", "17/03"};

            string fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
            foreach (var no in dias)
            {
                if (fecha.StartsWith(no))
                {
                    MessageBox.Show("La fecha [ " + fecha + " ] no está disponible. \nEl laboratorio permanecera cerrado. \nPor favor, selecciona otra fecha", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Restablecemos la fecha
                    dtpFecha.Value = DateTime.Today.AddDays(2);

                    //Foco en el DTP
                    dtpFecha.Focus();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            cmbHora.Enabled = true;
            dtpFecha.Enabled = true;
            txtCodigo.Enabled = false;
            btnOk.Enabled = false;

            // abrir conexion
            conexion.Open();

            //Datos del laboratorio
            SqlCommand comando1 = new SqlCommand($"SELECT * FROM Cita where codigo=@Codigo", conexion);
            comando1.Parameters.AddWithValue("Codigo", txtCodigo.Text);
            SqlDataReader reader1 = comando1.ExecuteReader();
            while (reader1.Read())
            {
                txtSucursal.Text = reader1[1].ToString();
                txtMunicipio.Text = reader1[2].ToString();
                txtEstado.Text = reader1[3].ToString();
                txtFechas.Text = reader1[4].ToString();
                cmbHora.Text = reader1[5].ToString();
                txtEstudio.Text = reader1[6].ToString();
                txtTipo.Text = reader1[7].ToString();
                txtPrecio.Text = reader1[8].ToString();
                txtReserva.Text = reader1[9].ToString();
            }
            reader1.Close();

            // comando para cargar los datos
            SqlCommand comando = new SqlCommand($"SELECT * FROM Usuarios where Usuario=@Usuario", conexion);
            comando.Parameters.AddWithValue("Usuario", UsuarioActual);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                txtNombre.Text = reader[1].ToString();
                txtApellido.Text = reader[2].ToString();
                txtGenero.Text = reader[5].ToString();
                txtEdad.Text = reader[3].ToString();
                DateTime a = Convert.ToDateTime(reader[4].ToString());
                txtFecha.Text = a.ToString("dd-MM-yyyy");
                txtCorreo.Text = reader[9].ToString();
                txtTel.Text = reader[6].ToString();
            }
            reader.Close();

            //Cierra la conexion
            conexion.Close();

            btnAceptar.Enabled = true;
            btnQR.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;

            var valor = ("Datos de la cita: -Código de reserva: " + txtCodigo.Text, "-Clínica: " + txtSucursal.Text, "-Municipio: " + txtMunicipio.Text, "-Estado: " + txtEstado.Text, "-Fecha: " + txtFecha.Text, "-Hora: " + cmbHora.Text, "-Estudio: " + txtTipo.Text, "-Precio: " + txtPrecio.Text);
            
            // abrir conexion
            conexion.Open();

            // Comando para modificar usuarios
            SqlCommand comando = new SqlCommand($"Update Cita set  Fecha=@Fecha, Hora=@Hora where Codigo=@Codigo", conexion);
            comando.Parameters.AddWithValue("Codigo", txtCodigo.Text);

            // Añadir valores
            comando.Parameters.AddWithValue("Fecha", dtpFecha.Text);
            comando.Parameters.AddWithValue("Hora", cmbHora.Text);

            // Ejecutar comando
            comando.ExecuteNonQuery();

            //Cierra la conexion
            conexion.Close();

            QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();
            ASCIIEncoding ASSCII = new ASCIIEncoding();
            var z = QR.CreateQrCode(ASSCII.GetBytes(valor.ToString()), QRCoder.QRCodeGenerator.ECCLevel.H);
            QRCoder.PngByteQRCode png = new QRCoder.PngByteQRCode();
            png.SetQRCodeData(z);
            var arr = png.GetGraphic(10);

            MemoryStream ms = new MemoryStream();
            ms.Write(arr, 0, arr.Length);
            Bitmap b = new Bitmap(ms);
            pbQR.Image = b;

            btnQR.Enabled = true;

            MessageBox.Show("Modificación realizada con exito");

            btnNueva.Enabled = true;
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)pbQR.Image.Clone();

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

        private void btnMenu_Click(object sender, EventArgs e)
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

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtSucursal.Clear();
            txtMunicipio.Clear();
            txtEstado.Clear();
            dtpFecha.MinDate = DateTime.Today;
            cmbHora.Text = " ";
            txtEstudio.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
            txtReserva.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtGenero.Clear();
            txtEdad.Clear();
            txtFecha.Clear();
            txtCorreo.Clear();
            txtTel.Clear();
            txtCodigo.Clear();

            btnAceptar.Enabled = false;
            btnQR.Enabled = false;
            btnNueva.Enabled = false;
            dtpFecha.Enabled = false;
            cmbHora.Enabled = false;

            txtCodigo.Enabled = true;
            btnOk.Enabled = true;

            pbQR.Image = null;
        }
    }
}
