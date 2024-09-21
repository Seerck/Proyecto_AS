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
using System.Data.SqlClient; /*esto sirve para poder ocupar sql*/

namespace Proyecto_AS
{
    public partial class Form_Añadir_Productos : Form
    {
        //wena mati
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        //static string inicio_sesion = "Server=PAOLO\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        static string inicio_sesion = "Server=LAPTOP-OBQGVQ1D ;Database=BD_AS ;User id=sa ;Password=2024;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public Form_Añadir_Productos()
        {
            InitializeComponent();
        }

        public void consultar()
        {
            string cmd = "select * from PRODUCTO";
            SqlCommand lol = new SqlCommand(cmd, conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            dataGridView1.DataSource = red;
        }

        public void insertar()
        {
            if (nombrecmd.Text != "" && tipocmd.Text != "" && txt_cantidad.Text != "" && txt_precio.Text != "" && ubicacioncmd.Text != "" &&
                fechaingresocmd.Text != "" && fechasalidacmd.Text != "" && estadocmd.Text != "")
            {
                string cmd = "INSERT INTO PRODUCTO (Nombre, Tipo, Cantidad, Precio, Ubicacion, FechaIngreso, FechaSalida, Estado, NivelEstante) " +
                     "VALUES ('" + nombrecmd.Text + "','" + tipocmd.Text + "', '" + txt_cantidad.Text + "','" + txt_precio.Text  + "','" + ubicacioncmd.Text + "','" + fechaingresocmd.Text + "','" + fechasalidacmd.Text + "','" + estadocmd.Text + "', '" + estantecmd.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(cmd, conectar);
                conectar.Open();
                sqlCommand.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Se ha registrado correctamente");
            }
            else
            {
                MessageBox.Show("Por favor, rellene todos los datos");
            }
        }

        public void Nombre()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select Nombre from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["Nombre"] = "";
            red.Rows.InsertAt(rod, 0);

        }

        public void Tipo()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select Tipo from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["Tipo"] = "";
            red.Rows.InsertAt(rod, 0);
        }

        public void Cantidad()
        {
             conectar.Open();
            SqlCommand lol = new SqlCommand("select Cantidad from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["Cantidad"] = "";
            red.Rows.InsertAt(rod, 0);
        }

        public void Precio()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select Precio from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["Precio"] = "";
            red.Rows.InsertAt(rod, 0);
        }

        public void Caducidad()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select Caducidad from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["Caducidad"] = "";
            red.Rows.InsertAt(rod, 0);
        }


        public void Ubicacion()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select Ubicacion from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["Ubicacion"] = "";
            red.Rows.InsertAt(rod, 0);
        }

        public void FechaIngreso()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select FechaIngreso from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["FechaIngreso"] = "";
            red.Rows.InsertAt(rod, 0);
        }

        public void FechaSalida()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select FechaSalida from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["FechaSalida"] = "";
            red.Rows.InsertAt(rod, 0);
        }

        public void Estado()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select Estado from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["Estado"] = "";
            red.Rows.InsertAt(rod, 0);
        }

        public void NivelEstante()
        {
            conectar.Open();
            SqlCommand lol = new SqlCommand("select NivelEstante from PRODUCTO", conectar);
            SqlDataAdapter data = new SqlDataAdapter(lol);
            DataTable red = new DataTable();
            data.Fill(red);
            conectar.Close();
            DataRow rod = red.NewRow();
            rod["NivelEstante"] = "";
            red.Rows.InsertAt(rod, 0);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consultar();
            Nombre();
            Tipo();
            Cantidad();
            Precio();
            Caducidad();
            Ubicacion();
            FechaIngreso();
            FechaSalida();
            Estado();
            NivelEstante();
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            insertar();
        }

        private void Form_Añadir_Productos_Load(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
