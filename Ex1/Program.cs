using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual número é maior? - Descobridor mágico (Não pode ser números iguais!) ");
            Console.WriteLine("------------------------");
           
        
        float valor1;
        float valor2;
            Console.WriteLine("Digite um número");
            valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite outro número");
            valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

        if (valor1 > valor2){
            Console.WriteLine("O maior número é:");
            Console.WriteLine(valor1);

        }
        else if (valor1 < valor2){
            Console.WriteLine("O maior número é:");
            Console.WriteLine(valor2);
        }
        }
    }
}
