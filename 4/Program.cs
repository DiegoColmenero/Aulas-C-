using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pi = "(PI)";
            
            for(int i = 1; i < 101; i++){

                if ((i % 4) == 0){
                    Console.WriteLine(pi);
                }else{
                    Console.WriteLine(i);
                }
                    
                
            }    

        
        
        }
    }
}
