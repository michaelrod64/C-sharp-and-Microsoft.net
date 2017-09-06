using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgramming
{
    class Dog : Animal 
    {
        private string breed;
        
        public String Breed {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        public void WagTail()
        {
            Console.WriteLine("Dog wags tail");
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Bark");
        }
    }
}
