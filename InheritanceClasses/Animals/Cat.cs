using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
   public class Cat : Animals
   {
        
        public Cat()
        {
            Console.WriteLine("This is a cat Constructor.");
            IsMammal = true;DietType = DietType.Carnivore;
        }
        public bool IsEvil { get; set; }
        public int HowManyWhiskers { get; set; }
        public string Color { get; set; }
        public string HairLength { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Meow"); 
        }

        public override void Move ()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly!.");
        }
   }
    public class Liger : Cat
    {

        public Liger()
        {
            Console.WriteLine("theis is the Liger Constructor.");
        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey.");
            base.Move();
        }
        public override void MakeSound()
        {
           Console.WriteLine("Roar");
        
        }


    }

    public class Lion : Cat
    {
        public Lion()
        {
            Console.WriteLine("This is a Lion Contsructor");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Twinkle Toes");
        }
    }
}
