using KitapBLL;
using MODEL;
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
    public partial class KitapAra : Form
    {

        System.Data.SqlClient.SqlConnection cn = null;
        private Form1 form1;



        public KitapAra(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }
        public KitapAra()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            KitapBL kbl = new KitapBL();
            Kitap ktp = kbl.KitapBul(txtKtpAd.Text);

            if (ktp == null)
            {
                MessageBox.Show("Kitap Bulunamadı!");
            }
            else
            {
                txtKtpAd.Text = ktp.KitapAd;
                txtYazar.Text = ktp.Yazar;
                cmbTur.Text = ktp.KitapTuruId.ToString();
            }




        }
    }

}
