﻿namespace IKO
{
    partial class sirket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sirket));
            this.panel2 = new System.Windows.Forms.Panel();
            this.sirketara = new System.Windows.Forms.Button();
            this.geributton = new System.Windows.Forms.Button();
            this.personelduzenle = new System.Windows.Forms.Button();
            this.personelsil = new System.Windows.Forms.Button();
            this.personelekle = new System.Windows.Forms.Button();
            this.insankaynaklariDataSet1 = new IKO.insankaynaklariDataSet();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::IKO.Properties.Resources.back;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.sirketara);
            this.panel2.Controls.Add(this.geributton);
            this.panel2.Controls.Add(this.personelduzenle);
            this.panel2.Controls.Add(this.personelsil);
            this.panel2.Controls.Add(this.personelekle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 656);
            this.panel2.TabIndex = 23;
            // 
            // sirketara
            // 
            this.sirketara.AccessibleName = "sirketara";
            this.sirketara.BackColor = System.Drawing.Color.Olive;
            this.sirketara.BackgroundImage = global::IKO.Properties.Resources.se128;
            this.sirketara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sirketara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sirketara.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sirketara.FlatAppearance.BorderSize = 0;
            this.sirketara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sirketara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sirketara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sirketara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sirketara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sirketara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sirketara.Location = new System.Drawing.Point(515, 330);
            this.sirketara.Name = "sirketara";
            this.sirketara.Size = new System.Drawing.Size(492, 201);
            this.sirketara.TabIndex = 19;
            this.sirketara.Text = "Şirket Bak";
            this.sirketara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sirketara.UseVisualStyleBackColor = false;
            this.sirketara.Click += new System.EventHandler(this.Sirketara_Click);
            this.sirketara.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sirketara_MouseClick);
            this.sirketara.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sirketara_MouseDown);
            this.sirketara.MouseEnter += new System.EventHandler(this.Sirketara_MouseEnter);
            this.sirketara.MouseLeave += new System.EventHandler(this.Sirketara_MouseLeave);
            // 
            // geributton
            // 
            this.geributton.BackColor = System.Drawing.Color.Maroon;
            this.geributton.BackgroundImage = global::IKO.Properties.Resources.back_button;
            this.geributton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.geributton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geributton.Dock = System.Windows.Forms.DockStyle.Right;
            this.geributton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.geributton.FlatAppearance.BorderSize = 0;
            this.geributton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.geributton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.geributton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geributton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geributton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geributton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.geributton.Location = new System.Drawing.Point(1017, 0);
            this.geributton.Name = "geributton";
            this.geributton.Size = new System.Drawing.Size(102, 656);
            this.geributton.TabIndex = 5;
            this.geributton.Text = "Geri";
            this.geributton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.geributton.UseVisualStyleBackColor = false;
            this.geributton.Click += new System.EventHandler(this.Geributton_Click);
            this.geributton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Geributton_MouseClick);
            this.geributton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Geributton_MouseDown);
            this.geributton.MouseEnter += new System.EventHandler(this.Geributton_MouseEnter);
            this.geributton.MouseLeave += new System.EventHandler(this.Geributton_MouseLeave);
            // 
            // personelduzenle
            // 
            this.personelduzenle.BackColor = System.Drawing.Color.Teal;
            this.personelduzenle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personelduzenle.BackgroundImage")));
            this.personelduzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.personelduzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personelduzenle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.personelduzenle.FlatAppearance.BorderSize = 0;
            this.personelduzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personelduzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.personelduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelduzenle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personelduzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.personelduzenle.Location = new System.Drawing.Point(515, 123);
            this.personelduzenle.Name = "personelduzenle";
            this.personelduzenle.Size = new System.Drawing.Size(492, 201);
            this.personelduzenle.TabIndex = 14;
            this.personelduzenle.Text = "Şirket Düzenle";
            this.personelduzenle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelduzenle.UseVisualStyleBackColor = false;
            this.personelduzenle.Click += new System.EventHandler(this.Personelduzenle_Click);
            this.personelduzenle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Personelduzenle_MouseClick);
            this.personelduzenle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Personelduzenle_MouseDown);
            this.personelduzenle.MouseEnter += new System.EventHandler(this.Personelduzenle_MouseEnter);
            this.personelduzenle.MouseLeave += new System.EventHandler(this.Personelduzenle_MouseLeave);
            // 
            // personelsil
            // 
            this.personelsil.BackColor = System.Drawing.Color.Maroon;
            this.personelsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personelsil.BackgroundImage")));
            this.personelsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.personelsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personelsil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.personelsil.FlatAppearance.BorderSize = 0;
            this.personelsil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personelsil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.personelsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personelsil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.personelsil.Location = new System.Drawing.Point(17, 330);
            this.personelsil.Name = "personelsil";
            this.personelsil.Size = new System.Drawing.Size(492, 201);
            this.personelsil.TabIndex = 13;
            this.personelsil.Text = "Şirket Kaldır";
            this.personelsil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelsil.UseVisualStyleBackColor = false;
            this.personelsil.Click += new System.EventHandler(this.Personelsil_Click);
            this.personelsil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Personelsil_MouseClick);
            this.personelsil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Personelsil_MouseDown);
            this.personelsil.MouseEnter += new System.EventHandler(this.Personelsil_MouseEnter);
            this.personelsil.MouseLeave += new System.EventHandler(this.Personelsil_MouseLeave);
            // 
            // personelekle
            // 
            this.personelekle.BackColor = System.Drawing.Color.ForestGreen;
            this.personelekle.BackgroundImage = global::IKO.Properties.Resources.gerceksirketekle;
            this.personelekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.personelekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personelekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.personelekle.FlatAppearance.BorderSize = 0;
            this.personelekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personelekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.personelekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personelekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personelekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.personelekle.Location = new System.Drawing.Point(17, 123);
            this.personelekle.Name = "personelekle";
            this.personelekle.Size = new System.Drawing.Size(492, 201);
            this.personelekle.TabIndex = 11;
            this.personelekle.Text = "Şirket Ekle";
            this.personelekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelekle.UseVisualStyleBackColor = false;
            this.personelekle.Click += new System.EventHandler(this.Personelekle_Click);
            this.personelekle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Personelekle_MouseClick);
            this.personelekle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Personelekle_MouseDown);
            this.personelekle.MouseEnter += new System.EventHandler(this.Personelekle_MouseEnter);
            this.personelekle.MouseLeave += new System.EventHandler(this.Personelekle_MouseLeave);
            // 
            // insankaynaklariDataSet1
            // 
            this.insankaynaklariDataSet1.DataSetName = "insankaynaklariDataSet";
            this.insankaynaklariDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sirket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::IKO.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 656);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sirket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sirket";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.insankaynaklariDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
       
        private System.Windows.Forms.Button personelduzenle;
        private System.Windows.Forms.Button personelsil;
        private System.Windows.Forms.Button personelekle;
        private System.Windows.Forms.Button geributton;
        private System.Windows.Forms.Button sirketara;
        private insankaynaklariDataSet insankaynaklariDataSet1;
    }
}