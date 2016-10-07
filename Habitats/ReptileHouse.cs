namespace Zoolandia.Habitats
{
  public class ReptileHouse : Habitat, IMoveable
  {
    public string currentLocation { get; set; }

    public string destination { get; set; }

    public void move(string destination)
    {
      this.destination = destination;
    }
    public ReptileHouse(string location)
    {
      this.currentLocation = location;
    }
    public ReptileHouse()
    {
    }
  }
}
