using System;
using Zoolandia.Animals;
using System.Collections.Generic;

namespace Zoolandia
{ 
  class Zoolandia
  {
    static void Main(string[] args)
    {
      Savanna savanna = new Savanna();
      savanna.inhabitants = new List<Animal>();


      Aquarium aquarium = new Aquarium();

      Pool sealPool = new Pool();


      ReptileHouse snakePit = new ReptileHouse();


      Aviary aviary = new Aviary();


      Mantis manny = new Mantis();
      manny.name = "Manny";
      manny.species = new TenoderaAngustipennis();

      Mantis danny = new Mantis();
      danny.name = "Danny";
      danny.species = new TenoderaSinensis();

      FlyingSquirrel scrat = new FlyingSquirrel();
      scrat.name = "Scrat";
      scrat.species = new TenoderaAngustipennis();


      savanna.inhabitants.Add(manny);
      savanna.inhabitants.Add(danny);
      savanna.inhabitants.Add(scrat);

      foreach (Animal a in savanna.inhabitants)
      {
        Console.WriteLine("{0} the {1} in the genus {2}. To find out more visit {3}.",
          a.name,
          a.species.commonName,
          a.species.genus.scientificName,
          a.species.url);
      }


    }
  }

}


