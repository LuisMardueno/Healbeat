using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Drawing.Imaging;
namespace ProSalud
{
    public partial class Ultrasonido : Form
    {
        // Conexion con SQL
        public SqlConnection conexion;

        public Ultrasonido()
        {
            InitializeComponent();

            //No permite hacer visible fechas anteriores
            dtpFecha.MinDate = DateTime.Today.AddDays(1); ;
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
                    dtpFecha.Value = DateTime.Today.AddDays(1);

                    //Foco en el DTP
                    dtpFecha.Focus();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // abrir conexion
            conexion.Open();
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

            // Objeto random para generar codigo del pedido
            Random r = new Random();
            int x = r.Next(10000000, 99999999);

            txtReserva.Text = Convert.ToString(x);

            SqlCommand altas = new SqlCommand("insert into Cita(Sucursal, Municipio, Estado, Fecha, Hora, Estudio, Tipo, Precio, Codigo, Usuario) values(@Sucursal, @Municipio, @Estado, @Fecha, @Hora, @Estudio, @Tipo, @Precio, @Codigo, @Usuario)", conexion);

            // Añadir datos
            altas.Parameters.AddWithValue("Sucursal", cmbClinica.Text);
            altas.Parameters.AddWithValue("Municipio", txtMunicipio.Text);
            altas.Parameters.AddWithValue("Estado", txtEstado.Text);
            altas.Parameters.AddWithValue("Fecha", dtpFecha.Text);
            altas.Parameters.AddWithValue("Hora", cmbHora.Text);
            altas.Parameters.AddWithValue("Estudio", "Ultrasonido");
            altas.Parameters.AddWithValue("Tipo", cmbEstudio.Text);
            altas.Parameters.AddWithValue("Precio", txtPrecio.Text);
            altas.Parameters.AddWithValue("Codigo", txtReserva.Text);
            altas.Parameters.AddWithValue("Usuario", UsuarioActual);

            // Ejecutar el comando
            altas.ExecuteNonQuery();
            conexion.Close();

            var valor = ("Datos de la cita: ", "Código de reserva: " + txtReserva.Text, "Clínica: " + cmbClinica.Text, "Municipio: " + txtMunicipio.Text, "Estado: " + txtEstado.Text, "Fecha: " + txtFecha.Text, "Hora: " + cmbHora.Text, "Estudio: " + cmbEstudio.Text, "Precio: " + txtPrecio.Text);

            // Metodo para geenerar codigo QR
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

            MessageBox.Show("Cita creada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void cmbClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHora.Enabled = true;
            if (cmbClinica.SelectedIndex == 0)
            {
                txtMunicipio.Text = "Tijuana";
                txtEstado.Text = "Baja California Norte";
            }
            else if (cmbClinica.SelectedIndex == 1)
            {
                txtMunicipio.Text = "Mexicali";
                txtEstado.Text = "Baja California Norte";
            }
            else if (cmbClinica.SelectedIndex == 2)
            {
                txtMunicipio.Text = "La paz";
                txtEstado.Text = "Baja California Sur";
            }
            else if (cmbClinica.SelectedIndex == 3)
            {
                txtMunicipio.Text = "Tijuana";
                txtEstado.Text = "Baja California Norte";
            }
        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstudio.Enabled = true;
        }

        private void Ultrasonido_Load(object sender, EventArgs e)
        {
            // Cargar los nombres de peliculas en el combobox
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT Estudio FROM Ultrasonido", conexion);

            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                cmbEstudio.Items.Add(registro["Estudio"].ToString());
            }
            conexion.Close();
        }

        private void cmbEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // abrir conexion
            conexion.Open();

            // Comando para seleccionar los datos de la pelicula
            SqlCommand comando = new SqlCommand($"SELECT *FROM Ultrasonido where Estudio=@Estudio", conexion);
            // Proporcionar nombre
            comando.Parameters.AddWithValue("Estudio", cmbEstudio.SelectedItem);

            // Inicializar lector de datos
            SqlDataReader reader = comando.ExecuteReader();

            // Cargar los datos de la pelicula
            while (reader.Read())
            {
                txtPrecio.Text = reader[2].ToString();
                txtDescrip.Text = reader[3].ToString();
            }

            // Cerrar conexion
            conexion.Close();
        }

        
    }
}
