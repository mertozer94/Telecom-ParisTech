namespace proje
{
    partial class Saat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saatlabel = new System.Windows.Forms.Label();
            this.tarhlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // saatlabel
            // 
            this.saatlabel.AutoSize = true;
            this.saatlabel.Location = new System.Drawing.Point(19, 14);
            this.saatlabel.Name = "saatlabel";
            this.saatlabel.Size = new System.Drawing.Size(0, 13);
            this.saatlabel.TabIndex = 0;
            // 
            // tarhlabel
            // 
            this.tarhlabel.AutoSize = true;
            this.tarhlabel.Location = new System.Drawing.Point(110, 13);
            this.tarhlabel.Name = "tarhlabel";
            this.tarhlabel.Size = new System.Drawing.Size(0, 13);
            this.tarhlabel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Saat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tarhlabel);
            this.Controls.Add(this.saatlabel);
            this.Name = "Saat";
            this.Size = new System.Drawing.Size(236, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saatlabel;
        private System.Windows.Forms.Label tarhlabel;
        private System.Windows.Forms.Timer timer1;
    }
}
