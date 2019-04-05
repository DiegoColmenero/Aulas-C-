using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um número de 0, a 9 para imprimir o triângulo");
                string estrela = "%";
                int triangulo = int.Parse(Console.ReadLine());

                for  (int i = 1; i < triangulo; i++)
                {
                   Console.WriteLine(estrela = estrela+"%");

                    
               
                }
        }
    }
}
