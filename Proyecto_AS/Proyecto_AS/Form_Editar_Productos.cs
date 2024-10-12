using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_AS
{
    public partial class Form_Editar_Productos : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        //static string inicio_sesion = "Server=PAOLO\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        //static string inicio_sesion = "Server=LAPTOP-OBQGVQ1D ;Database=BD_AS ;User id=sa ;Password=2024;";
        static string inicio_sesion = "Server=LAPTOP-PEB8KTKM ;Database=BD_AS ;User id=sa ;Password=1253351;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/

        public Form_Editar_Productos()
        {
            InitializeComponent();
        }
        public void consultar()
        {
            conectar.Open(); //abrimos la conexion a la bd
            SqlCommand comando = new SqlCommand("SELECT * FROM PRODUCTO", conectar); //creamos la consulta sql
            SqlDataAdapter dato = new SqlDataAdapter(comando); //ejecutamos la consulta de sql
            DataTable dt = new DataTable(); //creamos una tabla c#
            dato.Fill(dt); //rellenamos la tabla de c# con los datos obtenido al ejecutar la linea sql
            dataGridView1.DataSource = dt; //motramos los datos en el datagriedview

            conectar.Close(); //cerramos la conexion a la bd
        }

        public void insertar()
        {
            if (txt_nombre.Text != "" && cmb_tipo.SelectedIndex > -1 && txt_cantidad.Text != "" && txt_precio.Text != "" && txt_ubicacion.Text != "" &&
                txt_fecha_i.Text != "" && txt_fecha_v.Text != "" && cmb_estado.SelectedIndex > -1)
            {
                string cmd = "INSERT INTO PRODUCTO (Nombre, Tipo, Cantidad, Precio, Ubicacion, FechaIngreso, FechaSalida, Estado, NivelEstante) " +
             "VALUES ('" + txt_nombre.Text + "','" + cmb_tipo.Text + "', '" + txt_cantidad.Text + "','" + txt_precio.Text + "','" + txt_ubicacion.Text + "','" + txt_fecha_i.Text + "','" + txt_fecha_v.Text + "','" + cmb_estado.Text + "', '" + txt_nivel.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(cmd, conectar);
                conectar.Open();
                sqlCommand.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Se ha registrado correctamente");
            }
            else
            {
                MessageBox.Show("Rellene todos los campos porfavor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form_Editar_Productos_Load(object sender, EventArgs e)
        {
            //consultar();
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            // Validación de fechas
            DateTime fechaIngreso;
            if (!DateTime.TryParseExact(txt_fecha_i.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fechaIngreso))
            {
                MessageBox.Show("El formato de la fecha de ingreso es inválido. Por favor, utilice el formato dd-MM-yyyy.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime? fechaVencimiento = null;
            if (!string.IsNullOrWhiteSpace(txt_fecha_v.Text))
            {
                if (!DateTime.TryParseExact(txt_fecha_v.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime vencimiento))
                {
                    MessageBox.Show("El formato de la fecha de vencimiento es inválido. Por favor, utilice el formato dd-MM-yyyy.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fechaVencimiento = vencimiento;
            }

            string fechaIngresoSql = fechaIngreso.ToString("yyyy-MM-dd");
            string caducidadValue = fechaVencimiento.HasValue ? fechaVencimiento.Value.ToString("yyyy-MM-dd") : "NULL";

            if (!string.IsNullOrEmpty(variable_id))
            {
                if (txt_nombre.Text != "" & cmb_tipo.SelectedIndex > -1 & txt_cantidad.Text != "" & txt_precio.Text != "" & txt_ubicacion.Text != "" & txt_fecha_i.Text != "" & txt_nivel.Text != "" & cmb_estado.SelectedIndex > -1)
                {
                    // Usar la fecha ya convertida
                    string edit = "UPDATE PRODUCTO SET Nombre = '" + txt_nombre.Text + "', Tipo = '" + cmb_tipo.SelectedItem.ToString() + "', Cantidad = '" + txt_cantidad.Text + "', Precio = '" + txt_precio.Text + "', Caducidad = " + (caducidadValue == "NULL" ? caducidadValue : "'" + caducidadValue + "'") + ", Ubicacion = '" + txt_ubicacion.Text + "', FechaIngreso = '" + fechaIngresoSql + "', Estado = '" + cmb_estado.SelectedItem.ToString() + "', NivelEstante = '" + txt_nivel.Text + "' WHERE Id = '" + variable_id + "'";

                    SqlCommand sqlCommand = new SqlCommand(edit, conectar);
                    conectar.Open();
                    sqlCommand.ExecuteNonQuery();
                    conectar.Close();

                    dataGridView1.DataSource = null;   // Limpiar datos anteriores
                    MessageBox.Show("Se han actualizado los datos del producto.");

                    conectar.Open();
                    string consulta = "SELECT * FROM PRODUCTO WHERE Id = '" + variable_id + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar); // Ejecutamos la consulta con SqlDataAdapter
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    conectar.Close();

                    // Limpiar los TextBoxes y ComboBoxes
                    txt_nombre.Text = "";
                    txt_cantidad.Text = "";
                    txt_precio.Text = "";
                    txt_ubicacion.Text = "";
                    txt_fecha_i.Text = "";
                    txt_fecha_v.Text = "";
                    txt_nivel.Text = "";

                    cmb_estado.SelectedIndex = -1;
                    cmb_tipo.SelectedIndex = -1;

                    dataGridView1.DataSource = null;   // Limpiar datos anteriores
                    dataGridView1.DataSource = dt;     // Asignar los nuevos datos
                    dataGridView1.Refresh();           // Forzar refresco
                }
                else
                {
                    MessageBox.Show("Falta rellenar todos los campos para realizar el cambio", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione algún producto antes de actualizar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_nombre.Text = "";
                txt_cantidad.Text = "";
                txt_precio.Text = "";
                txt_ubicacion.Text = "";
                txt_fecha_i.Text = "";
                txt_fecha_v.Text = "";
                txt_nivel.Text = "";

                cmb_estado.SelectedIndex = -1;
                cmb_tipo.SelectedIndex = -1;
            }
        }


        private void fechasalidacmd_TextChanged(object sender, EventArgs e)
        {
            // Desuscribir el evento temporalmente para evitar bucles infinitos
            txt_fecha_v.TextChanged -= fechasalidacmd_TextChanged;

            // Guardar la posición actual del cursor
            int cursorPos = txt_fecha_v.SelectionStart;

            // Limpiar cualquier guion para reformatear la cadena correctamente
            string valor = txt_fecha_v.Text.Replace("-", "");

            // Verificar que solo se manejen hasta 8 caracteres (ddMMyyyy)
            if (valor.Length > 8)
            {
                valor = valor.Substring(0, 8);
            }

            // Insertar guiones en las posiciones correctas si la longitud lo permite
            if (valor.Length > 2)
            {
                valor = valor.Insert(2, "-");
            }
            if (valor.Length > 5)
            {
                valor = valor.Insert(5, "-");
            }

            // Asignar el valor formateado al TextBox
            txt_fecha_v.Text = valor;

            // Ajustar la posición del cursor después de las modificaciones
            cursorPos += (valor.Length - txt_fecha_v.Text.Length);
            txt_fecha_v.SelectionStart = txt_fecha_v.Text.Length;

            // Re-suscribir el evento TextChanged
            txt_fecha_v.TextChanged += fechasalidacmd_TextChanged;

            if (txt_fecha_v.Text.Length == 10) // El formato esperado es "dd-MM-yyyy"
            {
                DateTime fecha;
                bool esValida = DateTime.TryParseExact(txt_fecha_v.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fecha);

                if (!esValida)
                {
                    MessageBox.Show("Por favor, ingrese una fecha válida y existente.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_fecha_v.Focus();
                    txt_fecha_v.SelectAll();
                    txt_fecha_v.Text = "";
                }
            }
        }

        private void fechaingresocmd_TextChanged(object sender, EventArgs e)
        {
            // Desuscribir el evento temporalmente para evitar bucles infinitos
            txt_fecha_i.TextChanged -= fechaingresocmd_TextChanged;

            // Limpiar cualquier guion para re-formatear la cadena correctamente
            string valor = txt_fecha_i.Text.Replace("-", "");

            // Verificar que solo se manejen hasta 8 caracteres (ddMMyyyy)
            if (valor.Length > 8)
            {
                valor = valor.Substring(0, 8);
            }

            // Insertar guiones en las posiciones correctas si la longitud lo permite
            if (valor.Length > 2)
            {
                valor = valor.Insert(2, "-");
            }
            if (valor.Length > 5)
            {
                valor = valor.Insert(5, "-");
            }

            // Asignar el valor formateado al TextBox
            txt_fecha_i.Text = valor;

            // Colocar el cursor al final del texto
            txt_fecha_i.SelectionStart = txt_fecha_i.Text.Length;

            // Re-suscribir el evento TextChanged
            txt_fecha_i.TextChanged += fechaingresocmd_TextChanged;

            // Validar la fecha ingresada solo cuando tiene un formato completo
            if (txt_fecha_i.Text.Length == 10) // El formato esperado es "dd-MM-yyyy"
            {
                DateTime fecha;
                bool esValida = DateTime.TryParseExact(txt_fecha_i.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out fecha);

                if (!esValida)
                {
                    MessageBox.Show("Por favor, ingrese una fecha válida y existente.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_fecha_i.Focus();
                    txt_fecha_i.SelectAll();
                    txt_fecha_i.Text = "";
                }
            }
        }

        private void ubicacioncmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombrecmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consultar();

        }

        #region
        /*private void btn_extraer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)  // Comprueba si hay filas seleccionadas
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];  // Obtenemos la fila seleccionada

                // Asignamos los valores de las columnas a los controles
                variable_id = filaSeleccionada.Cells["Id"].Value.ToString();
                txt_nombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string tipoSeleccionado = filaSeleccionada.Cells["Tipo"]?.Value?.ToString();

                if (!string.IsNullOrEmpty(tipoSeleccionado))
                {
                    cmb_tipo.SelectedItem = tipoSeleccionado;
                }
                else
                {
                    MessageBox.Show("El tipo no esta registrado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_cantidad.Text = filaSeleccionada.Cells["Cantidad"].Value?.ToString();
                txt_precio.Text = filaSeleccionada.Cells["Precio"].Value?.ToString();
                txt_ubicacion.Text = filaSeleccionada.Cells["Ubicacion"].Value?.ToString();
                txt_fecha_i.Text = filaSeleccionada.Cells["FechaIngreso"].Value?.ToString();
                txt_fecha_v.Text = filaSeleccionada.Cells["Caducidad"].Value?.ToString();
                txt_nivel.Text = filaSeleccionada.Cells["NivelEstante"].Value?.ToString();

                string tipoEstado = filaSeleccionada.Cells["Estado"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(tipoEstado))
                {
                    cmb_estado.SelectedItem = tipoEstado;
                }
                else
                {
                    MessageBox.Show("El estado no esta correctamente guardado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para extraer los datos.");
            }
        }*/
        #endregion

        string variable_id;

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || cmb_tipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, ingrese el nombre y tipo de producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                conectar.Open();
                string consulta = "SELECT * FROM PRODUCTO WHERE Nombre LIKE '" + txt_nombre.Text + "%' AND Tipo = '" + cmb_tipo.SelectedItem.ToString() + "'";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar); // Ejecutamos la consulta con SqlDataAdapter
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)  // Verificamos si se encontraron resultados
                {
                    dataGridView1.DataSource = dt;  // Si hay resultados, los mostramos en el DataGridView
                }

                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;  // Limpiamos el DataGridView si no encontramos ningun nombre
                }

                txt_nombre.Text = "";
                cmb_tipo.SelectedIndex = -1;

                conectar.Close();
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {           
            if (dataGridView1.CurrentRow != null) // Verificamos si hay al menos una celda seleccionada
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.CurrentRow;

                variable_id = filaSeleccionada.Cells["Id"].Value?.ToString();
                txt_nombre.Text = filaSeleccionada.Cells["Nombre"].Value?.ToString();

                string tipoSeleccionado = filaSeleccionada.Cells["Tipo"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(tipoSeleccionado))
                {
                    cmb_tipo.SelectedItem = tipoSeleccionado;
                }
                else
                {
                    MessageBox.Show("El tipo no está registrado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_cantidad.Text = filaSeleccionada.Cells["Cantidad"].Value?.ToString();
                txt_precio.Text = filaSeleccionada.Cells["Precio"].Value?.ToString();
                txt_ubicacion.Text = filaSeleccionada.Cells["Ubicacion"].Value?.ToString();
                txt_fecha_i.Text = filaSeleccionada.Cells["FechaIngreso"].Value?.ToString();
                txt_fecha_v.Text = filaSeleccionada.Cells["Caducidad"].Value?.ToString();
                txt_nivel.Text = filaSeleccionada.Cells["NivelEstante"].Value?.ToString();

                string tipoEstado = filaSeleccionada.Cells["Estado"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(tipoEstado))
                {
                    cmb_estado.SelectedItem = tipoEstado;
                }
                else
                {
                    MessageBox.Show("El estado no está correctamente guardado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para extraer los datos.");
            }
        }

        private void cmb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Cancela cualquier tecla presionada, impidiendo que se escriba cualquier carácter
        }

        private void cmb_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Cancela cualquier tecla presionada, impidiendo que se escriba cualquier carácter
        }

        private void txt_fecha_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se cancela la entrada
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;  // Cancela el evento si no es una letra, espacio o tecla de control
            }
        }

        private void txt_nivel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se cancela la entrada
                e.Handled = true;
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se cancela la entrada
                e.Handled = true;
            }
        }

        private void txt_fecha_v_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, se cancela la entrada
                e.Handled = true;
            }
        }

        private void txt_ubicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = (int)e.KeyChar;

            // Permitir letras (A-Z, a-z), números (0-9), la tecla de borrar (Backspace) y espacios (ASCII 32)
            if (!((asciiCode >= 65 && asciiCode <= 90) ||   // Mayúsculas A-Z
                  (asciiCode >= 97 && asciiCode <= 122) ||  // Minúsculas a-z
                  (asciiCode >= 48 && asciiCode <= 57) ||   // Números 0-9
                  asciiCode == 8 ||                         // Tecla de borrar (Backspace)
                  asciiCode == 32))                         // Espacio (ASCII 32)
            {
                // Si no es una letra, número, Backspace o espacio, se cancela la entrada
                e.Handled = true;
            }
        }
        #region
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void estadocmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void estantecmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
    #endregion
}
