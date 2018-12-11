namespace opdracht2{
     public class Gebruiker{
         public string GebruikersNaam{get;set;}
         protected string wachtwoord;

         public virtual string GenereerWachtwoord(){

             return "Gebruiker - wachtwoord";
         }
         public void GenereerGebruikersnaam(){

             this.GebruikersNaam ="test";
         }
         public  Gebruiker(){
             this.wachtwoord = GenereerWachtwoord();
         }
    }
}
