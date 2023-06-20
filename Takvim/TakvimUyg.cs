using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takvim
{
    public partial class TakvimUyg : Form
    {

        int ay, yil;

        public static int static_ay, static_yil;

        public TakvimUyg()
        {
            InitializeComponent();
        }

        private void Takvim_Load(object sender, EventArgs e)
        {
            GunGoster();
        }

        private void GunGoster()
        {
            DateTime now = DateTime.Now;

            ay = now.Month;
            yil = now.Year;

            string AyYil = DateTimeFormatInfo.CurrentInfo.GetMonthName(ay);
            lblAyYil.Text = AyYil + " " + yil;

            static_ay = ay;
            static_yil = yil;

            DateTime Aybaslangic = new DateTime(yil, ay, 1);
            int gun = DateTime.DaysInMonth(yil, ay);
            int haftagun = Convert.ToInt32(Aybaslangic.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < haftagun; i++)
            {
                UserControlKart UCkart = new UserControlKart();
                flowLayoutPanel1.Controls.Add(UCkart);
            }
            for (int i = 1; i <= gun; i++)
            {
                UserControlGunler UCGunler = new UserControlGunler();
                UCGunler.Gunler(i);
                flowLayoutPanel1.Controls.Add(UCGunler);

            }
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (ay == 12)
            {
                ay = 0;
                yil++;
            }
            ay++;

            static_ay = ay;
            static_yil = yil;

            string AyYil = DateTimeFormatInfo.CurrentInfo.GetMonthName(ay);
            lblAyYil.Text = AyYil + " " + yil;

            DateTime Aybaslangic = new DateTime(yil, ay, 1);
            int gun = DateTime.DaysInMonth(yil, ay);
            int haftagun = Convert.ToInt32(Aybaslangic.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < haftagun; i++)
            {
                UserControlKart UCkart = new UserControlKart();
                flowLayoutPanel1.Controls.Add(UCkart);
            }
            for (int i = 1; i <= gun; i++)
            {
                UserControlGunler UCGunler = new UserControlGunler();
                UCGunler.Gunler(i);
                flowLayoutPanel1.Controls.Add(UCGunler);
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (ay == 1)
            {
                ay = 13;
                yil--;
            }
            ay--;

            static_ay = ay;
            static_yil = yil;

            string AyYil = DateTimeFormatInfo.CurrentInfo.GetMonthName(ay);
            lblAyYil.Text = AyYil + " " + yil;

            DateTime Aybaslangic = new DateTime(yil, ay, 1);
            int gun = DateTime.DaysInMonth(yil, ay);
            int haftagun = Convert.ToInt32(Aybaslangic.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < haftagun; i++)
            {
                UserControlKart UCkart = new UserControlKart();
                flowLayoutPanel1.Controls.Add(UCkart);
            }
            for (int i = 1; i <= gun; i++)
            {
                UserControlGunler UCGunler = new UserControlGunler();
                UCGunler.Gunler(i);
                flowLayoutPanel1.Controls.Add(UCGunler);
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            AnaMenu objAnaMenu = new AnaMenu();
            this.Hide();
            objAnaMenu.Show();
        }
    }
}
