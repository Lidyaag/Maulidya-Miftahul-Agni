using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjectUjian
{
    public partial class Form1 : Form
    {

        SqlConnection conn = null;
        SqlCommand cmd = null;
        Koneksi konek = new Koneksi();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DateTime Tanggal;
        }

        private void txttanggal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdekripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesk1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpengeluaran_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdeks2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();

            try
            {
                conn = konek.Getconn();
                cmd = new SqlCommand("INSERT INTO Ujian (Tanggal,Pemasukan,DeskripsiPemasukan,Pengeluaran,DeskripsiPengeluaran) VALUES (@Tanggal,@Pemasukan,@DeskripsiPemasukan,@Pengeluaran,@DeskripsiPengeluaran)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Tanggal", txttanggal.Text.Trim());
                cmd.Parameters.AddWithValue("@Pemasukan", txtpemasukan.Text.Trim());
                cmd.Parameters.AddWithValue("@DeskripsiPemasukan", txtdesk1.Text.Trim());
                cmd.Parameters.AddWithValue("@Pengeluaran", txtpengeluaran.Text.Trim());
                cmd.Parameters.AddWithValue("@DeskripsiPengeluaran", txtdeks2.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups! Data yang Anda masukkan tidak sesuai!" +ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtpemasukan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttanggal_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

