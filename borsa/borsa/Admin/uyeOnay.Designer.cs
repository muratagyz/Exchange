namespace borsa.Admin
{
    partial class uyeOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeOnay));
            this.btnOnay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.borsaDataSet = new borsa.BorsaDataSet();
            this.tblAliciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAliciTableAdapter = new borsa.BorsaDataSetTableAdapters.tblAliciTableAdapter();
            this.dgwUyeler = new System.Windows.Forms.DataGridView();
            this.rdbAlici = new System.Windows.Forms.RadioButton();
            this.rdbSatici = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblVeriSil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borsaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAliciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.ForeColor = System.Drawing.Color.White;
            this.btnOnay.Location = new System.Drawing.Point(329, 283);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(135, 42);
            this.btnOnay.TabIndex = 2;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(200, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borsaDataSet
            // 
            this.borsaDataSet.DataSetName = "BorsaDataSet";
            this.borsaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAliciBindingSource
            // 
            this.tblAliciBindingSource.DataMember = "tblAlici";
            this.tblAliciBindingSource.DataSource = this.borsaDataSet;
            // 
            // tblAliciTableAdapter
            // 
            this.tblAliciTableAdapter.ClearBeforeFill = true;
            // 
            // dgwUyeler
            // 
            this.dgwUyeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUyeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUyeler.Location = new System.Drawing.Point(12, 41);
            this.dgwUyeler.Name = "dgwUyeler";
            this.dgwUyeler.Size = new System.Drawing.Size(452, 220);
            this.dgwUyeler.TabIndex = 4;
            this.dgwUyeler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwUyeler_CellMouseDoubleClick);
            // 
            // rdbAlici
            // 
            this.rdbAlici.AutoSize = true;
            this.rdbAlici.Location = new System.Drawing.Point(15, 283);
            this.rdbAlici.Name = "rdbAlici";
            this.rdbAlici.Size = new System.Drawing.Size(44, 17);
            this.rdbAlici.TabIndex = 5;
            this.rdbAlici.TabStop = true;
            this.rdbAlici.Text = "Alıcı";
            this.rdbAlici.UseVisualStyleBackColor = true;
            // 
            // rdbSatici
            // 
            this.rdbSatici.AutoSize = true;
            this.rdbSatici.Location = new System.Drawing.Point(15, 308);
            this.rdbSatici.Name = "rdbSatici";
            this.rdbSatici.Size = new System.Drawing.Size(51, 17);
            this.rdbSatici.TabIndex = 6;
            this.rdbSatici.TabStop = true;
            this.rdbSatici.Text = "Satıcı";
            this.rdbSatici.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "🡄";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.lblId.Location = new System.Drawing.Point(395, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(69, 24);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "alionay";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.ForeColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(72, 283);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(122, 42);
            this.btnListele.TabIndex = 21;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblVeriSil
            // 
            this.lblVeriSil.AutoSize = true;
            this.lblVeriSil.Location = new System.Drawing.Point(326, 16);
            this.lblVeriSil.Name = "lblVeriSil";
            this.lblVeriSil.Size = new System.Drawing.Size(0, 13);
            this.lblVeriSil.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "ÜYE ONAYLAMA SİSTEMİ";
            // 
            // uyeOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVeriSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbSatici);
            this.Controls.Add(this.rdbAlici);
            this.Controls.Add(this.dgwUyeler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOnay);
            this.Name = "uyeOnay";
            this.Text = "Üye Onaylama Ekranı";
            this.Load += new System.EventHandler(this.uyeOnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borsaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAliciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button button1;
        private BorsaDataSet borsaDataSet;
        private System.Windows.Forms.BindingSource tblAliciBindingSource;
        private BorsaDataSetTableAdapters.tblAliciTableAdapter tblAliciTableAdapter;
        private System.Windows.Forms.DataGridView dgwUyeler;
        private System.Windows.Forms.RadioButton rdbAlici;
        private System.Windows.Forms.RadioButton rdbSatici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblVeriSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}