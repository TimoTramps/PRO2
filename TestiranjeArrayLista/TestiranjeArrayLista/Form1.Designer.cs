namespace TestiranjeArrayLista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtVnesi = new TextBox();
            btnDodaj = new Button();
            btnOdstrani = new Button();
            btnPrvi = new Button();
            btnZadnji = new Button();
            btnPozicija = new Button();
            btnVsebuje = new Button();
            btnPrazna = new Button();
            btnIzpisi = new Button();
            btnStatistika = new Button();
            btnTrim = new Button();
            txtKonzola = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 48);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 0;
            label1.Text = "Vnesi nekaj:";
            // 
            // txtVnesi
            // 
            txtVnesi.Location = new Point(171, 45);
            txtVnesi.Name = "txtVnesi";
            txtVnesi.Size = new Size(172, 39);
            txtVnesi.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(386, 45);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(140, 44);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnOdstrani
            // 
            btnOdstrani.Location = new Point(25, 127);
            btnOdstrani.Name = "btnOdstrani";
            btnOdstrani.Size = new Size(140, 44);
            btnOdstrani.TabIndex = 3;
            btnOdstrani.Text = "Odstrani";
            btnOdstrani.UseVisualStyleBackColor = true;
            btnOdstrani.Click += btnOdstrani_Click;
            // 
            // btnPrvi
            // 
            btnPrvi.Location = new Point(203, 127);
            btnPrvi.Name = "btnPrvi";
            btnPrvi.Size = new Size(140, 44);
            btnPrvi.TabIndex = 4;
            btnPrvi.Text = "Prvi";
            btnPrvi.UseVisualStyleBackColor = true;
            btnPrvi.Click += btnPrvi_Click;
            // 
            // btnZadnji
            // 
            btnZadnji.Location = new Point(386, 127);
            btnZadnji.Name = "btnZadnji";
            btnZadnji.Size = new Size(140, 44);
            btnZadnji.TabIndex = 5;
            btnZadnji.Text = "Zadnji";
            btnZadnji.UseVisualStyleBackColor = true;
            btnZadnji.Click += btnZadnji_Click;
            // 
            // btnPozicija
            // 
            btnPozicija.Location = new Point(386, 197);
            btnPozicija.Name = "btnPozicija";
            btnPozicija.Size = new Size(140, 44);
            btnPozicija.TabIndex = 8;
            btnPozicija.Text = "Lokacija";
            btnPozicija.UseVisualStyleBackColor = true;
            // 
            // btnVsebuje
            // 
            btnVsebuje.Location = new Point(203, 197);
            btnVsebuje.Name = "btnVsebuje";
            btnVsebuje.Size = new Size(140, 44);
            btnVsebuje.TabIndex = 7;
            btnVsebuje.Text = "Vsebuje";
            btnVsebuje.UseVisualStyleBackColor = true;
            btnVsebuje.Click += btnVsebuje_Click;
            // 
            // btnPrazna
            // 
            btnPrazna.Location = new Point(25, 197);
            btnPrazna.Name = "btnPrazna";
            btnPrazna.Size = new Size(140, 44);
            btnPrazna.TabIndex = 6;
            btnPrazna.Text = "Je prazna?";
            btnPrazna.UseVisualStyleBackColor = true;
            btnPrazna.Click += btnPrazna_Click;
            // 
            // btnIzpisi
            // 
            btnIzpisi.Location = new Point(386, 262);
            btnIzpisi.Name = "btnIzpisi";
            btnIzpisi.Size = new Size(140, 44);
            btnIzpisi.TabIndex = 11;
            btnIzpisi.Text = "Izpiši";
            btnIzpisi.UseVisualStyleBackColor = true;
            btnIzpisi.Click += btnIzpisi_Click;
            // 
            // btnStatistika
            // 
            btnStatistika.Location = new Point(203, 262);
            btnStatistika.Name = "btnStatistika";
            btnStatistika.Size = new Size(140, 44);
            btnStatistika.TabIndex = 10;
            btnStatistika.Text = "Statistika";
            btnStatistika.UseVisualStyleBackColor = true;
            btnStatistika.Click += btnStatistika_Click;
            // 
            // btnTrim
            // 
            btnTrim.Location = new Point(25, 262);
            btnTrim.Name = "btnTrim";
            btnTrim.Size = new Size(140, 44);
            btnTrim.TabIndex = 9;
            btnTrim.Text = "Trim";
            btnTrim.UseVisualStyleBackColor = true;
            btnTrim.Click += btnTrim_Click;
            // 
            // txtKonzola
            // 
            txtKonzola.Location = new Point(25, 332);
            txtKonzola.Multiline = true;
            txtKonzola.Name = "txtKonzola";
            txtKonzola.ReadOnly = true;
            txtKonzola.Size = new Size(501, 148);
            txtKonzola.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 492);
            Controls.Add(txtKonzola);
            Controls.Add(btnIzpisi);
            Controls.Add(btnStatistika);
            Controls.Add(btnTrim);
            Controls.Add(btnPozicija);
            Controls.Add(btnVsebuje);
            Controls.Add(btnPrazna);
            Controls.Add(btnZadnji);
            Controls.Add(btnPrvi);
            Controls.Add(btnOdstrani);
            Controls.Add(btnDodaj);
            Controls.Add(txtVnesi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "TestArrayList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVnesi;
        private Button btnDodaj;
        private Button btnOdstrani;
        private Button btnPrvi;
        private Button btnZadnji;
        private Button btnPozicija;
        private Button btnVsebuje;
        private Button btnPrazna;
        private Button btnIzpisi;
        private Button btnStatistika;
        private Button btnTrim;
        private TextBox txtKonzola;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
