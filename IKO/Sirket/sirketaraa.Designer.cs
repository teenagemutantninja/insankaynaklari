namespace IKO
{
    partial class sirketaraa
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
            this.insankaynaklariDataSet2 = new IKO.insankaynaklariDataSet2();
            this.tblSirketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_SirketTableAdapter = new IKO.insankaynaklariDataSet2TableAdapters.tbl_SirketTableAdapter();
            this.sirketepostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirketyoneticiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirketsektorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirketnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirketadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirketadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ara = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSirketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insankaynaklariDataSet2
            // 
            this.insankaynaklariDataSet2.DataSetName = "insankaynaklariDataSet2";
            this.insankaynaklariDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSirketBindingSource
            // 
            this.tblSirketBindingSource.DataMember = "tbl_Sirket";
            this.tblSirketBindingSource.DataSource = this.insankaynaklariDataSet2;
            // 
            // tbl_SirketTableAdapter
            // 
            this.tbl_SirketTableAdapter.ClearBeforeFill = true;
            // 
            // sirketepostaDataGridViewTextBoxColumn
            // 
            this.sirketepostaDataGridViewTextBoxColumn.DataPropertyName = "sirket_eposta";
            this.sirketepostaDataGridViewTextBoxColumn.HeaderText = "sirket_eposta";
            this.sirketepostaDataGridViewTextBoxColumn.Name = "sirketepostaDataGridViewTextBoxColumn";
            // 
            // sirketyoneticiDataGridViewTextBoxColumn
            // 
            this.sirketyoneticiDataGridViewTextBoxColumn.DataPropertyName = "sirket_yonetici";
            this.sirketyoneticiDataGridViewTextBoxColumn.HeaderText = "sirket_yonetici";
            this.sirketyoneticiDataGridViewTextBoxColumn.Name = "sirketyoneticiDataGridViewTextBoxColumn";
            // 
            // sirketsektorDataGridViewTextBoxColumn
            // 
            this.sirketsektorDataGridViewTextBoxColumn.DataPropertyName = "sirket_sektor";
            this.sirketsektorDataGridViewTextBoxColumn.HeaderText = "sirket_sektor";
            this.sirketsektorDataGridViewTextBoxColumn.Name = "sirketsektorDataGridViewTextBoxColumn";
            // 
            // sirketnoDataGridViewTextBoxColumn
            // 
            this.sirketnoDataGridViewTextBoxColumn.DataPropertyName = "sirket_no";
            this.sirketnoDataGridViewTextBoxColumn.HeaderText = "sirket_no";
            this.sirketnoDataGridViewTextBoxColumn.Name = "sirketnoDataGridViewTextBoxColumn";
            // 
            // sirketadresDataGridViewTextBoxColumn
            // 
            this.sirketadresDataGridViewTextBoxColumn.DataPropertyName = "sirket_adres";
            this.sirketadresDataGridViewTextBoxColumn.HeaderText = "sirket_adres";
            this.sirketadresDataGridViewTextBoxColumn.Name = "sirketadresDataGridViewTextBoxColumn";
            // 
            // sirketadiDataGridViewTextBoxColumn
            // 
            this.sirketadiDataGridViewTextBoxColumn.DataPropertyName = "sirket_adi";
            this.sirketadiDataGridViewTextBoxColumn.HeaderText = "sirket_adi";
            this.sirketadiDataGridViewTextBoxColumn.Name = "sirketadiDataGridViewTextBoxColumn";
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "s_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "s_id";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(100)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.sirketadiDataGridViewTextBoxColumn,
            this.sirketadresDataGridViewTextBoxColumn,
            this.sirketnoDataGridViewTextBoxColumn,
            this.sirketsektorDataGridViewTextBoxColumn,
            this.sirketyoneticiDataGridViewTextBoxColumn,
            this.sirketepostaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSirketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(954, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::IKO.Properties.Resources.back;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 340);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(130, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(842, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ara
            // 
            this.Ara.BackColor = System.Drawing.Color.Transparent;
            this.Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Ara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ara.Location = new System.Drawing.Point(12, 45);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(112, 23);
            this.Ara.TabIndex = 4;
            this.Ara.Text = "Şirket Ara";
            this.Ara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(966, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ada Göre Sırala";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(966, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "ID\' ye Göre Sırala";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(966, 49);
            this.button3.TabIndex = 21;
            this.button3.Text = "Yöneticiye Göre Sırala";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sirketaraa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IKO.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 650);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sirketaraa";
            this.Text = "sirketara";
            this.Load += new System.EventHandler(this.sirketaraa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSirketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private insankaynaklariDataSet2 insankaynaklariDataSet2;
        private System.Windows.Forms.BindingSource tblSirketBindingSource;
        private insankaynaklariDataSet2TableAdapters.tbl_SirketTableAdapter tbl_SirketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketepostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketyoneticiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketsektorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sirketadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Ara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}