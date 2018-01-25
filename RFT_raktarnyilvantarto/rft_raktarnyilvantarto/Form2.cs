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
using System.IO;
namespace rft_raktarnyilvantarto
{
    public partial class Form2 : Form
    {
        static OleDbConnection Connect = new OleDbConnection();

        static List<Rendelesek> Rendelesek = new List<Rendelesek>();
        public Form2()
        {
            InitializeComponent();
        }

        private void raktar_gomb_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AdatbazisBeolvasasa("Database.accdb");
        }
        private void AdatbazisBeolvasasa(string path)
        {
            try
            {
                Connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @";User Id=admin;Password=";
                Connect.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba az adatbázis elérése közben! Nem létező útvonal!");
                Application.Exit();
                return; // Hogy ki is lépjen
            }


            //Termékek
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = Connect;
            Command.CommandText = "SELECT Vonalkod, Megnevezes, Tipus, Rendelt_db, Megrendelo, Rendeles_ideje, Beerkezes_ideje, Szallito, Beerkezett FROM Rendelesek";

            OleDbDataReader Reader;
            try
            {
                Reader = Command.ExecuteReader();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba az adatbázisban! Nem megfelelő táblanév vagy mezőnév itt:Rendelsek");
                Application.Exit();
                return; // Hogy ki is lépjen
            }


            Rendelesek rendeles = new Rendelesek("1111111111116", "atm", "Rendelse", 1);
            //try
            //{
                while (Reader.Read())
                {
                try
                {
                    rendeles.Vonalkod = Reader[0].ToString();
                }
                catch
                {
                    MessageBox.Show("1");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Nev = Reader[1].ToString();
                }
                catch
                {
                    MessageBox.Show("2");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Tipus = Reader[2].ToString();
                }
                catch
                {
                    MessageBox.Show("3");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Rendelt_db = Convert.ToInt32(Reader[3].ToString());
                }
                catch
                {
                    MessageBox.Show("4");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Rendelo = Reader[4].ToString();
                }
                catch
                {
                    MessageBox.Show("5");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Rendelesido = Reader[5].ToString();
                }
                catch
                {
                    MessageBox.Show("6");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Erkezesido = Reader[6].ToString();
                }
                catch
                {
                    MessageBox.Show("7");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Szallito = Reader[7].ToString();
                }
                catch
                {
                    MessageBox.Show("8");
                    Application.Exit();
                    return;
                }
                try
                {
                    rendeles.Beerkezet = Convert.ToBoolean(Reader[8].ToString());
                }
                catch
                {
                    MessageBox.Show("9");
                    Application.Exit();
                    return;
                }
                Rendelesek.Add(rendeles);

                    rendeles = new Rendelesek("1111111111116", "atm", "Rendelse", 1);
                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Hiba az adatbázisban! Nem megfelelő rekord a Megrendelések táblában!");
            //    Application.Exit();
            //    return;
            //}

            Reader.Close();
            Connect.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
