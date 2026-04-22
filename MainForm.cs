using PametniSat.BusinessLayer;
using PametniSat.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PametniSat
{
    public partial class MainForm : Form
    {
        int korisnikId;

        SatService service = new SatService();

        public MainForm(int id)
        {
            InitializeComponent();

            korisnikId = id;

            LoadSatovi();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        void LoadSatovi()
        {
            List<Sat> lista = service.GetSatovi(korisnikId);

            dataGridSatovi.DataSource = null;
            dataGridSatovi.DataSource = lista;
            dataGridSatovi.Columns["Id"].Visible = false;
            dataGridSatovi.Columns["KorisnikId"].Visible = false;
        }

        private void btnObrisiSat_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridSatovi.CurrentRow.Cells["Id"].Value;

            service.DeleteSat(id);

            LoadSatovi();
        }

        private void btnNapuni_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridSatovi.CurrentRow.Cells["Id"].Value;

            service.NapuniSat(id);

            LoadSatovi();
        }

        private void btnKoraci_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridSatovi.CurrentRow.Cells["Id"].Value;

            service.DodajKorake(id);

            LoadSatovi();
        }

        private void btnDodajSat_Click(object sender, EventArgs e)
        {
            DodajSatForm form = new DodajSatForm(korisnikId);

            form.ShowDialog();

            LoadSatovi();
        }

        private void btnSrce_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridSatovi.CurrentRow.Cells["Id"].Value;

            int puls = service.OtkucajiSrca(id);

            if (puls > 120)
            {
                MessageBox.Show("Upozorenje! Puls je previsok: " + puls);
            }
            else if (puls < 50)
            {
                MessageBox.Show("Upozorenje! Puls je prenizak: " + puls);
            }
            else
            {
                MessageBox.Show("Puls je normalan: " + puls);
            }

            LoadSatovi();
        }
        private void btnPulsHistory_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridSatovi.CurrentRow.Cells["Id"].Value;

            PulsHistoryForm form = new PulsHistoryForm(id);

            form.ShowDialog();
        }
        private void btnDatum_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridSatovi.CurrentRow.Cells["Id"].Value;

            service.UpdateDatum(id);

            LoadSatovi();
        }
    }
}