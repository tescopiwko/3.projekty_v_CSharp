namespace _06_UhodniCislo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int cislo = random.Next(1, 101);
            Console.WriteLine(cislo);

            Console.Write("Hádejte číslo: ");
            int Zvolenecislo = Convert.ToInt32(Console.ReadLine());

            while (Zvolenecislo != cislo)
            {
                if (Zvolenecislo > cislo)
                {
                    Console.WriteLine("Cislo je prilis velke. Zkus mensi");
                }
                else
                {
                    Console.WriteLine("Cislo je prilis male. Zkus vetsi");
                }
                Console.WriteLine("Hádejte číslo: ");
                Zvolenecislo = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Uhodl jsi číslo!");
        }
    }
}
