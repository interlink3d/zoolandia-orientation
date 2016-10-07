using System;

namespace Zoolandia.Animals
{
  public class Animal : IAnimal
  {
    /*
      Private scoped variable that are only accessible within
      the Animal class.
     */
    private string _name = "";
    private string _food = null;
    public Species species { get; set; }


    /*
      Public property that is accessible by other classes but
      can only be read, not manipulated.
     */
    public string name
    {
      get
      {
        return _name;
      }
      set
      {
        if (value != "")
        {
            _name = value;
        }
        
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
    public string food
    {
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


    public void eat()
    {
        if (_food == null)
        {
            Console.WriteLine("No food provided yet");
        }
    }

    public virtual void eat(string food)
    {
        _food = food;
        Console.WriteLine("Currently eating {0}", food);
    }

    public virtual void sleep()
    {
        throw new NotImplementedException();
    }

    public virtual void move()
    {
        throw new NotImplementedException();
    }

    public virtual void reproduce()
    {
        throw new NotImplementedException();
    }

  }
}
