using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemDll
{
    public partial class Db : Component
    {
        public Db()
        {
            InitializeComponent();
        }

        public Db(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public List<Item> SelectAll()
        {
            List < Item > list = new List<Item>();
            Item i = new Item();

            sqlConnection1.Open();

            sqlCommand1.CommandText = "SELECT id, marque, prix FROM items";

            //traitement

            SqlDataReader reader = sqlCommand1.ExecuteReader();

            while (reader.Read())
            {
                i = new Item(reader.GetString(1), reader.GetDouble(2));
                list.Add(i);
            }

            sqlConnection1.Close();

            return list;
        }

        public void Insert(String Marque, double Prix)
        {
            sqlConnection1.Open();

            sqlCommand1.CommandText = "Insert into items values ('"+Marque+"',"+Prix+")";

            sqlCommand1.ExecuteNonQuery();

            sqlConnection1.Close();
        }
    }
}
