using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AS
{
    public partial class Form_Ver_Usuario : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public Form_Ver_Usuario()
        {
            InitializeComponent();
        }
        private void Form_Ver_Usuario_Load(object sender, EventArgs e)
        {
            btn_buscar.Enabled = false;
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(txt_nombre.Text);
                     btn_buscar.Enabled = vr;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void cmd_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // Aseguramos que la conexión esté cerrada antes de abrirla
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }

            // Definimos la consulta con un parámetro en lugar de concatenar directamente el texto
            string consulta = "SELECT * FROM USUARIO WHERE nombre = @nombre";

            // Creamos el SqlCommand con la consulta y la conexión
            SqlCommand comando = new SqlCommand(consulta, conectar);

            // Añadimos el parámetro con el valor del TextBox
            comando.Parameters.AddWithValue("@nombre", txt_nombre.Text);

            // Adaptador para llenar el DataTable
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();

            // Llenamos el DataTable y lo asignamos al DataGridView
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            // Cerramos la conexión después de realizar la consulta
            conectar.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
