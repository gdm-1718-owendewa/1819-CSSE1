using System;

namespace Lesweek6
{
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
             Menu();  
        }
        static void Menu(){
                List();
                Item();
                ListTwo();

        }
        static void List(){

            var list = new(string,double)[]
            {
            ("platwater",1),
            ("cola 25cl",1.5),
            ("cola 33cl",2),
            ("witte wijn",3),
            ("pils",2),
            ("Toast",5),
            ("Kaasplank",4)
            };
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
  
        }
        static void Item(){
            string[,] array  = new string[7,3]{
                    {"1","platwater","1"},
                    {"2","cola 25cl","1,5"},
                    {"3","cola 33cl","2"},
                    {"4","witte wijn","3"},
                    {"5","pils","2"},
                    {"6","Toast","5"},
                    {"7","Kaasplank","4"},
                };   
                Console.WriteLine("geef uw itemnummer in");
                int item = int.Parse(Console.ReadLine());
                Console.WriteLine("Nummer: "+array[item-1,0]+" Item: "+array[item-1,1]+" Kostprijs: "+array[item-1,2] );
        }
         static void ListTwo(){
             add();
                  
        }  
        static void add(){ 
            Console.WriteLine("geef uw getrokken nummer");
            int nummer = int.Parse(Console.ReadLine());  
            Console.WriteLine("geef uw vraag");
            string boodschap = Console.ReadLine();

            List<string> order = new List<string>();
            order.Add(nummer+" "+boodschap);

            foreach(var item in order){
                Console.WriteLine(item);
            }
        }
}
}

