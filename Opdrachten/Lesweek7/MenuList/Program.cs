using System;
using System.Collections.Generic;

namespace MenuList
{
    class Program
    {
      static void Main(string[] args)
        {
            //Basis classe is Menuitem, Product en Valuta zijn subclasses
            // Voor de order op mijn list zou ik Linq voor gebruiken met OrderBy
            Console.WriteLine("Basis classe is Menuitem, Product en Valuta zijn subclasses ");
            Console.WriteLine("Voor de order op mijn list zou ik Linq voor gebruiken met OrderBy");
            Console.WriteLine("");
            Console.WriteLine("De menulijst");
           List<string> Menulist = new List<string>();
           Product Product1 = new Product();
            Product1.ProductName = "Cola";
            Product1.ProductType = "Drinken";
            Product1.ProductIngrdiënten ="cola";
            Valuta valutaProduct1 = new Valuta();
            valutaProduct1.ProductWaarde = 1.0;
            Menuitem menuitem1 = new Menuitem();
            menuitem1.Product = Product1.productToString();
            menuitem1.Prijs = valutaProduct1.valutaToString();

            Product Product2 = new Product("sprite","Drinken","sprite");
            Valuta valutaProduct2 = new Valuta(1.0);
            Menuitem menuitem2 = new Menuitem(Product2.productToString(),valutaProduct2.valutaToString());

            Product Product3 = new Product("Frieten met bolletjes in de tomatensaus", "Eten", "Tomatensaus, frieten, gehakt");
            Valuta valutaProduct3 = new Valuta(5.0);
            Menuitem menuitem3 = new Menuitem(Product3.productToString(),valutaProduct3.valutaToString());

            Product Product4 = new Product();
            Product4.ProductName = "Visschotel";
            Product4.ProductType = "Eten";
            Product4.ProductIngrdiënten ="Vis van de dag, zalm, kabeljouw, baars, inktvis";
            Valuta valutaProduct4 = new Valuta();
            valutaProduct4.ProductWaarde = 5.0;
            Menuitem menuitem4 = new Menuitem();
            menuitem4.Product = Product4.productToString();
            menuitem4.Prijs = valutaProduct4.valutaToString();

            Product Product5 = new Product("Wijn", "Drinken", "Druiven, alcohol");
            Valuta valutaProduct5 = new Valuta(3.0);
            Menuitem menuitem5 = new Menuitem(Product5.productToString(), valutaProduct5.valutaToString());
            

            Product Product6 = new Product("Karaf Wijn 1L", "Drinken", "Druiven, alcohol");
            Valuta valutaProduct6 = new Valuta(15.0);
            Menuitem menuitem6 = new Menuitem(Product6.productToString(), valutaProduct6.valutaToString());
           
            Product Product7 = new Product("Plat water", "Drinken", "water");
            Valuta valutaProduct7 = new Valuta(2.0);
            Menuitem menuitem7 = new Menuitem(Product7.productToString(), valutaProduct7.valutaToString());
             

            Product Product8 = new Product("Bruis water", "Drinken", "water");
            Valuta valutaProduct8 = new Valuta(2.0);
            Menuitem menuitem8 = new Menuitem(Product8.productToString(), valutaProduct8.valutaToString());
             

            Product Product9 = new Product("Soep van de dag", "Drinken/eten", "water, ingrediënten van de dag");
            Valuta valutaProduct9 = new Valuta(4.0);
            Menuitem menuitem9 = new Menuitem(Product9.productToString(), valutaProduct9.valutaToString());
             

            Product Product10 = new Product("Ijs van de dag", "Eten", "Suiker, melk, smaakstoffen, etherische oliën");
            Valuta valutaProduct10 = new Valuta(2.0);
            Menuitem menuitem10 = new Menuitem(Product10.productToString(), valutaProduct10.valutaToString());
             

          
           for(int run = 0; run<1; run++){
               Menulist.Add(menuitem1.ToString());
               Menulist.Add(menuitem2.ToString());
               Menulist.Add(menuitem3.ToString());
               Menulist.Add(menuitem4.ToString());
               Menulist.Add(menuitem5.ToString());
               Menulist.Add(menuitem6.ToString());
               Menulist.Add(menuitem7.ToString());
               Menulist.Add(menuitem8.ToString());
               Menulist.Add(menuitem9.ToString());
               Menulist.Add(menuitem10.ToString());
           }
            foreach(var item in Menulist) {
                Console.WriteLine(item);
            }        
        }
        
        
         
       
        
      
       
    }
}
