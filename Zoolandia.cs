using System;
using Zoolandia.Animals;
using Zoolandia.Habitats;
using Zoolandia.Buildings;
using System.Collections.Generic;

namespace Zoolandia
{ 
  class Zoolandia
  {
    static void Main(string[] args)
    {
      // Create an savanna habitat and 
      Savanna savanna = new Savanna();
      savanna.inhabitants = new List<Animal>();
      savanna.name = "African Grasslands";

      // Create an aquarium habitat
      Aquarium aquarium = new Aquarium();
      aquarium.name = "Coral Reef";

      // Create a pool habitat
      Pool sealPool = new Pool();
      sealPool.name = "California Coast";

      // Create a snake pit habitat
      ReptileHouse snakePit = new ReptileHouse();
      snakePit.name = "Snake Pit";

      // Create an aviary habitat
      Aviary aviary = new Aviary();
      aviary.name = "Tropical Canopy";

      // Create the Zoo and add all the habitats to it
      Zoo zoolandia = new Zoo();
      zoolandia.habitats.Add(aviary);
      zoolandia.habitats.Add(savanna);
      zoolandia.habitats.Add(aquarium);
      zoolandia.habitats.Add(sealPool);
      zoolandia.habitats.Add(snakePit);

      // Create some animals
      Mantis manny = new Mantis();
      manny.name = "Manny";
      manny.species = new TenoderaAngustipennis();

      Mantis danny = new Mantis();
      danny.name = "Danny";
      danny.species = new TenoderaSinensis();

      FlyingSquirrel scrat = new FlyingSquirrel();
      scrat.name = "Scrat";
      scrat.species = new Pteromyini();
      scrat.airSpeed = 4;
      // scrat.fly();

      // Add the sample animals to the savanna habitat
      savanna.inhabitants.Add(manny);
      savanna.inhabitants.Add(danny);
      savanna.inhabitants.Add(scrat);

      // Output the habitats in our Zoo
      Console.WriteLine($"\nHabitats in `{zoolandia.marketingReport()}`\n===================================");
      foreach(Habitat habitat in zoolandia.habitats)
      {
        Console.WriteLine($"{habitat.name}");
      }

      // Iterate over the inhabitants of the savanna habitat and output 
      // info to the console
      foreach (Animal a in savanna.inhabitants)
      {
        Console.WriteLine($@"
{a.name} the {a.species.commonName} in the genus {a.species.genus.scientificName}.
To find out more visit {a.species.url}.");
      }
    }
  }
}


