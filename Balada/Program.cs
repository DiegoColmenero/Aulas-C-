using System;

namespace Balada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Confirmação da baladinha na sexta");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Estou disponível na sexta?");
            string disponivel = Console.ReadLine().ToLower();
            if (disponivel.Equals("nao")){
                Console.WriteLine("Sem tempo irmão");
            }
            else if (disponivel.Equals("sim"))

            {
                Console.WriteLine("Tenho 18 anos ou mais? (Insira idade) ");
            float idade;
            idade = float.Parse(Console.ReadLine().ToLower());
            if (idade < 18){
                Console.WriteLine("Vai estudar muleque!");
            }
            else if (idade >= 18)
            {
                 Console.WriteLine("Já paguei a entrada?");
            string paguei = Console.ReadLine().ToLower();
            if(paguei.Equals("nao")){
                Console.WriteLine("Sem dinheiro irmão, esquece");
            }
                else if (paguei.Equals("sim"))
                {
                    Console.WriteLine("Tenho pulseira VIP?");
            string pulseira = Console.ReadLine().ToLower();
            if (pulseira.Equals("nao")){
                Console.WriteLine("Ser pobre é foda, mas bora!");
                }
                else if (pulseira.Equals("sim"))
                {
                    Console.WriteLine("Xama no xesque, SEXTOUU");
                }
                    Console.WriteLine("Irmão se tu quiser ouvir funk fica em casa!");
                }

            }
            
            }
           
            
            
            
        }
    }
}
