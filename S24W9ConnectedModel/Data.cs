using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S24W9ConnectedModel
{
    public class Data
    {
        private static string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";

        public static string ConnectionStr { get { return connectionStr; } }
    }
}
