using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Figgle;

namespace PROJEKT_KCK1
{
    class snake
    {
        public int dlugosc;
        public string kierunek;
        int szybkosc = 150;
        private string cialo = "■";
        private string glowa = "■";

        readonly Random liczba = new Random();

        Współrzędne pozycja_glowy = new Współrzędne(30, 20); // pozycja startu
        Współrzędne pozycja_ogona = new Współrzędne(0, 1);

        jedzenie zwykłe = new jedzenie();
        Współrzędne pozcyja_zwykłego = new Współrzędne(0, 0);

        jedzenie szybkie = new jedzenie();
        Współrzędne pozycja_szybkiego = new Współrzędne(0, 0);

        jedzenie wolne = new jedzenie();
        Współrzędne pozycja_wolnego = new Współrzędne(0, 0);

        readonly int[,] cialo_weza = new int[500, 2]; //moze miec maksymalnie 500 pól, druga wartosc jest dwa, bo to pozycja ogona zlozona z 2 wspolrzednych

        public snake()
        {
            dlugosc = 4;
            kierunek = "PRAWO";
        }

        public bool TrwanieGry()
        {
            Console.CursorVisible = false;


            //pobranie starej pozycji glowy
            cialo_weza[dlugosc - 1, pozycja_ogona.x] = pozycja_glowy.x;
            cialo_weza[dlugosc - 1, pozycja_ogona.y] = pozycja_glowy.y;


            //odswiezenie pozycji calego ciala
            for (int i = 2; i < dlugosc; i++)
            {
                cialo_weza[i - 1, pozycja_ogona.x] = cialo_weza[i, pozycja_ogona.x];
                cialo_weza[i - 1, pozycja_ogona.y] = cialo_weza[i, pozycja_ogona.y];
                
                //koniec gry, gdy snake wjedzie w swoje ciało
                if ((cialo_weza[i - 2, pozycja_ogona.x] == pozycja_glowy.x) && (cialo_weza[i - 2, pozycja_ogona.y] == pozycja_glowy.y))
                {
                    return false;
                }
            }

            //sprawdzenie czy snake jest dalej w polu mapy
            if ((pozycja_glowy.x > 89) || (pozycja_glowy.x < 11) || (pozycja_glowy.y > 44) || (pozycja_glowy.y < 6))
            {
                return false;
            }

            //narysuj jedzenie
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(pozcyja_zwykłego.x, pozcyja_zwykłego.y);
            Console.Write(zwykłe.jedzenie1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(pozycja_szybkiego.x, pozycja_szybkiego.y);
            Console.Write(szybkie.jedzenie2);


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(pozycja_wolnego.x, pozycja_wolnego.y);
            Console.Write(wolne.jedzenie3);


            switch (kierunek)
            {
                case ("PRAWO"):
                {
                    pozycja_glowy.x++;
                    break;
                }
                case ("LEWO"):
                    {
                        pozycja_glowy.x--;
                        break;
                    }
                case ("DOL"):
                    {
                        pozycja_glowy.y++;
                        break;
                    }
                case ("GORA"):
                    {
                        pozycja_glowy.y--;
                        break;
                    }

            }

            //rysowanie glowy snakea
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(pozycja_glowy.x, pozycja_glowy.y);
            Console.Write(glowa);

            //rysowanie ciala snakea
            for(int i = 1; i < dlugosc; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(cialo_weza[dlugosc - i, pozycja_ogona.x], cialo_weza[dlugosc - i, pozycja_ogona.y]);
                Console.Write(cialo);
            }
            Thread.Sleep(szybkosc); // jak tego nie zrobimy to wąż przeleci na maksa szybko i nawet nie zobaczymy XD

            //rysuje tło na czarno za wężem, zeby nie byl nieskonczony
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(cialo_weza[0, pozycja_ogona.x], cialo_weza[0, pozycja_ogona.y]);
            Console.Write(cialo);
            Console.SetCursorPosition(cialo_weza[1, pozycja_ogona.x], cialo_weza[1, pozycja_ogona.y]);
            Console.Write(cialo);

            return true;
        }

        public int Jedz()
        {
            if ((pozycja_glowy.x == pozcyja_zwykłego.x) && (pozycja_glowy.y == pozcyja_zwykłego.y))
            {
                dlugosc++;
                return 1;
            }
            if ((pozycja_glowy.x == pozycja_szybkiego.x) && (pozycja_glowy.y == pozycja_szybkiego.y))
            {
                dlugosc += 1;
                return 2;
            }
            if ((pozycja_glowy.x == pozycja_wolnego.x) && (pozycja_glowy.y == pozycja_wolnego.y))
            {
                dlugosc += 2;
                return 3;
            }
            else
            {
                return 0;
            }
        }


        public void Zrob_zwykle()
        {
            pozcyja_zwykłego.x = liczba.Next(11, 89);
            pozcyja_zwykłego.y = liczba.Next(6, 44);
        }

        public void Zrob_szybki()
        {
            pozycja_szybkiego.x = liczba.Next(11, 89);
            pozycja_szybkiego.y = liczba.Next(6, 44);
        }
        public void Zrob_wolny()
        {
            pozycja_wolnego.x = liczba.Next(11, 89);
            pozycja_wolnego.y = liczba.Next(6, 44);
        }
    }
}
