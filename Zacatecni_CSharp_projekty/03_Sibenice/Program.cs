namespace _03_Sibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> slovaDoSibenice = NactiSlovaZListu();
            Random random = new Random();
            string vybraneSlovo = slovaDoSibenice[random.Next(slovaDoSibenice.Count)];
            //Console.WriteLine(vybraneSlovo); //*CHEAT*
            string skryteSlovo = new string('_', vybraneSlovo.Length);//pretvoreni vybraneho slova na podtrzitka dle poctu pismen
            Console.WriteLine(skryteSlovo);//vypsani podtrzitek
            int pocetPokusu = 6;
            List<char> uhodnutaPismena = new List<char>();

            while (pocetPokusu > 0)
            {
                Console.WriteLine("Zadejte písmeno: ");
                char pismeno = Console.ReadLine()[0];
                if (uhodnutaPismena.Contains(pismeno))
                {
                    Console.WriteLine($"Písmeno {pismeno} už bylo uhodnuto, zadejte jiné.");
                    continue;
                }
                uhodnutaPismena.Add(pismeno);

                bool uhadlPismeno = false;//pokud clovek uhadne pismeno skryte slovo se aktualizuje
                char[] skrytePole = skryteSlovo.ToCharArray();

                for (int i = 0; i < vybraneSlovo.Length; i++)
                {
                    if (vybraneSlovo[i] == pismeno)
                    {
                        skrytePole[i] = pismeno;
                        uhadlPismeno = true;
                    }
                }
                if (uhadlPismeno) //aktualizace skryteho slova
                {
                    skryteSlovo = new string(skrytePole);
                    Console.WriteLine($"Správně! Slovo je: {skryteSlovo}");
                    if (skryteSlovo == vybraneSlovo)
                    {
                        Console.WriteLine("Vyhrál jsi!");
                        break;
                    }
                }
                else
                {
                    pocetPokusu--;
                    Console.WriteLine($"Špatně. Písmeno {pismeno} ve slově není");
                    Console.WriteLine($"Zbývá {pocetPokusu} pokusů");
                }
                if (pocetPokusu == 0)
                {
                    Console.WriteLine($"Prohrál jsi! Slovo bylo {vybraneSlovo}!");
                    break;
                }
            }
        }

        static List<string> NactiSlovaZListu()
        {
            List<string> slovaDoSibenice = File.ReadLines("Slova.txt").ToList();
            return slovaDoSibenice;
        }
        
    }   
}
