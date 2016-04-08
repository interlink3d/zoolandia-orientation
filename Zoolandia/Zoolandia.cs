using System;

namespace Zoolandia
{

  class Animal
  {
    /*
      Private scoped variable that are only accessible within
      the Animal class.
     */
    private string _name = "";
    private string _food = "";
    private Species _species;

    public Species species
    {
      get
      {
        return _species;
      }
      set
      {
        _species = value;
      }
    }


    /*
      Public property that is accessible by other classes but
      can only be read, not manipulated.
     */
    public string name {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }

    /*
      Public property that is accessible by other classes that
      can be read and set, but with some conditional logic that
      checks the value before the private variable is set.

      Animal adam = new Animal();
      adam.food = "Banana";   <-- will compile
      adam.food = "";         <-- will not compile
     */
    public string food {
      get
      {
        return _food;
      }
      set
      {
        if (value != "")
        {
          _food = value;
        }
      }
    }
    
    public Animal (string name)
    {
      _name = name;
    }

    /*
      Your first method on a class.
     */
    public virtual void eat(string food) {
      _food = food;
      Console.WriteLine("Currently eating {0}", food);
    }
  }

  class Taxonomy
  {
    public string url { get; set; }
    public string trait { get; set; }
    public string scientificName { get; set; }
    public string commonName { get; set; }
  }

  class Genus : Taxonomy
  {

  }

  class Species : Taxonomy
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


  /*
    Genus class
   */
  class Tenodera : Genus
  {
    private string _continent;

    public string continent
    {
      get
      {
        return _continent;
      }
      set
      {
        if (value != "")
        {
          _continent = value;
        }
      }
    }

    private void init ()
    {
      this.url = "https://en.wikipedia.org/wiki/Tenodera";
      this.trait = "apical spine";
      this.commonName = "Mantis";
      this.scientificName = "Tenodera";
    }

    public Tenodera () {
      this.init();
    }

    public Tenodera (string continent) {
      this.init();
      this.continent = continent;
    }
  }

  /*
    Species of Tenodera
   */
  class TenoderaSinensis : Species
  {
    public TenoderaSinensis ()
    {
        this.genus = new Tenodera("Asia");
        this.scientificName = "Tenodera sinensis";
        this.commonName = "Chinese Mantis";
    }
  }

  /*
    Species of Tenodera
   */
  class TenoderaAngustipennis : Species
  {
    public TenoderaAngustipennis ()
    {
        this.genus = new Tenodera("Asia");
        this.scientificName = "Tenodera angustipennis";
        this.commonName = "Japanese Mantis";
    }
  }


  class Zoolandia
  {
    static void Main(string[] args)
    {
      Animal firstAnimal = new Animal(args[0]);
      firstAnimal.species = new TenoderaAngustipennis();

      Console.WriteLine("{0} the {1} in the genus {2}", firstAnimal.name, firstAnimal.species.commonName, firstAnimal.species.genus.scientificName);
    }
  }

}


