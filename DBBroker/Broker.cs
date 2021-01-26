using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GrupniTreninzi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void OtvoriKonekciju()
        {
            connection.Open();

        }

        public void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void RollBack()
        {
            transaction?.Rollback();
        }

        public int Obrisi(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"DELETE FROM {objekat.TableName} WHERE {objekat.KriterijumPretrage}";
            return command.ExecuteNonQuery();
        }

        public int Sacuvaj(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"INSERT INTO {objekat.TableName} VALUES ({objekat.InsertValues})";
            return command.ExecuteNonQuery();
        }

        public DomenskiObjekat VratiJedan(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT * FROM {objekat.TableName} WHERE {objekat.KriterijumPretrage}";
            SqlDataReader reader = command.ExecuteReader();
            DomenskiObjekat rezultat = objekat.GetEntity(reader);
            reader.Close();
            return rezultat;
        }

        public List<DomenskiObjekat> VratiSve(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT * FROM {objekat.TableName}";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = objekat.GetEntities(reader);
            reader.Close();
            return rezultat;
        }

        public List<DomenskiObjekat> VratiSveJoin(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT * FROM {objekat.TableName} {objekat.JoinFull}";
            Console.WriteLine(command.CommandText);
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = objekat.GetEntities(reader);
            reader.Close();
            return rezultat;
        }

        public List<DomenskiObjekat> Pronadji(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"SELECT * FROM {objekat.TableName} WHERE {objekat.KriterijumPretrage}";
            SqlDataReader reader = command.ExecuteReader();
            List<DomenskiObjekat> rezultat = objekat.GetEntities(reader);
            reader.Close();
            return rezultat;
        }

        public object Azuriraj(DomenskiObjekat objekat)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"UPDATE {objekat.TableName} SET {objekat.UpdateValues} WHERE {objekat.KriterijumPretrage}";
            object rezultat = command.ExecuteNonQuery();
            return rezultat;
        }
    }
}
