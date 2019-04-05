using System;

namespace Dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jaAcordei = false;

            do{
                System.Console.WriteLine("Pai você já acordou?");
                string resposta = Console.ReadLine();

                jaAcordei = resposta.Contains("tio") ? true : false;
            }while (!jaAcordei);

            
        }
    }
}
