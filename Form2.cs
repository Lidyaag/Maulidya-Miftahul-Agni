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
namespace ProjectUjian
{
    public partial class Form2 : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        Koneksi konek = new Koneksi();
        public Form2()
        {
            InitializeComponent();
        }
        void set()
        {
            SqlConnection conn = konek.Getconn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM Pemasukan", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pemasukan");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Pemasukan";
            dataGridView1.AllowUserToAddRows = false; // Agar user tidak bisa menambahkan data langsung
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true; // Menjadikan seluruh DataGridView read-only
            dataGridView1.Refresh();
            conn.Close(); // Pastikan koneksi ditutup
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            set();
        }
    }
}
