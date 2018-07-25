namespace Projekt
{
    partial class Debugowanie
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
            this.KolorNeutralny = new System.Windows.Forms.PictureBox();
            this.KolorGracz1 = new System.Windows.Forms.PictureBox();
            this.KolorGracz2 = new System.Windows.Forms.PictureBox();
            this.RozmiarPlanszy = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pikczerboxy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.KolorNeutralny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolorGracz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolorGracz2)).BeginInit();
            this.SuspendLayout();
            // 
            // KolorNeutralny
            // 
            this.KolorNeutralny.ErrorImage = null;
            this.KolorNeutralny.InitialImage = null;
            this.KolorNeutralny.Location = new System.Drawing.Point(159, 12);
            this.KolorNeutralny.Name = "KolorNeutralny";
            this.KolorNeutralny.Size = new System.Drawing.Size(100, 50);
            this.KolorNeutralny.TabIndex = 0;
            this.KolorNeutralny.TabStop = false;
            // 
            // KolorGracz1
            // 
            this.KolorGracz1.ErrorImage = null;
            this.KolorGracz1.InitialImage = null;
            this.KolorGracz1.Location = new System.Drawing.Point(159, 68);
            this.KolorGracz1.Name = "KolorGracz1";
            this.KolorGracz1.Size = new System.Drawing.Size(100, 50);
            this.KolorGracz1.TabIndex = 1;
            this.KolorGracz1.TabStop = false;
            // 
            // KolorGracz2
            // 
            this.KolorGracz2.ErrorImage = null;
            this.KolorGracz2.InitialImage = null;
            this.KolorGracz2.Location = new System.Drawing.Point(159, 124);
            this.KolorGracz2.Name = "KolorGracz2";
            this.KolorGracz2.Size = new System.Drawing.Size(100, 50);
            this.KolorGracz2.TabIndex = 2;
            this.KolorGracz2.TabStop = false;
            // 
            // RozmiarPlanszy
            // 
            this.RozmiarPlanszy.AutoSize = true;
            this.RozmiarPlanszy.Location = new System.Drawing.Point(13, 13);
            this.RozmiarPlanszy.Name = "RozmiarPlanszy";
            this.RozmiarPlanszy.Size = new System.Drawing.Size(51, 13);
            this.RozmiarPlanszy.TabIndex = 3;
            this.RozmiarPlanszy.Text = "Rozmiar: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Zamknij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pikczerboxy
            // 
            this.Pikczerboxy.AutoSize = true;
            this.Pikczerboxy.Location = new System.Drawing.Point(16, 30);
            this.Pikczerboxy.Name = "Pikczerboxy";
            this.Pikczerboxy.Size = new System.Drawing.Size(35, 13);
            this.Pikczerboxy.TabIndex = 5;
            this.Pikczerboxy.Text = "label1";
            // 
            // Debugowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 191);
            this.Controls.Add(this.Pikczerboxy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RozmiarPlanszy);
            this.Controls.Add(this.KolorGracz2);
            this.Controls.Add(this.KolorGracz1);
            this.Controls.Add(this.KolorNeutralny);
            this.Name = "Debugowanie";
            this.Text = "Debugowanie";
            ((System.ComponentModel.ISupportInitialize)(this.KolorNeutralny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolorGracz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KolorGracz2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KolorNeutralny;
        private System.Windows.Forms.PictureBox KolorGracz1;
        private System.Windows.Forms.PictureBox KolorGracz2;
        private System.Windows.Forms.Label RozmiarPlanszy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Pikczerboxy;
    }
}