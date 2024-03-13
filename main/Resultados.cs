using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;

namespace ProSalud
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }
        public SqlConnection conexion;

        // Parametros heredados 
        public string UsuarioActual;

        // Limpiar los campos
        public void Limpiar()
        {
            cmbId.SelectedIndex = 0;
            txtLab.Text = "";
            txtDescripcion.Text = "";
            txtReserva.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtProfe.Text = "";
            ptbResultados.Image = null;
        }
        // Llenar el datagridview
        public void llenar_grid()
        {
            try
            {
                //Puente entre el DataSet y Sql
                SqlDataAdapter da = new SqlDataAdapter("Select * from Resultado", conexion);
                //Tabla en memoria
                DataTable dt = new DataTable();
                //Añade y/o actualiza la info
                da.Fill(dt);
                //Despliega la info
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido agregar el estudio" + ex.ToString());
            }
        }

        private void btnElimiar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            //Cadena para dar de baja   modificar
            string baja = "Delete From Resultado Where Id=@ID";

            //Crea comandos
            SqlCommand cmdbj = new SqlCommand(baja, conexion);
            cmdbj.Parameters.AddWithValue("Id", cmbId.Text);
            cmdbj.ExecuteNonQuery();

            //Libera los recursos
            cmdbj.Dispose();
            cmdbj = null;
            llenar_grid();

            // cerrar conexion
            conexion.Close();

            // Remor id del combobox
            cmbId.Items.Remove(cmbId.Text);
            Limpiar();
            MessageBox.Show("Estudio eliminado");
        }
        // Limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Inicializar el formulario y enviar parametros
            MenuAdmin formulario = new MenuAdmin();
            formulario.conexion = conexion;
            formulario.Show();
            this.Close();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Cargar las Id de Usuarios en el combobox
            SqlCommand comando = new SqlCommand("SELECT ID FROM Resultado", conexion);

            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                cmbId.Items.Add(registro["ID"].ToString());
            }
            conexion.Close();

            llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Permite colocar la info de DataGreView en los textbox
            try
            {
                cmbId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtProfe.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtLab.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtReserva.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();
            // Comando para seleccionr los datos de la usuarios
            SqlCommand comando = new SqlCommand($"SELECT *FROM Resultado where Id=@ID", conexion);
            // Enviar id
            comando.Parameters.AddWithValue("Id", cmbId.SelectedItem);
            // Lector de datos de SQL
            SqlDataReader reader = comando.ExecuteReader();

            // Cargar los datos de la id buscada
            while (reader.Read())
            {
                txtNombre.Text = reader[1].ToString();
                txtApellido.Text = reader[2].ToString();
                txtProfe.Text = reader[3].ToString();
                txtDescripcion.Text = reader[4].ToString();
                txtReserva.Text = reader[5].ToString();
                MemoryStream ms = new MemoryStream(reader.GetSqlBytes(6).Buffer);
                ptbResultados.Image = Image.FromStream(ms);
            }
            reader.Close();

            SqlCommand coman = new SqlCommand($"SELECT * FROM Cita where codigo=@Codigo", conexion);
            coman.Parameters.AddWithValue("Codigo", txtReserva.Text);
            SqlDataReader reader1 = coman.ExecuteReader();
            while (reader1.Read())
            {
                txtLab.Text = reader1[6].ToString();
            }
            reader1.Close();
            //Cerrar conexion
            conexion.Close();
        }
    }
}
