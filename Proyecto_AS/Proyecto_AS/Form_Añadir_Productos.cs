using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; /*esto sirve para poder ocupar sql*/
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Proyecto_AS
{
    public partial class Form_Añadir_Productos : Form
    {
        //wena mati
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        //static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        //static string inicio_sesion = "Server=LAPTOP-OBQGVQ1D ;Database=BD_AS ;User id=sa ;Password=2024;";
        static string inicio_sesion = "Server=LAPTOP-PEB8KTKM ;Database=BD_AS ;User id=sa ;Password=1253351;";
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
            if (nombrecmd.Text != "" && cmdtipo.SelectedIndex > -1  && txt_cantidad.Text != "" && txt_precio.Text != "" && ubicacioncmd.Text != "" &&
                fechaingresocmd.Text !=  ""  && estantecmd.Text != "" && estadocmb.SelectedIndex > -1 )
            {
                string caducidadValue = string.IsNullOrWhiteSpace(fecha_vencimientocmd.Text) ? "NULL" : "'" + fecha_vencimientocmd.Text + "'";
                string cmd = "INSERT INTO PRODUCTO (Nombre, Tipo, Cantidad, Precio, Ubicacion, FechaIngreso,  Estado, NivelEstante) " +
                     "VALUES ('" + nombrecmd.Text + "','" + cmdtipo.Text + "', '" + txt_cantidad.Text + "','" + txt_precio.Text + "','" + ubicacioncmd.Text + "', '" + fechaingresocmd.Text + "','" + estadocmb.Text + "', '" + estantecmd.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(cmd, conectar);
                conectar.Open();
                sqlCommand.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Se ha registrado correctamente");

                // Limpiar campos después de registrar
                nombrecmd.Text = "";
                cmdtipo.SelectedIndex = -1;
                txt_cantidad.Text = "";
                txt_precio.Text = "";
                ubicacioncmd.Text = "";
                fechaingresocmd.Text = "";
                fecha_vencimientocmd.Text = "";
                estantecmd.Text = "";
                estadocmb.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Rellene todos los campos porfavor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            consultar();
        }

        private void Form_Añadir_Productos_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (0-9), la tecla Backspace y no aceptar otros caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Cancela el evento si no es un número o control
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (0-9), la tecla Backspace y no aceptar otros caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Cancela el evento si no es un número o control
            }
        }

        private void estantecmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números (0-9), la tecla Backspace y no aceptar otros caracteres
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Cancela el evento si no es un número o control
            }
        }

        private void nombrecmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;  // Cancela el evento si no es una letra, espacio o tecla de control
            }
        }

        private void fechaingresocmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el carácter "-", teclas de control (Backspace, Delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;  // Cancela el evento si no es un número, "-", o tecla de control
            }
        }

        private void fechasalidacmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el carácter "-", teclas de control (Backspace, Delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;  // Cancela el evento si no es un número, "-", o tecla de control
            }
        }

        private void txt_fechasalida_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_fechacaducidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el carácter "-", teclas de control (Backspace, Delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;  // Cancela el evento si no es un número, "-", o tecla de control
            }
        }

        private void estadocmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fechaingresocmd_TextChanged(object sender, EventArgs e)
        {
            string texto = fechaingresocmd.Text.Replace("-","");

            // Formatear la fecha automáticamente
            if (texto.Length > 2)
            {
                texto = texto.Insert(2, "-");  //inserta la posicion 2 por el - 
            }

            // Actualizar el TextBox con el formato correcto
            if (texto.Length > 5)
            {
                texto = texto.Insert(5, "-");  //inserta la posicion 5 por el - 
            }

            fechaingresocmd.Text = texto;
            fechaingresocmd.SelectionStart = texto.Length; // Mantener el cursor al final
        }

        private void fecha_vencimientocmd_TextChanged(object sender, EventArgs e)
        {
            string texto = fecha_vencimientocmd.Text.Replace("-", "");

            // Formatear la fecha automáticamente
            if (texto.Length > 2)
            {
                texto = texto.Insert(2, "-");  //inserta la posicion 2 por el - 
            }

            // Actualizar el TextBox con el formato correcto
            if (texto.Length > 5)
            {
                texto = texto.Insert(5, "-");  //inserta la posicion 5 por el - 
            }

            fecha_vencimientocmd.Text = texto; 
            fecha_vencimientocmd.SelectionStart = texto.Length; // Mantener el cursor al final
        }

        private void cmdtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Cancela cualquier tecla presionada, impidiendo que se escriba cualquier carácter
        }

        private void estadocmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Cancela cualquier tecla presionada, impidiendo que se escriba cualquier carácter
        }

        private void ubicacioncmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = (int)e.KeyChar;

            // Permitir letras (A-Z, a-z), números (0-9) y la tecla de borrar (Backspace)
            // ASCII 8 corresponde a Backspace
            // Números 0-9: ASCII 48-57

            if (!((asciiCode >= 65 && asciiCode <= 90) ||   // Mayúsculas A-Z
                  (asciiCode >= 97 && asciiCode <= 122) ||  // Minúsculas a-z
                  (asciiCode >= 48 && asciiCode <= 57) ||   // Números 0-9
                  asciiCode == 8))                          // Tecla de borrar (Backspace)
            {
                // Si no es una letra, número o Backspace, se cancela la entrada
                e.Handled = true;
            }
        }
    }
}
