using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Models
{
    internal class Eagle : Bird
    {  
        public int Speed { get; set; }

        public void Test()
        {
            Console.WriteLine("Eagle test");

        }


        public override void Sound()
        {
            Console.WriteLine("Eagle.sound");   
        }
    }
}
