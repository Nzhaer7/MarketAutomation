﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Formlar.Suleymanogrk
{
    public partial class Personel_urun_sepet_odeme : Form
    {
        public Personel_urun_sepet_odeme()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_fis personel_Fis = new Personel_fis();
            personel_Fis.Show();
        }

        private void Personel_urun_sepet_odeme_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
    }
}