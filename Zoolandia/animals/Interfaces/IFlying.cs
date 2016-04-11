using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    interface IFlying
    {
        void fly();
        double airSpeed { get; set; }
    }
}
