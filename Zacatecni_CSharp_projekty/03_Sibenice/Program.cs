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

        }

        static List<string> NactiSlovaZListu()
        {
            List<string> slovaDoSibenice = File.ReadLines("Slova.txt").ToList();
            return slovaDoSibenice;
        }
        
    }   
}
