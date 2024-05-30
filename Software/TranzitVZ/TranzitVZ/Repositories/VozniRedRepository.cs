using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranzitVZ.Models;
namespace TranzitVZ.Repositories
{
    public class VozniRedRepository
    {
        public static VozniRed GetVozniRed(int id)
        {
            VozniRed vozniRed = null;
            string sql = $"SELECT * FROM voznired WHERE idVoznogReda = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows)
            {
                reader.Read();
                vozniRed = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vozniRed;
        }

        public static List<VozniRed> GetVozniReds()
        {
            var vozniReds = new List<VozniRed>();

            string sql = "SELECT * FROM voznired";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                VozniRed vozniRed = CreateObject(reader);
                vozniReds.Add(vozniRed);
            }

            reader.Close();
            DB.CloseConnection();

            return vozniReds;
        }

        private static VozniRed CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idVoznogReda"].ToString());
            int idLinije = int.Parse(reader["idLinije"].ToString());
            int idStanice = int.Parse(reader["idStanice"].ToString());

            var vozniRed = new VozniRed
            {
                IdVoznogReda = id,
                IdLinije = idLinije,
                IdStanice = idStanice,
            };
            return vozniRed;
        }
    }
}
