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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("El  nombre está incorrecto o vacio.");
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string queryActualizarCategorias = @"UPDATE Categoria
                                                    SET 
                                                        NombreCategoria = '" + textBox8.Text + "'" +
                                                    "WHERE Categoriaid = '" + textBox9.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryActualizarCategorias, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha actualizado la categoria en la base de datos.");
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

                string queryCategorias = @"SELECT * FROM Categoria ";

                using (SqlCommand cmd = new SqlCommand(queryCategorias, connection))
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
                MessageBox.Show("El  nombre está incorrecto o vacio.");
                return;
            }



            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryInsertarCategorias = @"INSERT INTO Categoria ( Categoriaid, NombreCategoria)
                                           VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarCategorias, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado la categoria  en la base de datos.");
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

                string queryEliminarCategoria = @"DELETE FROM Categoria WHERE Categoriaid = '" + textBox5.Text + "'";

                using (SqlCommand cmd = new SqlCommand(queryEliminarCategoria, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha eliminado la categoria de la base de datos.");
                    }
                }

                connection.Close();

            }
        }
    }
}
