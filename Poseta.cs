using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivatnaOrdinacija_WindowsForms
{
    internal class Poseta<T> : IPoseta
    {
        protected T ime, prezime, brojKnjizice, datumPosete, datumSledecePosete, izabraniLekar, razlogPosete, beleske, propisaniLekovi;
        public Poseta() { }
        public Poseta(T ime, T prezime, T brojKnjizice, T datumPosete, T datumSledecePosete, T izabraniLekar, T razlogPosete, T beleske, T propisaniLekovi)
        {
            Ime = ime;
            Prezime = prezime;
            BrojKnjizice = brojKnjizice;
            DatumPosete = datumPosete;
            DatumSledecePosete = datumSledecePosete;
            IzabraniLekar = izabraniLekar;
            RazlogPosete = razlogPosete;
            Beleske = beleske;
            PropisaniLekovi = propisaniLekovi;
        }

        public T Ime
        {
            get { return ime; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti ime");
                else ime = value;
            }
        }
        public T Prezime
        {
            get { return prezime; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti prezime");
                else prezime = value;
            }
        }
        public T BrojKnjizice
        {
            get { return brojKnjizice; }
            set
            {
                if (value.ToString().Length == 11) brojKnjizice = value;
                else throw new Exception("Broj Knjižice mora imati 11 cifara");
            }
        }
        public T DatumPosete
        {
            get { return datumPosete; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Datum posete");
                else datumPosete = value;
            }
        }
        public T DatumSledecePosete
        {
            get { return datumSledecePosete; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Datum sledece posete");
                else datumSledecePosete = value;
            }
        }
        public T IzabraniLekar
        {
            get { return izabraniLekar; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Izabranog lekara");
                else izabraniLekar = value;
            }

        }
        public T RazlogPosete
        {
            get { return razlogPosete; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Razlog posete");
                else razlogPosete = value;
            }
        }
        public T Beleske
        {
            get { return beleske; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Beleske i dijagnozu");
                else beleske = value;
            }
        }
        public T PropisaniLekovi
        {
            get { return propisaniLekovi; }
            set
            {
                if (value.ToString() == "") throw new Exception("Morate uneti Propisane lekove");
                else propisaniLekovi = value;
            }
        }
        virtual public void upis(StreamWriter sw)
        {
            sw.Write("\n" + Ime + ", ");
            sw.Write(Prezime + ", ");
            sw.Write(BrojKnjizice + ", ");
            sw.Write(DatumPosete + ", ");
            sw.Write(DatumSledecePosete + ", ");
            sw.Write(IzabraniLekar + ", ");
            sw.Write(RazlogPosete + ", ");
            sw.Write(Beleske + ", ");
            sw.Write(PropisaniLekovi);

            sw.Close();
        }
        virtual public string ispis()
        {
            return Ime + " " + Prezime + " ,Datum: " + DatumPosete + " ,Lekar: " + izabraniLekar;
        }
        virtual public void citaj(string linija)
        {
            T[] podaci;
            if (linija != null)
            {
                string[] delovi = linija.Split(',');
                for (int i = 0; i < delovi.Length; i++)
                {
                    delovi[i] = delovi[i].Trim();
                }
                podaci = new T[delovi.Length];
                for (int i = 0; i < delovi.Length; i++)
                {
                    podaci[i] = (T)Convert.ChangeType(delovi[i], typeof(T));
                }
            }
            else throw new Exception("Ne postoje podaci za Posetu");

            Ime = podaci[0];
            Prezime = podaci[1];
            BrojKnjizice = podaci[2];
            DatumPosete = podaci[3];
            DatumSledecePosete = podaci[4];
            IzabraniLekar = podaci[5];
            RazlogPosete = podaci[6];
            Beleske = podaci[7];
            PropisaniLekovi = podaci[8];
        }
    }
}
