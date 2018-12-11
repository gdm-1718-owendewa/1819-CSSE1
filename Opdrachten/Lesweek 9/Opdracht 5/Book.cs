using System;

namespace Opdracht_5
{
    class Book
    {
        private string bookName;
        private Author auteur;
        private double price;
        private int qtyInStock;

        public string BookName{get;set;}
        public Author Auteur{get;set;}
        public double Price{get;set;}
        public int QtyInStock{get;set;}
        public Book(string bookName, Author auteur, double price, int qtyInStock){

            BookName = bookName;
            Auteur = auteur;
            Price = price;
            QtyInStock = qtyInStock; 
        }
        public Book(){
            
        }
        public string Print(){
            return "Titel: " + this.BookName +" Auteur: "+ this.Auteur.getAuthorName()+" Prijs: "+ this.Price+" Aantal in stock: "+ this.QtyInStock;
        }
        public string getName(){
            return "Titel: "+this.BookName;
        }
        public string getAuthor(){
            return "Auteur: "+this.Auteur.auteurToString();
        }
        public double setPrice(double prijs){
            return this.Price = prijs;
        }
            public double getPrice(){
            return this.Price;
        }
        public int getQtyInStock(){
            return this.QtyInStock;
        }
        public int setQtyInStock(int quantity){
            return this.QtyInStock = quantity;
        }
    }
}