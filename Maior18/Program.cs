using System;

namespace Maior18
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 1;
            int maiores = 0;
            int menores = 0;
            Console.WriteLine("Maiores de 18");
            while (idade <= 10){
                Console.WriteLine("Digite a idade da pessoa");
                int anos = int.Parse(Console.ReadLine());
                if (anos >= 18){
                  maiores++;
                }else{
                   menores++;
                }
                idade ++; 
        
            }
            Console.WriteLine("A quantidade de pessoas maior de idade é: {0}", maiores);
            

        }
    }
}
