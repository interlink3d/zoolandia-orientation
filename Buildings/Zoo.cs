using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Habitats;

namespace Zoolandia.Buildings
{
  class Zoo
  {
    private string _name = "Zoolandia";
    
    public List<Habitat> habitats = new List<Habitat>();
    
    public string marketingReport ()
    {
      return "The amazing " + _name;
    }
  }
}
