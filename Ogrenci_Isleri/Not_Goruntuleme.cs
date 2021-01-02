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
    public partial class Not_Goruntuleme : Form
    {
        public Not_Goruntuleme()
        {
            InitializeComponent();
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
        private void getir()
        {
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
                listitem.SubItems.Add("");
                listView1.Items.Add(listitem);
            }
            otoboyut(listView1, listView1.Width / 8);
            SetHeight(listView1, listView1.Height / listView1.Items.Count - 7);
            // listView1.Columns.Add("Bok");
            baglanti.Close();
            dt.Dispose();
        }
        private void Not_Goruntuleme_Load(object sender, EventArgs e)
        {
            getir();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            getir();
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
