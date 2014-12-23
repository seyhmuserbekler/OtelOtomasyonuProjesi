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
            this.components = new System.ComponentModel.Container();
            this.TumOdalar = new System.Windows.Forms.Button();
            this.DoluOdalar = new System.Windows.Forms.Button();
            this.MusteriAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TumOdalar
            // 
            this.TumOdalar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.TumOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TumOdalar.Location = new System.Drawing.Point(1, 387);
            this.TumOdalar.Name = "TumOdalar";
            this.TumOdalar.Size = new System.Drawing.Size(160, 34);
            this.TumOdalar.TabIndex = 0;
            this.TumOdalar.Text = "Tüm Odalar";
            this.TumOdalar.UseVisualStyleBackColor = false;
            this.TumOdalar.Click += new System.EventHandler(this.BosOdalar_Click);
            // 
            // DoluOdalar
            // 
            this.DoluOdalar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DoluOdalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoluOdalar.Location = new System.Drawing.Point(145, 387);
            this.DoluOdalar.Name = "DoluOdalar";
            this.DoluOdalar.Size = new System.Drawing.Size(181, 34);
            this.DoluOdalar.TabIndex = 1;
            this.DoluOdalar.Text = "Müşteriler";
            this.DoluOdalar.UseVisualStyleBackColor = false;
            this.DoluOdalar.Click += new System.EventHandler(this.DoluOdalar_Click);
            // 
            // MusteriAra
            // 
            this.MusteriAra.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusteriAra.Location = new System.Drawing.Point(324, 387);
            this.MusteriAra.Name = "MusteriAra";
            this.MusteriAra.Size = new System.Drawing.Size(168, 34);
            this.MusteriAra.TabIndex = 2;
            this.MusteriAra.Text = "Müşteri Ara";
            this.MusteriAra.UseVisualStyleBackColor = false;
            this.MusteriAra.Click += new System.EventHandler(this.MusteriAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tarih : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(98, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(268, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saat : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(356, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 36);
            this.label4.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::OtelOtomasyonuProjesi.Properties.Resources.backround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MusteriAra);
            this.Controls.Add(this.DoluOdalar);
            this.Controls.Add(this.TumOdalar);
            this.Name = "Form2";
            this.Text = "Otel Bilgi Sistemi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TumOdalar;
        private System.Windows.Forms.Button DoluOdalar;
        private System.Windows.Forms.Button MusteriAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}