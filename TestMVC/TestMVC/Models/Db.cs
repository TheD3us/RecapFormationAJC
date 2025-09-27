
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestMVC.Models
{
    partial class Db : Component
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

        public List<Article> SelectAll()
        {
            List<Article> ListArticle = new List<Article>();

            sqlConnection1.Open();
            sqlCommand1.CommandText = "select ref, marque, prix from articles";

            SqlDataReader reader = sqlCommand1.ExecuteReader();

            while (reader.Read())
            {
                Article a = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                ListArticle.Add(a);
            }

            sqlConnection1.Close();

            return ListArticle;
        }

        public Article SelectByRef(string Ref)
        {
            Article a = new Article();

            sqlConnection1.Open();
            sqlCommand1.CommandText = "select * from articles where marque = "+ Ref;
            SqlDataReader reader = sqlCommand1.ExecuteReader();
            
            try
            {
                if (reader.Read())
                {
                    a = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                }
            }
            catch
            {
                throw new Exception("Pas d'article avec cette référence");
            }

       
            return a;

               
        }

        public void Insert(int Id, string Marque, double Prix)
        {
            sqlConnection1.Open();
            sqlCommand1.CommandText = "insert into articles ( marque, prix) values ( '" + Marque + "', " + Prix + ") ";
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void Update(Article a)
        {
            sqlConnection1.Open();
            sqlCommand1.CommandText = "update articles set marque = '" + a.Marque + "' , prix = " + a.Prix + " where ref = "+ a.Id;
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public void Delete(int i)
        {
            sqlConnection1.Open();
            sqlCommand1.CommandText = "delete from articles where ref = " + i;
            sqlCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public Article SelectById(int id)
        {
            Article a = new Article();

            sqlConnection1.Open();
            sqlCommand1.CommandText = "select ref, marque, prix from articles where ref = " + id;
            SqlDataReader reader = sqlCommand1.ExecuteReader();

           
                if (reader.Read())
                {
                    a = new Article(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                }
                else
            {
                a = null;
            }
            
            


            return a;


        }
    }
}
