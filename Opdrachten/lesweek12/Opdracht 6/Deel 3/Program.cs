using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Deel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw figuur in Cirkel/Vierkant/Rechthoek/Trapezium/Parrallelogram");
            string type = Console.ReadLine();
            Vorm obj = CreateVorm.getobject(type);
            Console.WriteLine(obj.Teken());
            Console.ReadLine();
        }
    }
    public class CreateVorm{
        public static Vorm getobject(string typeofobj){
            Vorm obj = null;
            if(typeofobj.ToLower()=="cirkel"){
                obj = new Cirkel();
            }else if (typeofobj.ToLower()=="vierkant"){
                obj = new Vierkant();
            }else if (typeofobj.ToLower()=="rechthoek"){   
                obj = new Rechthoek();
            }else if (typeofobj.ToLower()=="trapezium"){   
                obj = new Trapezium();
            }else{
                obj = new Parrallelogram();
            }
            return obj;
        }
    }
   public interface Vorm{
        string Teken();
    }

    class Cirkel: Vorm{
        public virtual string Teken(){
            return "Dit is een cirkel";
            
        }
    }
    class Vierkant: Vorm{
        public virtual string Teken(){
            return "Dit is een vierkant";
        }
    }
    class Rechthoek: Vorm{
        public virtual string Teken(){
            return "Dit is een rechthoek";
        }
    }
     class Trapezium: Vorm{
        public virtual string Teken(){
            return "Dit is een trapezium";
        }
    }
     class Parrallelogram: Vorm{
        public virtual string Teken(){
            return "Dit is een parrallelogram";
        }
    }
    
}
