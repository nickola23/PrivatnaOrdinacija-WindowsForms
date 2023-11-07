using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatnaOrdinacija_WindowsForms
{
    internal class Pacijent<T> : Osoba<T>
    {
        protected T brojKnjizice, adresa, pol, izabraniLekar, alergije, istorijaBolesti;
        public Pacijent() { }
        public Pacijent(T ime, T prezime, T datumRodjenja, T jmbg, T telefon, T brojKnjizice, T adresa, T pol, T izabraniLekar, T alergije, T istorijaBolesti) : base(ime, prezime, datumRodjenja, jmbg, telefon)
        {
            BrojKnjizice = brojKnjizice;
            Adresa = adresa;
            Pol = pol;
            IzabraniLekar = izabraniLekar;
            Alergije = alergije;
            IstorijaBolesti = istorijaBolesti;
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
        public T Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public T Pol
        {
            get { return pol; }
            set {
                if (pol.ToString() == "M" || pol.ToString() == "Ž") pol = value;
                else throw new Exception("Uneti pol mora biti M ili Ž");
            }
        }
        public T IzabraniLekar
        {
            get { return izabraniLekar; }
            set { izabraniLekar = value; }
        }
        public T Alergije
        {
            get { return alergije; }
            set { alergije = value; }
        }
        public T IstorijaBolesti
        {
            get { return istorijaBolesti; }
            set { istorijaBolesti = value; }
        }
    }
}
