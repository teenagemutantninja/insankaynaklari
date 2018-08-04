namespace IKO
{
    partial class duyurukaldir
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tblDuyuruBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.duyurudatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duyurudataset = new IKO.duyurudataset();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolusturanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbaslikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dicerikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDuyuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insankaynaklariDataSet3 = new IKO.insankaynaklariDataSet3();
            this.tbl_DuyuruTableAdapter = new IKO.insankaynaklariDataSet3TableAdapters.tbl_DuyuruTableAdapter();
            this.tbl_DuyuruTableAdapter1 = new IKO.duyurudatasetTableAdapters.tbl_DuyuruTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurudatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurudataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::IKO.Properties.Resources.back;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 632);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(945, 92);
            this.label4.TabIndex = 27;
            this.label4.Text = "Duyuru Kaldır";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblDuyuruBindingSource1;
            this.comboBox2.DisplayMember = "d_baslik";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(113, 207);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(280, 28);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "d_baslik";
            // 
            // tblDuyuruBindingSource1
            // 
            this.tblDuyuruBindingSource1.DataMember = "tbl_Duyuru";
            this.tblDuyuruBindingSource1.DataSource = this.duyurudatasetBindingSource;
            // 
            // duyurudatasetBindingSource
            // 
            this.duyurudatasetBindingSource.DataSource = this.duyurudataset;
            this.duyurudatasetBindingSource.Position = 0;
            // 
            // duyurudataset
            // 
            this.duyurudataset.DataSetName = "duyurudataset";
            this.duyurudataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblDuyuruBindingSource1;
            this.comboBox1.DisplayMember = "d_olusturan";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "d_olusturan";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Başlık";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Oluşturan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(19, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 140);
            this.button1.TabIndex = 19;
            this.button1.Text = "Duyuruyu Kaldır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(842, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ara";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtarihDataGridViewTextBoxColumn,
            this.dolusturanDataGridViewTextBoxColumn,
            this.dbaslikDataGridViewTextBoxColumn,
            this.dicerikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDuyuruBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(399, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dtarihDataGridViewTextBoxColumn
            // 
            this.dtarihDataGridViewTextBoxColumn.DataPropertyName = "d_tarih";
            this.dtarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.dtarihDataGridViewTextBoxColumn.Name = "dtarihDataGridViewTextBoxColumn";
            // 
            // dolusturanDataGridViewTextBoxColumn
            // 
            this.dolusturanDataGridViewTextBoxColumn.DataPropertyName = "d_olusturan";
            this.dolusturanDataGridViewTextBoxColumn.HeaderText = "Oluışturan";
            this.dolusturanDataGridViewTextBoxColumn.Name = "dolusturanDataGridViewTextBoxColumn";
            // 
            // dbaslikDataGridViewTextBoxColumn
            // 
            this.dbaslikDataGridViewTextBoxColumn.DataPropertyName = "d_baslik";
            this.dbaslikDataGridViewTextBoxColumn.HeaderText = "Başlık";
            this.dbaslikDataGridViewTextBoxColumn.Name = "dbaslikDataGridViewTextBoxColumn";
            // 
            // dicerikDataGridViewTextBoxColumn
            // 
            this.dicerikDataGridViewTextBoxColumn.DataPropertyName = "d_icerik";
            this.dicerikDataGridViewTextBoxColumn.HeaderText = "İçerik";
            this.dicerikDataGridViewTextBoxColumn.Name = "dicerikDataGridViewTextBoxColumn";
            // 
            // tblDuyuruBindingSource
            // 
            this.tblDuyuruBindingSource.DataMember = "tbl_Duyuru";
            this.tblDuyuruBindingSource.DataSource = this.insankaynaklariDataSet3;
            // 
            // insankaynaklariDataSet3
            // 
            this.insankaynaklariDataSet3.DataSetName = "insankaynaklariDataSet3";
            this.insankaynaklariDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DuyuruTableAdapter
            // 
            this.tbl_DuyuruTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DuyuruTableAdapter1
            // 
            this.tbl_DuyuruTableAdapter1.ClearBeforeFill = true;
            // 
            // duyurukaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IKO.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 656);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "duyurukaldir";
            this.Text = "duyurukaldir";
            this.Load += new System.EventHandler(this.duyurukaldir_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurudatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duyurudataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDuyuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private insankaynaklariDataSet3 insankaynaklariDataSet3;
        private System.Windows.Forms.BindingSource tblDuyuruBindingSource;
        private insankaynaklariDataSet3TableAdapters.tbl_DuyuruTableAdapter tbl_DuyuruTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolusturanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbaslikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dicerikDataGridViewTextBoxColumn;
        private duyurudataset duyurudataset;
        private System.Windows.Forms.BindingSource duyurudatasetBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblDuyuruBindingSource1;
        private duyurudatasetTableAdapters.tbl_DuyuruTableAdapter tbl_DuyuruTableAdapter1;
        private System.Windows.Forms.Label label4;
    }
}