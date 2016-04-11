using System;
using Zoolandia.Animals;

namespace Zoolandia
{ 
  class Zoolandia
  {
    static void Main(string[] args)
    {
      FlyingSquirrel scrat = new FlyingSquirrel
      {
        name = "Scrat"
      };
      scrat.species = new TenoderaAngustipennis();

      Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.", 
        scrat.name, 
        scrat.species.commonName,
        scrat.species.genus.scientificName,
        scrat.species.url);
    }
  }

}


