using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Practica_3
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("El ID está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(maskedTextBox2.Text))
            {
                MessageBox.Show("El telefono está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("El correo  está incorrecta o vacia.");
                return;
            }
            if (string.IsNullOrEmpty(textBox11.Text))
            {
                MessageBox.Show("La direccion está incorrecta o vacia.");
                return;
            }


            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryActualizarClientes = @"UPDATE Clientes 
                                                    SET 
                                                        NombreCompleto = '" + textBox8.Text + "', " +
                                                        "Telefono = '" + maskedTextBox2.Text + "',  " +
                                                        "CorreoElectronico = '" + textBox6.Text + "',  " +
                                                        "Direccion = '" + textBox11.Text + "'" +
                                                    "WHERE ClienteID = '" + textBox9.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryActualizarClientes, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha actualizado el proveedor en la base de datos.");
                    }
                }

                connection.Close();


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryClientes = @"SELECT *
	                                                FROM Clientes
		                                                ";

                using (SqlCommand cmd = new SqlCommand(queryClientes, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        dataGridView1.DataSource = dt;
                    }
                }

                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("El ID está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("El telefono está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("El correo  está incorrecta o vacia.");
                return;
            }
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                MessageBox.Show("La direccion está incorrecta o vacia.");
                return;
            }


            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();





                string queryInsertarClientes = @"INSERT INTO Clientes (ClienteID, NombreCompleto, Telefono, CorreoElectronico, Direccion)
                                           VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox1.Text + "', '" + textBox4.Text + "'," +
                                                   "'" + textBox10.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarClientes, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado el Cliente en la base de datos.");
                    }
                }

                connection.Close();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryEliminarClientes = @"DELETE FROM Clientes WHERE ClienteID = '" + textBox5.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarClientes, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado el cliente de la base de datos.");
                    }
                }

                connection.Close();

            }


        }
    }
}
