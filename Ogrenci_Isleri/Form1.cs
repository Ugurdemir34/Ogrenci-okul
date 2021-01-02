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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnkapat_MouseEnter(object sender, EventArgs e)
        {
            btnkapat.ForeColor = Color.Red;
        }
        
        private void btnkapat_MouseLeave(object sender, EventArgs e)
        {
            btnkapat.ForeColor = Color.White;
        }
        private void dersProgramıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ders_Programi drs = new Ders_Programi();
            drs.Show();           
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Çıkmak İstediğinize Emin Misin ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                Application.Exit();
            }       
        }
        private void dersProgramıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void notGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Not_Goruntuleme not = new Not_Goruntuleme();
            not.Show();
        }

        private void kayıttaBulunanNotlarıHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotHesap nt = new NotHesap();
            nt.Show();
        }

        private void yeniNotGirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniNotHesap yni = new YeniNotHesap();
            yni.Show();
        }

        private void notDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Not_Duzenle nt_dz = new Not_Duzenle();
            nt_dz.Show();
        }

        private void programıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program_Duzenle pd = new Program_Duzenle();
            pd.Show();
        }
    }
}
