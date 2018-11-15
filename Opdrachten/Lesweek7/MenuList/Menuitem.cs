using System;
using System.Collections.Generic;

namespace MenuList
{
    class Menuitem
    {
         private string product;
         private string prijs;
        private double productWaarde;
        private string productName;
        private string productType;
        private string productIngrdiënten;

        public string Prijs{get;set;}
        public string Product{get;set;}

         public string ProductName{get;set;}
        public string ProductType{get;set;}
        public string ProductIngrdiënten{get;set;}
        public double ProductWaarde;

        public Menuitem(string product, string prijs){
        //Laadvermogen = laadvermogen;
        Product = product;
        Prijs = prijs;
    }
        public Menuitem(){

        }

        
       public string ToString(){
       return "Het product: "+ this.Product +" "+ this.Prijs;
         }
         public string productToString(){
       return this.ProductName + " met type " + this.ProductType + " " +this.ProductIngrdiënten +" en";
         }
         public string valutaToString(){
       return  String.Format("Kostprijs: €{0:N2}", this.ProductWaarde);

         }
    }
}
