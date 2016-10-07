using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
  public class Habitat
  {
    public bool hasWalls;
    public bool outside;
    public string climateType;
    public bool isAquatic;
    public double ambientTemperature;
    public double width;
    public double depth;
    public double height;
    public int windowCount;
    public string name;

    public List<Animal> inhabitants;
    public List<Decoration> decorations { get; set; }
  }
}
