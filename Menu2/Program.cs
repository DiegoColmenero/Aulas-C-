using System;

namespace Menu2
{
    class Program
    {
        static void Main(string[] args)
        {


            
                Console.WriteLine("BEM VINDO AO MENU");
                Console.WriteLine("Digite seu nome");
                string nome = Console.ReadLine();
                
                
                while (true){
                
                    
                    
                    if (nome == "Diego")
                    {
                        Console.WriteLine("Digite a senha");
                        int senha = int.Parse(Console.ReadLine());
                        if (senha == 123){
                            Console.WriteLine("Bem vindo {0}", nome);
                            Console.WriteLine("Selecione uma opção");
                            Console.WriteLine("2 - Listar contatos");
                            Console.WriteLine("3 - Listar comentários");
                            Console.WriteLine("9 - Sair");
                            int resposta = int.Parse(Console.ReadLine());
                            switch (resposta){
                                case 2:
                                Console.WriteLine("Gabriel - 000000000");
                                Console.WriteLine("Lucas - 999999999");
                                Console.WriteLine("Tsuka - 222222222");
                                Console.WriteLine("César - 555555555");
                                break;
                            }
                            
                        }else{
                            Console.WriteLine("Senha errada");
                        }
                        
                    }else{
                        Console.WriteLine("Usuário inexistente");
                    }
                

            
             }
            } 
        }
    }

