using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivatnaOrdinacija_WindowsForms.Forme
{
    public partial class DodajDoktora : Form
    {
        public DodajDoktora()
        {
            InitializeComponent();
        }

        private void buttonDodajDoktora_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("Doktori.txt", true);

                string ime = textBoxIme.Text;
                string prezime = textBoxPrezime.Text;
                string datumRodjenja = textBoxDatumRodjenja.Text;
                string jmbg = textBoxJMBG.Text;
                string telefon = textBoxTelefon.Text;
                string brojLicence = textBoxBrojLicence.Text;
                string Specijalizacija = textBoxSpecijalizacija.Text;

                Doktor<string> doktor = new Doktor<string>(ime, prezime, datumRodjenja, jmbg, telefon, brojLicence, Specijalizacija);
                doktor.upis(sw);

                textBoxIme.Text = string.Empty;
                textBoxPrezime.Text = string.Empty;
                textBoxDatumRodjenja.Text = string.Empty;
                textBoxJMBG.Text = string.Empty;
                textBoxTelefon.Text = string.Empty;
                textBoxBrojLicence.Text = string.Empty;
                textBoxSpecijalizacija.Text = string.Empty;

                MessageBox.Show("Uspešno ste dodali Doktora " + doktor.Ime + " " + doktor.Prezime, "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            textBoxIme.Text = string.Empty;
            textBoxPrezime.Text = string.Empty;
            textBoxDatumRodjenja.Text = string.Empty;
            textBoxJMBG.Text = string.Empty;
            textBoxTelefon.Text = string.Empty;
            textBoxBrojLicence.Text = string.Empty;
            textBoxSpecijalizacija.Text = string.Empty;
        }
    }
}
