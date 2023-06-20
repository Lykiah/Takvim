using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Takvim
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lykia\source\repos\Takvim\Takvim\Database1.mdf;Integrated Security=True");
            string query = "Select * from [Table] Where KullaniciAdi = '" + txtboxKullanici.Text.Trim() + "' and Sifre = '" + txtboxSifre.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                AnaMenu objAnaMenu = new AnaMenu();
                this.Hide();
                objAnaMenu.Show();
            }
            else
            {
                MessageBox.Show("Kullanici Adi veya Sifreyi tekrar kontrol edin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtboxSifre.PasswordChar = '\0';
            }
            else
            {
                txtboxSifre.PasswordChar = '*';
            }
        }

        private void lblTemizle_Click(object sender, EventArgs e)
        {
            txtboxKullanici.Text = "";
            txtboxSifre.Text = "";
        }
    }
}