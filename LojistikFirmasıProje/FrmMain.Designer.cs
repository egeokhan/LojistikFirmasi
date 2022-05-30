namespace LojistikFirmasıProje
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferNoyaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelIDsineGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tariheGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferYerineGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriyeGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelikİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaklaşanGörüşmelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaGelirGiderleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maaşlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haklarVeLisansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gelirEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferToolStripMenuItem,
            this.aramaToolStripMenuItem,
            this.üyelikİşlemleriToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.yardımToolStripMenuItem1,
            this.destekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seferToolStripMenuItem
            // 
            this.seferToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.seferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferleriGörüntüleToolStripMenuItem,
            this.seferEkleToolStripMenuItem,
            this.seferSilToolStripMenuItem});
            this.seferToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.seferToolStripMenuItem.Name = "seferToolStripMenuItem";
            this.seferToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.seferToolStripMenuItem.Text = "Sefer";
            // 
            // seferleriGörüntüleToolStripMenuItem
            // 
            this.seferleriGörüntüleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.seferleriGörüntüleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seferleriGörüntüleToolStripMenuItem.Name = "seferleriGörüntüleToolStripMenuItem";
            this.seferleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seferleriGörüntüleToolStripMenuItem.Text = "Seferleri Görüntüle";
            this.seferleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.seferleriGörüntüleToolStripMenuItem_Click);
            // 
            // seferEkleToolStripMenuItem
            // 
            this.seferEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.seferEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seferEkleToolStripMenuItem.Name = "seferEkleToolStripMenuItem";
            this.seferEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seferEkleToolStripMenuItem.Text = "Sefer Ekle";
            this.seferEkleToolStripMenuItem.Click += new System.EventHandler(this.seferEkleToolStripMenuItem_Click);
            // 
            // seferSilToolStripMenuItem
            // 
            this.seferSilToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.seferSilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seferSilToolStripMenuItem.Name = "seferSilToolStripMenuItem";
            this.seferSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seferSilToolStripMenuItem.Text = "Sefer Sil";
            this.seferSilToolStripMenuItem.Click += new System.EventHandler(this.seferSilToolStripMenuItem_Click);
            // 
            // aramaToolStripMenuItem
            // 
            this.aramaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.aramaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferNoyaGöreToolStripMenuItem,
            this.personelIDsineGöreToolStripMenuItem,
            this.tariheGöreToolStripMenuItem,
            this.seferYerineGöreToolStripMenuItem,
            this.kategoriyeGöreToolStripMenuItem});
            this.aramaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aramaToolStripMenuItem.Name = "aramaToolStripMenuItem";
            this.aramaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aramaToolStripMenuItem.Text = "Arama";
            // 
            // seferNoyaGöreToolStripMenuItem
            // 
            this.seferNoyaGöreToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.seferNoyaGöreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seferNoyaGöreToolStripMenuItem.Name = "seferNoyaGöreToolStripMenuItem";
            this.seferNoyaGöreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.seferNoyaGöreToolStripMenuItem.Text = "Sefer No\'ya Göre";
            this.seferNoyaGöreToolStripMenuItem.Click += new System.EventHandler(this.seferNoyaGöreToolStripMenuItem_Click);
            // 
            // personelIDsineGöreToolStripMenuItem
            // 
            this.personelIDsineGöreToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.personelIDsineGöreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.personelIDsineGöreToolStripMenuItem.Name = "personelIDsineGöreToolStripMenuItem";
            this.personelIDsineGöreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.personelIDsineGöreToolStripMenuItem.Text = "Personel ID\'sine Göre";
            this.personelIDsineGöreToolStripMenuItem.Click += new System.EventHandler(this.personelIDsineGöreToolStripMenuItem_Click);
            // 
            // tariheGöreToolStripMenuItem
            // 
            this.tariheGöreToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.tariheGöreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tariheGöreToolStripMenuItem.Name = "tariheGöreToolStripMenuItem";
            this.tariheGöreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tariheGöreToolStripMenuItem.Text = "Tarihe Göre";
            this.tariheGöreToolStripMenuItem.Click += new System.EventHandler(this.tariheGöreToolStripMenuItem_Click);
            // 
            // seferYerineGöreToolStripMenuItem
            // 
            this.seferYerineGöreToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.seferYerineGöreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.seferYerineGöreToolStripMenuItem.Name = "seferYerineGöreToolStripMenuItem";
            this.seferYerineGöreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.seferYerineGöreToolStripMenuItem.Text = "Sefer Yerine Göre";
            this.seferYerineGöreToolStripMenuItem.Click += new System.EventHandler(this.seferYerineGöreToolStripMenuItem_Click);
            // 
            // kategoriyeGöreToolStripMenuItem
            // 
            this.kategoriyeGöreToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.kategoriyeGöreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kategoriyeGöreToolStripMenuItem.Name = "kategoriyeGöreToolStripMenuItem";
            this.kategoriyeGöreToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kategoriyeGöreToolStripMenuItem.Text = "Kategoriye Göre";
            this.kategoriyeGöreToolStripMenuItem.Click += new System.EventHandler(this.kategoriyeGöreToolStripMenuItem_Click);
            // 
            // üyelikİşlemleriToolStripMenuItem
            // 
            this.üyelikİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.üyelikİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeleriGörüntüleToolStripMenuItem,
            this.üyeEkleToolStripMenuItem,
            this.üyeSilToolStripMenuItem,
            this.üyeGüncelleToolStripMenuItem,
            this.üyeAraToolStripMenuItem});
            this.üyelikİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.üyelikİşlemleriToolStripMenuItem.Name = "üyelikİşlemleriToolStripMenuItem";
            this.üyelikİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.üyelikİşlemleriToolStripMenuItem.Text = "Üyelik İşlemleri";
            // 
            // üyeleriGörüntüleToolStripMenuItem
            // 
            this.üyeleriGörüntüleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.üyeleriGörüntüleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.üyeleriGörüntüleToolStripMenuItem.Name = "üyeleriGörüntüleToolStripMenuItem";
            this.üyeleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.üyeleriGörüntüleToolStripMenuItem.Text = "Üyeleri Görüntüle";
            this.üyeleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.üyeleriGörüntüleToolStripMenuItem_Click);
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.üyeEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // üyeSilToolStripMenuItem
            // 
            this.üyeSilToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.üyeSilToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.üyeSilToolStripMenuItem.Name = "üyeSilToolStripMenuItem";
            this.üyeSilToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.üyeSilToolStripMenuItem.Text = "Üye Sil";
            this.üyeSilToolStripMenuItem.Click += new System.EventHandler(this.üyeSilToolStripMenuItem_Click);
            // 
            // üyeGüncelleToolStripMenuItem
            // 
            this.üyeGüncelleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.üyeGüncelleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.üyeGüncelleToolStripMenuItem.Name = "üyeGüncelleToolStripMenuItem";
            this.üyeGüncelleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.üyeGüncelleToolStripMenuItem.Text = "Üye Güncelle";
            this.üyeGüncelleToolStripMenuItem.Click += new System.EventHandler(this.üyeGüncelleToolStripMenuItem_Click);
            // 
            // üyeAraToolStripMenuItem
            // 
            this.üyeAraToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.üyeAraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.üyeAraToolStripMenuItem.Name = "üyeAraToolStripMenuItem";
            this.üyeAraToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.üyeAraToolStripMenuItem.Text = "Üye Ara";
            this.üyeAraToolStripMenuItem.Click += new System.EventHandler(this.üyeAraToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaklaşanGörüşmelerToolStripMenuItem,
            this.randevuEkleToolStripMenuItem});
            this.yardımToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Takvim";
            // 
            // yaklaşanGörüşmelerToolStripMenuItem
            // 
            this.yaklaşanGörüşmelerToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.yaklaşanGörüşmelerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yaklaşanGörüşmelerToolStripMenuItem.Name = "yaklaşanGörüşmelerToolStripMenuItem";
            this.yaklaşanGörüşmelerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.yaklaşanGörüşmelerToolStripMenuItem.Text = "Görüşmeleri Görüntüle";
            this.yaklaşanGörüşmelerToolStripMenuItem.Click += new System.EventHandler(this.yaklaşanGörüşmelerToolStripMenuItem_Click);
            // 
            // randevuEkleToolStripMenuItem
            // 
            this.randevuEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.randevuEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.randevuEkleToolStripMenuItem.Name = "randevuEkleToolStripMenuItem";
            this.randevuEkleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.randevuEkleToolStripMenuItem.Text = "Görüşme Ekle";
            this.randevuEkleToolStripMenuItem.Click += new System.EventHandler(this.randevuEkleToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem1
            // 
            this.yardımToolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.yardımToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaGelirGiderleriToolStripMenuItem,
            this.maaşlarToolStripMenuItem,
            this.gelirEkleToolStripMenuItem,
            this.giderEkleToolStripMenuItem});
            this.yardımToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.yardımToolStripMenuItem1.Name = "yardımToolStripMenuItem1";
            this.yardımToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.yardımToolStripMenuItem1.Text = "Kayıtlar";
            // 
            // firmaGelirGiderleriToolStripMenuItem
            // 
            this.firmaGelirGiderleriToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.firmaGelirGiderleriToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.firmaGelirGiderleriToolStripMenuItem.Name = "firmaGelirGiderleriToolStripMenuItem";
            this.firmaGelirGiderleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaGelirGiderleriToolStripMenuItem.Text = "Firma Gelir Giderleri";
            this.firmaGelirGiderleriToolStripMenuItem.Click += new System.EventHandler(this.firmaGelirGiderleriToolStripMenuItem_Click);
            // 
            // maaşlarToolStripMenuItem
            // 
            this.maaşlarToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.maaşlarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.maaşlarToolStripMenuItem.Name = "maaşlarToolStripMenuItem";
            this.maaşlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maaşlarToolStripMenuItem.Text = "Maaşları Ver";
            this.maaşlarToolStripMenuItem.Click += new System.EventHandler(this.maaşlarToolStripMenuItem_Click);
            // 
            // destekToolStripMenuItem
            // 
            this.destekToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.destekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanımToolStripMenuItem,
            this.haklarVeLisansToolStripMenuItem});
            this.destekToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.destekToolStripMenuItem.Name = "destekToolStripMenuItem";
            this.destekToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.destekToolStripMenuItem.Text = "Destek";
            // 
            // kullanımToolStripMenuItem
            // 
            this.kullanımToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.kullanımToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kullanımToolStripMenuItem.Name = "kullanımToolStripMenuItem";
            this.kullanımToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanımToolStripMenuItem.Text = "Kullanım Bilgisi";
            this.kullanımToolStripMenuItem.Click += new System.EventHandler(this.kullanımToolStripMenuItem_Click);
            // 
            // haklarVeLisansToolStripMenuItem
            // 
            this.haklarVeLisansToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.haklarVeLisansToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.haklarVeLisansToolStripMenuItem.Name = "haklarVeLisansToolStripMenuItem";
            this.haklarVeLisansToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.haklarVeLisansToolStripMenuItem.Text = "Haklar ve Lisans";
            this.haklarVeLisansToolStripMenuItem.Click += new System.EventHandler(this.haklarVeLisansToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Gray;
            this.lblTarih.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(1807, 927);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(125, 29);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "00.00.0000";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1800, 959);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gelirEkleToolStripMenuItem
            // 
            this.gelirEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.gelirEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gelirEkleToolStripMenuItem.Name = "gelirEkleToolStripMenuItem";
            this.gelirEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gelirEkleToolStripMenuItem.Text = "Gelir Ekle";
            this.gelirEkleToolStripMenuItem.Click += new System.EventHandler(this.gelirEkleToolStripMenuItem_Click);
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.giderEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            this.giderEkleToolStripMenuItem.Click += new System.EventHandler(this.giderEkleToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1924, 1031);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyelikİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seferleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferNoyaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelIDsineGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tariheGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferYerineGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaGelirGiderleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maaşlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haklarVeLisansToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ToolStripMenuItem yaklaşanGörüşmelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriyeGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeAraToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem gelirEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
    }
}

