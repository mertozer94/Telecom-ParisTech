namespace proje
{
    partial class SEKRETERGİRİS
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
            this.label2 = new System.Windows.Forms.Label();
            this.adtextBox = new System.Windows.Forms.TextBox();
            this.GİRİSbutton = new System.Windows.Forms.Button();
            this.TcKİmerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfrtextBox = new System.Windows.Forms.TextBox();
            this.saat1 = new proje.Saat();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TcKİmerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE :";
            // 
            // adtextBox
            // 
            this.adtextBox.Location = new System.Drawing.Point(237, 84);
            this.adtextBox.MaxLength = 25;
            this.adtextBox.Name = "adtextBox";
            this.adtextBox.Size = new System.Drawing.Size(116, 20);
            this.adtextBox.TabIndex = 2;
            // 
            // GİRİSbutton
            // 
            this.GİRİSbutton.Location = new System.Drawing.Point(254, 155);
            this.GİRİSbutton.Name = "GİRİSbutton";
            this.GİRİSbutton.Size = new System.Drawing.Size(75, 23);
            this.GİRİSbutton.TabIndex = 4;
            this.GİRİSbutton.Text = "&GİRİŞ";
            this.GİRİSbutton.UseVisualStyleBackColor = true;
            this.GİRİSbutton.Click += new System.EventHandler(this.GİRİSbutton_Click);
            // 
            // TcKİmerrorProvider
            // 
            this.TcKİmerrorProvider.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // sfrtextBox
            // 
            this.sfrtextBox.Location = new System.Drawing.Point(238, 112);
            this.sfrtextBox.MaxLength = 11;
            this.sfrtextBox.Name = "sfrtextBox";
            this.sfrtextBox.Size = new System.Drawing.Size(115, 20);
            this.sfrtextBox.TabIndex = 3;
            // 
            // saat1
            // 
            this.saat1.Location = new System.Drawing.Point(145, 32);
            this.saat1.Name = "saat1";
            this.saat1.Size = new System.Drawing.Size(236, 46);
            this.saat1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(368, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SEKRETERGİRİS
            // 
            this.AcceptButton = this.GİRİSbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 337);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sfrtextBox);
            this.Controls.Add(this.saat1);
            this.Controls.Add(this.GİRİSbutton);
            this.Controls.Add(this.adtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SEKRETERGİRİS";
            this.Text = "SEKRETERGİRİS";
            this.Load += new System.EventHandler(this.SEKRETERGİRİS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TcKİmerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adtextBox;
        private System.Windows.Forms.Button GİRİSbutton;
        private Saat saat1;
        private System.Windows.Forms.ErrorProvider TcKİmerrorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox sfrtextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}