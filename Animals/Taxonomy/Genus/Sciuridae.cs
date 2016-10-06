namespace Zoolandia.Animals
{
  public class Sciuridae : Genus
  {

    public int toes { get; set; }

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Squirrel";
      this.trait = "bushy tail";
      this.commonName = "Squirrel";
      this.scientificName = "Sciuridae";
    }

    public Sciuridae()
    {
      this.init();
    }

    public Sciuridae(int toes)
    {
      this.init();
      this.toes = toes;
    }
  }
}
