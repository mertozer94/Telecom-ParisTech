namespace proje
{
    partial class DİSHEKİMİTAKİP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DİSHEKİMİTAKİP));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sEKRETERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hASTAİŞLEMERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEKRETERToolStripMenuItem,
            this.hASTAİŞLEMERİToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sEKRETERToolStripMenuItem
            // 
            this.sEKRETERToolStripMenuItem.Name = "sEKRETERToolStripMenuItem";
            this.sEKRETERToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.sEKRETERToolStripMenuItem.Text = "&SEKRETER İŞLEMLERİ";
            this.sEKRETERToolStripMenuItem.Click += new System.EventHandler(this.sEKRETERToolStripMenuItem_Click);
            // 
            // hASTAİŞLEMERİToolStripMenuItem
            // 
            this.hASTAİŞLEMERİToolStripMenuItem.Name = "hASTAİŞLEMERİToolStripMenuItem";
            this.hASTAİŞLEMERİToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.hASTAİŞLEMERİToolStripMenuItem.Text = "&HASTA İŞLEMERİ";
            this.hASTAİŞLEMERİToolStripMenuItem.Click += new System.EventHandler(this.hASTAİŞLEMERİToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.çIKIŞToolStripMenuItem.Text = "&ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // DİSHEKİMİTAKİP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DİSHEKİMİTAKİP";
            this.Text = "DİS HEKİMİ TAKİP SİSTEMİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DİSHEKİMİTAKİP_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sEKRETERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hASTAİŞLEMERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}