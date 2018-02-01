namespace proje
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.Doktorbutton = new System.Windows.Forms.Button();
            this.Hastabutton = new System.Windows.Forms.Button();
            this.Muayenebutton = new System.Windows.Forms.Button();
            this.Çıkışbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muayaneTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Doktorbutton
            // 
            this.Doktorbutton.Location = new System.Drawing.Point(65, 86);
            this.Doktorbutton.Name = "Doktorbutton";
            this.Doktorbutton.Size = new System.Drawing.Size(75, 65);
            this.Doktorbutton.TabIndex = 0;
            this.Doktorbutton.Text = "Doktor İşlemleri";
            this.Doktorbutton.UseVisualStyleBackColor = true;
            this.Doktorbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hastabutton
            // 
            this.Hastabutton.Location = new System.Drawing.Point(186, 86);
            this.Hastabutton.Name = "Hastabutton";
            this.Hastabutton.Size = new System.Drawing.Size(75, 65);
            this.Hastabutton.TabIndex = 1;
            this.Hastabutton.Text = "Hasta İşlemleri";
            this.Hastabutton.UseVisualStyleBackColor = true;
            this.Hastabutton.Click += new System.EventHandler(this.Hastabutton_Click);
            // 
            // Muayenebutton
            // 
            this.Muayenebutton.Location = new System.Drawing.Point(318, 86);
            this.Muayenebutton.Name = "Muayenebutton";
            this.Muayenebutton.Size = new System.Drawing.Size(75, 65);
            this.Muayenebutton.TabIndex = 2;
            this.Muayenebutton.Text = "Muayene";
            this.Muayenebutton.UseVisualStyleBackColor = true;
            this.Muayenebutton.Click += new System.EventHandler(this.Muayenebutton_Click);
            // 
            // Çıkışbutton
            // 
            this.Çıkışbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Çıkışbutton.Location = new System.Drawing.Point(590, 86);
            this.Çıkışbutton.Name = "Çıkışbutton";
            this.Çıkışbutton.Size = new System.Drawing.Size(75, 65);
            this.Çıkışbutton.TabIndex = 3;
            this.Çıkışbutton.Text = "Çıkış";
            this.Çıkışbutton.UseVisualStyleBackColor = true;
            this.Çıkışbutton.Click += new System.EventHandler(this.Çıkışbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(206, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bugünün Randevuları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezIDDataGridViewTextBoxColumn,
            this.rezTarihiDataGridViewTextBoxColumn,
            this.muayaneTurDataGridViewTextBoxColumn,
            this.doktorTCDataGridViewTextBoxColumn,
            this.hastaTCDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.islemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 219);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 217);
            this.dataGridView1.TabIndex = 6;
            // 
            // rezIDDataGridViewTextBoxColumn
            // 
            this.rezIDDataGridViewTextBoxColumn.DataPropertyName = "RezID";
            this.rezIDDataGridViewTextBoxColumn.HeaderText = "RezID";
            this.rezIDDataGridViewTextBoxColumn.Name = "rezIDDataGridViewTextBoxColumn";
            this.rezIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezTarihiDataGridViewTextBoxColumn
            // 
            this.rezTarihiDataGridViewTextBoxColumn.DataPropertyName = "RezTarihi";
            this.rezTarihiDataGridViewTextBoxColumn.HeaderText = "RezTarihi";
            this.rezTarihiDataGridViewTextBoxColumn.Name = "rezTarihiDataGridViewTextBoxColumn";
            this.rezTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // muayaneTurDataGridViewTextBoxColumn
            // 
            this.muayaneTurDataGridViewTextBoxColumn.DataPropertyName = "MuayaneTur";
            this.muayaneTurDataGridViewTextBoxColumn.HeaderText = "MuayaneTur";
            this.muayaneTurDataGridViewTextBoxColumn.Name = "muayaneTurDataGridViewTextBoxColumn";
            this.muayaneTurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doktorTCDataGridViewTextBoxColumn
            // 
            this.doktorTCDataGridViewTextBoxColumn.DataPropertyName = "Doktor_TC";
            this.doktorTCDataGridViewTextBoxColumn.HeaderText = "Doktor_TC";
            this.doktorTCDataGridViewTextBoxColumn.Name = "doktorTCDataGridViewTextBoxColumn";
            this.doktorTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hastaTCDataGridViewTextBoxColumn
            // 
            this.hastaTCDataGridViewTextBoxColumn.DataPropertyName = "Hasta_TC";
            this.hastaTCDataGridViewTextBoxColumn.HeaderText = "Hasta_TC";
            this.hastaTCDataGridViewTextBoxColumn.Name = "hastaTCDataGridViewTextBoxColumn";
            this.hastaTCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "Saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "Saat";
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            this.saatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // islemBindingSource
            // 
            this.islemBindingSource.DataSource = typeof(proje.İslem);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(590, 221);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yeni Sekreter Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(proje.Doctor);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Çıkışbutton);
            this.Controls.Add(this.Muayenebutton);
            this.Controls.Add(this.Hastabutton);
            this.Controls.Add(this.Doktorbutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Doktorbutton;
        private System.Windows.Forms.Button Hastabutton;
        private System.Windows.Forms.Button Muayenebutton;
        private System.Windows.Forms.Button Çıkışbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource islemBindingSource;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muayaneTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}

