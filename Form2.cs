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

        private void GetRefreshTable()
        {
            conn = konek.Getconn();
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
        void set()
        {
            conn = konek.Getconn();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = konek.Getconn();
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Pemasukan WHERE Pemasukan=@Pemasukan", conn);
                cmd.Parameters.AddWithValue("@Pemasukan", int.Parse(textBox1.Text));

                int rowsAffected = cmd.ExecuteNonQuery(); // ExecuteNonQuery digunakan untuk perintah non-select

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil dihapus.");
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan atau sudah dihapus.");
                }

                set();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}