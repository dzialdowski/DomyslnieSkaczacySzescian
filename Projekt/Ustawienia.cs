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
    public partial class Ustawienia : Form
    {
        public Action<int> genPole;
        public Ustawienia()
        {
            InitializeComponent();
            Gracz1Name.Text = MainWindow.gracz1.nazwaGracza;
            KolorGracz1.Color = MainWindow.gracz1.KolorGracza;
            Gracz2Name.Text = MainWindow.gracz2.nazwaGracza;
            KolorGracz2.Color = MainWindow.gracz2.KolorGracza;
            KolorNeutralny.Color = MainWindow.plansza.kolorNeutralny;
            RozmiarPlanszy.Value = MainWindow.plansza.rozmiar;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MainWindow.gracz1.KolorGracza = KolorGracz1.Color;
            MainWindow.gracz1.nazwaGracza = Gracz1Name.Text;
            MainWindow.gracz2.KolorGracza = KolorGracz2.Color;
            MainWindow.gracz2.nazwaGracza = Gracz2Name.Text;
            MainWindow.plansza.kolorNeutralny = KolorNeutralny.Color;
            MainWindow.plansza.rozmiar = RozmiarPlanszy.Value;
            genPole(MainWindow.oldRozmiar);
            Close();
        }

        private void KolorButton1_Click(object sender, EventArgs e)
        {
            KolorGracz1.ShowDialog();
        }

        private void KolorButton2_Click(object sender, EventArgs e)
        {
            KolorGracz2.ShowDialog();
        }

        private void KolorButton0_Click(object sender, EventArgs e)
        {
            KolorNeutralny.ShowDialog();
        }
    }
}
