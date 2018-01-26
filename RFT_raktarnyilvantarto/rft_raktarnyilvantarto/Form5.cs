using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace rft_raktarnyilvantarto
{
    public partial class Form5 : Form
    {
      static   string s1 = System.Reflection.Assembly.GetExecutingAssembly().Location;
      static   int idx = s1.LastIndexOf('\\');
      static   string databasePath = s1.Substring(0, idx) + "\\Database1.mdf";


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+databasePath+";Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
            textBox5.ReadOnly = true;
            disp_data();
            dataGridView1.ReadOnly = true;
        }

        

       
        public void disp_data()
        {
            
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table]";
            cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime ma = DateTime.Now;
            string mainap = ma.ToString("yyyy.MM.dd");
            string beerkezett = "Nem érkezett be!";
            con.Open();
            // SqlCommand cmd = con.CreateCommand();
            // cmd.CommandType = CommandType.Text;
            SqlCommand cmd = new SqlCommand("insert into [Table](Vonalkod, Megnevezes, Mennyiseg, Szallito, Varhatoerkezes, Rendelesideje,Beerkezett) values" +
                "(@vonalkod,@megnevezes,@mennyiseg,@szallito,@varhatoerkezes,@rendelesideje,@beerkezett)", con);
            cmd.Parameters.AddWithValue("@vonalkod", textBox1.Text);
            cmd.Parameters.AddWithValue("@megnevezes", textBox2.Text);
            cmd.Parameters.AddWithValue("@mennyiseg", textBox3.Text);
            cmd.Parameters.AddWithValue("@szallito", textBox4.Text);
            cmd.Parameters.AddWithValue("@varhatoerkezes", textBox5.Text);
            cmd.Parameters.AddWithValue("@rendelesideje", mainap);
            cmd.Parameters.AddWithValue("@beerkezett", beerkezett);
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();

            MessageBox.Show("Gratula jó irányba haladsz");
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime erkezes = monthCalendar1.SelectionStart;
            if (erkezes < DateTime.Now)
            {
                MessageBox.Show("A beérkezés ideje nem lehet régebbi a mai napnál");
            }
            else
            {
                textBox5.Text = erkezes.ToString("yyyy.MM.dd");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char[] l_charList = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };//engedélyezett karakterek
            List<Char> l_lsChars = new List<Char>(l_charList);
            bool l_bFound = false;
            foreach (Char l_Current in l_lsChars)
            {
                if (l_Current.Equals(e.KeyChar))
                    l_bFound = true;
            }
            if (!l_bFound)//nincs :(
            {
                MessageBox.Show("Csak szám szerpelhet");
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime ma = DateTime.Now;
            string mainap = ma.ToString("yyyy.MM.dd");
            string beerkezett = "Beérkezett: " + mainap;
            con.Open();
           
            SqlCommand cmd = new SqlCommand("update [Table] set Beerkezett = @beerkezett where id=@id", con);
            cmd.Parameters.AddWithValue("@id", textBox6.Text);
            cmd.Parameters.AddWithValue("@beerkezett", beerkezett);
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table]";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table] where  beerkezett = 'Nem érkezett be!'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table] where not  beerkezett = 'Nem érkezett be!'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if (comboBox1.Text == "ID")
        //    {
        //        con.Open();

        //        SqlCommand cmd = new SqlCommand("select * from [Table] where not  Id = @id", con);
        //        cmd.Parameters.AddWithValue("@id", textBox7.Text);
               
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        disp_data();
        //    }
        }
    }
}
