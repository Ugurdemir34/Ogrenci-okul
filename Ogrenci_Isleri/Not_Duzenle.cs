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
    public partial class Not_Duzenle : Form
    {
        public Not_Duzenle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB.accdb");
        OleDbCommand kmt;
        int id = 0;
        void getir(string secilen)
        {            
            listView1.Clear();            
            baglanti.Open();  //www.ahmetcansever.com
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM NOTLAR WHERE [Ders Adı] = '"+ secilen + "'", baglanti);
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
            id = Convert.ToInt16(listView1.Items[0].SubItems[0].Text);
            otoboyut(listView1, listView1.Width / 8);
            int index = 0;
            foreach (TextBox a in this.Controls.OfType<TextBox>())
            {              
                index++;
                a.Text = listView1.Items[0].SubItems[index].Text;             
            }
            baglanti.Close();
            dt.Dispose();
        }
        private void otoboyut(ListView lvw, int width)
        {
            foreach (ColumnHeader col in lvw.Columns)
                col.Width = width;
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
        void Temizle()
        {
            foreach (TextBox txtler in this.Controls.OfType<TextBox>())
            {
                txtler.Text = string.Empty;
            }
        }    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            getir(comboBox1.SelectedItem.ToString());
        }
        private void Not_Duzenle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            kmt = new OleDbCommand("SELECT [Ders Adı] FROM NOTLAR",baglanti);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
            }
            baglanti.Close();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            string HBN = txtHbn.Text;
            if
            (
            txtAd.Text ==string.Empty || 
            txtKredi.Text == string.Empty || 
            txtVize.Text == string.Empty ||
            txtProje.Text == string.Empty ||
            txtOrtalama.Text == string.Empty ||
            txtHbn.Text == string.Empty
            )
            {
                MessageBox.Show("Tüm Boşlukları Doldurun!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);                  
            }
            else
            {
                try
                {
                    baglanti.Open();
                    kmt.Connection = baglanti;                
                    kmt = new OleDbCommand("UPDATE NOTLAR SET [Ders Adı]=@Ad, [Kredi]=@Kredi, [Vize]=@Vize, [Proje]=@Proje, [Final]=@Final, [HBN]=@HBN WHERE [ID] = @ID",baglanti);                   
                    kmt.Parameters.AddWithValue("@Ad",txtAd.Text);
                    kmt.Parameters.AddWithValue("@Kredi", Convert.ToInt16(txtKredi.Text));
                    kmt.Parameters.AddWithValue("@Vize", Convert.ToDouble(txtVize.Text));
                    kmt.Parameters.AddWithValue("@Proje", Convert.ToDouble(txtProje.Text));
                    kmt.Parameters.AddWithValue("@Final", Convert.ToDouble(txtFinal.Text));
                    kmt.Parameters.AddWithValue("@HBN", txtHbn.Text);
                    kmt.Parameters.AddWithValue("@ID", id);
                    kmt.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı !", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    kmt.Dispose();
                    getir(comboBox1.SelectedItem.ToString());
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata : " + hata.Message);
                }
            }
        }
    }
}
