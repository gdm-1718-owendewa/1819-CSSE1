using System;

namespace Deel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw figuur in Cirkel/Vierkant/Rechthoek");
            string type = Console.ReadLine();
            Vorm obj = CreateVorm.getobject(type);
            Console.WriteLine(obj.getShape());
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
            }else{   
                obj = new Rechthoek();
            }
            return obj;
        }
    }
   public interface Vorm{
        string getShape();
    }

    class Cirkel: Vorm{
        public virtual string getShape(){
            return "Dit is een cirkel";
        }
    }
    class Vierkant: Vorm{
        public virtual string getShape(){
            return "Dit is een vierkant";
        }
    }
    class Rechthoek: Vorm{
        public virtual string getShape(){
            return "Dit is een rechthoek";
        }
    }
    
}
