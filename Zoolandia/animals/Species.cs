using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Species : TaxonomyTerm
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
