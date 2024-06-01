using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranzitVZ.Models;
using DBLayer;
using System.Data.SqlClient;
namespace TranzitVZ.Repositories
{
    public class VozniParkRepository
    {
        public static VozniPark GetVozniPark(int brojAutobusa)
        {
            VozniPark vozniPark = null;
            string sql = $"SELECT * FROM VozniPark WHERE brojAutobusa = {brojAutobusa}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vozniPark = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozniPark;
        }

        public static List<VozniPark> GetVozniParks()
        {
            var vozniParks = new List<VozniPark>();

            string sql = "SELECT * FROM VozniPark";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                VozniPark vozniPark = CreateObject(reader);
                vozniParks.Add(vozniPark);
            }

            reader.Close();
            DB.CloseConnection();

            return vozniParks;
        }

        private static VozniPark CreateObject(SqlDataReader reader)
        {
            int brojAutobusa = int.Parse(reader["brojAutobusa"].ToString());
            string proizvodjac = reader["proizvodjac"].ToString();
            int brojSjedala = int.Parse(reader["brojSjedala"].ToString());
            int kilometraza = int.Parse(reader["kilometraza"].ToString());
            string registracija = reader["registracija"].ToString();

            var vozniPark = new VozniPark
            {
                BrojAutobusa = brojAutobusa,
                Proizvodjac = proizvodjac,
                BrojSjedala = brojSjedala,
                Kilometraza = kilometraza,
                Registracija = registracija
            };
            return vozniPark;
        }
        public static List<VozniPark> SearchVozniPark(string trazi)
        {
            var vozniPark = new List<VozniPark>();

            string sql = $"SELECT * FROM VozniPark WHERE proizvodjac LIKE '%{trazi}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                int brojAutobusa = int.Parse(reader["brojAutobusa"].ToString());
                string proizvodjac = reader["proizvodjac"].ToString();
                int brojSjedala = int.Parse(reader["brojSjedala"].ToString());
                int kilometraza = int.Parse(reader["kilometraza"].ToString());
                string registracija = reader["registracija"].ToString();
                var red = new VozniPark
                {
                    BrojAutobusa = brojAutobusa,
                    Proizvodjac = proizvodjac,
                    BrojSjedala = brojSjedala,
                    Kilometraza = kilometraza,
                    Registracija = registracija
                };
                vozniPark.Add(red);
            }

            reader.Close();
            DB.CloseConnection();

            return vozniPark;
        }

        public static void DodajVozniPark(string proizvodjac, int brojSjedala, int kilometraza, string registracija)
        {
            string sql = $"INSERT INTO VozniPark (proizvodjac, brojSjedala, kilometraza, registracija) VALUES ('{proizvodjac}', '{brojSjedala}', '{kilometraza}', '{registracija}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void PromijeniVozniPark(string proizvodjac, int brojSjedala, int kilometraza, string registracija, int brojAutobusa)
        {
            string sql = $"UPDATE VozniPark SET proizvodjac = '{proizvodjac}', brojSjedala = '{brojSjedala}', kilometraza = '{kilometraza}', registracija = '{registracija}' WHERE brojAutobusa = '{brojAutobusa}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void BrisiVozniPark(int brojAutobusa)
        {
            string sql = $"DELETE FROM VozniPark WHERE brojAutobusa = {brojAutobusa}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
