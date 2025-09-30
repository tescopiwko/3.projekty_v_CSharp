namespace NudneTextoveChceteBytMilionarem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            bool beziHra = true;
            bool jeOdpovedSpravna = false;
            int pomocnyIndex = 0;
            int konecneKolo = 3;
            int konto = 0;
            List<string> otazkyDoHry = nacteniZeSouboru("Otazky.txt");
            List<string> odpovediDoHry = nacteniZeSouboru("Odpovedi.txt");
            while (beziHra)
            {
                Console.Write($"Otázka číslo {pomocnyIndex+1}. {otazkyDoHry[pomocnyIndex]} ");
                string odpoved = Console.ReadLine();
                if (odpoved == odpovediDoHry[pomocnyIndex])
                {
                    konto = konto + (pomocnyIndex + 1) * 500;
                    Console.WriteLine($"Výborně odpověděl jsi správně na {pomocnyIndex + 1}. otázku odnášíš si: {konto} místní-měny");
                    pomocnyIndex++;
                    
                }

                

            }

            
            

        }

        static List<string> nacteniZeSouboru(string otazkyNeboOdpovedi)
        {
            List<string> otazkyDoHry = File.ReadLines(otazkyNeboOdpovedi).ToList();
            return otazkyDoHry;
        }
    }
}       
    
