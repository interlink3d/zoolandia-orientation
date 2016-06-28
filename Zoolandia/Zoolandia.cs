﻿using System;
using Zoolandia.Animals;
using Zoolandia.Habitats;
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

      // Create an aquarium habitat
      Aquarium aquarium = new Aquarium();

      // Create an pool habitat
      Pool sealPool = new Pool();

      // Create a snake pit habitat
      ReptileHouse snakePit = new ReptileHouse();

      // Create an aviary habitat
      Aviary aviary = new Aviary();

      // Create some animals
      Mantis manny = new Mantis();
      manny.name = "Manny";
      manny.species = new TenoderaAngustipennis();

      Mantis danny = new Mantis();
      danny.name = "Danny";
      danny.species = new TenoderaSinensis();

      FlyingSquirrel scrat = new FlyingSquirrel();
      scrat.name = "Scrat";
      scrat.species = new TenoderaAngustipennis();

      // Add the sample animals to the savanna habitat
      savanna.inhabitants.Add(manny);
      savanna.inhabitants.Add(danny);
      savanna.inhabitants.Add(scrat);

      // Iterate over the inhabitants of the savanna habitat and output 
      // info to the console
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


