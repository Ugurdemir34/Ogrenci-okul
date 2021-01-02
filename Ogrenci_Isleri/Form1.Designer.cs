namespace Öğrenci_İşleri
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngizle = new System.Windows.Forms.Button();
            this.btnkapat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.notDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haftalıkDersProgramıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersProgramıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersProgramıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniProgramEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniNotGirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.btngizle);
            this.panel1.Controls.Add(this.btnkapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 37);
            this.panel1.TabIndex = 0;
            // 
            // btngizle
            // 
            this.btngizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btngizle.FlatAppearance.BorderSize = 0;
            this.btngizle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btngizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btngizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btngizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngizle.ForeColor = System.Drawing.Color.White;
            this.btngizle.Location = new System.Drawing.Point(748, 0);
            this.btngizle.Name = "btngizle";
            this.btngizle.Size = new System.Drawing.Size(36, 37);
            this.btngizle.TabIndex = 2;
            this.btngizle.Text = "_";
            this.btngizle.UseVisualStyleBackColor = true;
            // 
            // btnkapat
            // 
            this.btnkapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnkapat.FlatAppearance.BorderSize = 0;
            this.btnkapat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnkapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnkapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.Color.White;
            this.btnkapat.Location = new System.Drawing.Point(784, 0);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(36, 37);
            this.btnkapat.TabIndex = 1;
            this.btnkapat.Text = "X";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            this.btnkapat.MouseEnter += new System.EventHandler(this.btnkapat_MouseEnter);
            this.btnkapat.MouseLeave += new System.EventHandler(this.btnkapat_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notDurumuToolStripMenuItem,
            this.haftalıkDersProgramıToolStripMenuItem,
            this.notHesaplamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 37);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // notDurumuToolStripMenuItem
            // 
            this.notDurumuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notGörüntülemeToolStripMenuItem,
            this.notDüzenlemeToolStripMenuItem});
            this.notDurumuToolStripMenuItem.Name = "notDurumuToolStripMenuItem";
            this.notDurumuToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.notDurumuToolStripMenuItem.Text = "Not  Bilgileri";
            // 
            // notGörüntülemeToolStripMenuItem
            // 
            this.notGörüntülemeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notGörüntülemeToolStripMenuItem.Image = global::Öğrenci_İşleri.Properties.Resources.notgoster;
            this.notGörüntülemeToolStripMenuItem.Name = "notGörüntülemeToolStripMenuItem";
            this.notGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.notGörüntülemeToolStripMenuItem.Text = "Not Görüntüleme";
            this.notGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.notGörüntülemeToolStripMenuItem_Click);
            // 
            // notDüzenlemeToolStripMenuItem
            // 
            this.notDüzenlemeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notDüzenlemeToolStripMenuItem.Image = global::Öğrenci_İşleri.Properties.Resources.duzenle;
            this.notDüzenlemeToolStripMenuItem.Name = "notDüzenlemeToolStripMenuItem";
            this.notDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.notDüzenlemeToolStripMenuItem.Text = "Not Düzenleme";
            this.notDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.notDüzenlemeToolStripMenuItem_Click);
            // 
            // haftalıkDersProgramıToolStripMenuItem
            // 
            this.haftalıkDersProgramıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersProgramıGörüntüleToolStripMenuItem,
            this.dersProgramıDüzenleToolStripMenuItem});
            this.haftalıkDersProgramıToolStripMenuItem.Name = "haftalıkDersProgramıToolStripMenuItem";
            this.haftalıkDersProgramıToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.haftalıkDersProgramıToolStripMenuItem.Text = "Haftalık Ders Programı";
            // 
            // dersProgramıGörüntüleToolStripMenuItem
            // 
            this.dersProgramıGörüntüleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersProgramıGörüntüleToolStripMenuItem.Image = global::Öğrenci_İşleri.Properties.Resources.program;
            this.dersProgramıGörüntüleToolStripMenuItem.Name = "dersProgramıGörüntüleToolStripMenuItem";
            this.dersProgramıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.dersProgramıGörüntüleToolStripMenuItem.Text = "Ders Programı Görüntüle";
            this.dersProgramıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.dersProgramıGörüntüleToolStripMenuItem_Click);
            // 
            // dersProgramıDüzenleToolStripMenuItem
            // 
            this.dersProgramıDüzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniProgramEkleToolStripMenuItem,
            this.programıGüncelleToolStripMenuItem});
            this.dersProgramıDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersProgramıDüzenleToolStripMenuItem.Image = global::Öğrenci_İşleri.Properties.Resources.duzenle;
            this.dersProgramıDüzenleToolStripMenuItem.Name = "dersProgramıDüzenleToolStripMenuItem";
            this.dersProgramıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.dersProgramıDüzenleToolStripMenuItem.Text = "Ders Programı Düzenle";
            this.dersProgramıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.dersProgramıDüzenleToolStripMenuItem_Click);
            // 
            // yeniProgramEkleToolStripMenuItem
            // 
            this.yeniProgramEkleToolStripMenuItem.Image = global::Öğrenci_İşleri.Properties.Resources.programekle;
            this.yeniProgramEkleToolStripMenuItem.Name = "yeniProgramEkleToolStripMenuItem";
            this.yeniProgramEkleToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.yeniProgramEkleToolStripMenuItem.Text = "Yeni Program Ekle";
            // 
            // programıGüncelleToolStripMenuItem
            // 
            this.programıGüncelleToolStripMenuItem.Name = "programıGüncelleToolStripMenuItem";
            this.programıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.programıGüncelleToolStripMenuItem.Text = "Programı Güncelle";
            this.programıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.programıGüncelleToolStripMenuItem_Click);
            // 
            // notHesaplamaToolStripMenuItem
            // 
            this.notHesaplamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem,
            this.yeniNotGirmeToolStripMenuItem});
            this.notHesaplamaToolStripMenuItem.Name = "notHesaplamaToolStripMenuItem";
            this.notHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.notHesaplamaToolStripMenuItem.Text = "Not Hesaplama";
            // 
            // kayıttaBulunanNotlarıHesaplamaToolStripMenuItem
            // 
            this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem.Image = global::Öğrenci_İşleri.Properties.Resources.calc;
            this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem.Name = "kayıttaBulunanNotlarıHesaplamaToolStripMenuItem";
            this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem.Text = "Kayıtta Bulunan Notları Hesaplama";
            this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.kayıttaBulunanNotlarıHesaplamaToolStripMenuItem_Click);
            // 
            // yeniNotGirmeToolStripMenuItem
            // 
            this.yeniNotGirmeToolStripMenuItem.Image = global::Öğrenci_İşleri.Properties.Resources.create;
            this.yeniNotGirmeToolStripMenuItem.Name = "yeniNotGirmeToolStripMenuItem";
            this.yeniNotGirmeToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.yeniNotGirmeToolStripMenuItem.Text = "Yeni Not Hesaplama";
            this.yeniNotGirmeToolStripMenuItem.Click += new System.EventHandler(this.yeniNotGirmeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(820, 485);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btngizle;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem notDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haftalıkDersProgramıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersProgramıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersProgramıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıttaBulunanNotlarıHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniNotGirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniProgramEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programıGüncelleToolStripMenuItem;
    }
}

