using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KitapAra ka = new KitapAra();
         


            if (txtAd.Text=="melisa" && txtSifre.Text=="2009")
            {
                MessageBox.Show("Giriş Başarılı");
                ka.Show();
               

            }

            
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

        }
    }
}
