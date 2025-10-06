namespace NudneTextoveChceteBytMilionarem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool beziHra = true;
            bool jeOdpovedSpravna = false;
            int pomocnyIndex = 0;
            int konecneKolo = 3;
            string konto = "";
            List<string> otazkyDoHry = nacteniZeSouboru("Otazky.txt");
            List<string> odpovediDoHry = nacteniZeSouboru("Odpovedi.txt");
            List<string> vyhraPodleKola = nacteniZeSouboru("Odmeny.txt");
            Console.WriteLine("Vítej ve variantě hry Chcete být milionářem zaměřené výhradně na originální Star Wars trilogii!!!");
            Console.Write("""
                               ____ _              _         _       __  _                               
                              / ___| |__   ___ ___| |_ ___  | |__  _/_/_| |_                             
                             | |   | '_ \ / __/ _ \ __/ _ \ | '_ \| | | | __|                            
                             | |___| | | | (_|  __/ ||  __/ | |_) | |_| | |_                             
                              \____|_| |_|\___\___|\__\___| |_.__/ \__, |\__|                            
                                        _ _ _               __  \\//___/              __   _             
                              _ __ ___ (_) (_) ___  _ __   /_/_ _\/_ ___ _ __ ___    / /__| |_ __ _ _ __ 
                             | '_ ` _ \| | | |/ _ \| '_ \ / _` | '__/ _ \ '_ ` _ \  | / __| __/ _` | '__|
                             | | | | | | | | | (_) | | | | (_| | | |  __/ | | | | | | \__ \ || (_| | |   
                             |_| |_| |_|_|_|_|\___/|_| |_|\__,_|_|_ \___|_| |_| |_| | |___/\__\__,_|_|   
                             __      ____ _ _ __ ___    ___  _ __(_) __ _(_)_ __   __\_\ |_ __ (_)       
                             \ \ /\ / / _` | '__/ __|  / _ \| '__| |/ _` | | '_ \ / _` | | '_ \| |       
                              \ V  V / (_| | |  \__ \ | (_) | |  | | (_| | | | | | (_| | | | | | |       
                               \_/\_/ \__,_|_|  |___/  \___/|_|  |_|\__, |_|_| |_|\__,_|_|_| |_|_|       
                              _        _ _             _            |___/_ _        __                   
                             | |_ _ __(_) | ___   __ _(_) ___    ___  __| (_) ___ __\ \                  
                             | __| '__| | |/ _ \ / _` | |/ _ \  / _ \/ _` | |/ __/ _ \ |                 
                             | |_| |  | | | (_) | (_| | |  __/ |  __/ (_| | | (_|  __/ |                 
                              \__|_|  |_|_|\___/ \__, |_|\___|  \___|\__,_|_|\___\___| |                 
                                                 |___/                              /_/     
                           """);
            Console.WriteLine();
            Console.WriteLine($"Pravidla jsou jednoduchá, na každou otázku je pouze jedna správná odpověď, pokud odpovíš špatně hra končí a odnášíš si výhru z posledního správně zodpovězeného kola, pokud odpovíš správně postupuješ do dalšího kola, pokud zodpovíš všechny otázky správně vyhráváš maximum, které je: {vyhraPodleKola[vyhraPodleKola.Count-1]} místní-měny.");
            Console.ReadLine();
            Console.Clear();

            while (beziHra)
            {
                Console.Write($"Otázka číslo {pomocnyIndex + 1}. za {vyhraPodleKola[pomocnyIndex]} {otazkyDoHry[pomocnyIndex]} ");
                string odpoved = Console.ReadLine().ToLower();
                if (odpoved == odpovediDoHry[pomocnyIndex].ToLower())
                {
                    konto = vyhraPodleKola[pomocnyIndex];
                    pomocnyIndex++;
                    if (pomocnyIndex >= otazkyDoHry.Count)
                    {
                        Console.WriteLine($"Gratuluji odnášíš si maximální výhru a tím je {konto} místní-měny!");
                        Console.Write("""
                         _  ___         ___   ___   ___         ___   ___   ___  _   _   _ 
                        / |/ _ \       / _ \ / _ \ / _ \       / _ \ / _ \ / _ \| | | | | |
                        | | | | |     | | | | | | | | | |     | | | | | | | | | | | | | | |
                        | | |_| |  _  | |_| | |_| | |_| |  _  | |_| | |_| | |_| |_| |_| |_|
                        |_|\___/  (_)  \___/ \___/ \___/  (_)  \___/ \___/ \___/(_) (_) (_)
                                                               
                        """);
                        break;
                    }
                    Console.WriteLine($"Výborně možnost {odpovediDoHry[pomocnyIndex-1]} byla správnou odpovědí na {pomocnyIndex + 1}. otázku, odnášíš si: {konto} místní-měny");
                    Console.WriteLine("Stiskněte Enter pro zobrzení další otázku");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Bohužel možnost {odpoved} nebyla správnou odpovědí na {pomocnyIndex + 1}. otázku, správná odpověď byla {odpovediDoHry[pomocnyIndex]}, odnášíš si: {konto} místní-měny");
                    break;
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
    
