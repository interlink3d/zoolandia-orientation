using System;

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

    /*
      Public property that is accessible by other classes but
      can only be read, not manipulated.
     */
    public string name { get; set; }

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
    public url { get; set; }
    public trait { get; set; }
    public scientificName { get; set; }
    public commonName { get; set; }
  }

  class Genus : Taxonomy
  {

  }

  class Species : Taxonomy
  {
    public Genus genus { get; set; }
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
      this.continent = "Asia";
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
      this.continent = "Asia";
      this.scientificName = "Tenodera angustipennis";
      this.commonName = "Japanese Mantis";
    }
  }


  /*
    Genus class
   */
  class Procyon : Animal
  {

  }

  /*
    Species of Procyon
   */
  class ProcyonLotor : Procyon
  {

  }

  /*
    Species of Procyon
   */
  class ProcyonCancrivorus : Procyon
  {

  }

  /*
    Species of Procyon
   */
  class ProcyonPygmaeus : Procyon
  {

  }

  /*
    Species of Procyon
   */
  class ProcyonLotorGloveralleni : Procyon
  {

  }

  /*
    Species of Procyon
   */
  class ProcyonLotorMinor : Procyon
  {

  }

  /*
    Genus class
   */
  class Python : Animal
  {

  }

  /*
    Species of Python
   */
  class PythonCurtus : Python
  {

  }

  /*
    Species of Python
   */
  class PythonBrongersmai : Python
  {

  }

  /*
    Species of Python
   */
  class PythonBreitensteini : Python
  {

  }

  /*
    Species of Python
   */
  class PythonBivittatus : Python
  {

  }

  /*
    Species of Python
   */
  class PythonAnchietae : Python
  {

  }

  /*
    Genus class
   */
  class Loligo : Animal
  {

  }

  /*
    Species of Loligo
   */
  class LoligoForbesii : Loligo
  {

  }

  /*
    Species of Loligo
   */
  class LoligoReynaudii : Loligo
  {

  }

  /*
    Species of Loligo
   */
  class LoligoVulgaris : Loligo
  {

  }

  class Zoolandia
  {
    static void Main(string[] args)
    {
      Animal firstAnimal = new Animal(args[0]);
      firstAnimal.species = "Ostrich";

      Console.WriteLine("{0} the {1}", firstAnimal.name, firstAnimal.species);
    }
  }

}


