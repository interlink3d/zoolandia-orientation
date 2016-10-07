namespace Zoolandia.Habitats
{
  public class Aviary : Habitat, IMoveable
  {
    public string currentLocation { get; set; }

    public string destination { get; set; }

    public void move(string destination)
    {
      this.destination = destination;
    }
    public Aviary(string location)
    {
      this.currentLocation = location;
    }
    public Aviary()
    {
    }
  }
}
