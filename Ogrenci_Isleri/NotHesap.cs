using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Öğrenci_İşleri
{
    public partial class NotHesap : Form
    {
        public NotHesap()
        {
            InitializeComponent();
        }
       
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
        private void otoboyut(ListView lvw, int width)
        {
            foreach (ColumnHeader col in lvw.Columns)
                col.Width = width;
        }
        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }
        int toplamkredi = 0;
        int tamamlanan = 0;
        double puan;
        double GANO = 0;
        private void getir()
        {
            toplamkredi = 0;
            tamamlanan = 0;
            puan = 0;
            GANO = 0;
            listView1.Clear();
            listView1.GridLines = true;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb");
            baglanti.Open();  //www.ahmetcansever.com
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM NOTLAR", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                listView1.Columns.Add(dt.Columns[i].ToString());
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr[0].ToString());
                listitem.SubItems.Add(dr[1].ToString().Trim());
                listitem.SubItems.Add(dr[2].ToString().Trim());
                listitem.SubItems.Add(dr[3].ToString().Trim());
                listitem.SubItems.Add(dr[4].ToString().Trim());
                listitem.SubItems.Add(dr[5].ToString().Trim());
                listitem.SubItems.Add(dr[6].ToString().Trim());
                listitem.SubItems.Add(dr[7].ToString().Trim());              
                listitem.UseItemStyleForSubItems = false;
                listView1.Items.Add(listitem);
                toplamkredi += Convert.ToInt32(listitem.SubItems[2].Text);
                listitem.SubItems[7].Font = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
                GANO += Convert.ToDouble(listitem.SubItems[2].Text) * harfler(listitem.SubItems[7].Text);
                if(listitem.SubItems[7].Text !="FF")
                {
                    listitem.SubItems[7].BackColor = Color.FromArgb(77, 194, 71);
                    tamamlanan+= Convert.ToInt32(listitem.SubItems[2].Text);
                }
                if(listitem.SubItems[7].Text == "FF")
                {
                    listitem.SubItems[7].BackColor = Color.Red;
                }
                if (listitem.SubItems[7].Text == "CB" || listitem.SubItems[7].Text == "CC" || listitem.SubItems[7].Text == "DC")
                {
                    listitem.SubItems[7].BackColor = Color.Orange;
                }
            }                            
            GANO = GANO / toplamkredi;        
            puan = (GANO * 100) / 4.00;
            lblgano.Text = Math.Round(GANO, 2).ToString();
            lblpuan.Text = Math.Round(puan,2).ToString();
            lbltoplam.Text = toplamkredi.ToString();
            lbltmm.Text = tamamlanan.ToString();
            otoboyut(listView1, listView1.Width / 8);
            SetHeight(listView1, listView1.Height / listView1.Items.Count - 7);     
            baglanti.Close();
            dt.Dispose();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            getir();
        }
        private void NotHesap_Load(object sender, EventArgs e)
        {
            getir();         
        }
    }
}
