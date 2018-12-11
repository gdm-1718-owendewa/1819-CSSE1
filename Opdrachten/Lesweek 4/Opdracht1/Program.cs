using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int f = vermenigvuldig(som(100 , 7) , 3);
            int g = vermenigvuldig(delen(som(406, 7367),69),5);
            int h = verschil(vermenigvuldig(73,41) ,39);
            int i = verschil(vermenigvuldig(7,8) , 19);
            int resultaat = result(f,g,h,i);
            Console.WriteLine(resultaat);


            if(resultaat == 3872){
                Console.WriteLine("Uw resultaat is correct");
            }else if(resultaat < 3872){
                Console.WriteLine("Uw resultaat is te klein");
            }else   {
                Console.WriteLine("Uw resultaat is te groot");
            }

            for(int x = 0; x< 11; x++){
                for(int y = 0; y<11; y++){
                    Console.WriteLine(x+" maal "+y+" is gelijk aan "+ x*y);
                }
            }
        }
        static int som(int a , int b){
            return a + b;
        }
        static int verschil(int a , int b){
            return a-b;
        }
        static int vermenigvuldig(int a , int b){
            return a * b;
        }
        static int delen(int a , int b){
            return a/b;
        }
         static int result(int a , int b, int c, int d){
            return a+b+c+d;
        }
    }
}   
