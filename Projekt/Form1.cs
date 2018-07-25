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
    public partial class MainWindow : Form
    {
        public static Gracz gracz1 = new Gracz("Gracz1","Green");
        public static Gracz gracz2 = new Gracz("Gracz2","Blue");
        public static PolePlanszy plansza = new PolePlanszy();
        public static Pole[,] pole = new Pole[plansza.rozmiar,plansza.rozmiar];//Stworzenie planszy o domyślnym rozmiarze
        public static int pikczerboxy = 0;//Ilość pól na planszy, pokazywane w okienku debuguj
        public static int oldRozmiar = plansza.rozmiar;//Stary rozmiar planszy, potrzebne do usuwania pól przy generowaniu nowej planszy
        public static Boolean wygranaGlobal = false;//Domyślnie nikt nie wygrywa, domyślna wartość true też będzie działać
        public void czyWygrana()//Wartość zostaje ustawiona globalnie, zamiast przekazania w return
        {//Dziwnie się korzysta z Action
            Boolean wygrana = true;
            for (int i = 0; i < plansza.rozmiar; i++)
            {
                for (int j = 0; j < plansza.rozmiar; j++)
                {
                    if (pole[i, j].owner != pole[0, 0].owner)//Czy są pola które mają innego właściciela niż pierwsze pole
                    {
                        wygrana = false;
                        break;
                    }
                }
                if (!wygrana) break;
            }
            if (wygrana)//Każde pole ma tego samego właściciela
            {
                Gracz1Score.Text = gracz1.nazwaGracza + ": " + gracz1.punkty;//Aktualizacja pola wyniku
                Gracz2Score.Text = gracz2.nazwaGracza + ": " + gracz2.punkty;//Było dziwnie kiedy MessageBox pokazywał inną wartość niż pole wyniku
                MessageBox.Show("Zwycięzcą został " + pole[0, 0].owner.nazwaGracza + " z wynikiem " + plansza.aktualnyGracz.punkty + " punktów!", "Zwycięstwo!");
                GenerujPole(oldRozmiar);//Gdyby nie rysować nowego pola, w określonych sytuacjach gra wpadałaby w nieskończoną pętlę
                changePlayer();//Z jakiegoś powodu nową turę zaczynał zawsze gracz 2, przywrócenie gracza 1
                wygranaGlobal = true;//Dzięki tej fladze działająca fala skoków może się zatrzymać
            }
        }
        public void changePlayer()
        {
            if (plansza.aktualnyGracz == gracz1)
            {
                gracz1.punkty = plansza.aktualnyGracz.punkty;
                Gracz1Score.Text = gracz1.nazwaGracza + ": " + gracz1.punkty;
                Gracz2Score.Text = gracz2.nazwaGracza + ": " + gracz2.punkty;
                plansza.aktualnyGracz = gracz2;
                CurrGraczKostka.Image = Image.FromFile("2.png");
                CurrGraczKostka.BackColor = gracz2.KolorGracza;
                GraczNazwa.Text = gracz2.nazwaGracza;
            }
            else
            {
                gracz2.punkty = plansza.aktualnyGracz.punkty;
                Gracz1Score.Text = gracz1.nazwaGracza + ": " + gracz1.punkty;
                Gracz2Score.Text = gracz2.nazwaGracza + ": " + gracz2.punkty;
                plansza.aktualnyGracz = gracz1;
                CurrGraczKostka.Image = Image.FromFile("1.png");
                CurrGraczKostka.BackColor = gracz1.KolorGracza;
                GraczNazwa.Text = gracz1.nazwaGracza;
            }
        }
        public void skok(miejsceWTablicy miejsce)//Fala na sąsiednie pola
        {
            int i = miejsce.i;
            int j = miejsce.j;
            if (i - 1 >= 0) pole[i - 1, j].dodaj();//Pole po lewej, jeżeli istnieje
            if (i + 1 <= plansza.rozmiar - 1) pole[i + 1, j].dodaj();//Pole po prawej, jeżeli istnieje
            if (j - 1 >= 0) pole[i, j - 1].dodaj();//Pole u góry, jeżeli istnieje
            if (j + 1 <= plansza.rozmiar - 1) pole[i, j + 1].dodaj();//Pole na dole, jeżeli istnieje
        }
        public void GenerujPole()//Tworzenie planszy w momencie startu programu, wartości domyślne
        {
            plansza.aktualnyGracz = gracz1;
            CurrGraczKostka.Image = Image.FromFile("1.png");
            CurrGraczKostka.SizeMode = PictureBoxSizeMode.StretchImage;
            CurrGraczKostka.BackColor = gracz1.KolorGracza;
            GraczNazwa.Text = gracz1.nazwaGracza;
            int LokalizacjaSzerokość = 0, LokalizacjaWysokość = 0;
            for (int i = 0; i < plansza.rozmiar; i++)
            {
                for (int j = 0; j < plansza.rozmiar; j++)
                {
                    if ((i == 0 && j == 0) || (i == 0 && j == plansza.rozmiar - 1) || (i == plansza.rozmiar - 1 && j == 0) || (i == plansza.rozmiar - 1 && j == plansza.rozmiar - 1))
                    {//Pole ma 2 sąsiadów, jest w rogu
                        pole[i, j] = new Pole(3,i,j);
                    }
                    else if(i==0 || j==0 || j==plansza.rozmiar-1 || i == plansza.rozmiar - 1)//Pole ma 3 sąsiadów, jest na krawędzi
                    {
                        pole[i, j] = new Pole(4,i,j);
                    }
                    else//Pole ma 4 sąsiadów, jest wewnątrz planszy
                    {
                        pole[i, j] = new Pole(5,i,j);
                    }
                    Plansza.Controls.Add(pole[i, j].poleNaPlanszy);//dodanie pola na planszę
                    pole[i, j].zmianaGracza = changePlayer;//Akcja
                    pole[i, j].skok = skok;//Akcja
                    pole[i, j].czyWygrana = czyWygrana;//Akcja
                    //Wymiary i lokalizacja pola
                    pole[i, j].poleNaPlanszy.Width = Plansza.Size.Width / plansza.rozmiar;
                    pole[i, j].poleNaPlanszy.Height = Plansza.Size.Height / plansza.rozmiar;
                    pole[i, j].poleNaPlanszy.Location = new Point(LokalizacjaSzerokość, LokalizacjaWysokość);
                    LokalizacjaSzerokość += pole[i, j].poleNaPlanszy.Width;
                    pikczerboxy++;
                }
                LokalizacjaSzerokość = 0;//Początek linii
                LokalizacjaWysokość += Plansza.Size.Height / plansza.rozmiar;//Nowa linia
            }
        }
        public void GenerujPole(int oldRozmiar)
        {
            gracz1.punkty = 0;
            gracz2.punkty = 0;
            Gracz1Score.Text = gracz1.nazwaGracza + ": " + gracz1.punkty;
            Gracz2Score.Text = gracz2.nazwaGracza + ": " + gracz2.punkty;
            plansza.aktualnyGracz = gracz1;
            CurrGraczKostka.Image = Image.FromFile("1.png");
            CurrGraczKostka.SizeMode = PictureBoxSizeMode.StretchImage;
            CurrGraczKostka.BackColor = gracz1.KolorGracza;
            GraczNazwa.Text = gracz1.nazwaGracza;
            for (int i = 0; i < oldRozmiar; i++)//Czyszenie starej planszy
            {
                for (int j = 0; j < oldRozmiar; j++)
                {
                    Plansza.Controls.Remove(pole[i, j].poleNaPlanszy);
                    pole[i, j].poleNaPlanszy.Dispose();
                }
            }
            pikczerboxy = 0;
            pole = new Pole[plansza.rozmiar, plansza.rozmiar];
            MainWindow.oldRozmiar = plansza.rozmiar;//Musi być MainWindow, bo inaczej nadpisuje parametr funkcji, który nie jest już potrzebny
            plansza.aktualnyGracz = gracz1;
            int LokalizacjaSzerokość = 0, LokalizacjaWysokość = 0;
            for (int i = 0; i < plansza.rozmiar; i++)
            {
                for (int j = 0; j < plansza.rozmiar; j++)
                {
                    if ((i == 0 && j == 0) || (i == 0 && j == plansza.rozmiar - 1) || (i == plansza.rozmiar - 1 && j == 0) || (i == plansza.rozmiar - 1 && j == plansza.rozmiar - 1))
                    {
                        pole[i, j] = new Pole(3, i, j);
                    }
                    else if (i == 0 || j == 0 || j == plansza.rozmiar - 1 || i == plansza.rozmiar - 1)
                    {
                        pole[i, j] = new Pole(4, i, j);
                    }
                    else
                    {
                        pole[i, j] = new Pole(5, i, j);
                    }
                    pole[i, j].zmianaGracza = changePlayer;
                    pole[i, j].skok = skok;
                    pole[i, j].czyWygrana = czyWygrana;
                    Plansza.Controls.Add(pole[i, j].poleNaPlanszy);
                    pole[i, j].poleNaPlanszy.Width = Plansza.Size.Width / plansza.rozmiar;
                    pole[i, j].poleNaPlanszy.Height = Plansza.Size.Height / plansza.rozmiar;
                    pole[i, j].poleNaPlanszy.Location = new Point(LokalizacjaSzerokość, LokalizacjaWysokość);
                    LokalizacjaSzerokość += pole[i, j].poleNaPlanszy.Width;
                    pikczerboxy++;
                }
                LokalizacjaSzerokość = 0;
                LokalizacjaWysokość += Plansza.Size.Height / plansza.rozmiar;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            GenerujPole();
        }

        private void button2_Click(object sender, EventArgs e)//Ustawienia
        {
            Ustawienia settings = new Ustawienia();
            settings.genPole = GenerujPole;
            settings.ShowDialog();
            Gracz1Score.Text = gracz1.nazwaGracza + ": " + gracz1.punkty;
            Gracz2Score.Text = gracz2.nazwaGracza + ": " + gracz2.punkty;
        }

        private void Debug_Click(object sender, KeyEventArgs e)//Debugowanie z F12 -- Nie działa
        {
            if (e.KeyCode == Keys.F12)
            {
                Debugowanie debug = new Debugowanie();
                debug.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)//Debugowanie z przycisku
        {
            Debugowanie debug = new Debugowanie();
            debug.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)//Od nowa
        {
            GenerujPole(oldRozmiar);
        }
    }
}
