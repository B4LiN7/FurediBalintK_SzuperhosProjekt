using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<Inter> szuperhosok = new List<Inter>();

        public static void Szereplok(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(' ');
                    if (sor[0] == "Batman")
                    {
                        Batman batman = new Batman();
                        szuperhosok.Add(batman);
                        for (int i = 1; i < Convert.ToInt32(sor[1]); i++)
                        {
                            (szuperhosok[szuperhosok.IndexOf(batman)] as Batman).KutyutKeszit();
                        }
                    }
                    else if (sor[0] == "Vasember")
                    {
                        Vasember vasember = new Vasember();
                        szuperhosok.Add(vasember);
                        for (int i = 1; i < Convert.ToInt32(sor[1]); i++)
                        {
                            (szuperhosok[szuperhosok.IndexOf(vasember)] as Vasember).KutyutKeszit();
                        }
                    }
                }
            }
        }

        public static void Szuperhosok()
        {
            foreach (var item in szuperhosok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
