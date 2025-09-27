using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoGenerique
{
    class DaoPersonneSqlServer : IDaoPersonne
    {
        public void Create(Personne p)
        {
            string connectionString = @"Data Source=PC-JACKY2\SQLEXPRESS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "insert into personnes values (@id,@nom,@prenom,@age)";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.Parameters.Add("id", SqlDbType.Int).Value = p.Id;
            command.Parameters.Add("nom", SqlDbType.NVarChar).Value = p.Nom;
            command.Parameters.Add("prenom", SqlDbType.NVarChar).Value = p.Prenom;
            command.Parameters.Add("age", SqlDbType.Int).Value = p.Age;

            connection.Open();
            // execution de la requete
            command.ExecuteNonQuery();
            // Console.WriteLine(sql);

            connection.Close();
        }

        public void Delete(int id)
        {
            string connectionString = @"Data Source=PC-JACKY2\SQLEXPRESS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "delete from personnes where id=" + id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            // execution de la requete
            int nb = command.ExecuteNonQuery();


            connection.Close();
        }

        public List<Personne> FindAll()
        {
            List<Personne> liste = new List<Personne>();
            string connectionString = @"Data Source=PC-JACKY2\SQLEXPRESS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "select * from personnes";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Personne p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                   reader.GetInt32(3));
                liste.Add(p);
            }
            connection.Close();


            return liste;
        }

        public Personne FindById(int id)
        {
            Personne p = null;
            string connectionString = @"Data Source=PC-JACKY2\SQLEXPRESS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "select * from personnes where id=" + id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                   reader.GetInt32(3));
            }
            connection.Close();


            return p;
        }

        public List<Personne> FindByNom(string nom)
        {
            List<Personne> liste = new List<Personne>();
            string connectionString = @"Data Source=PC-JACKY2\SQLEXPRESS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "select * from personnes where nom='" + nom + "'";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Personne p = new Personne(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                   reader.GetInt32(3));
                liste.Add(p);
            }
            connection.Close();


            return liste;
        }

        public void Update(Personne p)
        {
            string connectionString = @"Data Source=PC-JACKY2\SQLEXPRESS;Initial Catalog=ajc_formation;Integrated Security=True";
            string sql = "update personnes set nom='" + p.Nom + "',prenom='" + p.Prenom + "',age=" + p.Age + "  where id=" + p.Id;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            // execution de la requete
            command.ExecuteNonQuery();
            int nb = command.ExecuteNonQuery();


            connection.Close();
        

    }
}
}
