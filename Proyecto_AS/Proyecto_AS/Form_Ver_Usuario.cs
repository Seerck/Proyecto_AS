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
        static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        //static string inicio_sesion = "Server=PAOLO\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public Form_Ver_Usuario()
        {
            InitializeComponent();
        }

        private void Form_Ver_Usuario_Load(object sender, EventArgs e)
        {
            mostrar_usuario();
        }
        public void mostrar_usuario()
        {
            conectar.Open(); //abrimos la conexion a la bd
            SqlCommand comando = new SqlCommand("SELECT * FROM USUARIO", conectar); //creamos la consulta sql
            SqlDataAdapter dato = new SqlDataAdapter(comando); //ejecutamos la consulta de sql
            DataTable dt = new DataTable(); //creamos una tabla c#
            dato.Fill(dt); //rellenamos la tabla de c# con los datos obtenido al ejecutar la linea sql
            dataGridView1.DataSource = dt; //motramos los datos en el datagriedview

            conectar.Close(); //cerramos la conexion a la bd
        }
    }
}
