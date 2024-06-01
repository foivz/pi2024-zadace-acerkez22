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
    public class ZaposlenikRepository
    {
        public static Zaposlenik GetZaposlenik (string username)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE username = '{username}'";
            return FetchZaposlenik(sql);
        }
        private static Zaposlenik FetchZaposlenik(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if(reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return zaposlenik;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idZaposlenika"].ToString());
            string ime = reader["ime"].ToString();
            string prezime = reader["prezime"].ToString();
            string username = reader["username"].ToString();
            string password = reader["password"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Username = username,
                Password = password
            };
            return zaposlenik;
        }
    }
    
}
