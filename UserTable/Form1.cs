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

namespace UserTable
{
    public partial class Form1 : Form
    {
        void Refresh_()
        {
            if (data.Rows.Count == 0)
            {
                unesi.Enabled = false;
                izmeni.Enabled = false;
                izbrisi.Enabled = false;
                pocetak.Enabled = false;
                levo.Enabled = false;
                desno.Enabled = false;
                kraj.Enabled = false;
                id_tb.Text = "";
                login_name_tb.Text = "";
                pass_tb.Text = "";
                ime_tb.Text = "";
                prezime_tb.Text = "";
                tip_tb.Text = "";
            }
            else
            {
                id_tb.Text = data.Rows[pos]["id"].ToString();
                login_name_tb.Text= data.Rows[pos]["login_name"].ToString();
                pass_tb.Text = data.Rows[pos]["pass"].ToString();
                ime_tb.Text = data.Rows[pos]["ime"].ToString();
                prezime_tb.Text = data.Rows[pos]["prezime"].ToString();
                tip_tb.Text = data.Rows[pos]["tip"].ToString();
            }
        }
        string cs= "Data source = DANICA-PC\\SQLEXPRESS; Initial catalog = Domaci; Integrated security = true";
        int pos = 0;
        DataTable data = new DataTable();
        SqlConnection connect;
        string login_name_, password_, ime_, prezime_, tip_;
        SqlDataAdapter adapter;

        private void Izmeni_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(cs);
            login_name_ = login_name_tb.Text;
            password_ = pass_tb.Text;
            ime_ = ime_tb.Text;
            prezime_ = prezime_tb.Text;
            tip_ = tip_tb.Text;
            if (login_name_=="" && password_=="" && ime_ == "" && prezime_ == "" && tip_ == "")
            {
                MessageBox.Show("Barem jedan podatak mora biti unesen");
            }
            connect.Open();
            SqlCommand order=new SqlCommand($"update firma set login_name = '{login_name_}', pass = '{password_}', ime = '{ime_}', prezime = '{prezime_}', tip = '{tip_}' where id = {id_tb.Text}", connect);
        }

        private void Pocetak_Click(object sender, EventArgs e)
        {
            pos = 0;
            Refresh_(); 
        }

        private void Levo_Click(object sender, EventArgs e)
        {
            if (pos-1>=0)
            {
                pos--;
                Refresh_();
            }
        }

        private void Desno_Click(object sender, EventArgs e)
        {
            if (pos+1<=data.Rows.Count)
            {
                pos++;
                Refresh_();
            }
        }

        private void Kraj_Click(object sender, EventArgs e)
        {
            pos = data.Rows.Count - 1;
            Refresh_();
        }

        private void Izbrisi_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(cs);
            SqlCommand order = new SqlCommand(String.Format($"delete from User_ where id={id_tb.Text}"), connect);
            connect.Open();
            order.ExecuteNonQuery();
            connect.Close();
            data.Clear();
            adapter = new SqlDataAdapter("select * from User_", connect);
            adapter.Fill(data);
            pos = 0;
            Refresh_();
        }

        private void Unesi_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(cs);
            login_name_ = login_name_tb.Text;
            password_ = pass_tb.Text;
            ime_ = ime_tb.Text;
            prezime_ = prezime_tb.Text;
            tip_ = tip_tb.Text;

            connect.Open();
            SqlCommand order=new SqlCommand($"insert into User_ values('{login_name_}','{password_}','{ime_}','{prezime_}','{tip_}')", connect);
            order.ExecuteNonQuery();
            connect.Close();
            data.Clear();
            adapter = new SqlDataAdapter("select * from User_", connect);
            adapter.Fill(data);
            pos = data.Rows.Count - 1;
            Refresh_();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(cs);
            adapter = new SqlDataAdapter("select * from User_", connect);
            adapter.Fill(data);
            id_tb.Enabled = false;
            Refresh_();
        }

    }
}
