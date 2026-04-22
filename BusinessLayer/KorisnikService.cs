using PametniSat.DataLayer;
using PametniSat.Models;

namespace PametniSat.BusinessLayer
{
    public class KorisnikService
    {
        KorisnikRepository repo = new KorisnikRepository();

        public Korisnik Login(string ime, string lozinka)
        {
            return repo.Login(ime, lozinka);
        }
        public void Register(string ime, string lozinka)
        {
            repo.Register(ime, lozinka);
        }
        public bool PostojiKorisnik(string ime)
        {
            return repo.PostojiKorisnik(ime);
        }
    }
}