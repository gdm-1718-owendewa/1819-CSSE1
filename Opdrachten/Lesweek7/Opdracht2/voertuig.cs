using System;

namespace Opdracht2
{
     class Voertuig
    {      
    private int laadvermogen;
    private string brandstof;
    private string merk;
    private bool motor;
    /* int Laadvermogen{
        get;
        set;
    }*/
    public int Laadvermogen{
        get{return laadvermogen;}
        set{laadvermogen = value;}
    }
    public bool Motor{
        get;
        set;
    }
    public string Kleur{ get; set;}
    public Voertuig(int laadvermogen, string kleur){
        //Laadvermogen = laadvermogen;
        this.laadvermogen = laadvermogen;
        Kleur = kleur;
    }
    public Voertuig(){
    }
   public string ToString(){
       return "Voertuig met laadvermogen "+ this.laadvermogen +" met kleur "+ this.Kleur;
   }
}
    
}
