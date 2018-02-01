namespace proje
{
    partial class Doktorİşlemleri
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
            this.Eklebutton = new System.Windows.Forms.Button();
            this.Silbutton = new System.Windows.Forms.Button();
            this.Arabutton = new System.Windows.Forms.Button();
            this.AramatextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Geributton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCkimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceptelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GeridontoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DoktorekletoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SiltoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.güncellebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Eklebutton
            // 
            this.Eklebutton.Location = new System.Drawing.Point(262, 298);
            this.Eklebutton.Name = "Eklebutton";
            this.Eklebutton.Size = new System.Drawing.Size(75, 23);
            this.Eklebutton.TabIndex = 0;
            this.Eklebutton.Text = "Ekle";
            this.DoktorekletoolTip.SetToolTip(this.Eklebutton, "Yeni bir doktor kaydı girmek için tıklayınız.");
            this.Eklebutton.UseVisualStyleBackColor = true;
            this.Eklebutton.Click += new System.EventHandler(this.Eklebutton_Click);
            // 
            // Silbutton
            // 
            this.Silbutton.Location = new System.Drawing.Point(392, 298);
            this.Silbutton.Name = "Silbutton";
            this.Silbutton.Size = new System.Drawing.Size(75, 23);
            this.Silbutton.TabIndex = 1;
            this.Silbutton.Text = "Sil";
            this.SiltoolTip.SetToolTip(this.Silbutton, "Kayıt silmek için tıklayınız.");
            this.Silbutton.UseVisualStyleBackColor = true;
            this.Silbutton.Click += new System.EventHandler(this.Silbutton_Click);
            // 
            // Arabutton
            // 
            this.Arabutton.Location = new System.Drawing.Point(366, 47);
            this.Arabutton.Name = "Arabutton";
            this.Arabutton.Size = new System.Drawing.Size(75, 23);
            this.Arabutton.TabIndex = 2;
            this.Arabutton.Text = "&Listele";
            this.Arabutton.UseVisualStyleBackColor = true;
            this.Arabutton.Click += new System.EventHandler(this.Arabutton_Click);
            // 
            // AramatextBox
            // 
            this.AramatextBox.Location = new System.Drawing.Point(50, 47);
            this.AramatextBox.Name = "AramatextBox";
            this.AramatextBox.Size = new System.Drawing.Size(100, 20);
            this.AramatextBox.TabIndex = 3;
            this.AramatextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Tümü";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü",
            "Tc Kimlik",
            "Ad Soyad",
            "Sicil No",
            "Cep Tel",
            "Ev Tel",
            "E mail"});
            this.comboBox1.Location = new System.Drawing.Point(193, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Geributton
            // 
            this.Geributton.Location = new System.Drawing.Point(35, 298);
            this.Geributton.Name = "Geributton";
            this.Geributton.Size = new System.Drawing.Size(75, 23);
            this.Geributton.TabIndex = 5;
            this.Geributton.Text = "Geri Dön";
            this.GeridontoolTip.SetToolTip(this.Geributton, "Anasayfaya geri dönmek için tıklayınız.");
            this.Geributton.UseVisualStyleBackColor = true;
            this.Geributton.Click += new System.EventHandler(this.Geributton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCkimlikDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.sicilNoDataGridViewTextBoxColumn,
            this.ceptelDataGridViewTextBoxColumn,
            this.evtelDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewCheckBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.ilceDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 6;
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
            // sicilNoDataGridViewTextBoxColumn
            // 
            this.sicilNoDataGridViewTextBoxColumn.DataPropertyName = "SicilNo";
            this.sicilNoDataGridViewTextBoxColumn.HeaderText = "SicilNo";
            this.sicilNoDataGridViewTextBoxColumn.Name = "sicilNoDataGridViewTextBoxColumn";
            this.sicilNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cinsiyetDataGridViewCheckBoxColumn
            // 
            this.cinsiyetDataGridViewCheckBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.FalseValue = "Kadın";
            this.cinsiyetDataGridViewCheckBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewCheckBoxColumn.Name = "cinsiyetDataGridViewCheckBoxColumn";
            this.cinsiyetDataGridViewCheckBoxColumn.ReadOnly = true;
            this.cinsiyetDataGridViewCheckBoxColumn.TrueValue = "Erkek";
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(proje.Doctor);
            // 
            // güncellebutton
            // 
            this.güncellebutton.Location = new System.Drawing.Point(523, 298);
            this.güncellebutton.Name = "güncellebutton";
            this.güncellebutton.Size = new System.Drawing.Size(75, 23);
            this.güncellebutton.TabIndex = 7;
            this.güncellebutton.Text = "&Güncelle";
            this.güncellebutton.UseVisualStyleBackColor = true;
            this.güncellebutton.Click += new System.EventHandler(this.güncellebutton_Click);
            // 
            // Doktorİşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 410);
            this.Controls.Add(this.güncellebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Geributton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AramatextBox);
            this.Controls.Add(this.Arabutton);
            this.Controls.Add(this.Silbutton);
            this.Controls.Add(this.Eklebutton);
            this.Name = "Doktorİşlemleri";
            this.Text = "Doktor İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doktorİşlemleri_FormClosing);
            this.Load += new System.EventHandler(this.Doktorİşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eklebutton;
        private System.Windows.Forms.Button Silbutton;
        private System.Windows.Forms.Button Arabutton;
        private System.Windows.Forms.TextBox AramatextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Geributton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip GeridontoolTip;
        private System.Windows.Forms.ToolTip DoktorekletoolTip;
        private System.Windows.Forms.ToolTip SiltoolTip;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCkimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceptelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cinsiyetDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button güncellebutton;
    }
}