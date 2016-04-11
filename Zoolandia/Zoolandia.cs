using System;
using Zoolandia.Animals;

namespace Zoolandia
{ 
  class Zoolandia
  {
    static void Main(string[] args)
    {
      Animal firstAnimal = new Animal(args[0]);
      firstAnimal.species = new TenoderaAngustipennis();

      Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.", 
        firstAnimal.name, 
        firstAnimal.species.commonName,
        firstAnimal.species.genus.scientificName,
        firstAnimal.species.url);
    }
  }

}


