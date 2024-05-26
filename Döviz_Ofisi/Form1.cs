using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; //xml dosya kullanmak için kütüphaneye bunu girmek gerekiyor.
using System.Data.SqlClient;

namespace Döviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=KAAN\SQLEXPRESS;Initial Catalog=DbDoviz;Integrated Security=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarsatis;

            string euroslis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroslis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = eurosatis;

        }

        private void btnDolarAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlis.Text;
        }

        private void btnDolarSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlis.Text;
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatis.Text;
        }

        private void btnAlis_Click(object sender, EventArgs e)
        {//döviz girdi.TL çıktı.
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtTutar.Text = tutar.ToString();
            txtKalan.Text = "Kalan yok";

            baglanti.Open();

            //SqlCommand komut = new SqlCommand("insert into TBLDOVIZ(GirenPara) values(@p1)", baglanti);
            //komut.Parameters.AddWithValue("@p1", decimal.Parse(txtKur.Text));
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("KASAYA PARA GİRDİ");

            SqlCommand komut = new SqlCommand("update TBLDOVIZ set GirenPara=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KASAYA PARA GİRDİ");
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ",");//noktayı virgülle değiştir demek.
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {//TL girdi.Döviz çıktı.
            double kur, miktar;
            kur = Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            txtTutar.Text = (miktar / kur).ToString();
            txtKalan.Text = (miktar % kur).ToString();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLDOVIZ set CikanPara=@p1",baglanti);
            komut2.Parameters.AddWithValue("@p1",decimal.Parse(txtTutar.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KASADAN PARA ÇIKTI");
        }
    }
}