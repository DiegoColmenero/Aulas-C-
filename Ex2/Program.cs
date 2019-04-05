using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eu ja posso votar?");
            Console.WriteLine("---------------------------------------------------------------------------");
            
            int nascimento;
            int ano;
            int conta;
            


            Console.WriteLine("Insira seu ano de nascimento e vamos descobrir se você já pode votar:");
            nascimento = int.Parse(Console.ReadLine()); 

            Console.WriteLine("---------------------------------------------------------------------------");

            Console.WriteLine("Agora insira o ano em que estamos");
            ano = int.Parse(Console.ReadLine());
            
            conta = ano - nascimento;
            
            if (conta < 18){
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Ainda não meu caro! Mas logo poderá!");
            }
            else if (conta > 18)
            {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("O país depende do seu voto! Pode votar!");
            }
        }
    }
}
