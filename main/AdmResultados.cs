using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net.Mime;

namespace ProSalud
{
    public partial class AdmResultados : Form
    {
        // Conexion con SQL
        public SqlConnection conexion;

        public AdmResultados()
        {
            InitializeComponent();
        }

        // Parametros heredados 
        public string UsuarioActual;

        public string correo;

        private void AdmResultados_Load(object sender, EventArgs e)
        {
            // abrir conexion
            conexion.Open();
            //Datos del tecnico
            SqlCommand coman = new SqlCommand($"SELECT * FROM Usuarios where Usuario=@Usuario", conexion);
            coman.Parameters.AddWithValue("Usuario", UsuarioActual);
            SqlDataReader reader1 = coman.ExecuteReader();

            while (reader1.Read())
            {
                txtName.Text = reader1[1].ToString();
                txtApe.Text = reader1[2].ToString();
            }
            reader1.Close();

            //Cerar conexion
            conexion.Close();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnEnvia.Enabled = true;
            btnEnviar.Enabled = true;
            txtProfe.Enabled = true;
            txtDescrip.Enabled = true;
            btnOk.Enabled = false;
            txtReserva.Enabled = false;

            // abrir conexion
            conexion.Open();

            //Datos de las citas
            string db = $"SELECT* FROM CitaConsulta ({txtReserva.Text})";
            SqlCommand comando = new SqlCommand(db, conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                txtNombre.Text = reader[0].ToString();
                txtApellido.Text = reader[1].ToString();
                txtEdad.Text = reader[2].ToString();
                txtGenero.Text = reader[3].ToString();
                txtFecha.Text = reader[4].ToString();
                txtHora.Text = reader[5].ToString();
                txtEstudio.Text = reader[6].ToString();
                txtTipo.Text = reader[7].ToString();
            }
            //Cerar conexion
            conexion.Close();

            // abrir conexion
            conexion.Open();

            //Datos usuario
            SqlCommand comando2 = new SqlCommand($"SELECT * FROM Usuarios where Nombre=@Nombre", conexion);
            comando2.Parameters.AddWithValue("Nombre", txtNombre.Text);
            SqlDataReader reader2 = comando2.ExecuteReader();
            while (reader2.Read())
            {
                correo = reader2[9].ToString();
            }

            reader.Close();

            //Cerar conexion
            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            //Realiza la transacción modificar
            SqlCommand altas = new SqlCommand("insert into Resultado(Nombre, Apellido, Cedula, Descripcion, Codigo, Imagen)values (@Nombre, @Apellido, @Cedula, @Descripcion, @Codigo, @Imagen)", conexion);
            //Tranforma la imagen a bytes
            MemoryStream ms = new MemoryStream();
            ptbResultados.Image.Save(ms, ptbResultados.Image.RawFormat);
            altas.Parameters.AddWithValue("Nombre", txtName.Text);
            altas.Parameters.AddWithValue("Apellido", txtApe.Text);
            altas.Parameters.AddWithValue("Cedula", txtProfe.Text);
            altas.Parameters.AddWithValue("Descripcion", txtDescrip.Text);
            altas.Parameters.AddWithValue("Codigo", txtReserva.Text);
            altas.Parameters.AddWithValue("Imagen", ms.GetBuffer());

            // Ejecutar comando
            altas.ExecuteNonQuery();

            //Cierra la conexion  
            conexion.Close();
            MessageBox.Show("Modificación realizada con exito");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFecha.Clear();
            txtHora.Clear();
            txtEstudio.Clear();
            txtTipo.Clear();
            txtReserva.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtGenero.Clear();
            txtEdad.Clear();
            txtDescrip.Clear();
            txtProfe.Clear();

            ptbResultados.Image = null;

            btnModificar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnEnvia.Enabled = false;
            btnEnviar.Enabled = false;
            txtReserva.Enabled = true;
            txtProfe.Enabled = false;
            txtDescrip.Enabled = false;
            btnOk.Enabled = true;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Permite cargar imagenes
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ptbResultados.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Inicalizar el formulario
            Form1 formulario = new Form1();
            formulario.Show();
            this.Close();
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            var a = "Estimad@ " + txtNombre.Text + " " + txtApellido.Text + ". Reciba en nombre de ProSalud un cordial saludo, deseándole éxito en sus labores diarios. ";
            var b = "Me es grato dirigirme a usted para informarle por este medio que, sus resultados ya se encuentran disponibles en la plataforma del laboratorio clínico 'ProSalud'. "
                + " Para acceder a estos, es necesario que ingrese el número de su reserva: " + txtReserva.Text + ". Sin más por el momento, agradezco su atención y quedamos a sus ordenes. ";
            try
            {
                // Dirección de correo electrónico del destinatario
                string destinatario = correo;

                // Asunto y cuerpo del correo
                string asunto = "ProSalud. Resultados de: " + txtEstudio.Text;
                string cuerpo = a.ToString() + b.ToString();

                // Componer el comando de inicio del cliente de correo predeterminado (por ejemplo, Outlook)
                string comandoCorreo = $"mailto:{destinatario}?subject={asunto}&body={cuerpo}";

                // Abrir el cliente de correo predeterminado con los datos precargados
                Process.Start(new ProcessStartInfo(comandoCorreo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el cliente de correo: " + ex.Message);
            }
        }

        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Define el límite máximo de caracteres
            int maxLength = 100; // Cambia esto al valor que desees

            // Verifica si se ha alcanzado el límite máximo de caracteres
            if (txtDescrip.Text.Length >= maxLength && e.KeyChar != (char)Keys.Back)
            {
                // Evita que se agregue más texto al TextBox
                e.Handled = true;
                MessageBox.Show("Has alcanzado el limite de caracteres", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}