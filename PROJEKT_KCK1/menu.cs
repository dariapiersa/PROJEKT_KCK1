using System;
using System.Collections.Generic;
using System.Text;

namespace PROJEKT_KCK1
{
    class menu
    {
        private string tekst;
        private string[] opcja;
        private int wspolrzedna;

        public menu(string tekst, string[] opcja, int wspolrzedna)
        {
            this.tekst = tekst;
            this.opcja = opcja;
            this.wspolrzedna = wspolrzedna;
        }


        public int ZrobMenu()
        {
            int index = 0;
            int pozycjaY;

            while (true)
            {
                pozycjaY = wspolrzedna;
                Console.SetWindowSize(105, 51);
                Console.CursorVisible = false;
                Console.SetCursorPosition((Console.WindowWidth / 2) - (tekst.Length / 2), pozycjaY);
                Console.WriteLine(tekst);
                for (int i = 0; i < opcja.Length; i++)
                {
                    pozycjaY++;
                    if (i == index)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition((Console.WindowWidth / 2) - (tekst.Length / 2), pozycjaY);
                        Console.WriteLine("> {0}", opcja[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.SetCursorPosition((Console.WindowWidth / 2) - (tekst.Length / 2), pozycjaY);
                        Console.WriteLine("  {0}", opcja[i]);
                    }
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo press = Console.ReadKey();
                    switch (press.Key)
                    {
                        case (ConsoleKey.UpArrow):
                            if (index > 0)
                            {
                                index--;
                            }
                            break;
                        case (ConsoleKey.DownArrow):
                            if (index < opcja.Length - 1)
                            {
                                index++;
                            }
                            break;
                        case (ConsoleKey.Enter):  
                            return index;

                    }
                }
            }
        }
    }
}
