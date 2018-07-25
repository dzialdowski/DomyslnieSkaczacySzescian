using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public class Pole
    {
        public PictureBox poleNaPlanszy = new PictureBox(); //PictureBox bo ilość oczek będzie przedstawiana w postaci graficznej
        public Gracz owner;//właściciel pola
        public int oczka;//Ilość oczek w polu
        private int max;//Maksymalna ilość oczek w polu: >>Ilość krawędzi pola + 1<<
        public int i, j;//miejsce w tablicy
        public Action zmianaGracza;//Funkcja w Form1.cs
        public Action<miejsceWTablicy> skok;//Funkcja w Form1.cs
        public Action czyWygrana;//Funkcja w Form1.cs
        public Pole(int maks,int a,int b)//maks - maksymalna ilość oczek, a i b - lokalizacja pola w tablicy
        {
            poleNaPlanszy = new PictureBox
            {
                Name = "Pole",//Chyba niepotrzebne, ale jest
                Image = Image.FromFile("1.png"),//Domyślnie na polu jest 1 oczko
                SizeMode = PictureBoxSizeMode.StretchImage,//Dopasowanie grafiki do wymiarów obiektu
                BorderStyle = BorderStyle.FixedSingle,//Obramowanie pola
                BackColor = MainWindow.plansza.kolorNeutralny,//Kolor neutralny
            };
            oczka = 1;
            i = a;//Przypisanie polu informacji na temat jego lokalizacji
            j = b;
            max = maks;//Informacja o maksymalnej liczbie oczek jest generowana w momencie tworzenia pola w pliku Form1.cs
            poleNaPlanszy.MouseClick += new MouseEventHandler(dodaj);//Po kliknięciu pola ma ono zwiększyć swoją liczbę oczek
            owner = null;//Domyślnie pola nie posiadają właściciela
        }
        private void skokInside()//Tutaj zostaje wykonywana część operacji skoku, dla pojedynczego pola 
        {
            oczka = 1;//Domyślna ilość oczek
            poleNaPlanszy.Image = Image.FromFile(oczka + ".png");//Przedstawienie ilości oczek użytkownikowi
            miejsceWTablicy miejsce = new miejsceWTablicy();//Funkcji skok mogę przekazać tylko jedną zmienną, dlatego stworzyłem klasę łączącą 2 zmienne
            miejsce.i = i;
            miejsce.j = j;
            skok(miejsce);//Wykonanie dalszej operacji skoku na polach sąsiadujących
        }
        public void dodaj()//Ta metoda zostaje wywołana przez efekt fali
        {
            if (!MainWindow.wygranaGlobal)//Ta flaga została ustawiona, ponieważ po wygranej i stworzeniu nowego pola poprzednia gra wpływała na nową
            {
                owner = MainWindow.plansza.aktualnyGracz;//Przyznanie pola graczowi który to pole przejął
                oczka++;//Zwiększenie ilości oczek
                poleNaPlanszy.Image = Image.FromFile(oczka + ".png");
                MainWindow.plansza.aktualnyGracz.punkty += oczka;//Punkty dla aktualnego gracza
                poleNaPlanszy.BackColor = MainWindow.plansza.aktualnyGracz.KolorGracza;//Sygnalizowanie kolorem własności pola
                czyWygrana();
                if (!MainWindow.wygranaGlobal)
                {
                    if (oczka == max) skokInside();//Ilość oczek osiągnęła wartość maksymalną, rozpoczynanie efektu fali
                }
            }
        }
        private void dodaj(object sender, MouseEventArgs e)//Ta metoda zostaje wywołana kliknięciem myszą
        {
            if (e.Button == MouseButtons.Right)//Prawoklik da informacje o polu
            {
                if (owner == null)
                {
                    MessageBox.Show("Właściciel pola: Pole neutralne", "Informacje o polu");
                }
                else
                {
                    MessageBox.Show("Właściciel pola: " + owner.nazwaGracza, "Informacje o polu");
                }
            }
            else
            {
                if (MainWindow.plansza.aktualnyGracz == owner)//Prawie to samo co dodaj() bez argumentów
                {
                    owner = MainWindow.plansza.aktualnyGracz;
                    oczka++;
                    poleNaPlanszy.Image = Image.FromFile(oczka + ".png");
                    MainWindow.plansza.aktualnyGracz.punkty+=oczka;
                    if (oczka == max) skokInside();
                    zmianaGracza();
                }
                else if (owner == null)//Przejęcie neutralnego pola
                {
                    owner = MainWindow.plansza.aktualnyGracz;
                    poleNaPlanszy.BackColor = MainWindow.plansza.aktualnyGracz.KolorGracza;
                    oczka++;
                    MainWindow.plansza.aktualnyGracz.punkty += oczka;
                    poleNaPlanszy.Image = Image.FromFile(oczka + ".png");
                    zmianaGracza();
                    MainWindow.wygranaGlobal = false;//Pierwsze kliknięcia zerują flagę wygranej
                }
                else//Gracz kliknął pole przeciwnika
                {
                    MessageBox.Show("To pole nie należy do Ciebie", "Cudze pole");
                }
            }
        }
    }
}
