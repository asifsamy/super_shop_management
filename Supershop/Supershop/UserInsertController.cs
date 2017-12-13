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
    public class UserInsertController
    {

        private bool isTypeNumber(string type)
        {
            return Regex.IsMatch(type, @"^\d+$");
        }

        public bool validateInsertedUser(string name, string type, string password)
        {
            bool validate = true;

            if (name == "" || type == "" || password == "" || password.Length <= 3 || isTypeNumber(type))
            {
                validate = false;
            }

           return validate;
        }
    }
}
