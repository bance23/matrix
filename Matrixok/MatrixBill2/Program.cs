using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixokfeltoltese
{
    class Matrixok
    {
        public Matrixok()
        {

        }

        public void getMatrixok()
        {
            Console.WriteLine("Szia! Hány sor legyen?");
            int sor = Convert.ToInt32(Console.ReadLine());
            if (sor % 2 == 1 || sor % 2 == 0)
            {

            }
            else
            {
                Console.WriteLine("Nem egész számot adtál meg. Viszlát!");
            }
            Console.WriteLine("Hány oszlop legyen?");
            int oszlop = Convert.ToInt32(Console.ReadLine());
            if (oszlop % 2 == 1 || oszlop % 2 == 0)
            {

            }
            else
            {
                Console.WriteLine("Nem egész számot adtál meg. Viszlát!");
            }

            int[,] array = new int[sor, oszlop];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Írj be egy elemet:");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Sor.keszSor();
            }
            Console.WriteLine("A feltöltés befejeződött.");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
    }
    class Sor : Matrixok
    {
        public Sor()
        {

        }

        public static void keszSor()
        {
            Console.WriteLine("Kész egy sor.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrixok matrixok = new Matrixok();
            matrixok.getMatrixok();

            Console.ReadKey();
        }
    }
}
