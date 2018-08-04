namespace IKO
{
    partial class ilanekle
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
            this.personelekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personelekle
            // 
            this.personelekle.BackColor = System.Drawing.Color.ForestGreen;
            this.personelekle.BackgroundImage = global::IKO.Properties.Resources.office_briefcase;
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
            this.personelekle.Location = new System.Drawing.Point(52, 100);
            this.personelekle.Name = "personelekle";
            this.personelekle.Size = new System.Drawing.Size(444, 453);
            this.personelekle.TabIndex = 12;
            this.personelekle.Text = "İş Veren Olarak";
            this.personelekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personelekle.UseVisualStyleBackColor = false;
            this.personelekle.Click += new System.EventHandler(this.personelekle_Click);
            this.personelekle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.personelekle_MouseClick);
            this.personelekle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.personelekle_MouseDown);
            this.personelekle.MouseEnter += new System.EventHandler(this.personelekle_MouseEnter);
            this.personelekle.MouseLeave += new System.EventHandler(this.personelekle_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.BackgroundImage = global::IKO.Properties.Resources.user;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(522, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(444, 453);
            this.button1.TabIndex = 13;
            this.button1.Text = "İş Arayan Olarak";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // ilanekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IKO.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personelekle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ilanekle";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personelekle;
        private System.Windows.Forms.Button button1;
    }
}