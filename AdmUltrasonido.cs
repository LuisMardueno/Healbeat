using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProSalud
{
    public partial class AdmUltrasonido : Form
    {
        public AdmUltrasonido()
        {
            InitializeComponent();
        }
        // Conexion con SQL
        public SqlConnection conexion;

        // Limpiar los campos
        public void Limpiar()
        {
            cmbId.SelectedIndex = 0;
            txtEstudio.Text = "";
            txtPrecio.Text = "";
            txtDescrip.Text = "";
        }
        // Llenar el datagridview
        public void llenar_grid()
        {
            try
            {
                //Puente entre el DataSet y Sql
                SqlDataAdapter da = new SqlDataAdapter("Select * from Ultrasonido", conexion);
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
       
        private void AdmUltrasonido_Load(object sender, EventArgs e)
        {
            conexion.Open();
            // Cargar las Id de Usuarios en el combobox
            SqlCommand comando = new SqlCommand("SELECT ID FROM Ultrasonido", conexion);

            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                cmbId.Items.Add(registro["ID"].ToString());
            }
            conexion.Close();

            llenar_grid();
        }
        // Boton para agregar 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Comando para insertar datos
            SqlCommand altas = new SqlCommand("insert into Ultrasonido(Estudio, Precio, Descripcion) values( @Estudio, @Precio, @Descripcion)", conexion);

            // Añadir datos
            altas.Parameters.AddWithValue("Estudio", txtEstudio.Text);
            altas.Parameters.AddWithValue("Precio", txtPrecio.Text);
            altas.Parameters.AddWithValue("Descripcion", txtDescrip.Text);

            //Ejecuta las intrucciones
            altas.ExecuteNonQuery();

            llenar_grid();

            // Limpiar los items del combo box
            cmbId.Items.Clear();

            // Cargar las id de usuarios en el combobox
            SqlCommand comando = new SqlCommand("SELECT ID FROM Ultrasonido", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmbId.Items.Add(registro["ID"].ToString());
            }
            //Cierra la conexion
            conexion.Close();

            Limpiar();
            MessageBox.Show("Estudio dado de alta");
        }
        // Boton para modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Comando para insertar datos
            SqlCommand comando = new SqlCommand("update Ultrasonido set Estudio=@Estudio, Precio=@Precio, Descripcion=@Descripcion where Id=@ID", conexion);
            // Enviar parametro
            comando.Parameters.AddWithValue("Id", cmbId.SelectedItem);

            // Añadir datos
            comando.Parameters.AddWithValue("Estudio", txtEstudio.Text);
            comando.Parameters.AddWithValue("Precio", txtPrecio.Text);
            comando.Parameters.AddWithValue("Descripcion", txtDescrip.Text);

            comando.ExecuteNonQuery();

            MessageBox.Show("Modificación realizada con exito");
            llenar_grid();

            //Cierre de conección
            conexion.Close();

            Limpiar();
        }
        // Boton para eliminar
        private void btnElimiar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            //Cadena para dar de baja   modificar
            string baja = "Delete From Ultrasonido Where Id=@ID";

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
        // Boton para regresar al menu de opciones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Inicializar el formulario y enviar parametros
            MenuAdmin formulario = new MenuAdmin();
            formulario.conexion = conexion;
            formulario.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Permite colocar la info de DataGreView en los textbox
            try
            {
                cmbId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtEstudio.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDescrip.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
            SqlCommand comando = new SqlCommand($"SELECT *FROM Ultrasonido where Id=@ID", conexion);
            // Enviar id
            comando.Parameters.AddWithValue("Id", cmbId.SelectedItem);
            // Lector de datos de SQL
            SqlDataReader reader = comando.ExecuteReader();

            // Cargar los datos de la id buscada
            while (reader.Read())
            {
                txtEstudio.Text = reader[1].ToString();
                txtPrecio.Text = reader[2].ToString();
                txtDescrip.Text = reader[3].ToString();
            }
            // Cerrar conexion
            conexion.Close();
        }
    }
}
