namespace AplikacjaWBD
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPolaczenie = new System.Windows.Forms.GroupBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.textBoxUzytkownik = new System.Windows.Forms.TextBox();
            this.buttonPolacz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTablicaDanych = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZapytanieSQL = new System.Windows.Forms.TextBox();
            this.groupBoxSortowanieProste = new System.Windows.Forms.GroupBox();
            this.buttonZapytanie = new System.Windows.Forms.Button();
            this.buttonPokazWszystko = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.textBoxSortowanieWarunkowe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.comboBoxNazwyKolumn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxPolaczenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablicaDanych)).BeginInit();
            this.groupBoxSortowanieProste.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPolaczenie
            // 
            this.groupBoxPolaczenie.Controls.Add(this.textBoxHaslo);
            this.groupBoxPolaczenie.Controls.Add(this.textBoxUzytkownik);
            this.groupBoxPolaczenie.Controls.Add(this.buttonPolacz);
            this.groupBoxPolaczenie.Controls.Add(this.label2);
            this.groupBoxPolaczenie.Controls.Add(this.label1);
            this.groupBoxPolaczenie.Location = new System.Drawing.Point(34, 40);
            this.groupBoxPolaczenie.Name = "groupBoxPolaczenie";
            this.groupBoxPolaczenie.Size = new System.Drawing.Size(712, 74);
            this.groupBoxPolaczenie.TabIndex = 0;
            this.groupBoxPolaczenie.TabStop = false;
            this.groupBoxPolaczenie.Text = "Połączenie z bazą danych";
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Location = new System.Drawing.Point(397, 30);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHaslo.TabIndex = 4;
            this.textBoxHaslo.TextChanged += new System.EventHandler(this.textBoxHaslo_TextChanged);
            // 
            // textBoxUzytkownik
            // 
            this.textBoxUzytkownik.Location = new System.Drawing.Point(142, 33);
            this.textBoxUzytkownik.Name = "textBoxUzytkownik";
            this.textBoxUzytkownik.Size = new System.Drawing.Size(100, 20);
            this.textBoxUzytkownik.TabIndex = 3;
            this.textBoxUzytkownik.TextChanged += new System.EventHandler(this.textBoxUzytkownik_TextChanged);
            // 
            // buttonPolacz
            // 
            this.buttonPolacz.Location = new System.Drawing.Point(604, 31);
            this.buttonPolacz.Name = "buttonPolacz";
            this.buttonPolacz.Size = new System.Drawing.Size(75, 23);
            this.buttonPolacz.TabIndex = 2;
            this.buttonPolacz.Text = "Połącz";
            this.buttonPolacz.UseVisualStyleBackColor = true;
            this.buttonPolacz.Click += new System.EventHandler(this.buttonPolacz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewTablicaDanych
            // 
            this.dataGridViewTablicaDanych.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablicaDanych.Location = new System.Drawing.Point(34, 204);
            this.dataGridViewTablicaDanych.Name = "dataGridViewTablicaDanych";
            this.dataGridViewTablicaDanych.Size = new System.Drawing.Size(712, 213);
            this.dataGridViewTablicaDanych.TabIndex = 1;
            this.dataGridViewTablicaDanych.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablicaDanych_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tabela:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxZapytanieSQL
            // 
            this.textBoxZapytanieSQL.Location = new System.Drawing.Point(130, 121);
            this.textBoxZapytanieSQL.Name = "textBoxZapytanieSQL";
            this.textBoxZapytanieSQL.Size = new System.Drawing.Size(415, 20);
            this.textBoxZapytanieSQL.TabIndex = 3;
            this.textBoxZapytanieSQL.TextChanged += new System.EventHandler(this.textBoxZapytanieSQL_TextChanged);
            // 
            // groupBoxSortowanieProste
            // 
            this.groupBoxSortowanieProste.Controls.Add(this.buttonZapytanie);
            this.groupBoxSortowanieProste.Controls.Add(this.textBoxSortowanieWarunkowe);
            this.groupBoxSortowanieProste.Controls.Add(this.label6);
            this.groupBoxSortowanieProste.Controls.Add(this.buttonSzukaj);
            this.groupBoxSortowanieProste.Controls.Add(this.textBoxSzukaj);
            this.groupBoxSortowanieProste.Controls.Add(this.comboBoxNazwyKolumn);
            this.groupBoxSortowanieProste.Controls.Add(this.label5);
            this.groupBoxSortowanieProste.Controls.Add(this.label4);
            this.groupBoxSortowanieProste.Location = new System.Drawing.Point(34, 465);
            this.groupBoxSortowanieProste.Name = "groupBoxSortowanieProste";
            this.groupBoxSortowanieProste.Size = new System.Drawing.Size(712, 113);
            this.groupBoxSortowanieProste.TabIndex = 4;
            this.groupBoxSortowanieProste.TabStop = false;
            this.groupBoxSortowanieProste.Text = "Sortowanie Proste";
            // 
            // buttonZapytanie
            // 
            this.buttonZapytanie.Location = new System.Drawing.Point(289, 76);
            this.buttonZapytanie.Name = "buttonZapytanie";
            this.buttonZapytanie.Size = new System.Drawing.Size(133, 23);
            this.buttonZapytanie.TabIndex = 9;
            this.buttonZapytanie.Text = "Wyświetl wyniki";
            this.buttonZapytanie.UseVisualStyleBackColor = true;
            this.buttonZapytanie.Click += new System.EventHandler(this.buttonZapytanie_Click);
            // 
            // buttonPokazWszystko
            // 
            this.buttonPokazWszystko.Location = new System.Drawing.Point(395, 436);
            this.buttonPokazWszystko.Name = "buttonPokazWszystko";
            this.buttonPokazWszystko.Size = new System.Drawing.Size(150, 23);
            this.buttonPokazWszystko.TabIndex = 8;
            this.buttonPokazWszystko.Text = "Pokaż wszystko";
            this.buttonPokazWszystko.UseVisualStyleBackColor = true;
            this.buttonPokazWszystko.Click += new System.EventHandler(this.buttonPokazWszystko_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(163, 436);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(135, 23);
            this.buttonZapisz.TabIndex = 7;
            this.buttonZapisz.Text = "Zapisz zmiany";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // textBoxSortowanieWarunkowe
            // 
            this.textBoxSortowanieWarunkowe.Location = new System.Drawing.Point(78, 79);
            this.textBoxSortowanieWarunkowe.Name = "textBoxSortowanieWarunkowe";
            this.textBoxSortowanieWarunkowe.Size = new System.Drawing.Size(164, 20);
            this.textBoxSortowanieWarunkowe.TabIndex = 6;
            this.textBoxSortowanieWarunkowe.TextChanged += new System.EventHandler(this.textBoxSortowanieWarunkowe_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Warunek:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(467, 29);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonSzukaj.TabIndex = 4;
            this.buttonSzukaj.Text = "Pokaż dane";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Location = new System.Drawing.Point(322, 27);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzukaj.TabIndex = 3;
            // 
            // comboBoxNazwyKolumn
            // 
            this.comboBoxNazwyKolumn.FormattingEnabled = true;
            this.comboBoxNazwyKolumn.Location = new System.Drawing.Point(78, 26);
            this.comboBoxNazwyKolumn.Name = "comboBoxNazwyKolumn";
            this.comboBoxNazwyKolumn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNazwyKolumn.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Szukana fraza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Atrybuty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Atrybuty:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 601);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonPokazWszystko);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.groupBoxSortowanieProste);
            this.Controls.Add(this.textBoxZapytanieSQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewTablicaDanych);
            this.Controls.Add(this.groupBoxPolaczenie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxPolaczenie.ResumeLayout(false);
            this.groupBoxPolaczenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablicaDanych)).EndInit();
            this.groupBoxSortowanieProste.ResumeLayout(false);
            this.groupBoxSortowanieProste.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPolaczenie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPolacz;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.TextBox textBoxUzytkownik;
        private System.Windows.Forms.DataGridView dataGridViewTablicaDanych;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxZapytanieSQL;
        private System.Windows.Forms.GroupBox groupBoxSortowanieProste;
        private System.Windows.Forms.Button buttonZapytanie;
        private System.Windows.Forms.Button buttonPokazWszystko;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.TextBox textBoxSortowanieWarunkowe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private System.Windows.Forms.ComboBox comboBoxNazwyKolumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

