using System;
using Figgle;
using System.Media;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace PROJEKT_KCK1
{
    class Program
    {
        public static object Sleep { get; private set; }

        static void Main(string[] args)
        {

            string[] LOGO = new[]
            {
               @"         ...................   ........  ............   ...................................      Y   ",
               @"    .                                                                                       .   (')  ",
               @"  .    /////*((/\  //////*/    (/(///   ,**/***////,    /***#(//  ,,,**,,  /***,,*******##   .   \\  ",
               @"  .   ###(((&%###  (((((///*   %(////   */**%((((/(,    *%//(///  ///****  /(/(////***%((/   .    \\ ",
               @" .   /((((   (((/  (((((((//%  ##(((/   /////((((((,   .((//**%&  /(((#((  */&&(//(((((//*   .     ))",
               @" .   ####((*        *(((((((/#  ((((     #((/(&%#((      /(%&##  ,##((/     (#####    ,,,,   .    // ",
               @" .   .####%&##      /######((@% #(#(     (((  (####      ##(((( #(((#       (((%/(###       .    //  ",
               @"  .    ##(((((@&    /### %###%%####(    %###  #@&%##     ((//#&%###(#(      %%@&%%#((   .       ((   ",
               @"  .      ###&((##   /###  #(((%@%##(    #####%&#####     #####( ######%     %#####***       .    \\  ",
               @" .   ##%%   #(#&&   /#((   ###%#(##(   %%%%    ((@@@&    ((((((  #&&&%%%    ###(((    #(((   .    \\ ",
               @" .   #((#(  #(#%&  #%%%%%.  ##(#%@&#  ####*,  ,/&###%# .#((##### .###%%%%/ #####%%&%%%%%%#   .     ))",
               @" .   @%#%%%%%%%#(  &%%%%%.   #####&#  %%%%%%  %%%###%@ .@%##%%&& .###%&@@# ##%%%%%%####&%(   .    // ",
               @" .   \&&#(%%%%%    ###&@@.    %%%%#( .&%####  ##%%%&@& .%%##%%%# .###%@%%/ %%%%%%##%%((#%&   .   //  ",
               @"  .                                                                                         .   ((   ",
               @"     ..   ....     .......   ..............       ........        .......................        V   ",

            };


            string[] LOGO1 = new[]
            {
               @"         ...................   ........  ............   ...................................      Y   ",
               @"    .                                                                                       .   (')  ",
               @"  .    /////*((/\  //////*/    (/(///   ,**/***////,    /***#(//  ,,,**,,  /***,,*******##   .   \\  ",
               @"  .   ###(((&%###  (((((///*   %(////   */**%((((/(,    *%//(///  ///****  /(/(////***%((/   .    \\ ",
               @" .   /((((   (((/  (((((((//%  ##(((/   /////((((((,   .((//**%&  /(((#((  */&&(//(((((//*   .     ))",
               @" .   ####((*        *(((((((/#  ((((     #((/(&%#((      /(%&##  ,##((/     (#####    ,,,,   .    // ",
               @" .   .####%&##      /######((@% #(#(     (((  (####      ##(((( #(((#       (((%/(###       .    //  ",
               @"  .    ##(((((@&    /### %###%%####(    %###  #@&%##     ((//#&%###(#(      %%@&%%#((   .       ((   ",
               @"  .      ###&((##   /###  #(((%@%##(    #####%&#####     #####( ######%     %#####***       .    \\  ",
               @" .   ##%%   #(#&&   /#((   ###%#(##(   %%%%    ((@@@&    ((((((  #&&&%%%    ###(((    #(((   .    \\ ",
               @" .   #((#(  #(#%&  #%%%%%.  ##(#%@&#  ####*,  ,/&###%# .#((##### .###%%%%/ #####%%&%%%%%%#   .     ))",
               @" .   @%#%%%%%%%#(  &%%%%%.   #####&#  %%%%%%  %%%###%@ .@%##%%&& .###%&@@# ##%%%%%%####&%(   .    // ",
               @" .   \&&#(%%%%%    ###&@@.    %%%%#( .&%####  ##%%%&@& .%%##%%%# .###%@%%/ %%%%%%##%%((#%&   .   //  ",
               @"  .                                                                                         .   ( |  ",
               @"     ..   ....     .......   ..............       ........        .......................        V   ",

            };


            string[] LOGO2 = new[]
            {
               @"         ...................   ........  ............   ...................................      Y   ",
               @"    .                                                                                       .   (')  ",
               @"  .    /////*((/\  //////*/    (/(///   ,**/***////,    /***#(//  ,,,**,,  /***,,*******##   .   \\  ",
               @"  .   ###(((&%###  (((((///*   %(////   */**%((((/(,    *%//(///  ///****  /(/(////***%((/   .    \\ ",
               @" .   /((((   (((/  (((((((//%  ##(((/   /////((((((,   .((//**%&  /(((#((  */&&(//(((((//*   .     ))",
               @" .   ####((*        *(((((((/#  ((((     #((/(&%#((      /(%&##  ,##((/     (#####    ,,,,   .    // ",
               @" .   .####%&##      /######((@% #(#(     (((  (####      ##(((( #(((#       (((%/(###       .    //  ",
               @"  .    ##(((((@&    /### %###%%####(    %###  #@&%##     ((//#&%###(#(      %%@&%%#((   .       ((   ",
               @"  .      ###&((##   /###  #(((%@%##(    #####%&#####     #####( ######%     %#####***       .    \\  ",
               @" .   ##%%   #(#&&   /#((   ###%#(##(   %%%%    ((@@@&    ((((((  #&&&%%%    ###(((    #(((   .    \\ ",
               @" .   #((#(  #(#%&  #%%%%%.  ##(#%@&#  ####*,  ,/&###%# .#((##### .###%%%%/ #####%%&%%%%%%#   .    ( )",
               @" .   @%#%%%%%%%#(  &%%%%%.   #####&#  %%%%%%  %%%###%@ .@%##%%&& .###%&@@# ##%%%%%%####&%(   .   / / ",
               @" .   \&&#(%%%%%    ###&@@.    %%%%#( .&%####  ##%%%&@& .%%##%%%# .###%@%%/ %%%%%%##%%((#%&   .  ( /  ",
               @"  .                                                                                         .   ((   ",
               @"     ..   ....     .......   ..............       ........        .......................        V   ",

            };


            string[] LOGO3 = new[]
{
               @"         ...................   ........  ............   ...................................      Y   ",
               @"    .                                                                                       .   (')  ",
               @"  .    /////*((/\  //////*/    (/(///   ,**/***////,    /***#(//  ,,,**,,  /***,,*******##   .   \\  ",
               @"  .   ###(((&%###  (((((///*   %(////   */**%((((/(,    *%//(///  ///****  /(/(////***%((/   .    \\ ",
               @" .   /((((   (((/  (((((((//%  ##(((/   /////((((((,   .((//**%&  /(((#((  */&&(//(((((//*   .     ))",
               @" .   ####((*        *(((((((/#  ((((     #((/(&%#((      /(%&##  ,##((/     (#####    ,,,,   .    // ",
               @" .   .####%&##      /######((@% #(#(     (((  (####      ##(((( #(((#       (((%/(###       .    //  ",
               @"  .    ##(((((@&    /### %###%%####(    %###  #@&%##     ((//#&%###(#(      %%@&%%#((   .       ((_  ",
               @"  .      ###&((##   /###  #(((%@%##(    #####%&#####     #####( ######%     %#####***       .    \  \",
               @" .   ##%%   #(#&&   /#((   ###%#(##(   %%%%    ((@@@&    ((((((  #&&&%%%    ###(((    #(((   .   (  /",
               @" .   #((#(  #(#%&  #%%%%%.  ##(#%@&#  ####*,  ,/&###%# .#((##### .###%%%%/ #####%%&%%%%%%#   .    \ )",
               @" .   @%#%%%%%%%#(  &%%%%%.   #####&#  %%%%%%  %%%###%@ .@%##%%&& .###%&@@# ##%%%%%%####&%(   .    // ",
               @" .   \&&#(%%%%%    ###&@@.    %%%%#( .&%####  ##%%%&@& .%%##%%%# .###%@%%/ %%%%%%##%%((#%&   .   //  ",
               @"  .                                                                                         .   ((  ",
               @"     ..   ....     .......   ..............       ........        .......................        V   ",

            };


            string[] LOGO4 = new[]
{
               @"         ...................   ........  ............   ...................................      Y   ",
               @"    .                                                                                       .   (')  ",
               @"  .    /////*((/\  //////*/    (/(///   ,**/***////,    /***#(//  ,,,**,,  /***,,*******##   .   \\  ",
               @"  .   ###(((&%###  (((((///*   %(////   */**%((((/(,    *%//(///  ///****  /(/(////***%((/   .    \\ ",
               @" .   /((((   (((/  (((((((//%  ##(((/   /////((((((,   .((//**%&  /(((#((  */&&(//(((((//*   .   (  )",
               @" .   ####((*        *(((((((/#  ((((     #((/(&%#((      /(%&##  ,##((/     (#####    ,,,,   .  /  / ",
               @" .   .####%&##      /######((@% #(#(     (((  (####      ##(((( #(((#       (((%/(###       .   \ /  ",
               @"  .    ##(((((@&    /### %###%%####(    %###  #@&%##     ((//#&%###(#(      %%@&%%#((   .       ((   ",
               @"  .      ###&((##   /###  #(((%@%##(    #####%&#####     #####( ######%     %#####***       .    \\  ",
               @" .   ##%%   #(#&&   /#((   ###%#(##(   %%%%    ((@@@&    ((((((  #&&&%%%    ###(((    #(((   .    \\ ",
               @" .   #((#(  #(#%&  #%%%%%.  ##(#%@&#  ####*,  ,/&###%# .#((##### .###%%%%/ #####%%&%%%%%%#   .     ))",
               @" .   @%#%%%%%%%#(  &%%%%%.   #####&#  %%%%%%  %%%###%@ .@%##%%&& .###%&@@# ##%%%%%%####&%(   .    // ",
               @" .   \&&#(%%%%%    ###&@@.    %%%%#( .&%####  ##%%%&@& .%%##%%%# .###%@%%/ %%%%%%##%%((#%&   .   //  ",
               @"  .                                                                                         .   ((  ",
               @"     ..   ....     .......   ..............       ........        .......................        V   ",

            };

            string[] LOGO5 = new[]
{
               @"         ...................   ........  ............   ...................................    _Y_   ",
               @"    .                                                                                       . ( ' )  ",
               @"  .    /////*((/\  //////*/    (/(///   ,**/***////,    /***#(//  ,,,**,,  /***,,*******##   .|   \  ",
               @"  .   ###(((&%###  (((((///*   %(////   */**%((((/(,    *%//(///  ///****  /(/(////***%((/   . \  |  ",
               @" .   /((((   (((/  (((((((//%  ##(((/   /////((((((,   .((//**%&  /(((#((  */&&(//(((((//*   .  ( |  ",
               @" .   ####((*        *(((((((/#  ((((     #((/(&%#((      /(%&##  ,##((/     (#####    ,,,,   .   \\  ",
               @" .   .####%&##      /######((@% #(#(     (((  (####      ##(((( #(((#       (((%/(###       .    //  ",
               @"  .    ##(((((@&    /### %###%%####(    %###  #@&%##     ((//#&%###(#(      %%@&%%#((   .       ((   ",
               @"  .      ###&((##   /###  #(((%@%##(    #####%&#####     #####( ######%     %#####***       .    \\  ",
               @" .   ##%%   #(#&&   /#((   ###%#(##(   %%%%    ((@@@&    ((((((  #&&&%%%    ###(((    #(((   .    \\ ",
               @" .   #((#(  #(#%&  #%%%%%.  ##(#%@&#  ####*,  ,/&###%# .#((##### .###%%%%/ #####%%&%%%%%%#   .     ))",
               @" .   @%#%%%%%%%#(  &%%%%%.   #####&#  %%%%%%  %%%###%@ .@%##%%&& .###%&@@# ##%%%%%%####&%(   .    // ",
               @" .   \&&#(%%%%%    ###&@@.    %%%%#( .&%####  ##%%%&@& .%%##%%%# .###%@%%/ %%%%%%##%%((#%&   .   //  ",
               @"  .                                                                                         .   ((   ",
               @"     ..   ....     .......   ..............       ........        .......................        V   ",

            };

            string[] KONIEC_LOGO = new[]
            {
               @" @@@ @@@@     @@@@@@@@     @@@,  &@@@   @@   @@@@@@@   (@@@@&@@    ",
               @" @@@*@@.    @@#      @@@  @@,@@@  @@@  (@@   @@%      (@@       @  ",
               @" @@@@@@    .@@.      @@@  @@, *@@.@@@  (@@   @@@&&&%  @@@          ",
               @" @@@  @@@   @@@     %@@   @@,   @@@@@  (@@   @@%       @@@         ",
               @" @@@   &@@,  .@@@@@@@,    @@,    @@@@  (@@   @@@@@@@%   /@@@@@@#   ",
               @"                                                                   ",
               @"                                                                   ",
               @"                     ,@@@@@@    @@@@@@    @@@    @@@               ",
               @"                    @@@      @  /@@   *@@.  @@@  @@@               ",
               @"                   @@@          /@@   @@@    @@@@@&                ",
               @"                   @@&     @@@  /@@ ,@@@      (@@.                 ",
               @"                    @@@    @@@  /@@   @@@     .@@                  ",
               @"                      ,@@@@@/    @@    (@@     @@                  ",
            };

            bool gra = true;
            //bool instrukcja = true;
            bool start = false;
            int index;
            SoundPlayer player = new SoundPlayer();
            SoundPlayer koniec = new SoundPlayer();

            string tekst = "Wybierz co chcesz zrobić: ";
            string[] opcja1 = { "Start gry", "Wyjdź z gry" };
            string[] opcja2 = { "Wróć do menu głównego ", "Wyjdź z gry" };
            string[] opcja3 = { "Kontynuuj gre ", "Zakończ gre " };

            int współrzednaLoga = 15;
            int punkty;
            int najPunkty = 0;
            List<int> listaPunktow = new List<int>();
            wyniki wynik = new wyniki();


            menu MenuGłowne = new menu(tekst, opcja1, 31);
            menu Koniec = new menu(tekst, opcja2, 31);
            menu Pauza = new menu(tekst, opcja3, 31);

            static void GraniceMapy()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(10, 5);
                Console.Write("╔");
                Console.SetCursorPosition(90, 5);
                Console.Write("╗");
                Console.SetCursorPosition(10, 45);
                Console.Write("╚");
                Console.SetCursorPosition(90, 45);
                Console.Write("╝");

                for (int i = 11; i < 90; i++)
                {
                    Console.SetCursorPosition(i, 5);
                    Console.Write("═");
                    Console.SetCursorPosition(i, 45);
                    Console.Write("═");
                }

                for (int i = 6; i < 45; i++)
                {
                    Console.SetCursorPosition(10, i);
                    Console.Write("║");
                    Console.SetCursorPosition(90, i);
                    Console.Write("║");
                }
            }


            static void PokazLOGO(string[] LOGO, int wspolrzednaY)
            {
                foreach (string linia in LOGO)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition((Console.WindowWidth / 2) - (linia.Length / 2), wspolrzednaY);
                    Console.WriteLine(linia);
                    wspolrzednaY++;
                }
            }

            while (gra)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\soundtrack.wav";
                koniec.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\explosion-01.wav";
                player.PlayLooping();
                Console.SetWindowSize(105, 50);
                Console.CursorVisible = false;
                punkty = 0;
                snake gracz = new snake();
                Console.Clear();
                GraniceMapy();
                PokazLOGO(LOGO, współrzednaLoga);
                Thread.Sleep(400);
                PokazLOGO(LOGO5, współrzednaLoga);
                Thread.Sleep(400);
                PokazLOGO(LOGO4, współrzednaLoga);
                Thread.Sleep(400);
                PokazLOGO(LOGO3, współrzednaLoga);
                Thread.Sleep(400);
                PokazLOGO(LOGO2, współrzednaLoga);
                Thread.Sleep(400);
                PokazLOGO(LOGO1, współrzednaLoga);
                Thread.Sleep(400);
                PokazLOGO(LOGO, współrzednaLoga);
                index = MenuGłowne.ZrobMenu();
                if (index == 0) { start = true; }
                if (index == 1) { gra = false; }

                Console.Clear();
                gracz.Zrob_zwykle();
                gracz.Zrob_szybki();
                gracz.Zrob_wolny();
                GraniceMapy();

                while (start)
                {
                    Console.SetWindowSize(100, 50);
                    Console.CursorVisible = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(3, 1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("   ■ <-- (+1 długości i + 1pkt)    ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("■ <-- (+6 długości i + 10pkt)   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("■ <-- (+2 długości i + 3pkt)");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(4, 3);
                    Console.WriteLine("PAUZA- NACIŚNIJ KLAWISZ P ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth / 2) - 5, 3);
                    Console.WriteLine("PUNKTY: {0}", punkty);

                    start = gracz.TrwanieGry();
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo press = Console.ReadKey();
                        switch (press.Key)
                        {
                            case (ConsoleKey.UpArrow):
                                gracz.kierunek = "GORA";
                                break;
                            case (ConsoleKey.DownArrow):
                                gracz.kierunek = "DOL";
                                break;
                            case (ConsoleKey.LeftArrow):
                                gracz.kierunek = "LEWO";
                                break;
                            case (ConsoleKey.RightArrow):
                                gracz.kierunek = "PRAWO";
                                break;
                            case (ConsoleKey.P):
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                index = Pauza.ZrobMenu();
                                if (index == 0)
                                {
                                    Console.Clear();
                                    GraniceMapy();
                                    break;
                                }
                                if (index == 1)
                                {
                                    start = false;

                                    break;
                                }

                                break;
                        }
                    }
                    if (gracz.Jedz() == 1)
                    {
                        gracz.Zrob_zwykle();
                        punkty += 1;
                        Console.Beep(800, 10);
                    }
                    if (gracz.Jedz() == 2)
                    {
                        gracz.Zrob_szybki();
                        punkty += 3;
                        Console.Beep(500, 10);
                    }
                    if (gracz.Jedz() == 3)
                    {
                        gracz.Zrob_wolny();
                        punkty += 10;
                        Console.Beep(300, 10);
                    }
                }
                if (gra)
                {
                    player.Stop();
                    koniec.Play();
                    GraniceMapy();
                    PokazLOGO(KONIEC_LOGO, współrzednaLoga);
                    wynik.DoPliku(punkty);

                    if (punkty > najPunkty)
                    {
                        najPunkty = punkty;
                        
                    }
                    Console.SetCursorPosition(50, 37);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NAJLEPSZY DOTYCHCZASOWY WYNIK: " + najPunkty);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition(20, 38);
                    Console.WriteLine("TRZY OSTATNIE WYNIKI: ");

                    listaPunktow = wynik.Czytaj();
                    Console.SetCursorPosition(50, 39);
                    int y = 39;
                    for (int i = 0; i < listaPunktow.Count; i++)
                    {
                        Console.SetCursorPosition(23, y++);
                        Console.Write("-> ");
                        Console.WriteLine(listaPunktow[i] + " pkt");
                    }
                    index = Koniec.ZrobMenu();
                    if (index == 0) { }
                    else if (index == 1) { gra = false; }

                }

            }
        }
    }
}
