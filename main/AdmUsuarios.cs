using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProSalud
{
    public partial class AdmUsuarios : Form
    {
        public AdmUsuarios()
        {
            InitializeComponent();
        }

        // Conexion con SQL
        public SqlConnection conexion;

        // Limpiar los campos
        public void Limpiar()
        {
            cmbId.SelectedIndex = 0;
            txtApellido.Text = "";
            txtContra.Text = "";
            txtCorreo.Text = "";
            txtCURP.Text = "";
            txtDirec.Text = "";
            txtEdad.Text = "";
            txtFecha.Text = "";
            cmbGen.SelectedItem = null;
            txtNombre.Text = "";
            txtTel.Text = "";
            txtUser.Text = "";
        }

        // Llenar el datagridview
        public void llenar_grid()
        {
            try
            {
                //Puente entre el DataSet y Sql
                SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios", conexion);
                //Tabla en memoria
                DataTable dt = new DataTable();
                //Añade y/o actualiza la info
                da.Fill(dt);
                //Despliega la info
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido agregar al usuario" + ex.ToString());
            }
        }
        // Boton para agregar usuarios
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Comando para insertar datos
            SqlCommand altas = new SqlCommand("insert into Usuarios(Nombre, Apellido, Edad, Fecha, Genero, Tel, Curp, Direccion,Correo, Usuario, Contraseña) values( @Nombre, @Apellido, @Edad, @Fecha, @Genero, @Tel, @Curp, @Direccion, @Correo, @Usuario, @Contraseña)", conexion);

            // Añadir datos
            altas.Parameters.AddWithValue("Usuario", txtUser.Text);
            altas.Parameters.AddWithValue("Nombre", txtNombre.Text);
            altas.Parameters.AddWithValue("Apellido", txtApellido.Text);
            altas.Parameters.AddWithValue("Edad", txtEdad.Text);
            altas.Parameters.AddWithValue("Fecha", txtFecha.Text);
            altas.Parameters.AddWithValue("Genero", cmbGen.Text);
            altas.Parameters.AddWithValue("Tel", txtTel.Text);
            altas.Parameters.AddWithValue("Curp", txtCURP.Text);
            altas.Parameters.AddWithValue("Direccion", txtDirec.Text);
            altas.Parameters.AddWithValue("Correo", txtCorreo.Text);
            altas.Parameters.AddWithValue("Contraseña", txtContra.Text);
            
            //Ejecuta las intrucciones
            altas.ExecuteNonQuery();

            llenar_grid();

            // Limpiar los items del combo box
            cmbId.Items.Clear();

            // Cargar las id de usuarios en el combobox
            SqlCommand comando = new SqlCommand("SELECT ID FROM Usuarios", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cmbId.Items.Add(registro["ID"].ToString());
            }
            //Cierra la conexion
            conexion.Close();

            Limpiar();
            MessageBox.Show("Usuario dado de alta");
        }
        // Boton para modificar usuarios
        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            // Comando para insertar datos
            SqlCommand comando = new SqlCommand("update Usuarios set Nombre=@Nombre, Apellido=@Apellido, Edad=@Edad, Fecha=@Fecha, Genero=@Genero, Tel=@Tel, Curp=@Curp, Direccion=@Direccion, Correo=@Correo, Usuario=@Usuario, Contraseña=@Contraseña where Id=@ID", conexion);
            // Enviar parametro
            comando.Parameters.AddWithValue("Id", cmbId.SelectedItem);

            // Añadir datos
            comando.Parameters.AddWithValue("Usuario", txtUser.Text);
            comando.Parameters.AddWithValue("Nombre", txtNombre.Text);
            comando.Parameters.AddWithValue("Apellido", txtApellido.Text);
            comando.Parameters.AddWithValue("Edad", txtEdad.Text);
            comando.Parameters.AddWithValue("Fecha", txtFecha.Text);
            comando.Parameters.AddWithValue("Genero", cmbGen.Text);
            comando.Parameters.AddWithValue("Tel", txtTel.Text);
            comando.Parameters.AddWithValue("Curp", txtCURP.Text);
            comando.Parameters.AddWithValue("Direccion", txtDirec.Text);
            comando.Parameters.AddWithValue("Correo", txtCorreo.Text);
            comando.Parameters.AddWithValue("Contraseña", txtContra.Text);

            comando.ExecuteNonQuery();

            MessageBox.Show("Modificación realizada con exito");
            llenar_grid();

            //Cierre de conección
            conexion.Close();

            Limpiar();
        }
        // Boton para eliminar ususario
        private void btnElimiar_Click(object sender, EventArgs e)
        {
            // Abrir conexion
            conexion.Open();

            //Cadena para dar de baja   modificar
            string baja = "Delete From Usuarios Where Id=@ID";

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
            MessageBox.Show("Usuario eliminado");
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
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEdad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtFecha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cmbGen.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtCURP.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtDirec.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtUser.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                txtContra.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
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
            SqlCommand comando = new SqlCommand($"SELECT *FROM Usuarios where Id=@ID", conexion);
            // Enviar id
            comando.Parameters.AddWithValue("Id", cmbId.SelectedItem);
            // Lector de datos de SQL
            SqlDataReader reader = comando.ExecuteReader();

            // Cargar los datos de la id buscada
            while (reader.Read())
            {
                txtNombre.Text = reader[1].ToString();
                txtApellido.Text = reader[2].ToString();
                txtEdad.Text = reader[3].ToString();
                txtFecha.Text = reader[4].ToString();
                cmbGen.Text = reader[5].ToString();
                txtTel.Text = reader[6].ToString();
                txtCURP.Text = reader[7].ToString();
                txtDirec.Text = reader[8].ToString();
                txtCorreo.Text = reader[9].ToString();
                txtUser.Text = reader[10].ToString();
                txtContra.Text = reader[11].ToString();
            }
            // Cerrar conexion
            conexion.Close();
        }

        private void AdmUsuarios_Load(object sender, EventArgs e)
        {
            conexion.Open();
            // Cargar las Id de Usuarios en el combobox
            SqlCommand comando = new SqlCommand("SELECT ID FROM Usuarios", conexion);

            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                cmbId.Items.Add(registro["ID"].ToString());
            }
            conexion.Close();

            llenar_grid();
        }
        // resrtricciones de formato
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
            int limite = 18;
            if (txtCURP.Text.Contains(" "))
            {
                MessageBox.Show("No se permite espacios", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtCURP.Text.Trim().Length > limite)
            {
                txtCURP.Clear();
                MessageBox.Show(txtCURP, $"No puede superar el maximo de {limite} digitos", "Alerta",
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

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
