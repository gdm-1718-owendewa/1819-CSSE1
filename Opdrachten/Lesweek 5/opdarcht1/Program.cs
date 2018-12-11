using System;

namespace opdarcht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "dit is een test";
            string[] woorden = test.Split(' ');
            foreach(var woord in woorden ){
                Console.WriteLine(woord);
            }
            char[] spatie = {' '};
        }
    }
}
