namespace Actividad_Practica_3
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            button4 = new Button();
            textBox9 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox7 = new TextBox();
            label10 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(48, 317);
            button1.Name = "button1";
            button1.Size = new Size(1257, 75);
            button1.TabIndex = 12;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(32, 398);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1295, 275);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1252, 259);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(861, 35);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(466, 276);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(153, 110);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(155, 27);
            textBox11.TabIndex = 27;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(6, 182);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(305, 88);
            textBox10.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(153, 87);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 26;
            label12.Text = "Precio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 159);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 26;
            label11.Text = "Descripcion";
            label11.Click += label11_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 27);
            textBox3.TabIndex = 19;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Alimentos", "Bebidas", "Limpieza", "Electrónicos" });
            comboBox3.Location = new Point(345, 110);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(93, 28);
            comboBox3.TabIndex = 10;
            comboBox3.Text = "Categorias";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.Font = new Font("Segoe UI", 10F);
            button4.Location = new Point(342, 191);
            button4.Name = "button4";
            button4.Size = new Size(101, 51);
            button4.TabIndex = 17;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(26, 46);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(164, 27);
            textBox9.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 23);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 9;
            label9.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(209, 23);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 11;
            label8.Text = "Nombre";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(209, 46);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(229, 27);
            textBox8.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 90);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 13;
            label7.Text = "Stock";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(559, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 242);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Location = new Point(61, 91);
            button3.Name = "button3";
            button3.Size = new Size(142, 51);
            button3.TabIndex = 9;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(22, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 27);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 23);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 9;
            label5.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 281);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(189, 113);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(155, 27);
            textBox7.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(189, 90);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 24;
            label10.Text = "Precio";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(16, 183);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(305, 88);
            textBox6.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 160);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 22;
            label6.Text = "Descripcion";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(89, 27);
            textBox4.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 90);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 20;
            label3.Text = "Stock";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(394, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(93, 28);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Categorias";
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.Location = new Point(380, 220);
            button2.Name = "button2";
            button2.Size = new Size(107, 51);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 124);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 23);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 709);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button button4;
        private TextBox textBox9;
        private Label label9;
        private Label label8;
        private TextBox textBox8;
        private Label label7;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox textBox5;
        private Label label5;
        private GroupBox groupBox1;
        private Button button2;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox11;
        private Label label12;
    }
}