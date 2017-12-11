using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rft_raktarnyilvantarto
{
    class Rendelesek : Termek
    {
        public Rendelesek(string Vonalkod, string Nev, string Tipus, int Rendelt_db)
            : base(Vonalkod, Nev, Tipus)
        {
            this.Rendelt_db = Rendelt_db;
        }
        public Rendelesek(string Vonalkod, string Nev, string Tipus, int Rendelt_db,
                            string Rendelo, DateTime Rendelesido, DateTime Erkezesido,
                            string Szallito, bool Beerkezett)
                            : this(Vonalkod, Nev, Tipus, Rendelt_db)
        {
            this.Rendelo = Rendelo;
            this.Rendelesido = Rendelesido;
            this.Erkezesido = Erkezesido;
            this.Szallito = Szallito;
            this.Beerkezet = Beerkezet;
        }


        private int rendelt_db;
        public int Rendelt_db
        {
            get { return rendelt_db; }
            set
            {
                if (value > 0) rendelt_db = value;
                else throw new Exception("Nem lehet 0-tól kevesebbet rendelni!");
            }
        }
        private string rendelo;
        public string Rendelo
        {
            get { return rendelo; }
            set
            {
                this.rendelo = value;
            }
        }
        private DateTime rendelesido;
        public DateTime Rendelesido
        {
            get { return rendelesido; }
            set
            {
                if (value <= DateTime.Today) this.rendelesido = value;
                else throw new Exception("Nem lehet a mai naptól későbbi rendelési dátum!");
            }
        }
        private DateTime erkezesido;
        public DateTime Erkezesido
        {
            get { return erkezesido; }
            set
            {
                if (value > DateTime.Today) this.erkezesido = value;
                else throw new Exception("Nem lehet a mai naptól régebbi érkezési idő!");
            }
        }
        private string szallito;
        public string Szallito
        {
            get { return szallito; }
            set
            {
                this.szallito = value;
            }
        }
        private bool beerkezett;
        public bool Beerkezet
        {
            get { return beerkezett; }
            set
            {
                if (value == true) this.beerkezett = true;
                else this.beerkezett = false;
            }
        }
    }
}
