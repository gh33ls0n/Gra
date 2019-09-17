namespace GraGUI
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupboxLosowanie = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxOd = new System.Windows.Forms.TextBox();
            this.textboxDo = new System.Windows.Forms.TextBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.buttonPoddaj = new System.Windows.Forms.Button();
            this.groupBoxOdgadywanie = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonWyslij = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupboxLosowanie.SuspendLayout();
            this.groupBoxOdgadywanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupboxLosowanie
            // 
            this.groupboxLosowanie.Controls.Add(this.buttonLosuj);
            this.groupboxLosowanie.Controls.Add(this.textboxDo);
            this.groupboxLosowanie.Controls.Add(this.textboxOd);
            this.groupboxLosowanie.Controls.Add(this.label2);
            this.groupboxLosowanie.Controls.Add(this.label1);
            this.groupboxLosowanie.Location = new System.Drawing.Point(13, 43);
            this.groupboxLosowanie.Name = "groupboxLosowanie";
            this.groupboxLosowanie.Size = new System.Drawing.Size(315, 136);
            this.groupboxLosowanie.TabIndex = 1;
            this.groupboxLosowanie.TabStop = false;
            this.groupboxLosowanie.Text = "Losowanie";
            this.groupboxLosowanie.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Do:";
            // 
            // textboxOd
            // 
            this.textboxOd.Location = new System.Drawing.Point(38, 20);
            this.textboxOd.Name = "textboxOd";
            this.textboxOd.Size = new System.Drawing.Size(100, 20);
            this.textboxOd.TabIndex = 2;
            // 
            // textboxDo
            // 
            this.textboxDo.Location = new System.Drawing.Point(37, 60);
            this.textboxDo.Name = "textboxDo";
            this.textboxDo.Size = new System.Drawing.Size(100, 20);
            this.textboxDo.TabIndex = 3;
            this.textboxDo.TextChanged += new System.EventHandler(this.textboxDo_TextChanged);
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(178, 38);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 4;
            this.buttonLosuj.Text = "Losuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // buttonPoddaj
            // 
            this.buttonPoddaj.Location = new System.Drawing.Point(321, 13);
            this.buttonPoddaj.Name = "buttonPoddaj";
            this.buttonPoddaj.Size = new System.Drawing.Size(75, 23);
            this.buttonPoddaj.TabIndex = 2;
            this.buttonPoddaj.Text = "Poddaję się";
            this.buttonPoddaj.UseVisualStyleBackColor = true;
            this.buttonPoddaj.Visible = false;
            this.buttonPoddaj.Click += new System.EventHandler(this.buttonPoddaj_Click);
            // 
            // groupBoxOdgadywanie
            // 
            this.groupBoxOdgadywanie.Controls.Add(this.label4);
            this.groupBoxOdgadywanie.Controls.Add(this.buttonWyslij);
            this.groupBoxOdgadywanie.Controls.Add(this.textBox1);
            this.groupBoxOdgadywanie.Controls.Add(this.label3);
            this.groupBoxOdgadywanie.Location = new System.Drawing.Point(13, 186);
            this.groupBoxOdgadywanie.Name = "groupBoxOdgadywanie";
            this.groupBoxOdgadywanie.Size = new System.Drawing.Size(315, 173);
            this.groupBoxOdgadywanie.TabIndex = 3;
            this.groupBoxOdgadywanie.TabStop = false;
            this.groupBoxOdgadywanie.Text = "Odgadnij";
            this.groupBoxOdgadywanie.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wylosowałem liczbę. Odgadnij ją!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonWyslij
            // 
            this.buttonWyslij.Location = new System.Drawing.Point(178, 50);
            this.buttonWyslij.Name = "buttonWyslij";
            this.buttonWyslij.Size = new System.Drawing.Size(75, 23);
            this.buttonWyslij.TabIndex = 2;
            this.buttonWyslij.Text = "Wyślij";
            this.buttonWyslij.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 492);
            this.Controls.Add(this.groupBoxOdgadywanie);
            this.Controls.Add(this.buttonPoddaj);
            this.Controls.Add(this.groupboxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupboxLosowanie.ResumeLayout(false);
            this.groupboxLosowanie.PerformLayout();
            this.groupBoxOdgadywanie.ResumeLayout(false);
            this.groupBoxOdgadywanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupboxLosowanie;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textboxDo;
        private System.Windows.Forms.TextBox textboxOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPoddaj;
        private System.Windows.Forms.GroupBox groupBoxOdgadywanie;
        private System.Windows.Forms.Button buttonWyslij;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

