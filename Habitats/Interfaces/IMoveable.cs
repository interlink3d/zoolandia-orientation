namespace Zoolandia.Habitats
{
  public interface IMoveable
  {
    string currentLocation { get; set; }
    string destination { get; set; }
    void move(string destination);
  }
}
