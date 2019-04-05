using System;

namespace Previsao
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Insira a previsão do tempo, e lhe direi o que fazer");
            string clima = Console.ReadLine().ToLower();

            if (clima.Equals("frio")){
                Console.WriteLine("Vamos a montanha");
            }
            else if (clima.Equals("calor")){
                Console.WriteLine("Vamos a praia");
            }
            else if (clima.Equals("chuva"))
            {
                Console.WriteLine("Vamos para Steam?");
                string resposta = Console.ReadLine();
                    if (resposta.Equals("nao"))
                    Console.WriteLine("Vamos para a Netflix");
                    {
                    
                    } 
            }
        }            
    }
}
