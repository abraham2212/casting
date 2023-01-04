using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
    internal class Animal
    {
        public string Name { get; set; }

        public int Speed { get; set; } = 100;
        public Animal()
        {
            Console.WriteLine("Animal sound");
        }


        public  virtual void Sound()



        {
            Console.WriteLine("Animal sound");
        }
    }
}
