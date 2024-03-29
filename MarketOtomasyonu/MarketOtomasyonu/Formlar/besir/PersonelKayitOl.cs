﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MarketOtomasyonu.Formlar.besir
{
	public partial class PersonelKayitOl : Form
	{
		Regex kullaniciAdiKontrol = new Regex(@"^+[\w-]{4,10}$");
		Regex emailKontrol = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
		Regex sifreKontrol = new Regex(@"^([a-zA-Z0-9@*#]{8,15})$");

		String ad = null;
		String soyad = null;
		String mail = null;
		String kullaniciadi = null;
		String sifre = null;
		public PersonelKayitOl()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

        private Data.MOContext dbContext;
        private void PersonelKayitOl_Load(object sender, EventArgs e)
        {
            refreshkullanici();
        }
        public void refreshkullanici()
        {
            dbContext = new Data.MOContext();
            var kullaniciListesi = dbContext.Kullanici.ToList();

        }




        private void button1_Click(object sender, EventArgs e)
		{
			
			bool check = true;
			if (kullaniciAdiKontrol.IsMatch(textBox1.Text))
			{
				kullaniciadi = textBox1.Text;
			}
			else
			{
				MessageBox.Show("Kullanici adi gerekli kriterlere sahip degil");
				check = false;
			}
			if (kullaniciAdiKontrol.IsMatch(textBox2.Text))
			{
				kullaniciadi = textBox2.Text;
			}
			else
			{
				MessageBox.Show("Kullanici adi gerekli kriterlere sahip degil");
				check = false;
			}
			if (kullaniciAdiKontrol.IsMatch(textBox3.Text))
			{
				kullaniciadi = textBox3.Text;
			}
			else
			{
				MessageBox.Show("Kullanici adi gerekli kriterlere sahip degil");
				check = false;
			}
			if (emailKontrol.IsMatch(textBox4.Text))
			{
				mail = textBox4.Text;
			
			}

			else
			{
				MessageBox.Show("Hatalı E-posta");
				check = false;
			}
			if (sifreKontrol.IsMatch(textBox5.Text))
			{
				
			
				if (textBox5.Text == textBox6.Text)
				{
					sifre = textBox5.Text;
				
				}
				else
				{
					MessageBox.Show("Sifreler ayni degil");
					check = false;
				}
			}
			else
			{
				MessageBox.Show("Sifre kurallara uygun degil lutfen yeniden yaziniz");
				check = false;
			}

            var kullanici = new Classes.KullaniciDb()
            {
                kullaniciAdi = textBox3.Text,
                mail = textBox4.Text,
                sifre = textBox5.Text,
            };
            dbContext = new Data.MOContext();
            dbContext.Kullanici.Add(kullanici);
            int result = dbContext.SaveChanges();
            string message = result > 0 ? "Bilgiler Eklendi" : "Başarısız";

            if (check)
            {
                MessageBox.Show(message);
                Formlar.kamiltrn.Giris_Yap giris_Yap = new kamiltrn.Giris_Yap();
                giris_Yap.Show();
                Close();
            }
            else
            {
                message = "Başarısız";
                MessageBox.Show(message);

            }
        }
	}
}
