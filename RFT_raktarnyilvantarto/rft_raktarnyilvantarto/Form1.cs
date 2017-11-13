using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace rft_raktarnyilvantarto
{
    public partial class Form1 : Form
    {
        static OleDbConnection Connect = new OleDbConnection();

        static List<Termek> Termekek = new List<Termek>();
        static List<Megrendelo> Megrendelok = new List<Megrendelo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdatbazisBeolvasasa(@"C:\Users\dmark\Desktop\Beadando nyivantarto\RFT-raktarnyilvantarto\Database.accdb");
        }

        private void AdatbazisBeolvasasa(string path)
        {
            Connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @";User Id=admin;Password=";
            Connect.Open();

            //Termékek
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = Connect;
            Command.CommandText = "SELECT Vonalkod, Megnevezes, Tipus, Raktar_db, Minimum_db, Megrendelo FROM Termek";

            OleDbDataReader Reader = Command.ExecuteReader();
            Termek atm = new Termek("1111111111116","atm");

            while (Reader.Read())
            {
                atm.Vonalkod = Reader[0].ToString();
                atm.Nev = Reader[1].ToString();
                atm.Tipus = Reader[2].ToString();
                atm.Raktar_db = Convert.ToInt32(Reader[3].ToString());
                atm.Min_db = Convert.ToInt32(Reader[4].ToString());
                atm.Megrendelok.Add(Convert.ToInt32(Reader[5].ToString()));

                Termekek.Add(atm);

                atm = new Termek();
            }
            Reader.Close();
            Connect.Close();

            //Megrendelők
            Connect.Open();
            Command = new OleDbCommand();
            Command.Connection = Connect;
            Command.CommandText = "SELECT Id, Ceg_nev, Weblap, Telefon FROM Megrendelo";

            Reader = Command.ExecuteReader();
            Megrendelo atm_ = new Megrendelo();

            while (Reader.Read())
            {
                atm_.Id = Convert.ToInt32(Reader[0].ToString());
                atm_.Nev = Reader[1].ToString();
                atm_.Weblap = Reader[2].ToString();
                atm_.Telefon = Reader[3].ToString();

                Megrendelok.Add(atm_);

                atm_ = new Megrendelo();
            }
            Reader.Close();
            Connect.Close();

        }
    }
}
