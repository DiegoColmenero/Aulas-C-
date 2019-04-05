using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Escolha um número para descobrir a tabuada");
            int num = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(500);
            Console.Write("Processando");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
                
                while(cont <=10){
                    
                   
                }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Você gostaria de outra tabuada?");
           int conta = 0;
           
            while (conta <= 10){
                
            Console.WriteLine("Escolha um número para descobrir a tabuada");
            int nume = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(500);
            Console.Write("Processando");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
            Console.WriteLine(nume+"x"+conta+"="+nume * conta);
            conta ++;

            }
                  
                 
            
        }
    }
}
