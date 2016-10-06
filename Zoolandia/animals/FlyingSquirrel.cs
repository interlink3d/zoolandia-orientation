using System;

namespace Zoolandia.Animals
{
    class FlyingSquirrel : Animal, IAmbulatory, IFlying
    {
        public double airSpeed { get; set; }

        public double groundSpeed { get; set; }

        public void fly()
        {
            Console.WriteLine($"{this.name} jumps out of a tree and glides at {this.airSpeed} m/s.");
        }

        public void walk()
        {
            Console.WriteLine($"{this.name} bounds along the ground at {this.groundSpeed} m/s.");
        }
    }
}
