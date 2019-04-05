using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acesso para NASA (ACESSO RESTRITO - APENAS AUTORIZADOS)");
            Console.WriteLine("---------------------------------------------------------------------------");

            int senha;
            System.Threading.Thread.Sleep(750);

            Console.WriteLine("Insira a senha SUPER SECRETA CODIFICADA EXTREMAMENTE COMPLEXA");
            senha = int.Parse(Console.ReadLine());
            System.Threading.Thread.Sleep(750);
            if (senha == 1234){
                Console.Write("Verificando acesso");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else {
            
                Console.Write("Verificando acesso");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("ACESSO NEGADO, VOCÊ ESTÁ PRESO!");
            }
        }
    }
}
