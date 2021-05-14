
namespace borsa
{
    partial class SaticiYonteim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaticiYonteim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.satisonayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sonislemler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // satisonayla
            // 
            this.satisonayla.BackColor = System.Drawing.Color.MediumAquamarine;
            this.satisonayla.ForeColor = System.Drawing.Color.White;
            this.satisonayla.Location = new System.Drawing.Point(258, 13);
            this.satisonayla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.satisonayla.Name = "satisonayla";
            this.satisonayla.Size = new System.Drawing.Size(101, 45);
            this.satisonayla.TabIndex = 29;
            this.satisonayla.Text = "Satış Yap";
            this.satisonayla.UseVisualStyleBackColor = false;
            this.satisonayla.Click += new System.EventHandler(this.satisonayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Satıcı Yönetim Sistemi";
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
            this.button1.TabIndex = 32;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // sonislemler
            // 
            this.sonislemler.BackColor = System.Drawing.Color.MediumAquamarine;
            this.sonislemler.ForeColor = System.Drawing.Color.White;
            this.sonislemler.Location = new System.Drawing.Point(258, 66);
            this.sonislemler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sonislemler.Name = "sonislemler";
            this.sonislemler.Size = new System.Drawing.Size(101, 45);
            this.sonislemler.TabIndex = 30;
            this.sonislemler.Text = "Son İşlemler";
            this.sonislemler.UseVisualStyleBackColor = false;
            this.sonislemler.Click += new System.EventHandler(this.sonislemler_Click);
            // 
            // SaticiYonteim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sonislemler);
            this.Controls.Add(this.satisonayla);
            this.Controls.Add(this.label1);
            this.Name = "SaticiYonteim";
            this.Text = "SaticiYonteim";
            this.Load += new System.EventHandler(this.SaticiYonteim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button satisonayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sonislemler;
    }
}