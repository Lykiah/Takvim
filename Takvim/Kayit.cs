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
using System.Data;

namespace Takvim
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }


        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lykia\source\repos\Takvim\Takvim\Database1.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            gridKayit();
        }

        private void gridKayit()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", sqlcon);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGVKayitlar.DataSource = dt;
            sqlcon.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" && txtSifre.Text == "" && txtSifreTekrar.Text == "" && txtIsimSoyisim.Text == "" && txtTel.Text == "" && txtEmail.Text == "" && txtTCKimlik.Text == "" && txtKullaniciTipi.Text == "" && txtAdres.Text == "")
            {
                MessageBox.Show("Eksik bilgi girildi, tekrar kontrol ediniz.");
            }
            else if (txtSifre.Text == txtSifreTekrar.Text)
            {
                sqlcon.Open();
                string kayit = "INSERT INTO [TABLE] VALUES ('" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "','" + txtIsimSoyisim.Text + "','" + txtTel.Text + "','" + txtTCKimlik.Text + "','" + txtKullaniciTipi.Text + "','" + txtEmail.Text + "','" + txtAdres.Text + "')";
                cmd = new SqlCommand(kayit, sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                txtIsimSoyisim.Text = "";
                txtTel.Text = "";
                txtEmail.Text = "";
                txtTCKimlik.Text = "";
                txtKullaniciTipi.Text = "";
                txtAdres.Text = "";

                MessageBox.Show("Kayit basarili bir sekilde olusturuldu");

            }
            else
            {
                MessageBox.Show("Sifreler eslesmiyor tekrar deneyiniz");
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                txtSifre.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
                txtSifreTekrar.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
                txtSifreTekrar.PasswordChar = '*';
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtSifreTekrar.Text = "";
            txtIsimSoyisim.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            txtTCKimlik.Text = "";
            txtKullaniciTipi.Text = "";
            txtAdres.Text = "";
            txtKullaniciAdi.Focus();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaMenu objAnaMenu = new AnaMenu();
            this.Hide();
            objAnaMenu.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // bu sadece datagridview uzerinden siliyor Database uzerinden silmiyor , en son birsuru syntax hatasi verdiginden dolayi ugrasmadim.
            foreach (DataGridViewCell oneCell in DGVKayitlar.SelectedCells)
            {
                if (oneCell.Selected)
                    DGVKayitlar.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
    }
}

