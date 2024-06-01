using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TranzitVZ.Models
{
    public class VozniPark
    {
        public int BrojAutobusa {  get; set; }
        public string Proizvodjac {  get; set; }
        public int BrojSjedala { get; set; }
        public int Kilometraza { get; set; }
        public string Registracija { get; set; }
    }
}
