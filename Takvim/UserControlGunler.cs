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
    public partial class UserControlGunler : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lykia\source\repos\Takvim\Takvim\Database1.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public static string static_gun;
        public UserControlGunler()
        {
            InitializeComponent();
        }

        public void Gunler(int gunrakam)
        {
            lblGun.Text = gunrakam + "";
        }

        private void UserControlGunler_Click(object sender, EventArgs e)
        {
            static_gun = lblGun.Text;
            TarihEtkinlik EtkinlikForm = new TarihEtkinlik();
            EtkinlikForm.Show();
        }
    }
}
