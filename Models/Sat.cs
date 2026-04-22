using System;

namespace PametniSat.Models
{
    public class Sat
    {
        public int Id { get; set; }

        public int KorisnikId { get; set; }

        public string Marka { get; set; }

        public double Cena { get; set; }

        public int Baterija { get; set; }

        public int Koraci { get; set; }

        public int OtkucajiSrca { get; set; }

        public bool SleepMode { get; set; }

        public DateTime Datum { get; set; }
    }
}