namespace Zoolandia.Animals
{
  public class Species : TaxonomyTerm
  {
    private Genus _genus;

    public Genus genus
    {
      get
      {
        return _genus;
      }
      set
      {
        _genus = value;
      }
    }
  }
}
