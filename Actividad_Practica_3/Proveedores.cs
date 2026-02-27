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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Actividad_Practica_3
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryProveedores = @"SELECT *
	                                                FROM Proveedores 
		                                                ";

                using (SqlCommand cmd = new SqlCommand(queryProveedores, connection))
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



            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();





                string queryInsertarProveedores = @"INSERT INTO Proveedores (ProveedorID, NombreProveedor, Telefono, CorreoElectronico)
                                           VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox1.Text + "'," +
                                                   "'" + textBox4.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarProveedores, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado el proveedor en la base de datos.");
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

                string queryEliminarProveedor = @"DELETE FROM Proveedores WHERE ProveedorID = '" + textBox5.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarProveedor, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado el proveedor de la base de datos.");
                    }
                }

                connection.Close();

            }
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
                MessageBox.Show("El correo está incorrecta o vacia.");
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryActualizarProveedores = @"UPDATE Proveedores 
                                                    SET 
                                                        NombreProveedor = '" + textBox8.Text + "', " +
                                                        "Telefono = '" + maskedTextBox2.Text + "',  " +
                                                        "CorreoElectronico = '" + textBox6.Text +  "'" +
                                                    "WHERE ProveedorID = '" + textBox9.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryActualizarProveedores, connection))
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
    }
}
