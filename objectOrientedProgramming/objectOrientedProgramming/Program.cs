using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOrientedProgramming
{
    class Animal
    {
        private string type;
        private double weight;
        private string color;

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise");
        }

        public void Move()
        {
            Console.WriteLine("Animal is moving");
        }
    }
}
