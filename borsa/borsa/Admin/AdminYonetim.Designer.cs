
namespace borsa
{
    partial class AdminYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminYonetim));
            this.label1 = new System.Windows.Forms.Label();
            this.satisonayla = new System.Windows.Forms.Button();
            this.sonislemler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uyeonayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Yönetim Sistemi";
            // 
            // satisonayla
            // 
            this.satisonayla.BackColor = System.Drawing.Color.SandyBrown;
            this.satisonayla.ForeColor = System.Drawing.Color.White;
            this.satisonayla.Location = new System.Drawing.Point(259, 65);
            this.satisonayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satisonayla.Name = "satisonayla";
            this.satisonayla.Size = new System.Drawing.Size(101, 45);
            this.satisonayla.TabIndex = 2;
            this.satisonayla.Text = "Satış Onaylama";
            this.satisonayla.UseVisualStyleBackColor = false;
            // 
            // sonislemler
            // 
            this.sonislemler.BackColor = System.Drawing.Color.SandyBrown;
            this.sonislemler.ForeColor = System.Drawing.Color.White;
            this.sonislemler.Location = new System.Drawing.Point(259, 120);
            this.sonislemler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sonislemler.Name = "sonislemler";
            this.sonislemler.Size = new System.Drawing.Size(101, 45);
            this.sonislemler.TabIndex = 3;
            this.sonislemler.Text = "Son İşlemler";
            this.sonislemler.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uyeonayla
            // 
            this.uyeonayla.BackColor = System.Drawing.Color.SandyBrown;
            this.uyeonayla.ForeColor = System.Drawing.Color.White;
            this.uyeonayla.Location = new System.Drawing.Point(259, 12);
            this.uyeonayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uyeonayla.Name = "uyeonayla";
            this.uyeonayla.Size = new System.Drawing.Size(101, 45);
            this.uyeonayla.TabIndex = 1;
            this.uyeonayla.Text = "Üye Onaylama";
            this.uyeonayla.UseVisualStyleBackColor = false;
            this.uyeonayla.Click += new System.EventHandler(this.uyeonayla_Click);
            // 
            // AdminYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sonislemler);
            this.Controls.Add(this.satisonayla);
            this.Controls.Add(this.uyeonayla);
            this.Controls.Add(this.label1);
            this.Name = "AdminYonetim";
            this.Text = "AdminYönetim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button satisonayla;
        private System.Windows.Forms.Button sonislemler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uyeonayla;
    }
}