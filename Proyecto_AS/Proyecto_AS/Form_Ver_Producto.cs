﻿using System;
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
    public partial class Form_Ver_Producto : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;"; 
        //static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public Form_Ver_Producto()
        {
            InitializeComponent();
        }

        private void Form_Ver_Producto_Load(object sender, EventArgs e)
        {

        }
        public void mostrar_producto()
        {
            conectar.Open(); //abrimos la conexion a la bd
            SqlCommand comando = new SqlCommand("SELECT * FROM PRODUCTO", conectar); //creamos la consulta sql
            SqlDataAdapter dato = new SqlDataAdapter(comando); //ejecutamos la consulta de sql
            DataTable dt = new DataTable(); //creamos una tabla c#
            dato.Fill(dt); //rellenamos la tabla de c# con los datos obtenido al ejecutar la linea sql
            dataGridView1.DataSource = dt; //motramos los datos en el datagriedview

            conectar.Close(); //cerramos la conexion a la bd
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
                // Tu cadena de conexión
                //string connectionString = "Data Source=DESKTOP-5RJ2UO2\\SQLEXPRESS;Initial Catalog=BD_AS;User ID=sa;Password=12345678;";
            string connectionString = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
            // Consulta SQL para buscar los productos por nombre
            string query = "SELECT Nombre, Tipo, Cantidad, Precio, Caducidad, Ubicacion, FechaIngreso, Estado, NivelEstante FROM Productos WHERE(Nombre LIKE @NombreProducto) AND Estado = 'Habilitado'";

            // Obtener el valor que el usuario ingresó en el TextBox
            string Nombre = TxtNombre.Text;

                try
                {
                    // Validar que el TextBox no esté vacío
                    if (string.IsNullOrWhiteSpace(Nombre))
                    {
                        MessageBox.Show("Por favor, ingresa un nombre de producto para buscar.");
                        return;
                    }

                    // Crear la conexión a la base de datos
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Abrir la conexión
                        connection.Open();

                        // Crear el comando SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Agregar el parámetro con el valor de búsqueda
                            command.Parameters.AddWithValue("Nombre", "%" + TxtNombre + "%");

                            // Crear un adaptador de datos para llenar el DataGridView
                            SqlDataAdapter adapter = new SqlDataAdapter(command);

                            // Crear un DataTable para almacenar los resultados
                            DataTable dataTable = new DataTable();

                            // Llenar el DataTable con los datos de la consulta
                            adapter.Fill(dataTable);

                            // Asignar el DataTable al DataGridView
                            dataGridView1.DataSource = dataTable;
                        }

                        // Cerrar la conexión
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje si ocurre un error
                    MessageBox.Show("Error al buscar los productos, intente de nuevo.: " + ex.Message);
                }
            }
        }
    }
