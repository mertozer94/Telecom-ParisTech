namespace proje
{
    partial class Hastaİşlemleri
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
            this.AramatextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Arabutton = new System.Windows.Forms.Button();
            this.Eklebutton = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.Geributton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCkimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babaAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sosyalGüvenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medeniDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postaKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceptelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Güncellebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AramatextBox
            // 
            this.AramatextBox.Location = new System.Drawing.Point(89, 80);
            this.AramatextBox.Name = "AramatextBox";
            this.AramatextBox.Size = new System.Drawing.Size(100, 20);
            this.AramatextBox.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tumu",
            "T.C No",
            "Ad Soyad"});
            this.comboBox1.Location = new System.Drawing.Point(266, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Arabutton
            // 
            this.Arabutton.Location = new System.Drawing.Point(435, 76);
            this.Arabutton.Name = "Arabutton";
            this.Arabutton.Size = new System.Drawing.Size(75, 23);
            this.Arabutton.TabIndex = 2;
            this.Arabutton.Text = "Ara";
            this.Arabutton.UseVisualStyleBackColor = true;
            this.Arabutton.Click += new System.EventHandler(this.Arabutton_Click);
            // 
            // Eklebutton
            // 
            this.Eklebutton.Location = new System.Drawing.Point(266, 415);
            this.Eklebutton.Name = "Eklebutton";
            this.Eklebutton.Size = new System.Drawing.Size(75, 23);
            this.Eklebutton.TabIndex = 3;
            this.Eklebutton.Text = "&Ekle";
            this.Eklebutton.UseVisualStyleBackColor = true;
            this.Eklebutton.Click += new System.EventHandler(this.Eklebutton_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(370, 415);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 4;
            this.button_sil.Text = "&Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // Geributton
            // 
            this.Geributton.Location = new System.Drawing.Point(89, 415);
            this.Geributton.Name = "Geributton";
            this.Geributton.Size = new System.Drawing.Size(75, 23);
            this.Geributton.TabIndex = 5;
            this.Geributton.Text = "&Geri Dön";
            this.Geributton.UseVisualStyleBackColor = true;
            this.Geributton.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCkimlikDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.babaAdıDataGridViewTextBoxColumn,
            this.anaAdıDataGridViewTextBoxColumn,
            this.dogumYeriDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewCheckBoxColumn,
            this.sosyalGüvenceDataGridViewTextBoxColumn,
            this.sGNODataGridViewTextBoxColumn,
            this.medeniDurumDataGridViewCheckBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.ilceDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.postaKoduDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ceptelDataGridViewTextBoxColumn,
            this.evtelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(89, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(421, 215);
            this.dataGridView1.TabIndex = 7;
            // 
            // tCkimlikDataGridViewTextBoxColumn
            // 
            this.tCkimlikDataGridViewTextBoxColumn.DataPropertyName = "TC_kimlik";
            this.tCkimlikDataGridViewTextBoxColumn.HeaderText = "TC_kimlik";
            this.tCkimlikDataGridViewTextBoxColumn.Name = "tCkimlikDataGridViewTextBoxColumn";
            this.tCkimlikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // babaAdıDataGridViewTextBoxColumn
            // 
            this.babaAdıDataGridViewTextBoxColumn.DataPropertyName = "BabaAdı";
            this.babaAdıDataGridViewTextBoxColumn.HeaderText = "BabaAdı";
            this.babaAdıDataGridViewTextBoxColumn.Name = "babaAdıDataGridViewTextBoxColumn";
            this.babaAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anaAdıDataGridViewTextBoxColumn
            // 
            this.anaAdıDataGridViewTextBoxColumn.DataPropertyName = "AnaAdı";
            this.anaAdıDataGridViewTextBoxColumn.HeaderText = "AnaAdı";
            this.anaAdıDataGridViewTextBoxColumn.Name = "anaAdıDataGridViewTextBoxColumn";
            this.anaAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumYeriDataGridViewTextBoxColumn
            // 
            this.dogumYeriDataGridViewTextBoxColumn.DataPropertyName = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.HeaderText = "DogumYeri";
            this.dogumYeriDataGridViewTextBoxColumn.Name = "dogumYeriDataGridViewTextBoxColumn";
            this.dogumYeriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cinsiyetDataGridViewCheckBoxColumn
            // 
            this.cinsiyetDataGridViewCheckBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.Name = "cinsiyetDataGridViewCheckBoxColumn";
            this.cinsiyetDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sosyalGüvenceDataGridViewTextBoxColumn
            // 
            this.sosyalGüvenceDataGridViewTextBoxColumn.DataPropertyName = "SosyalGüvence";
            this.sosyalGüvenceDataGridViewTextBoxColumn.HeaderText = "SosyalGüvence";
            this.sosyalGüvenceDataGridViewTextBoxColumn.Name = "sosyalGüvenceDataGridViewTextBoxColumn";
            this.sosyalGüvenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGNODataGridViewTextBoxColumn
            // 
            this.sGNODataGridViewTextBoxColumn.DataPropertyName = "SGNO";
            this.sGNODataGridViewTextBoxColumn.HeaderText = "SGNO";
            this.sGNODataGridViewTextBoxColumn.Name = "sGNODataGridViewTextBoxColumn";
            this.sGNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medeniDurumDataGridViewCheckBoxColumn
            // 
            this.medeniDurumDataGridViewCheckBoxColumn.DataPropertyName = "MedeniDurum";
            this.medeniDurumDataGridViewCheckBoxColumn.HeaderText = "MedeniDurum";
            this.medeniDurumDataGridViewCheckBoxColumn.Name = "medeniDurumDataGridViewCheckBoxColumn";
            this.medeniDurumDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "il";
            this.ilDataGridViewTextBoxColumn.HeaderText = "il";
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            this.ilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilceDataGridViewTextBoxColumn
            // 
            this.ilceDataGridViewTextBoxColumn.DataPropertyName = "ilce";
            this.ilceDataGridViewTextBoxColumn.HeaderText = "ilce";
            this.ilceDataGridViewTextBoxColumn.Name = "ilceDataGridViewTextBoxColumn";
            this.ilceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postaKoduDataGridViewTextBoxColumn
            // 
            this.postaKoduDataGridViewTextBoxColumn.DataPropertyName = "PostaKodu";
            this.postaKoduDataGridViewTextBoxColumn.HeaderText = "PostaKodu";
            this.postaKoduDataGridViewTextBoxColumn.Name = "postaKoduDataGridViewTextBoxColumn";
            this.postaKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ceptelDataGridViewTextBoxColumn
            // 
            this.ceptelDataGridViewTextBoxColumn.DataPropertyName = "Ceptel";
            this.ceptelDataGridViewTextBoxColumn.HeaderText = "Ceptel";
            this.ceptelDataGridViewTextBoxColumn.Name = "ceptelDataGridViewTextBoxColumn";
            this.ceptelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evtelDataGridViewTextBoxColumn
            // 
            this.evtelDataGridViewTextBoxColumn.DataPropertyName = "Evtel";
            this.evtelDataGridViewTextBoxColumn.HeaderText = "Evtel";
            this.evtelDataGridViewTextBoxColumn.Name = "evtelDataGridViewTextBoxColumn";
            this.evtelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(proje.Person);
            // 
            // Güncellebutton
            // 
            this.Güncellebutton.Location = new System.Drawing.Point(470, 415);
            this.Güncellebutton.Name = "Güncellebutton";
            this.Güncellebutton.Size = new System.Drawing.Size(75, 23);
            this.Güncellebutton.TabIndex = 8;
            this.Güncellebutton.Text = "&Güncelle";
            this.Güncellebutton.UseVisualStyleBackColor = true;
            this.Güncellebutton.Click += new System.EventHandler(this.Güncellebutton_Click);
            // 
            // Hastaİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 609);
            this.Controls.Add(this.Güncellebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Geributton);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.Eklebutton);
            this.Controls.Add(this.Arabutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AramatextBox);
            this.Name = "Hastaİşlemleri";
            this.Text = "Hasta İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hastaİşlemleri_FormClosing);
            this.Load += new System.EventHandler(this.Hastaİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AramatextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Arabutton;
        private System.Windows.Forms.Button Eklebutton;
        private System.Windows.Forms.Button Geributton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCkimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn babaAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anaAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cinsiyetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosyalGüvenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn medeniDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postaKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceptelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button Güncellebutton;
    }
}