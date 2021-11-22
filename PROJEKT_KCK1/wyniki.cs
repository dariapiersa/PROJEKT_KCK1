using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace PROJEKT_KCK1
{
    class wyniki
    {
        public wyniki()
        {

        }

        public void DoPliku(int punkty)
        { 
            if (punkty != 0)
            {
                using (StreamWriter wpisz = File.AppendText(@"punkty.txt"))
                {
                    wpisz.WriteLine(punkty);
                }
            }
        }

        public List<int> Czytaj()
        {
            List<string> linie = File.ReadLines(@"punkty.txt").TakeLast(3).ToList();
            List<int> wyniki = new List<int>();
            for(int i = 0; i < 3; i++)
            {
                wyniki.Add(int.Parse(linie[i]));
            }

            return wyniki;

        }
    }
}
