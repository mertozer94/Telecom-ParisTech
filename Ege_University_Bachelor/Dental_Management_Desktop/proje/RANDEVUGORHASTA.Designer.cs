namespace proje
{
    partial class RANDEVUGORHASTA
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
            this.label1 = new System.Windows.Forms.Label();
            this.TCtextBox = new System.Windows.Forms.TextBox();
            this.Gosterbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saat1 = new proje.Saat();
            this.TcKİmerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.KaydeterrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcKİmerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaydeterrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK NO GİRİNİZ :";
            // 
            // TCtextBox
            // 
            this.TCtextBox.Location = new System.Drawing.Point(145, 56);
            this.TCtextBox.MaxLength = 11;
            this.TCtextBox.Name = "TCtextBox";
            this.TCtextBox.Size = new System.Drawing.Size(100, 20);
            this.TCtextBox.TabIndex = 1;
            this.TCtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCtextBox_KeyPress_1);
            // 
            // Gosterbutton
            // 
            this.Gosterbutton.Location = new System.Drawing.Point(277, 53);
            this.Gosterbutton.Name = "Gosterbutton";
            this.Gosterbutton.Size = new System.Drawing.Size(75, 23);
            this.Gosterbutton.TabIndex = 2;
            this.Gosterbutton.Text = "&GÖSTER";
            this.Gosterbutton.UseVisualStyleBackColor = true;
            this.Gosterbutton.Click += new System.EventHandler(this.Gosterbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(574, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // saat1
            // 
            this.saat1.Location = new System.Drawing.Point(179, 89);
            this.saat1.Name = "saat1";
            this.saat1.Size = new System.Drawing.Size(236, 46);
            this.saat1.TabIndex = 4;
            // 
            // TcKİmerrorProvider
            // 
            this.TcKİmerrorProvider.ContainerControl = this;
            // 
            // KaydeterrorProvider
            // 
            this.KaydeterrorProvider.ContainerControl = this;
            // 
            // RANDEVUGORHASTA
            // 
            this.AcceptButton = this.Gosterbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 337);
            this.Controls.Add(this.saat1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Gosterbutton);
            this.Controls.Add(this.TCtextBox);
            this.Controls.Add(this.label1);
            this.Name = "RANDEVUGORHASTA";
            this.Text = "RANDEVUGORHASTA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TcKİmerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaydeterrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCtextBox;
        private System.Windows.Forms.Button Gosterbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Saat saat1;
        private System.Windows.Forms.ErrorProvider TcKİmerrorProvider;
        private System.Windows.Forms.ErrorProvider KaydeterrorProvider;
    }
}