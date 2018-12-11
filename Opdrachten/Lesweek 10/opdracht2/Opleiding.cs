namespace opdracht2{
     public class Opleiding:IInformatie{

         string GetWifiCode(){
             return "code";
         }
         public string Campus{get;set;}
         public string Opleidingsnaam{get;set;}
         private string afkortingCampus;
         protected int campusNummer;

         public string ToString(){
             return string.Format("campus (0) - campusnummer",this.Campus, this.campusNummer);
         }
         public Opleiding(){
             this.afkortingCampus = this.Campus.Substring(0,3);
         }

    }
}
