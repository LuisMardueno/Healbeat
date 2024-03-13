using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProSalud
{
    public partial class AdmCorrespondencia : Form
    {
        public AdmCorrespondencia()
        {
            InitializeComponent();
        }
        // Conexion con SQL
        public SqlConnection conexion;

        // Limpiar los campos
        public void Limpiar()
        {
            cmbId.SelectedIndex = 0;
            txtAsunto.Text = "";
            txtComentario.Text = "";
            txtCorreo.Text = "";
            txtEstado.Text = "";
            txtMunicipio.Text = "";
            txtSucursal.Text = "";
        }
        // Llenar el datagridview
        public void llenar_grid()
        {
            try
            {
                //Puente entre el DataSet y Sql
                SqlDataAdapter da = new SqlDataAdapter("Select * from Contacto", conexion);
                //Tabla en memoria
                DataTable dt = new DataTable();
                //Añade y/o actualiza la info
                da.Fill(dt);
                //Despliega la info
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido agregar el correo" + ex.ToString());
            }
        }
        // Boton para eliminar
        private void btnElimiar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            //Cadena para dar de baja   modificar
            string baja = "Delete From Contacto Where Id=@ID";

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
            MessageBox.Show("Correo eliminado");
        }
        // Limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        // Boton para regresar al menu de opciones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Inicializar el formulario y enviar parametros
            MenuAdmin formulario = new MenuAdmin();
            formulario.conexion = conexion;
            formulario.Show();
            this.Close();
        }

        private void AdmCorrespondencia_Load(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Cargar las Id de Usuarios en el combobox
            SqlCommand comando = new SqlCommand("SELECT ID FROM Contacto", conexion);

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
                txtEstado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMunicipio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSucursal.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtAsunto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtComentario.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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
            SqlCommand comando = new SqlCommand($"SELECT *FROM Contacto where Id=@ID", conexion);
            // Enviar id
            comando.Parameters.AddWithValue("Id", cmbId.SelectedItem);
            // Lector de datos de SQL
            SqlDataReader reader = comando.ExecuteReader();

            // Cargar los datos de la id buscada
            while (reader.Read())
            {
                txtEstado.Text = reader[1].ToString();
                txtMunicipio.Text = reader[2].ToString();
                txtSucursal.Text = reader[3].ToString();
                txtAsunto.Text = reader[4].ToString();
                txtCorreo.Text = reader[5].ToString();
                txtComentario.Text = reader[6].ToString();
            }
            // Cerrar conexion
            conexion.Close();
        }
    }
}
