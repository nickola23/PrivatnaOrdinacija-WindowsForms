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
    public partial class Izvestaji : Form
    {
        Poseta<string>[] posete;
        public Izvestaji()
        {
            InitializeComponent();
            deklarisiIzvestaje();
            ispisiIzvestaje();
        }
        public void deklarisiIzvestaje()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("Posete.txt");
                string linija = "";
                int brojPoseta = 0, i = 0;

                while (sr.ReadLine() != null)
                {
                    brojPoseta++;
                }

                posete = new Poseta<string>[brojPoseta];
                sr = new StreamReader("Posete.txt");
                linija = sr.ReadLine();

                while (linija != null)
                {
                    posete[i] = new Poseta<string>();
                    posete[i].citaj(linija);
                    linija = sr.ReadLine();
                    i++;
                }
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
        public void ispisiIzvestaje()
        {
            dataGridViewIzvestaji.DataSource = posete;

            dataGridViewIzvestaji.Columns["Ime"].DisplayIndex = 0;
            dataGridViewIzvestaji.Columns["Prezime"].DisplayIndex = 1;
            dataGridViewIzvestaji.Columns["DatumPosete"].DisplayIndex = 2;
            dataGridViewIzvestaji.Columns["DatumSledecePosete"].DisplayIndex = 3;
            dataGridViewIzvestaji.Columns["BrojKnjizice"].DisplayIndex = 4;
            dataGridViewIzvestaji.Columns["IzabraniLekar"].DisplayIndex = 5;
            dataGridViewIzvestaji.Columns["RazlogPosete"].DisplayIndex = 6;
            dataGridViewIzvestaji.Columns["Beleske"].DisplayIndex = 7;
            dataGridViewIzvestaji.Columns["PropisaniLekovi"].DisplayIndex = 8;

        }
    }
}
