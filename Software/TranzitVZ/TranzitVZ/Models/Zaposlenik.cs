using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranzitVZ.Models
{
    public class Zaposlenik
    {
        public int Id { get; set; }
        public string Ime {  get; set; }
        public string Prezime {  get; set; }
        public string Username {  get; set; }
        public string Password {  get; set; }
    }
}
