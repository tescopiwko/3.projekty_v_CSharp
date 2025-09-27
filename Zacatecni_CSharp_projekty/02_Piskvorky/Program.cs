using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _02_Piskvorky
{
    internal class Program
    {
        static string[] mrizka;

        static void Main(string[] args)
        {
            mrizka = new string[9] {"1", "2", "3","4","5","6","7","8","9" }; 
            //Console.WriteLine(mrizka[1]);

            VytvoritMrizku();
            bool hraPokracuje = true;
            
            while (hraPokracuje)
            {
                tahHrace("X");
                if (kontrolaVyhry("X"))
                {
                    Console.WriteLine("Vyhrál hráč X!");
                    break;
                }
                tahHrace("O");
                if (kontrolaVyhry("O"))
                {
                    Console.WriteLine("Vyhrál hráč O!");
                    break;
                }
                kontrolaVyhry("O");
            }
            
            //if (vyberHracX == mrizka[0])
            //    mrizka[0] = symbolX;
            //    VytvoritMrizku();

     
            
        }
        static bool kontrolaVyhry(string hrac)
        {       //kontrola vodorovně
            if ((mrizka[0]== hrac && mrizka[1] == hrac && mrizka[2]== hrac) || 
                (mrizka[3]== hrac && mrizka[4] == hrac && mrizka[5]== hrac) || 
                (mrizka[6]== hrac && mrizka[7] == hrac && mrizka[8]== hrac) || 
                //kontrola svisle
                (mrizka[0]== hrac && mrizka[3] == hrac && mrizka[6]== hrac) ||
                (mrizka[1]== hrac && mrizka[4] == hrac && mrizka[7]== hrac) ||
                (mrizka[2]== hrac && mrizka[5] == hrac && mrizka[8]== hrac) ||
                //kontrola diagonálně
                (mrizka[0]== hrac && mrizka[4]== hrac && mrizka[8]== hrac) ||
                (mrizka[2]== hrac && mrizka[4]== hrac && mrizka[6]==hrac))
            {
                return true;
            }
            return false;
        }
        static void tahHrace(string hrac)
        {
            Console.Write($"Tah hráče {hrac}: ");
            string vyberHracX = Console.ReadLine();
            for (int k = 0; k < mrizka.Length; k++)
            {
                if (vyberHracX == mrizka[k])
                {
                    mrizka[k] = hrac;
                    VytvoritMrizku();
                }

            }
        }

        static void VytvoritMrizku() // void = funkce nic nevrací
        {
            for (int i = 0; i < 3; i++) //POZNAMKA: vice pracovat s indexy
            {
                for (int j = 0; j < 3; j++) // trikrat (j) pro kazde (i) ktere se vykona trikrat
                {
                    Console.Write(mrizka[i * 3 + j] + "|"); // logika: kdyz i == 0 a j == 0 = POČÍTACÍ OKENKO:(0*3+0 = 0) -> mrizka[0] = --"1"--, kdyz i == 0 a j == 1 = POČÍTACÍ OKENKO:(0*3+1 = 1) mrizka[1] = --"2"--
                }
                Console.WriteLine();
                Console.WriteLine("------");
            }
        }
    }
}
