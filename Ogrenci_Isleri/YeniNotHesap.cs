using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_İşleri
{
    public partial class YeniNotHesap : Form
    {
        public YeniNotHesap()
        {
            InitializeComponent();
        }
        ComboBox[] cmb_HarfNotu = new ComboBox[10];
        TextBox[] txt_Kredi = new TextBox[10];
        double harfler(string harf)
        {
            double a = 0;
            if (harf == "AA") a = 4;
            if (harf == "BA") a = 3.5;
            if (harf == "BB") a = 3;
            if (harf == "CB") a = 2.5;
            if (harf == "CC") a = 2;
            if (harf == "DC") a = 1.5;
            if (harf == "DD") a = 1;
            if (harf == "FF") a = 0;
            return a;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            int a = 60;
            for (int i = 0; i < comboBox1.SelectedIndex + 1; i++)
            {
                Label lbl = new Label();
                lbl.Text = (i + 1) + ". Dersin Harf Notu : ";
                lbl.Left = 5;
                lbl.Top = 46 + a;
                this.Controls.Add(lbl);
                cmb_HarfNotu[i] = new ComboBox();
                cmb_HarfNotu[i].Left = 140;
                cmb_HarfNotu[i].Top = 46 + a;
                cmb_HarfNotu[i].Items.Add("AA");
                cmb_HarfNotu[i].Items.Add("BA");
                cmb_HarfNotu[i].Items.Add("BB");
                cmb_HarfNotu[i].Items.Add("CB");
                cmb_HarfNotu[i].Items.Add("CC");
                cmb_HarfNotu[i].Items.Add("DC");
                cmb_HarfNotu[i].Items.Add("DD");
                cmb_HarfNotu[i].Items.Add("FF");
                cmb_HarfNotu[i].Width = 58;
                this.Controls.Add(cmb_HarfNotu[i]);
                Label lbl2 = new Label();
                lbl2.Text = "Dersin (AKTS) Kredisi :";
                lbl2.Left = 204;
                lbl2.Top = 46 + a;
                this.Controls.Add(lbl2);
                txt_Kredi[i] = new TextBox();
                txt_Kredi[i].Text = "4";
                txt_Kredi[i].Left = 325;
                txt_Kredi[i].Top = 46 + a;
                txt_Kredi[i].Width = 54;
                this.Controls.Add(txt_Kredi[i]);
                a += 28;
            }
            Button btn = new Button() { Size = new Size(90, 25),FlatStyle=FlatStyle.Flat };
            btn.Text = "HESAPLA";
            btn.Left = 206;
            btn.Top = 56 + a;
            this.Controls.Add(btn);
            btn.Click += new EventHandler(btn_Click);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            double toplam = 0, toplamKredi = 0;
            for (int i = 0; i < Convert.ToInt32(comboBox1.Text); i++)
            {
                toplam += Convert.ToDouble(txt_Kredi[i].Text) * harfler(cmb_HarfNotu[i].Text);
                toplamKredi += Convert.ToDouble(txt_Kredi[i].Text);
            }
            MessageBox.Show("GANO :" + Math.Round((toplam / toplamKredi),2).ToString());
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
