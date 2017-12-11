using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rft_raktarnyilvantarto
{
    class Termek
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string vonalkod;
        public string Vonalkod
        {
            get { return vonalkod; }
            set
            {
                if (value.Length == 13)
                {
                    if (value == "0000000000000") // Elfogadjuk a full 0 állapotot is
                    {
                        vonalkod = value;
                        return;
                    }

                    int paros = 0;
                    int paratlan = 0;

                    for (int i = 0; i < value.Length - 1; i++)
                    {
                        if (i % 2 == 0) paratlan += (int)Char.GetNumericValue(value[i]);
                        else paros += (int)Char.GetNumericValue(value[i]);
                    }

                    paros *= 3;
                    int osszeg = paros + paratlan;
                    osszeg = 10 - (osszeg % 10);


                    if (osszeg.ToString() == value[12].ToString()) vonalkod = value;
                    else throw new Exception("A termék vonalkódja nem felel meg az EAN13 típusú vonalkód szabályainak!");

                }
                else throw new Exception("A termék vonalkódja nem felel meg az EAN13 típusú vonalkód szabályainak!");
            }
        }

        private string nev;
        public string Nev
        {
            get { return nev; }

            set
            {
                if (value != null && value.Length >= 3) nev = value;
                else throw new Exception("A Termék nevének legalább 3 karakter hosszúnak kell lennie!");
            }
        }

        private string tipus;
        public string Tipus
        {
            get { return tipus; }
            set
            {
                if (value != null) tipus = value;
                else tipus = "";
            }
        }

        private int raktar_db;
        public int Raktar_db
        {
            get { return raktar_db; }

            set
            {
                if (value >= 0) raktar_db = value;
                else throw new Exception("A termék - raktár db értéke nem lehet kisebb mint 0!");
            }
        }

        private int min_db;
        public int Min_db
        {
            get { return min_db; }
            set
            {
                if (value >= 0) min_db = value;
                else throw new Exception("A termék - minimum db értéke nem lehet kisebb mint 0!");
            }
        }

        private List<int> megrendelok; // Több megrendelési lehetőség is tartozhat egy termékhez, idd a megrendelők ID jét tároljuk
        public List<int> Megrendelok
        {
            get { return megrendelok; }
            set { megrendelok = value; }
        }

        //Metódusok
        public void Add_megrendelo(int Id)
        {
            Megrendelok.Add(Id);
        }

        // Konstruktorok
        public Termek()
        {
            Id = 0;
            Vonalkod = "0000000000000";
            Nev = "atm";
            Tipus = "";
            Raktar_db = 0;
            Min_db = 0;
            Megrendelok = new List<int>();
        }

        public Termek(string Vonalkod, string Nev) : this()
        {
            this.Vonalkod = Vonalkod;
            this.Nev = Nev;
        }

        public Termek(string Vonalkod, string Nev, int Raktar_db) : this(Vonalkod, Nev)
        {
            this.Raktar_db = Raktar_db;
        }
        public Termek(string Vonalkod, string Nev, string Tipus) : this(Vonalkod, Nev)
        {
            this.Tipus = Tipus;
        }

        public Termek(string Vonalkod, string Nev, int Raktar_db, int Min_db) : this(Vonalkod, Nev, Raktar_db)
        {
            this.Min_db = Min_db;
        }

        public Termek(int Id, string Vonalkod, string Nev, string Tipus, int Raktar_db, int Min_db):this(Vonalkod,Nev,Raktar_db,Min_db)
        {
            this.Id = Id;
            this.Tipus = Tipus;
        }
    }
}
