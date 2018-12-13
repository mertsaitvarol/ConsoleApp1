using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MatrislerdeCarpma
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("1.Matrisin satır sayısını giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            Console.Write("1.Matrisin sutun sayısını giriniz: ");
            int boyut2 = Convert.ToInt32(Console.ReadLine());
            int[,] matrisA = new int[boyut, boyut2];

            //Console.Write("2.Matrisin satır sayısını giriniz: ");
            //int boyut3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Matrisin sutun sayısını giriniz: ");
            int boyut4 = Convert.ToInt32(Console.ReadLine());
            int[,] matrisB = new int[boyut2, boyut4];

            
            int[,] matrisC = new int[boyut, boyut4];

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut2; j++)
                {
                    Console.Write("1.Matrisin degeri giriniz: ");
                    matrisA[i, j] = Convert.ToInt32(Console.ReadLine());


                }
            }

            for (int i = 0; i < boyut2; i++)
            {
                for (int j = 0; j < boyut4; j++)
                {
                    Console.Write("Matris degeri giriniz: ");
                    matrisB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut4; j++)
                {
                    matrisC[i, j] = 0;
                }
            }

            // Çarpma işleminin yapıldığı yer.
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut4; j++)
                {
                    for (int k = 0; k < boyut2; k++)
                    {
                        matrisC[i, j] += matrisA[i ,k] * matrisB[k, j];
                       
                    }
                }
            }
            Console.WriteLine("Çarpma işlemi yapıldı.");

            for(int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut4; j++)
                {
                    Console.Write(matrisC[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}