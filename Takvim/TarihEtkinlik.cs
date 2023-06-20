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
    public partial class TarihEtkinlik : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lykia\source\repos\Takvim\Takvim\Database1.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public TarihEtkinlik()
        {
            InitializeComponent();
        }

        private void TarihEtkinlik_Load(object sender, EventArgs e)
        {
            txtTarih.Text = UserControlGunler.static_gun + "/" + TakvimUyg.static_ay + "/" + TakvimUyg.static_yil;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string etkinlikkayit = "INSERT INTO Etkinlik(Tarih,Etkinlik,Saat) VALUES ('" + txtTarih.Text + "','" + txtEtkinlik.Text + "','" + txtZaman.Text + "')";
            cmd = new SqlCommand(etkinlikkayit, sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Etkinlik Kaydedildi");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtEtkinlik.Text = "";
            txtZaman.Text = "";
        }
    }
}
