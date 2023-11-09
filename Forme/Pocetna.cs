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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            definisiBrojeve();
        }
        public void definisiBrojeve()
        {
            StreamReader sr = null;
            try
            {
                int brojPacijenata = 0, brojDoktora = 0, brojPregleda = 0;

                sr = new StreamReader("Pacijenti.txt");
                while (sr.ReadLine() != null)
                {
                    brojPacijenata++;
                }
                sr.Close();

                sr = new StreamReader("Doktori.txt");
                while (sr.ReadLine() != null)
                {
                    brojDoktora++;
                }
                sr.Close();

                sr = new StreamReader("Posete.txt");
                while (sr.ReadLine() != null)
                {
                    brojPregleda++;
                }
                sr.Close();

                labelBrojPacijenata.Text = brojPacijenata.ToString();
                labelBrojDoktora.Text = brojDoktora.ToString();
                labelBrojPregleda.Text = brojPregleda.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
