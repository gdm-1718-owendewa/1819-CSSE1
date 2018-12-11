using System;

namespace opdracht2{
     public class Persoon:Gebruiker,IInformatie{
          public string Naam{get;set;}
          private string naam;
          public string Voornaam{get{return this.voornaam;}set{this.voornaam = value;}}
          private string voornaam;
          public readonly string VolledigeNaam;
          public DateTime Geboortedatum{get;}
          public override string GenereerWachtwoord(){
             
             return "Persoon - wachtwoord";
         }
         public int Leeftijd(){
            return 0;
         }
         public string ToString(){
             return " waarde van het object persoon";
         }
    }
}
