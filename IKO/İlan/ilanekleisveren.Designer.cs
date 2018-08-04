namespace IKO
{
    partial class ilanekleisveren
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblSirketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ilanverisveren = new IKO.ilanverisveren();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isverenicinaskerlikcinsiyet = new IKO.isverenicinaskerlikcinsiyet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sirketsehir = new System.Windows.Forms.TextBox();
            this.isverenaditext = new System.Windows.Forms.ComboBox();
            this.pozisyontext = new System.Windows.Forms.TextBox();
            this.departmantext = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.istanimitext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxmaas = new System.Windows.Forms.TextBox();
            this.minmaas = new System.Windows.Forms.TextBox();
            this.insankaynaklariDataSet = new IKO.insankaynaklariDataSet();
            this.tblSirketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SirketTableAdapter = new IKO.insankaynaklariDataSetTableAdapters.tbl_SirketTableAdapter();
            this.tbl_SirketTableAdapter1 = new IKO.ilanverisverenTableAdapters.tbl_SirketTableAdapter();
            this.tbl_personelTableAdapter = new IKO.isverenicinaskerlikcinsiyetTableAdapters.tbl_personelTableAdapter();
            this.ilanekleisverendataset = new IKO.ilanekleisverendataset();
            this.tblpersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_personelTableAdapter1 = new IKO.ilanekleisverendatasetTableAdapters.tbl_personelTableAdapter();
            this.ilanverisverenadi = new IKO.ilanverisverenadi();
            this.tblilanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ilanTableAdapter = new IKO.ilanverisverenadiTableAdapters.tbl_ilanTableAdapter();
            this.sirketadres = new System.Windows.Forms.TextBox();
            this.sirketeposta = new System.Windows.Forms.TextBox();
            this.sirkettel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblSirketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanverisveren)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isverenicinaskerlikcinsiyet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSirketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanekleisverendataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanverisverenadi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1095, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "İş Ver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblSirketBindingSource1
            // 
            this.tblSirketBindingSource1.DataMember = "tbl_Sirket";
            this.tblSirketBindingSource1.DataSource = this.ilanverisveren;
            // 
            // ilanverisveren
            // 
            this.ilanverisveren.DataSetName = "ilanverisveren";
            this.ilanverisveren.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "İş Veren Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(760, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 279);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aranan Özellik";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(125, 207);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(119, 24);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "Yapılmamış";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(104, 87);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(73, 24);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Kadın";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 207);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 24);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Yapılmış";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Erkek";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Askerlik";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Cinsiyet";
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.isverenicinaskerlikcinsiyet;
            this.tblpersonelBindingSource.CurrentChanged += new System.EventHandler(this.tblpersonelBindingSource_CurrentChanged);
            // 
            // isverenicinaskerlikcinsiyet
            // 
            this.isverenicinaskerlikcinsiyet.DataSetName = "isverenicinaskerlikcinsiyet";
            this.isverenicinaskerlikcinsiyet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(24, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 58);
            this.button1.TabIndex = 23;
            this.button1.Text = "İş Veren Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(760, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(347, 254);
            this.button2.TabIndex = 22;
            this.button2.Text = "Yolla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.sirketsehir);
            this.groupBox3.Controls.Add(this.isverenaditext);
            this.groupBox3.Controls.Add(this.pozisyontext);
            this.groupBox3.Controls.Add(this.departmantext);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.istanimitext);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.maxmaas);
            this.groupBox3.Controls.Add(this.minmaas);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(17, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 546);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İş Tanımı";
            // 
            // sirketsehir
            // 
            this.sirketsehir.Location = new System.Drawing.Point(276, 238);
            this.sirketsehir.Name = "sirketsehir";
            this.sirketsehir.Size = new System.Drawing.Size(100, 26);
            this.sirketsehir.TabIndex = 27;
            this.sirketsehir.Visible = false;
            // 
            // isverenaditext
            // 
            this.isverenaditext.DataSource = this.ilanverisveren;
            this.isverenaditext.DisplayMember = "tbl_Sirket.sirket_adi";
            this.isverenaditext.FormattingEnabled = true;
            this.isverenaditext.Location = new System.Drawing.Point(24, 118);
            this.isverenaditext.Name = "isverenaditext";
            this.isverenaditext.Size = new System.Drawing.Size(297, 28);
            this.isverenaditext.TabIndex = 26;
            this.isverenaditext.ValueMember = "tbl_Sirket.sirket_adi";
            // 
            // pozisyontext
            // 
            this.pozisyontext.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pozisyontext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pozisyontext.Location = new System.Drawing.Point(505, 118);
            this.pozisyontext.Name = "pozisyontext";
            this.pozisyontext.Size = new System.Drawing.Size(196, 26);
            this.pozisyontext.TabIndex = 25;
            // 
            // departmantext
            // 
            this.departmantext.BackColor = System.Drawing.SystemColors.HighlightText;
            this.departmantext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departmantext.Location = new System.Drawing.Point(505, 82);
            this.departmantext.Name = "departmantext";
            this.departmantext.Size = new System.Drawing.Size(196, 26);
            this.departmantext.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pozisyon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Min Maaş";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Max Maaş";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "İş Tanımı";
            // 
            // istanimitext
            // 
            this.istanimitext.BackColor = System.Drawing.SystemColors.Info;
            this.istanimitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.istanimitext.Location = new System.Drawing.Point(24, 292);
            this.istanimitext.Multiline = true;
            this.istanimitext.Name = "istanimitext";
            this.istanimitext.Size = new System.Drawing.Size(677, 234);
            this.istanimitext.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departman";
            // 
            // maxmaas
            // 
            this.maxmaas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.maxmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maxmaas.Location = new System.Drawing.Point(505, 204);
            this.maxmaas.Name = "maxmaas";
            this.maxmaas.Size = new System.Drawing.Size(196, 26);
            this.maxmaas.TabIndex = 11;
            this.maxmaas.TextChanged += new System.EventHandler(this.maxmaas_TextChanged);
            // 
            // minmaas
            // 
            this.minmaas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.minmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minmaas.Location = new System.Drawing.Point(505, 169);
            this.minmaas.Name = "minmaas";
            this.minmaas.Size = new System.Drawing.Size(196, 26);
            this.minmaas.TabIndex = 10;
            this.minmaas.Leave += new System.EventHandler(this.minmaas_Leave);
            // 
            // insankaynaklariDataSet
            // 
            this.insankaynaklariDataSet.DataSetName = "insankaynaklariDataSet";
            this.insankaynaklariDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSirketBindingSource
            // 
            this.tblSirketBindingSource.DataMember = "tbl_Sirket";
            this.tblSirketBindingSource.DataSource = this.insankaynaklariDataSet;
            // 
            // tbl_SirketTableAdapter
            // 
            this.tbl_SirketTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_SirketTableAdapter1
            // 
            this.tbl_SirketTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // ilanekleisverendataset
            // 
            this.ilanekleisverendataset.DataSetName = "ilanekleisverendataset";
            this.ilanekleisverendataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpersonelBindingSource1
            // 
            this.tblpersonelBindingSource1.DataMember = "tbl_personel";
            this.tblpersonelBindingSource1.DataSource = this.ilanekleisverendataset;
            // 
            // tbl_personelTableAdapter1
            // 
            this.tbl_personelTableAdapter1.ClearBeforeFill = true;
            // 
            // ilanverisverenadi
            // 
            this.ilanverisverenadi.DataSetName = "ilanverisverenadi";
            this.ilanverisverenadi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblilanBindingSource
            // 
            this.tblilanBindingSource.DataMember = "tbl_ilan";
            this.tblilanBindingSource.DataSource = this.ilanverisverenadi;
            // 
            // tbl_ilanTableAdapter
            // 
            this.tbl_ilanTableAdapter.ClearBeforeFill = true;
            // 
            // sirketadres
            // 
            this.sirketadres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sirketadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sirketadres.Location = new System.Drawing.Point(41, 69);
            this.sirketadres.Name = "sirketadres";
            this.sirketadres.Size = new System.Drawing.Size(196, 26);
            this.sirketadres.TabIndex = 25;
            this.sirketadres.Visible = false;
            // 
            // sirketeposta
            // 
            this.sirketeposta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sirketeposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sirketeposta.Location = new System.Drawing.Point(243, 69);
            this.sirketeposta.Name = "sirketeposta";
            this.sirketeposta.Size = new System.Drawing.Size(196, 26);
            this.sirketeposta.TabIndex = 26;
            this.sirketeposta.Visible = false;
            // 
            // sirkettel
            // 
            this.sirkettel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sirkettel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sirkettel.Location = new System.Drawing.Point(445, 69);
            this.sirkettel.Name = "sirkettel";
            this.sirkettel.Size = new System.Drawing.Size(196, 26);
            this.sirkettel.TabIndex = 27;
            this.sirkettel.Visible = false;
            // 
            // ilanekleisveren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IKO.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 656);
            this.Controls.Add(this.sirkettel);
            this.Controls.Add(this.sirketeposta);
            this.Controls.Add(this.sirketadres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ilanekleisveren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ilanekleisveren";
            this.Load += new System.EventHandler(this.ilanekleisveren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSirketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanverisveren)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isverenicinaskerlikcinsiyet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSirketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanekleisverendataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanverisverenadi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox istanimitext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxmaas;
        private System.Windows.Forms.TextBox minmaas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private insankaynaklariDataSet insankaynaklariDataSet;
        private System.Windows.Forms.BindingSource tblSirketBindingSource;
        private insankaynaklariDataSetTableAdapters.tbl_SirketTableAdapter tbl_SirketTableAdapter;
        private ilanverisveren ilanverisveren;
        private System.Windows.Forms.BindingSource tblSirketBindingSource1;
        private ilanverisverenTableAdapters.tbl_SirketTableAdapter tbl_SirketTableAdapter1;
        private isverenicinaskerlikcinsiyet isverenicinaskerlikcinsiyet;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private isverenicinaskerlikcinsiyetTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
        private ilanekleisverendataset ilanekleisverendataset;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource1;
        private ilanekleisverendatasetTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter1;
        private System.Windows.Forms.TextBox pozisyontext;
        private System.Windows.Forms.TextBox departmantext;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private ilanverisverenadi ilanverisverenadi;
        private System.Windows.Forms.BindingSource tblilanBindingSource;
        private ilanverisverenadiTableAdapters.tbl_ilanTableAdapter tbl_ilanTableAdapter;
        private System.Windows.Forms.ComboBox isverenaditext;
        private System.Windows.Forms.TextBox sirketadres;
        private System.Windows.Forms.TextBox sirketeposta;
        private System.Windows.Forms.TextBox sirkettel;
        private System.Windows.Forms.TextBox sirketsehir;
    }
}