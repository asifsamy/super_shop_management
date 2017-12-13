using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Login Page
namespace Supershop
{
    public partial class Form1 : Form
    {
        private readonly LoginController loginController;
        public Form1()
        {
            InitializeComponent();
            loginController = new LoginController();
        }
       
        //string cs = @"Data Source=DESKTOP-HJFRIJJ;Initial Catalog=SuperShopDb;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string type     = textBox3.Text;

            if (loginController.validateLoginData(username, password, type))
            {
                int count = loginController.loginIntoSystem(username, password, type);
                
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Failed! Username, Password or Type Mismatched");
                }
            }
            else
            {
                MessageBox.Show(@"Userame should not be empty
                Password should not be emplty
                Type should not empty and should be string!", @"Error");
            }
        }
    }
}
