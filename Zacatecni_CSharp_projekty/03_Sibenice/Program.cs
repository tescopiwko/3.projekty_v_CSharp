namespace _03_Sibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NactiSlovaZListu();
            List<string> slovaDoSibenice = NactiSlovaZListu();
            Random random = new Random();
            string vybraneSlovo = slovaDoSibenice[random.Next(slovaDoSibenice.Count)];
            //Console.WriteLine(vybraneSlovo);
            string skryteSlovo = new string('_', vybraneSlovo.Length);
            Console.WriteLine(skryteSlovo);
            int pocetPokusu = 12;
            while (pocetPokusu > 0)
            {
                Console.WriteLine("Zadejte písmeno: ");
                char pismeno = Console.ReadLine()[0];
                if (vybraneSlovo.Contains(pismeno))
                {
                    for (int i = 0; i < vybraneSlovo.Length; i++)
                    {
                        if (vybraneSlovo[i] == pismeno)
                        {
                            char[] skrytePole = skryteSlovo.ToCharArray();
                            skrytePole[i] = pismeno;
                            skryteSlovo = new string(skrytePole);
                            Console.WriteLine(skryteSlovo);
                        }
                    
                    }

                }


            }
            List<char> uhodnutaPismena = new List<char>();

            

        }

        static List<string> NactiSlovaZListu()
        {
            List<string> slovaDoSibenice = File.ReadLines("Slova.txt").ToList();
            return slovaDoSibenice;
        }
        
    }   
}
