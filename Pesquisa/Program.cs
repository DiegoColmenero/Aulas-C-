using System;

namespace Pesquisa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pesquisa social");
            int pesquisa = 1;
            int numSexH = 0;
            int numSexM = 0;
            float somaIdadeH=0;
            float somaIdadeM=0;
            float somaPesoH=0;
            float somaPesoM=0;
            while (pesquisa <=10 ){
                Console.WriteLine("Digite o sexo");
                string sexo = Console.ReadLine().ToLower();
                Console.WriteLine("Digite a idade");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o peso");
                int peso = int.Parse(Console.ReadLine());
                Console.WriteLine("=================================");
                pesquisa ++;
            if (sexo.Equals("masculino")){
                numSexH++;
                somaPesoH += peso;
                somaIdadeH += idade;
            }else if(sexo.Equals("feminino")){
                numSexM++;
                somaPesoM += peso;
                somaIdadeM += idade;
            }   
            }
                float idadeH = somaIdadeH / numSexH;
                float idadeM = somaIdadeM /numSexM;
                float pesoH = somaPesoH / numSexH;
                float pesoM = somaPesoM / numSexM;
            Console.WriteLine("A quantidade de homens é : {0}", numSexH);
            Console.WriteLine("A quantidade de mulheres é : {0}", numSexM);
            Console.WriteLine("A média de idade dos homens é : {0}", idadeH);
            Console.WriteLine("A média de idade das mulheres é : {0}", idadeM);
            Console.WriteLine("A média de peso dos homens é : {0}", pesoH);
            Console.WriteLine("A média de peso das mulheres é : {0}", pesoM);
        }
    }
}
