using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.ComponentModel;
using System.Text.RegularExpressions;


namespace Supershop
{
    public class ProductInsertController
    {
        /*string cs = @"Data Source=DESKTOP-HJFRIJJ;Initial Catalog=SuperShopDb;Integrated Security=True;

        public int insertProduct(string name, double price, int available)
        {
              int i = 0;
              try
              {
                  SqlConnection con = new SqlConnection(cs);
                  SqlCommand cmd = new SqlCommand("insert into products(product_name,product_price,product_available) values (@name , @price , @available) ", con);

                  cmd.Parameters.AddWithValue("@name", name);
                  cmd.Parameters.AddWithValue("@price", price);
                  cmd.Parameters.AddWithValue("@available", available);
                  con.Open();
                  i = cmd.ExecuteNonQuery();
                  con.Close();
             }
             catch (Exception ex)
             {
                  //MessageBox.Show(ex.Message);
                  Console.WriteLine(ex.StackTrace);
             }
              return i;
        }*/


        public bool validateInsertedPd(string name, string price, string available)
        {
            bool validate = true;     

            if (name == "" || price == null || available == null)
            {
                validate = false;
            }
            else
            {
                try
                {
                    double price2 = Convert.ToDouble(price);
                    int avl = Convert.ToInt32(available);

                    validate = true;
                }
                catch (Exception ex)
                {
                    validate = false;
                    Console.WriteLine(ex.StackTrace);
                }
            }

           return validate;
        }
    }
}
