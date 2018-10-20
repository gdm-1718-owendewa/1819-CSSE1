using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int x = 0; x< 11; x++){
                for(int y = 0; y<11; y++){
                    Console.WriteLine(x+" maal "+y+" is gelijk aan "+ x*y);   
                }
            }
            int start = 0;
            if(start ==0){
                do{
                    start++;
                }while(start<10);
                Console.WriteLine(start+ " Dit is de waarde van de start variabele");
            }else{
                Console.WriteLine(" De start waarde moet 0 zijn om te beginnen uw start waarde is "+ start);
            }
        }
    }
}
