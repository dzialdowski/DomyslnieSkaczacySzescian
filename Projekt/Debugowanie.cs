using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Debugowanie : Form
    {
        public Debugowanie()
        {
            InitializeComponent();
            KolorNeutralny.BackColor = MainWindow.plansza.kolorNeutralny;
            KolorGracz1.BackColor = MainWindow.gracz1.KolorGracza;
            KolorGracz2.BackColor = MainWindow.gracz2.KolorGracza;
            RozmiarPlanszy.Text = "Rozmiar: " + MainWindow.plansza.rozmiar + "x" + MainWindow.plansza.rozmiar;
            Pikczerboxy.Text = Convert.ToString(MainWindow.pikczerboxy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
