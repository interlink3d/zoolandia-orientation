namespace Zoolandia.Habitats
{
  public interface IAquatic
  {
    bool isFreshwater { get; set; }
    double waterTemperature { get; set; }
    string filterType { get; set; }
    string pumpType { get; set; }
  }
}
