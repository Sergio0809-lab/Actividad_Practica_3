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
    public partial class Productos : Form
    {


        private void cargarCmbCategorias()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryCategorias = "SELECT * FROM Categoria;";

                using (SqlCommand cmd = new SqlCommand(queryCategorias, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "NombreCategoria";
                        comboBox1.ValueMember = "Categoriaid";

                        //cmbCategoriaActualizado.DataSource = dt;
                        //cmbCategoriaActualizado.DisplayMember = "NombreCategoria";
                        //cmbCategoriaActualizado.ValueMember = "CategoriaID";
                    }
                }

                connection.Close();
            }
        }

        public Productos()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryProductos = @"SELECT p.ProductosId, p.NombreProductos, p.Descripcion, p.Precio, p.Stock, c.NombreCategoria
	                                                FROM Productos p
		                                                INNER JOIN  Categoria c
			                                                ON p.CategoriaID = c.Categoriaid;";

                using (SqlCommand cmd = new SqlCommand(queryProductos, connection))
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
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("El nombre está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("La descripción está incorrecto o vacio.");
                return;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("El stock está incorrecta o vacia.");
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.SelectedValue.ToString()))
            {
                MessageBox.Show("La categoria está incorrecto o vacio.");
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("El precio está incorrecta o vacia.");
                return;
            }



            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Actividad_Practica_1;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string queryInsertarProductos = @"INSERT INTO Productos (NombreProductos, Descripcion, Stock, Categoriaid7, Precio)
                                           VALUES ('" + textBox2.Text + "','" + textBox6.Text + "'," +
                                                   "'" + textBox4.Text + "','" + comboBox1.SelectedValue + "'," +
                                                   "'" + textBox7.Text + "')";

                using (SqlCommand cmd = new SqlCommand(queryInsertarProductos, connection))
                {
                    4int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se ha insertado el producto en la base de datos.");
                    }
                }

                connection.Close();
            }



        }

        private void Productos_Load(object sender, EventArgs e)
        {
            this.cargarCmbCategorias();
        }
    }
}
