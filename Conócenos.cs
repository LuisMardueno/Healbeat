using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProSalud
{
    public partial class Conócenos : Form
    {
        public Conócenos()
        {
            InitializeComponent();
        }
        // Parametros heredados 
        public string UsuarioActual;

        // Conexion con SQL
        public SqlConnection conexion;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Inicializar el formulario y enviar parametros
            Menú formulario = new Menú();
            formulario.UsuarioActual = UsuarioActual;
            formulario.conexion = conexion;
            formulario.Show();
            this.Close();
        }
    }
}
