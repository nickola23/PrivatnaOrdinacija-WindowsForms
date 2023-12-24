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
        int brojPacijenata = 0, brojDoktora = 0, brojPregleda = 0;
        public Pocetna()
        {
            InitializeComponent();
            definisiBrojeve();
        }
        private void PostaviRezultat(Label labelRezultat, int rezultat)
        {
            if (labelRezultat.InvokeRequired)
            {
                labelRezultat.Invoke((MethodInvoker)delegate { labelRezultat.Text = rezultat.ToString(); });
            }
            else
            {
                labelRezultat.Text = rezultat.ToString();
            }
        }
        async public void izracunajPacijente(StreamReader sr)
        {
            if (!File.Exists("Pacijenti.txt")) File.Create("Pacijenti.txt").Close();
            sr = new StreamReader("Pacijenti.txt");
            while (sr.ReadLine() != null)
            {
                brojPacijenata++;
            }
            sr.Close();

            await Task.Delay(3000); //Ukloniti kada se zavrsi izrada niti 

            PostaviRezultat(labelBrojPacijenata, brojPacijenata);
        }
        public async void izracunajDoktore(StreamReader sr)
        {
            if (!File.Exists("Doktori.txt")) File.Create("Doktori.txt").Close();
            sr = new StreamReader("Doktori.txt");
            while (sr.ReadLine() != null)
            {
                brojDoktora++;
            }
            sr.Close();

            await Task.Delay(1000); //Ukloniti kada se zavrsi izrada niti 

            PostaviRezultat(labelBrojDoktora, brojDoktora);
        }
        public async void izracunajPreglede(StreamReader sr)
        {
            if (!File.Exists("Posete.txt")) File.Create("Posete.txt").Close();
            sr = new StreamReader("Posete.txt");
            while (sr.ReadLine() != null)
            {
                brojPregleda++;
            }
            sr.Close();

            await Task.Delay(2000); //Ukloniti kada se zavrsi izrada niti 

            PostaviRezultat(labelBrojPregleda, brojPregleda);
        }
        public void definisiBrojeve()
        {
            StreamReader sr = null;
            try
            {
                Task.Run(() => izracunajPacijente(sr));

                Task.Run(() => izracunajDoktore(sr));

                Task.Run(() => izracunajPreglede(sr));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
