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
    public partial class Personel_arıza_bildirm : Form
    {
        public Personel_arıza_bildirm()
        {
            InitializeComponent();
        }

        private void Personel_arıza_bildirm_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Formlar.Suleymanogrk.Personel_sifre_yenileme personel_Sifre_Yenileme = new Personel_sifre_yenileme();
            personel_Sifre_Yenileme.Show();
        }
    }
}
