using System;

namespace Zoolandia.Habitats
{
  public class Savanna : Habitat, IMoveable
  {
    public string currentLocation { get; set; }

    public string destination { get; set; }

    public void move(string destination)
    {
      this.destination = destination;
    }
  }
}
