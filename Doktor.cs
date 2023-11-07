using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatnaOrdinacija_WindowsForms
{
    internal class Doktor<T> : Osoba<T>
    {
        protected T brojLicence, specijalizacija;
        public Doktor() { }
        public Doktor(T ime, T prezime, T datumRodjenja, T jmbg, T telefon, T brojLicence, T specijalizacija) : base(ime, prezime, datumRodjenja, jmbg, telefon)
        {
            BrojLicence = brojLicence;
            Specijalizacija = specijalizacija;
        }

        public T BrojLicence
        {
            get { return brojLicence; }
            set { brojLicence = value; }
        }
        public T Specijalizacija
        {
            get { return specijalizacija; }
            set { specijalizacija = value; }
        }
    }
}
