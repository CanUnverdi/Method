using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        public void ToplamaYap(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            MessageBox.Show("Toplam Sonucu: " + toplam);
        }

        
        public int Toplama(int param1, int param2)
        {
            return param1 + param2;
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            int param1 = 12;
            int param2 = 12;

            
            MessageBox.Show(Toplama(param1, param2).ToString());
        }

        public void CiftTek()
        {
            int sayi = Convert.ToInt32(txtOrnek1.Text);

            if (sayi % 2 == 0)
                MessageBox.Show("Sayi Cift");
            else
                MessageBox.Show("Sayi Tek");
        }

        public void CiftTek(int a)
        {
            if (a % 2 == 0)
            {
                MessageBox.Show("Cİfttir!");
            }
            else
            {
                MessageBox.Show("Tektir!");
            }
        }

        public string CiftTekKontrol(int param)
        {
            if (param % 2 == 0)
            {
                return "Cift";
            }
            else
            {
                return "Tek";
            }
        }
        public string CiftTekKontrol()
        {
            int sayi = Convert.ToInt32(txtOrnek1.Text);
            if (sayi % 2 == 0)
            {
                return "Çift";
            }
            else
            {
                return "Tek";
            }
        }

        private void btnCiftTek_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtOrnek1.Text);
        
            string sonuc = CiftTekKontrol(sayi);
            MessageBox.Show(sonuc);
            MessageBox.Show(CiftTekKontrol());
        }

        public string MailOlustur(string ad, string soyad)
        {
            return ad + "." + soyad + "@gmail.com";
        }

        private void btnMatinsel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MailOlustur(txtAd.Text, txtSoyad.Text));
        }

        public void diziIslemleri(int[] dizi)
        {
            int toplam = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + dizi[i];
            }

            MessageBox.Show("Toplam Sonucu: " + toplam);
        }

        private void btnDiziIsleme_Click(object sender, EventArgs e)
        {
       

            int[] sayilar = { 2, 89, 45, 9, 13, 79, 666 };
            diziIslemleri(sayilar);
        }

        public Color ArkaPlanYakalayicisi(Control arkaPlaniYakalanacakKontrol)
        {
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.BackColor = arkaPlaniYakalanacakKontrol.BackColor;
                }
            }

            return arkaPlaniYakalanacakKontrol.BackColor;
        }


        private void btnRenkYakala_Click(object sender, EventArgs e)
        {
            btnMatinsel.BackColor = ArkaPlanYakalayicisi(btnRenkYakala);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
