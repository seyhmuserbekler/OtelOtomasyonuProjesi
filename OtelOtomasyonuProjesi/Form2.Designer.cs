namespace OtelOtomasyonuProjesi
{
    partial class Form2
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
            this.TumOdalar = new System.Windows.Forms.Button();
            this.DoluOdalar = new System.Windows.Forms.Button();
            this.MusteriAra = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müsterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TumOdalar
            // 
            this.TumOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TumOdalar.Location = new System.Drawing.Point(1, 387);
            this.TumOdalar.Name = "TumOdalar";
            this.TumOdalar.Size = new System.Drawing.Size(150, 34);
            this.TumOdalar.TabIndex = 0;
            this.TumOdalar.Text = "Tüm Odalar";
            this.TumOdalar.UseVisualStyleBackColor = true;
            this.TumOdalar.Click += new System.EventHandler(this.BosOdalar_Click);
            // 
            // DoluOdalar
            // 
            this.DoluOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoluOdalar.Location = new System.Drawing.Point(167, 387);
            this.DoluOdalar.Name = "DoluOdalar";
            this.DoluOdalar.Size = new System.Drawing.Size(162, 34);
            this.DoluOdalar.TabIndex = 1;
            this.DoluOdalar.Text = "Müşteriler";
            this.DoluOdalar.UseVisualStyleBackColor = true;
            // 
            // MusteriAra
            // 
            this.MusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAra.Location = new System.Drawing.Point(351, 387);
            this.MusteriAra.Name = "MusteriAra";
            this.MusteriAra.Size = new System.Drawing.Size(141, 34);
            this.MusteriAra.TabIndex = 2;
            this.MusteriAra.Text = "Müşteri Ara";
            this.MusteriAra.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müsterilerToolStripMenuItem,
            this.odalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müsterilerToolStripMenuItem
            // 
            this.müsterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müsteriEkleToolStripMenuItem,
            this.müsteriGüncelleToolStripMenuItem,
            this.müsteriSilToolStripMenuItem});
            this.müsterilerToolStripMenuItem.Name = "müsterilerToolStripMenuItem";
            this.müsterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müsterilerToolStripMenuItem.Text = "Müsteriler";
            this.müsterilerToolStripMenuItem.Click += new System.EventHandler(this.müsterilerToolStripMenuItem_Click);
            // 
            // müsteriEkleToolStripMenuItem
            // 
            this.müsteriEkleToolStripMenuItem.Name = "müsteriEkleToolStripMenuItem";
            this.müsteriEkleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.müsteriEkleToolStripMenuItem.Text = "Müsteri Ekle";
            // 
            // müsteriGüncelleToolStripMenuItem
            // 
            this.müsteriGüncelleToolStripMenuItem.Name = "müsteriGüncelleToolStripMenuItem";
            this.müsteriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.müsteriGüncelleToolStripMenuItem.Text = "Müsteri Güncelle";
            // 
            // müsteriSilToolStripMenuItem
            // 
            this.müsteriSilToolStripMenuItem.Name = "müsteriSilToolStripMenuItem";
            this.müsteriSilToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.müsteriSilToolStripMenuItem.Text = "Müsteri Sil";
            // 
            // odalarToolStripMenuItem
            // 
            this.odalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaEkleToolStripMenuItem,
            this.odaGüncelleToolStripMenuItem,
            this.odaSilToolStripMenuItem});
            this.odalarToolStripMenuItem.Name = "odalarToolStripMenuItem";
            this.odalarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.odalarToolStripMenuItem.Text = "Odalar";
            this.odalarToolStripMenuItem.Click += new System.EventHandler(this.odalarToolStripMenuItem_Click);
            // 
            // odaEkleToolStripMenuItem
            // 
            this.odaEkleToolStripMenuItem.Name = "odaEkleToolStripMenuItem";
            this.odaEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odaEkleToolStripMenuItem.Text = "Oda Ekle";
            this.odaEkleToolStripMenuItem.Click += new System.EventHandler(this.odaEkleToolStripMenuItem_Click);
            // 
            // odaGüncelleToolStripMenuItem
            // 
            this.odaGüncelleToolStripMenuItem.Name = "odaGüncelleToolStripMenuItem";
            this.odaGüncelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odaGüncelleToolStripMenuItem.Text = "Oda Güncelle";
            // 
            // odaSilToolStripMenuItem
            // 
            this.odaSilToolStripMenuItem.Name = "odaSilToolStripMenuItem";
            this.odaSilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.odaSilToolStripMenuItem.Text = "Oda Sil";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::OtelOtomasyonuProjesi.Properties.Resources.backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 422);
            this.Controls.Add(this.MusteriAra);
            this.Controls.Add(this.DoluOdalar);
            this.Controls.Add(this.TumOdalar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Otel Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TumOdalar;
        private System.Windows.Forms.Button DoluOdalar;
        private System.Windows.Forms.Button MusteriAra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müsterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaSilToolStripMenuItem;
    }
}