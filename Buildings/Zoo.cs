using System.Collections.Generic;
using Zoolandia.Habitats;

namespace Zoolandia.Buildings
{
  public class Zoo
  {
    private string _name = "Zoolandia";
    
    public List<Habitat> habitats = new List<Habitat>();
    
    public string marketingReport ()
    {
      return "The amazing " + _name;
    }
  }
}
