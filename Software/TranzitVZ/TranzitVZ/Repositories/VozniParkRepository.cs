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

            var vozniPark = new VozniPark
            {
                BrojAutobusa = brojAutobusa,
                Proizvodjac = proizvodjac,
                BrojSjedala = brojSjedala,
                Kilometraza = kilometraza
            };
            return vozniPark;
        }
    }
}
