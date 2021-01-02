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
    public partial class Program_Duzenle : Form
    {
        public Program_Duzenle()
        {
            InitializeComponent();


        }
        OleDbConnection baglanti = new OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DB.accdb");
        OleDbDataAdapter adapter;      
        OleDbCommandBuilder cmdb;
        DBDataSet ds;
        OleDbCommand kmt;
        DataTable tablo;
        DataRow row;
        int id = 0;
        private void otoboyut(ListView lvw, int width)
        {
            foreach (ColumnHeader col in lvw.Columns)
                col.Width = width;
        }
        void bilgigetir(string secilen)
        {
            listView1.Clear();
            baglanti.Open();  //www.ahmetcansever.com
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM LISTE WHERE GUNLER = '" + secilen + "'", baglanti);
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
            otoboyut(listView1, listView1.Width / 9);
            int index = 0;
            foreach (TextBox a in this.Controls.OfType<TextBox>())
            {
                index++;               
                a.Text = listView1.Items[0].SubItems[index].Text;             
            }
            baglanti.Close();
            dt.Dispose();
        }
        private void Program_Duzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.LISTE' table. You can move, or remove it, as needed.
          
            baglanti.Open();
            kmt = new OleDbCommand("SELECT GUNLER FROM LISTE", baglanti);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);              
            }
            baglanti.Close();
        }      
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bilgigetir(comboBox1.SelectedItem.ToString());
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int index = 1;
            adapter = new OleDbDataAdapter("SELECT * FROM [LISTE]",baglanti);
            ds = new DBDataSet();
            baglanti.Open();
            adapter.Fill(ds,"LISTE");
            baglanti.Close();
            cmdb = new OleDbCommandBuilder(adapter);
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                cmdb = new OleDbCommandBuilder(adapter);
                row = ds.Tables["LISTE"].Rows[comboBox1.SelectedIndex];                
                MessageBox.Show(row[index] +"");
                index++;

            }   
            
        }
    }
}
