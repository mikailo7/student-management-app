using System.Collections.Generic;
using PametniSat.DataLayer;
using PametniSat.Models;

namespace PametniSat.BusinessLayer
{
    public class SatService
    {
        SatRepository repo = new SatRepository();

        public List<Sat> GetSatovi(int id)
        {
            return repo.GetSatovi(id);
        }

        public void DeleteSat(int id)
        {
            repo.DeleteSat(id);
        }

        public void NapuniSat(int id)
        {
            repo.NapuniSat(id);
        }

        public void DodajKorake(int id)
        {
            repo.DodajKorake(id);
        }

        public void SleepMode(int id)
        {
            repo.SleepMode(id);
        }

        public int OtkucajiSrca(int id)
        {
            return repo.OtkucajiSrca(id);
        }
        public void UpdateDatum(int id)
        {
            repo.UpdateDatum(id);
        }
    }
}