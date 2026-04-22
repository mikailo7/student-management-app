using System;
using System.Windows.Forms;
using PametniSat.BusinessLayer;

namespace PametniSat
{
    public partial class RegisterForm : Form
    {
        KorisnikService service = new KorisnikService();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtPrezime.Text == "")
            {
                MessageBox.Show("Popunite sva polja");
                return;
            }
            if (service.PostojiKorisnik(txtIme.Text))
            {
                MessageBox.Show("Korisnik već postoji");
                return;
            }

            service.Register(txtIme.Text, txtPrezime.Text);

            MessageBox.Show("Korisnik uspešno registrovan");

            this.Close();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}