namespace Projekt
{
    partial class Ustawienia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RozmiarPlanszy = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gracz1Name = new System.Windows.Forms.TextBox();
            this.Gracz2Name = new System.Windows.Forms.TextBox();
            this.KolorGracz1 = new System.Windows.Forms.ColorDialog();
            this.KolorGracz2 = new System.Windows.Forms.ColorDialog();
            this.KolorButton1 = new System.Windows.Forms.Button();
            this.KolorButton2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.KolorNeutralny = new System.Windows.Forms.ColorDialog();
            this.KolorButton0 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RozmiarPlanszy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RozmiarPlanszy);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rozmiar planszy";
            // 
            // RozmiarPlanszy
            // 
            this.RozmiarPlanszy.LargeChange = 1;
            this.RozmiarPlanszy.Location = new System.Drawing.Point(7, 19);
            this.RozmiarPlanszy.Minimum = 3;
            this.RozmiarPlanszy.Name = "RozmiarPlanszy";
            this.RozmiarPlanszy.Size = new System.Drawing.Size(258, 45);
            this.RozmiarPlanszy.TabIndex = 0;
            this.RozmiarPlanszy.Value = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "3x3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "10x10";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.KolorButton1);
            this.groupBox2.Controls.Add(this.Gracz1Name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gracz1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.KolorButton2);
            this.groupBox3.Controls.Add(this.Gracz2Name);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(155, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gracz2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nazwa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nazwa";
            // 
            // Gracz1Name
            // 
            this.Gracz1Name.Location = new System.Drawing.Point(6, 32);
            this.Gracz1Name.Name = "Gracz1Name";
            this.Gracz1Name.Size = new System.Drawing.Size(124, 20);
            this.Gracz1Name.TabIndex = 1;
            this.Gracz1Name.Text = "Gracz1";
            // 
            // Gracz2Name
            // 
            this.Gracz2Name.Location = new System.Drawing.Point(6, 32);
            this.Gracz2Name.Name = "Gracz2Name";
            this.Gracz2Name.Size = new System.Drawing.Size(117, 20);
            this.Gracz2Name.TabIndex = 2;
            this.Gracz2Name.Text = "Gracz2";
            // 
            // KolorButton1
            // 
            this.KolorButton1.Location = new System.Drawing.Point(6, 59);
            this.KolorButton1.Name = "KolorButton1";
            this.KolorButton1.Size = new System.Drawing.Size(124, 23);
            this.KolorButton1.TabIndex = 2;
            this.KolorButton1.Text = "Kolor";
            this.KolorButton1.UseVisualStyleBackColor = true;
            this.KolorButton1.Click += new System.EventHandler(this.KolorButton1_Click);
            // 
            // KolorButton2
            // 
            this.KolorButton2.Location = new System.Drawing.Point(6, 58);
            this.KolorButton2.Name = "KolorButton2";
            this.KolorButton2.Size = new System.Drawing.Size(117, 23);
            this.KolorButton2.TabIndex = 3;
            this.KolorButton2.Text = "Kolor";
            this.KolorButton2.UseVisualStyleBackColor = true;
            this.KolorButton2.Click += new System.EventHandler(this.KolorButton2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.KolorButton0);
            this.groupBox4.Location = new System.Drawing.Point(13, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(136, 57);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Plansza";
            // 
            // KolorButton0
            // 
            this.KolorButton0.Location = new System.Drawing.Point(6, 19);
            this.KolorButton0.Name = "KolorButton0";
            this.KolorButton0.Size = new System.Drawing.Size(124, 23);
            this.KolorButton0.TabIndex = 0;
            this.KolorButton0.Text = "Kolor neutralny";
            this.KolorButton0.UseVisualStyleBackColor = true;
            this.KolorButton0.Click += new System.EventHandler(this.KolorButton0_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(155, 215);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 52);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 286);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ustawienia";
            this.Text = "Ustawienia";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RozmiarPlanszy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar RozmiarPlanszy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button KolorButton1;
        private System.Windows.Forms.TextBox Gracz1Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button KolorButton2;
        private System.Windows.Forms.TextBox Gracz2Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog KolorGracz1;
        private System.Windows.Forms.ColorDialog KolorGracz2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button KolorButton0;
        private System.Windows.Forms.ColorDialog KolorNeutralny;
        private System.Windows.Forms.Button SaveButton;
    }
}