using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Supershop
{
    public class LoginController
    {
        string cs = @"Data Source=DESKTOP-HJFRIJJ;Initial Catalog=SuperShopDb;Integrated Security=True;";

        public int loginIntoSystem(string username, string password, string type)
        {
            int count = 0;
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from users where user_name=@username and user_password=@password and user_type=@type", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@type", type);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return count;
        }

        private bool isTypeNumber(string type)
        {
            return Regex.IsMatch(type, @"^\d+$");
        }

        public bool validateLoginData(string username, string password, string type)
        {
            bool validate = true;

            if (username == "" || password == "" || type == "" || isTypeNumber(type))
            {
                validate = false;
            }

            return validate;
        }
    }
}
