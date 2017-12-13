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
    public class ProductSaleController
    {
        public bool checkAvailability(int available)
        {
            bool validate = false;
            if (available >= 1)
                validate = true;

            return validate;
        }
    }
}
