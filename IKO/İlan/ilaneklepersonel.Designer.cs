namespace IKO
{
    partial class ilaneklepersonel
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.posta = new System.Windows.Forms.TextBox();
            this.personelresim = new System.Windows.Forms.TextBox();
            this.p_telefon = new System.Windows.Forms.TextBox();
            this.ppozisyon = new System.Windows.Forms.TextBox();
            this.pdepartman = new System.Windows.Forms.TextBox();
            this.paskerlik = new System.Windows.Forms.TextBox();
            this.psehir = new System.Windows.Forms.TextBox();
            this.cinsiyetttt = new System.Windows.Forms.TextBox();
            this.personelid = new System.Windows.Forms.TextBox();
            this.personeltc = new System.Windows.Forms.ComboBox();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilaneklepersoneldataset = new IKO.ilaneklepersoneldataset();
            this.personelsoyadi = new System.Windows.Forms.ComboBox();
            this.personeladi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_personelTableAdapter = new IKO.ilaneklepersoneldatasetTableAdapters.tbl_personelTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaneklepersoneldataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(15, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.posta);
            this.groupBox1.Controls.Add(this.personelresim);
            this.groupBox1.Controls.Add(this.p_telefon);
            this.groupBox1.Controls.Add(this.ppozisyon);
            this.groupBox1.Controls.Add(this.pdepartman);
            this.groupBox1.Controls.Add(this.paskerlik);
            this.groupBox1.Controls.Add(this.psehir);
            this.groupBox1.Controls.Add(this.cinsiyetttt);
            this.groupBox1.Controls.Add(this.personelid);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.personeltc);
            this.groupBox1.Controls.Add(this.personelsoyadi);
            this.groupBox1.Controls.Add(this.personeladi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 328);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Arama İlanı";
            // 
            // posta
            // 
            this.posta.Location = new System.Drawing.Point(255, 205);
            this.posta.Name = "posta";
            this.posta.Size = new System.Drawing.Size(24, 26);
            this.posta.TabIndex = 31;
            this.posta.Visible = false;
            // 
            // personelresim
            // 
            this.personelresim.Location = new System.Drawing.Point(225, 205);
            this.personelresim.Name = "personelresim";
            this.personelresim.Size = new System.Drawing.Size(24, 26);
            this.personelresim.TabIndex = 30;
            this.personelresim.Visible = false;
            // 
            // p_telefon
            // 
            this.p_telefon.Location = new System.Drawing.Point(195, 205);
            this.p_telefon.Name = "p_telefon";
            this.p_telefon.Size = new System.Drawing.Size(24, 26);
            this.p_telefon.TabIndex = 29;
            this.p_telefon.Visible = false;
            // 
            // ppozisyon
            // 
            this.ppozisyon.Location = new System.Drawing.Point(165, 205);
            this.ppozisyon.Name = "ppozisyon";
            this.ppozisyon.Size = new System.Drawing.Size(24, 26);
            this.ppozisyon.TabIndex = 28;
            this.ppozisyon.Visible = false;
            // 
            // pdepartman
            // 
            this.pdepartman.Location = new System.Drawing.Point(135, 205);
            this.pdepartman.Name = "pdepartman";
            this.pdepartman.Size = new System.Drawing.Size(24, 26);
            this.pdepartman.TabIndex = 27;
            this.pdepartman.Visible = false;
            // 
            // paskerlik
            // 
            this.paskerlik.Location = new System.Drawing.Point(105, 205);
            this.paskerlik.Name = "paskerlik";
            this.paskerlik.Size = new System.Drawing.Size(24, 26);
            this.paskerlik.TabIndex = 26;
            this.paskerlik.Visible = false;
            // 
            // psehir
            // 
            this.psehir.Location = new System.Drawing.Point(75, 205);
            this.psehir.Name = "psehir";
            this.psehir.Size = new System.Drawing.Size(24, 26);
            this.psehir.TabIndex = 25;
            this.psehir.Visible = false;
            // 
            // cinsiyetttt
            // 
            this.cinsiyetttt.Location = new System.Drawing.Point(45, 205);
            this.cinsiyetttt.Name = "cinsiyetttt";
            this.cinsiyetttt.Size = new System.Drawing.Size(24, 26);
            this.cinsiyetttt.TabIndex = 24;
            this.cinsiyetttt.Visible = false;
            // 
            // personelid
            // 
            this.personelid.Location = new System.Drawing.Point(15, 205);
            this.personelid.Name = "personelid";
            this.personelid.Size = new System.Drawing.Size(24, 26);
            this.personelid.TabIndex = 23;
            this.personelid.Visible = false;
            // 
            // personeltc
            // 
            this.personeltc.DataSource = this.tblpersonelBindingSource;
            this.personeltc.DisplayMember = "p_tc_kimlik";
            this.personeltc.FormattingEnabled = true;
            this.personeltc.Location = new System.Drawing.Point(185, 101);
            this.personeltc.Name = "personeltc";
            this.personeltc.Size = new System.Drawing.Size(121, 28);
            this.personeltc.TabIndex = 22;
            this.personeltc.ValueMember = "p_tc_kimlik";
            this.personeltc.SelectedIndexChanged += new System.EventHandler(this.personeltc_SelectedIndexChanged);
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.ilaneklepersoneldataset;
            // 
            // ilaneklepersoneldataset
            // 
            this.ilaneklepersoneldataset.DataSetName = "ilaneklepersoneldataset";
            this.ilaneklepersoneldataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelsoyadi
            // 
            this.personelsoyadi.DataSource = this.tblpersonelBindingSource;
            this.personelsoyadi.DisplayMember = "p_soy_isim";
            this.personelsoyadi.FormattingEnabled = true;
            this.personelsoyadi.Location = new System.Drawing.Point(185, 69);
            this.personelsoyadi.Name = "personelsoyadi";
            this.personelsoyadi.Size = new System.Drawing.Size(121, 28);
            this.personelsoyadi.TabIndex = 21;
            this.personelsoyadi.ValueMember = "p_soy_isim";
            // 
            // personeladi
            // 
            this.personeladi.DataSource = this.tblpersonelBindingSource;
            this.personeladi.DisplayMember = "p_isim";
            this.personeladi.FormattingEnabled = true;
            this.personeladi.Location = new System.Drawing.Point(185, 37);
            this.personeladi.Name = "personeladi";
            this.personeladi.Size = new System.Drawing.Size(121, 28);
            this.personeladi.TabIndex = 4;
            this.personeladi.ValueMember = "p_isim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "T.C. No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IKO.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Personel Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // ilaneklepersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IKO.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 353);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "ilaneklepersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ilaneklepersonel";
            this.Load += new System.EventHandler(this.ilaneklepersonel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaneklepersoneldataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox personeltc;
        private System.Windows.Forms.ComboBox personelsoyadi;
        private System.Windows.Forms.ComboBox personeladi;
        private System.Windows.Forms.TextBox personelid;
        private System.Windows.Forms.TextBox personelresim;
        private System.Windows.Forms.TextBox p_telefon;
        private System.Windows.Forms.TextBox ppozisyon;
        private System.Windows.Forms.TextBox pdepartman;
        private System.Windows.Forms.TextBox paskerlik;
        private System.Windows.Forms.TextBox psehir;
        private System.Windows.Forms.TextBox cinsiyetttt;
        private System.Windows.Forms.TextBox posta;
        private ilaneklepersoneldataset ilaneklepersoneldataset;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private ilaneklepersoneldatasetTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
    }
}