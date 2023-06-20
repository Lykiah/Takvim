using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takvim
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lykia\source\repos\Takvim\Takvim\Database1.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit objKayit = new Kayit();
            this.Hide();
            objKayit.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTakvim_Click(object sender, EventArgs e)
        {
            TakvimUyg objTakvim = new TakvimUyg();
            this.Hide();
            objTakvim.Show();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            gridEtkinlik();
        }

        private void gridEtkinlik()
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Etkinlik", sqlcon);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DGVEtkinlik.DataSource = dt;
            sqlcon.Close();
        }
    }
}
