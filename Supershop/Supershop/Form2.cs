using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Product Entry Page
namespace Supershop
{
    public partial class Form2 : Form
    {
        private readonly ProductInsertController pdInController;
        string cs = @"Data Source=DESKTOP-HJFRIJJ;Initial Catalog=SuperShopDb;Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
            pdInController = new ProductInsertController();
            SqlConnection con = new SqlConnection(cs);
            string sqlQuery = @"SELECT * from products";
            SqlCommand cmd3 = new SqlCommand(sqlQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = new BindingSource(table, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string priceF = textBox2.Text;
            string availableF = textBox3.Text;
            SqlConnection con = new SqlConnection(cs);

            if (pdInController.validateInsertedPd(name, priceF, availableF))
            {
                //int i = pdInController.insertProduct(name, price, available);
                double price = Convert.ToDouble(textBox2.Text);
                int available = Convert.ToInt32(textBox3.Text);

                SqlCommand cmd = new SqlCommand("insert into products(product_name,product_price,product_available) values (@name , @price , @available) ", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@available", available);
                con.Open();
                int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show(i + " Product Inserted Successfully!");
                }

            }
            else
            {
                MessageBox.Show(@"Product Name should not be empty
                Price should not be emplty and string
                Availability should not empty and string!", @"Error");
            }

            /*SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("insert into products(product_name,product_price,product_available) values (@name , @price , @available) ", con);
            double price = Convert.ToDouble(textBox2.Text);
            int available = Convert.ToInt32(textBox3.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@available", available);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + " Product Inserted!");
            }*/

            string sqlQuery = @"SELECT * from products";
            SqlCommand cmd2 = new SqlCommand(sqlQuery, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = new BindingSource(table, null);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
        } 
    }
}
