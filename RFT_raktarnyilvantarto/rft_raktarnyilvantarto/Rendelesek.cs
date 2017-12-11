using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rft_raktarnyilvantarto
{
    class Rendelesek : Termek
    {
        string ma = DateTime.Today.ToString();
        
        public Rendelesek(string Vonalkod, string Nev, string Tipus, int Rendelt_db)
            : base(Vonalkod, Nev, Tipus)
        {
            this.Rendelt_db = Rendelt_db;
        }
        public Rendelesek(string Vonalkod, string Nev, string Tipus, int Rendelt_db,
                            string Rendelo, string Rendelesido, string Erkezesido,
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
        private string rendelesido;
        public string Rendelesido
        {
            get { return rendelesido; }
            set
            {
                this.rendelesido = value;
            }
        }
        private string erkezesido;
        public string Erkezesido
        {
            get { return erkezesido; }
            set
            {
                this.erkezesido = value;
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
