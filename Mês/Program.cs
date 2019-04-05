using System;

namespace Mês
{
    class Program
    {
        static void Main(string[] args)
        {
            // int num = 1;
            // while(num != 0){
            
            // Console.WriteLine("Bem vindo ao descobridor do mês, insira o número do mês");
            // Console.WriteLine("----------------------------------------------------------");
            // num = int.Parse(Console.ReadLine());
            // Console.WriteLine("----------------------------------------------------------");

            

            // // switch (num)
            // // {
            // //         case 1:
            // //     Console.WriteLine("É Janeiro meu caro");
            // //     break;
            // //         case 2:
            // //     Console.WriteLine("É Fevereiro meu parça");
            // //     break;
            // //         case 3:
            // //     Console.WriteLine("É Março meu truta");
            // //     break;
            // //         case 4:
            // //     Console.WriteLine("É Abril meu mano");
            // //     break;
            // //         case 5:
            // //     Console.WriteLine("É Maio meu consagrado");
            // //     break;
            // //         case 6:
            // //     Console.WriteLine("É Junho meu lindo");
            // //     break;
            // //         case 7:
            // //     Console.WriteLine("É Julho meu ousado");
            // //     break;
            // //         case 8:
            // //     Console.WriteLine("É Agosto meu chegado");
            // //     break;
            // //         case 9:
            // //     Console.WriteLine("É Setembro meu cheiroso");
            // //     break;
            // //         case 10:
            // //     Console.WriteLine("É Outubro meu gostoso");
            // //     break;
            // //         case 11:
            // //     Console.WriteLine("É Novembro meu companheiro");
            // //     break;
            // //         case 12:
            // //     Console.WriteLine("É Dezembro meu batuta");
            // //     break;
            // //         default:
            // //     Console.WriteLine("Escolha um número entre 1 a 12 seu doido");
            // //     break;

                bool replay = true;
                int cont = 3;

                while(cont >= 1 && replay){
                    System.Console.WriteLine("Você tem mais {0} chance(s), quer continuar?", cont);
                    string resposta = Console.ReadLine().ToLower();
                    replay = resposta.Equals("sim") ? true : false;
                    cont --;
                }
            }
        }
        }
    

