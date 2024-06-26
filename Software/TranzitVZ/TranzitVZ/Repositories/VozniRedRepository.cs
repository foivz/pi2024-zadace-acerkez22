﻿using DBLayer;
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
        public static VozniRed GetVozniRed(int brojStanice)
        {
            VozniRed vozniRed = null;
            string sql = $"SELECT * FROM VozniRed WHERE brojStanice = {brojStanice}";
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

            string sql = "SELECT * FROM VozniRed";
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
            int brojStanice = int.Parse(reader["brojStanice"].ToString());
            string nazivStanice = reader["nazivStanice"].ToString();
            string dodatniOpis = reader["dodatniOpis"].ToString();
            string vrijemePolaska = reader["vrijemePolaska"].ToString();

            var vozniRed = new VozniRed
            {
                BrojStanice = brojStanice,
                NazivStanice = nazivStanice,
                DodatniOpis = dodatniOpis,
                VrijemePolaska = vrijemePolaska
            };
            return vozniRed;
        }
        
        public static List<VozniRed> SearchVozniRed(string trazi)
        {
            var vozniRed = new List<VozniRed>();

            string sql = $"SELECT * FROM VozniRed WHERE nazivStanice LIKE '%{trazi}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                int brojStanice = int.Parse(reader["brojStanice"].ToString());
                string nazivStanice = reader["nazivStanice"].ToString();
                string dodatniOpis = reader["dodatniOpis"].ToString();
                string vrijemePolaska = reader["vrijemePolaska"].ToString();
                var red = new VozniRed
                {
                    BrojStanice = brojStanice,
                    NazivStanice = nazivStanice,
                    DodatniOpis = dodatniOpis,
                    VrijemePolaska = vrijemePolaska
                };
                vozniRed.Add(red);
            }

            reader.Close();
            DB.CloseConnection();

            return vozniRed;
        }
        public static void DodajVozniRed(string nazivStanice, string dodatniOpis, string vrijemePolaska)
        {
            string sql = $"INSERT INTO VozniRed (nazivStanice, dodatniOpis, vrijemePolaska) VALUES ('{nazivStanice}', '{dodatniOpis}', '{vrijemePolaska}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void PromijeniVozniRed(string nazivStanice, string dodatniOpis, string vrijemePolaska, int brojStanice)
        {
            string sql = $"UPDATE VozniRed SET nazivStanice = '{nazivStanice}', dodatniOpis = '{dodatniOpis}', vrijemePolaska = '{vrijemePolaska}' WHERE brojStanice = '{brojStanice}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void BrisiVozniRed(int brojStanice)
        {
            string sql = $"DELETE FROM VozniRed WHERE brojStanice = {brojStanice}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
