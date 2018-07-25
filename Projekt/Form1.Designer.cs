namespace Projekt
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Plansza = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gracz2Score = new System.Windows.Forms.Label();
            this.Gracz1Score = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.CurrGracz = new System.Windows.Forms.GroupBox();
            this.GraczNazwa = new System.Windows.Forms.Label();
            this.CurrGraczKostka = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.CurrGracz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrGraczKostka)).BeginInit();
            this.SuspendLayout();
            // 
            // Plansza
            // 
            resources.ApplyResources(this.Plansza, "Plansza");
            this.Plansza.Name = "Plansza";
            this.Plansza.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.Gracz2Score);
            this.groupBox1.Controls.Add(this.Gracz1Score);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Debug_Click);
            // 
            // Gracz2Score
            // 
            resources.ApplyResources(this.Gracz2Score, "Gracz2Score");
            this.Gracz2Score.Name = "Gracz2Score";
            // 
            // Gracz1Score
            // 
            resources.ApplyResources(this.Gracz1Score, "Gracz1Score");
            this.Gracz1Score.Name = "Gracz1Score";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CurrGracz
            // 
            resources.ApplyResources(this.CurrGracz, "CurrGracz");
            this.CurrGracz.Controls.Add(this.GraczNazwa);
            this.CurrGracz.Controls.Add(this.CurrGraczKostka);
            this.CurrGracz.Name = "CurrGracz";
            this.CurrGracz.TabStop = false;
            // 
            // GraczNazwa
            // 
            resources.ApplyResources(this.GraczNazwa, "GraczNazwa");
            this.GraczNazwa.Name = "GraczNazwa";
            // 
            // CurrGraczKostka
            // 
            resources.ApplyResources(this.CurrGraczKostka, "CurrGraczKostka");
            this.CurrGraczKostka.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CurrGraczKostka.Name = "CurrGraczKostka";
            this.CurrGraczKostka.TabStop = false;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrGracz);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Plansza);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CurrGracz.ResumeLayout(false);
            this.CurrGracz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrGraczKostka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Gracz2Score;
        private System.Windows.Forms.Label Gracz1Score;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.GroupBox Plansza;
        private System.Windows.Forms.GroupBox CurrGracz;
        private System.Windows.Forms.Label GraczNazwa;
        private System.Windows.Forms.PictureBox CurrGraczKostka;
    }
}

