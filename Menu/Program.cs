using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/MENU/");
            Console.WriteLine("Para abrir o Menu digite 1");
            int menu = int.Parse(Console.ReadLine());

                if (menu == 1){
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Abrindo menu...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("/Login/ - digite 2");
                    Console.WriteLine("/Contatos/ - digite 3");
                    Console.WriteLine("/Listar Comentários/ - digite 4");
                    Console.WriteLine("/Sair/ - digite 9");

                    int resposta = int.Parse(Console.ReadLine());
                    
                    if (resposta == 2){
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Acessando...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Você acessou a aba de Login");
                    }else if (resposta == 3){
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Acessndo...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Você acessou a aba de Contatos");
                    }else if(resposta == 4){
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Acessando...");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Você acessou a aba Listar Comentários");
                    }else if (resposta == 9){
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Acessando..."); 
                        System.Threading.Thread.Sleep(1000);  
                        Console.WriteLine("Você saiu do programa");
                    }else{
                         Console.WriteLine("Essa opção não existe");
                    }
                }else{
                    Console.WriteLine("Essa opção não existe");
                }

        }
    }
}
