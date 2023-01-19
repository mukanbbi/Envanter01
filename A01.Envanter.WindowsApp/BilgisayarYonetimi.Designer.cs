namespace A01.Envanter.WindowsApp
{
    partial class BilgisayarYonetimi
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
            this.dgwBilgisayar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.bntEkle = new System.Windows.Forms.Button();
            this.dateEklemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chYedekleniyorMu = new System.Windows.Forms.CheckBox();
            this.txtDcName = new System.Windows.Forms.TextBox();
            this.txtPCAdi = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtSabitIP2 = new System.Windows.Forms.TextBox();
            this.txtSabitIP1 = new System.Windows.Forms.TextBox();
            this.txtPCYedekMac = new System.Windows.Forms.TextBox();
            this.txtPCWrilessMac = new System.Windows.Forms.TextBox();
            this.txtPCLanMac = new System.Windows.Forms.TextBox();
            this.txtLisans3Code = new System.Windows.Forms.TextBox();
            this.txtLisans3 = new System.Windows.Forms.TextBox();
            this.txtLisans2Code = new System.Windows.Forms.TextBox();
            this.txtLisans2 = new System.Windows.Forms.TextBox();
            this.txtLisans1Code = new System.Windows.Forms.TextBox();
            this.txtLisans1 = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.cbMakina = new System.Windows.Forms.ComboBox();
            this.cbDepartman = new System.Windows.Forms.ComboBox();
            this.cbFirmaAdi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilgisayar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBilgisayar
            // 
            this.dgwBilgisayar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBilgisayar.Location = new System.Drawing.Point(13, 12);
            this.dgwBilgisayar.Name = "dgwBilgisayar";
            this.dgwBilgisayar.Size = new System.Drawing.Size(1283, 227);
            this.dgwBilgisayar.TabIndex = 1;
            this.dgwBilgisayar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBilgisayar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.bntEkle);
            this.groupBox1.Controls.Add(this.dateEklemeTarihi);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chYedekleniyorMu);
            this.groupBox1.Controls.Add(this.txtDcName);
            this.groupBox1.Controls.Add(this.txtPCAdi);
            this.groupBox1.Controls.Add(this.txtNot2);
            this.groupBox1.Controls.Add(this.txtNot1);
            this.groupBox1.Controls.Add(this.txtSabitIP2);
            this.groupBox1.Controls.Add(this.txtSabitIP1);
            this.groupBox1.Controls.Add(this.txtPCYedekMac);
            this.groupBox1.Controls.Add(this.txtPCWrilessMac);
            this.groupBox1.Controls.Add(this.txtPCLanMac);
            this.groupBox1.Controls.Add(this.txtLisans3Code);
            this.groupBox1.Controls.Add(this.txtLisans3);
            this.groupBox1.Controls.Add(this.txtLisans2Code);
            this.groupBox1.Controls.Add(this.txtLisans2);
            this.groupBox1.Controls.Add(this.txtLisans1Code);
            this.groupBox1.Controls.Add(this.txtLisans1);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.cbMarka);
            this.groupBox1.Controls.Add(this.cbMakina);
            this.groupBox1.Controls.Add(this.cbDepartman);
            this.groupBox1.Controls.Add(this.cbFirmaAdi);
            this.groupBox1.Location = new System.Drawing.Point(11, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1284, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgisayar Yonetimi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1130, 102);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 19);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1054, 103);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(56, 19);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // bntEkle
            // 
            this.bntEkle.Location = new System.Drawing.Point(981, 103);
            this.bntEkle.Margin = new System.Windows.Forms.Padding(2);
            this.bntEkle.Name = "bntEkle";
            this.bntEkle.Size = new System.Drawing.Size(56, 19);
            this.bntEkle.TabIndex = 5;
            this.bntEkle.Text = "Ekle";
            this.bntEkle.UseVisualStyleBackColor = true;
            this.bntEkle.Click += new System.EventHandler(this.BntEkle_Click);
            // 
            // dateEklemeTarihi
            // 
            this.dateEklemeTarihi.Location = new System.Drawing.Point(993, 28);
            this.dateEklemeTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dateEklemeTarihi.Name = "dateEklemeTarihi";
            this.dateEklemeTarihi.Size = new System.Drawing.Size(151, 20);
            this.dateEklemeTarihi.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 181);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "PC Lan Mac";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 150);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Lisans 3 Active Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Lisans 2 Active Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Lisans 1 Active Code";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(632, 181);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(33, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Not 2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(632, 181);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "label1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(632, 157);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Not 1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(628, 106);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Sabit IP 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(628, 85);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Sabit IP 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(604, 63);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "PC Yedek Mac";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Lisans 3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(911, 32);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Ekleme Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Lisans 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(600, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "PC Wriless Mac";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lisans 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Marka";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(35, 157);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Makina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DC Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PC Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firma";
            // 
            // chYedekleniyorMu
            // 
            this.chYedekleniyorMu.AutoSize = true;
            this.chYedekleniyorMu.Location = new System.Drawing.Point(696, 128);
            this.chYedekleniyorMu.Margin = new System.Windows.Forms.Padding(2);
            this.chYedekleniyorMu.Name = "chYedekleniyorMu";
            this.chYedekleniyorMu.Size = new System.Drawing.Size(110, 17);
            this.chYedekleniyorMu.TabIndex = 2;
            this.chYedekleniyorMu.Text = "Yedekleniyor mu?";
            this.chYedekleniyorMu.UseVisualStyleBackColor = true;
            // 
            // txtDcName
            // 
            this.txtDcName.Location = new System.Drawing.Point(91, 104);
            this.txtDcName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDcName.Name = "txtDcName";
            this.txtDcName.Size = new System.Drawing.Size(155, 20);
            this.txtDcName.TabIndex = 1;
            // 
            // txtPCAdi
            // 
            this.txtPCAdi.Location = new System.Drawing.Point(91, 81);
            this.txtPCAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPCAdi.Name = "txtPCAdi";
            this.txtPCAdi.Size = new System.Drawing.Size(155, 20);
            this.txtPCAdi.TabIndex = 1;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(696, 176);
            this.txtNot2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(155, 20);
            this.txtNot2.TabIndex = 1;
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(696, 153);
            this.txtNot1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(155, 20);
            this.txtNot1.TabIndex = 1;
            // 
            // txtSabitIP2
            // 
            this.txtSabitIP2.Location = new System.Drawing.Point(696, 104);
            this.txtSabitIP2.Margin = new System.Windows.Forms.Padding(2);
            this.txtSabitIP2.Name = "txtSabitIP2";
            this.txtSabitIP2.Size = new System.Drawing.Size(155, 20);
            this.txtSabitIP2.TabIndex = 1;
            // 
            // txtSabitIP1
            // 
            this.txtSabitIP1.Location = new System.Drawing.Point(696, 81);
            this.txtSabitIP1.Margin = new System.Windows.Forms.Padding(2);
            this.txtSabitIP1.Name = "txtSabitIP1";
            this.txtSabitIP1.Size = new System.Drawing.Size(155, 20);
            this.txtSabitIP1.TabIndex = 1;
            // 
            // txtPCYedekMac
            // 
            this.txtPCYedekMac.Location = new System.Drawing.Point(696, 58);
            this.txtPCYedekMac.Margin = new System.Windows.Forms.Padding(2);
            this.txtPCYedekMac.Name = "txtPCYedekMac";
            this.txtPCYedekMac.Size = new System.Drawing.Size(155, 20);
            this.txtPCYedekMac.TabIndex = 1;
            // 
            // txtPCWrilessMac
            // 
            this.txtPCWrilessMac.Location = new System.Drawing.Point(696, 28);
            this.txtPCWrilessMac.Margin = new System.Windows.Forms.Padding(2);
            this.txtPCWrilessMac.Name = "txtPCWrilessMac";
            this.txtPCWrilessMac.Size = new System.Drawing.Size(155, 20);
            this.txtPCWrilessMac.TabIndex = 1;
            // 
            // txtPCLanMac
            // 
            this.txtPCLanMac.Location = new System.Drawing.Point(392, 172);
            this.txtPCLanMac.Margin = new System.Windows.Forms.Padding(2);
            this.txtPCLanMac.Name = "txtPCLanMac";
            this.txtPCLanMac.Size = new System.Drawing.Size(155, 20);
            this.txtPCLanMac.TabIndex = 1;
            // 
            // txtLisans3Code
            // 
            this.txtLisans3Code.Location = new System.Drawing.Point(392, 150);
            this.txtLisans3Code.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisans3Code.Name = "txtLisans3Code";
            this.txtLisans3Code.Size = new System.Drawing.Size(155, 20);
            this.txtLisans3Code.TabIndex = 1;
            // 
            // txtLisans3
            // 
            this.txtLisans3.Location = new System.Drawing.Point(392, 127);
            this.txtLisans3.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisans3.Name = "txtLisans3";
            this.txtLisans3.Size = new System.Drawing.Size(155, 20);
            this.txtLisans3.TabIndex = 1;
            // 
            // txtLisans2Code
            // 
            this.txtLisans2Code.Location = new System.Drawing.Point(392, 104);
            this.txtLisans2Code.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisans2Code.Name = "txtLisans2Code";
            this.txtLisans2Code.Size = new System.Drawing.Size(155, 20);
            this.txtLisans2Code.TabIndex = 1;
            // 
            // txtLisans2
            // 
            this.txtLisans2.Location = new System.Drawing.Point(392, 81);
            this.txtLisans2.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisans2.Name = "txtLisans2";
            this.txtLisans2.Size = new System.Drawing.Size(155, 20);
            this.txtLisans2.TabIndex = 1;
            // 
            // txtLisans1Code
            // 
            this.txtLisans1Code.Location = new System.Drawing.Point(392, 58);
            this.txtLisans1Code.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisans1Code.Name = "txtLisans1Code";
            this.txtLisans1Code.Size = new System.Drawing.Size(155, 20);
            this.txtLisans1Code.TabIndex = 1;
            // 
            // txtLisans1
            // 
            this.txtLisans1.Location = new System.Drawing.Point(392, 28);
            this.txtLisans1.Margin = new System.Windows.Forms.Padding(2);
            this.txtLisans1.Name = "txtLisans1";
            this.txtLisans1.Size = new System.Drawing.Size(155, 20);
            this.txtLisans1.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(91, 58);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(155, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // cbMarka
            // 
            this.cbMarka.DisplayMember = "Marka";
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(91, 176);
            this.cbMarka.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(155, 21);
            this.cbMarka.TabIndex = 0;
            this.cbMarka.ValueMember = "Id";
            // 
            // cbMakina
            // 
            this.cbMakina.DisplayMember = "KasaTipi";
            this.cbMakina.FormattingEnabled = true;
            this.cbMakina.Location = new System.Drawing.Point(91, 151);
            this.cbMakina.Margin = new System.Windows.Forms.Padding(2);
            this.cbMakina.Name = "cbMakina";
            this.cbMakina.Size = new System.Drawing.Size(155, 21);
            this.cbMakina.TabIndex = 0;
            this.cbMakina.ValueMember = "Id";
            // 
            // cbDepartman
            // 
            this.cbDepartman.AccessibleName = "";
            this.cbDepartman.FormattingEnabled = true;
            this.cbDepartman.Location = new System.Drawing.Point(91, 127);
            this.cbDepartman.Margin = new System.Windows.Forms.Padding(2);
            this.cbDepartman.Name = "cbDepartman";
            this.cbDepartman.Size = new System.Drawing.Size(155, 21);
            this.cbDepartman.TabIndex = 0;
            // 
            // cbFirmaAdi
            // 
            this.cbFirmaAdi.DisplayMember = "FirmaAdi";
            this.cbFirmaAdi.FormattingEnabled = true;
            this.cbFirmaAdi.Location = new System.Drawing.Point(91, 27);
            this.cbFirmaAdi.Margin = new System.Windows.Forms.Padding(2);
            this.cbFirmaAdi.Name = "cbFirmaAdi";
            this.cbFirmaAdi.Size = new System.Drawing.Size(155, 21);
            this.cbFirmaAdi.TabIndex = 0;
            this.cbFirmaAdi.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(966, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Id";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(990, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "0";
            // 
            // BilgisayarYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwBilgisayar);
            this.Name = "BilgisayarYonetimi";
            this.Text = "BilgisayarYonetimi";
            this.Load += new System.EventHandler(this.BilgisayarYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBilgisayar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBilgisayar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button bntEkle;
        private System.Windows.Forms.DateTimePicker dateEklemeTarihi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chYedekleniyorMu;
        private System.Windows.Forms.TextBox txtDcName;
        private System.Windows.Forms.TextBox txtPCAdi;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtSabitIP2;
        private System.Windows.Forms.TextBox txtSabitIP1;
        private System.Windows.Forms.TextBox txtPCYedekMac;
        private System.Windows.Forms.TextBox txtPCWrilessMac;
        private System.Windows.Forms.TextBox txtPCLanMac;
        private System.Windows.Forms.TextBox txtLisans3Code;
        private System.Windows.Forms.TextBox txtLisans3;
        private System.Windows.Forms.TextBox txtLisans2Code;
        private System.Windows.Forms.TextBox txtLisans2;
        private System.Windows.Forms.TextBox txtLisans1Code;
        private System.Windows.Forms.TextBox txtLisans1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbMakina;
        private System.Windows.Forms.ComboBox cbDepartman;
        private System.Windows.Forms.ComboBox cbFirmaAdi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
    }
}