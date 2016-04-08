using System;
using System.Collections.Generic.List;

class Animal
{
  /*
    Private class variable section
   */
  private string _name = "";
  private string _food = "";

  /*
    Public properties section
   */
  public string species { get; set; }

  public string name
  {
    get
    {
      return _name;
    }
  }

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

  /*
    Public methods section
   */

  /*
    By marking this method as virtual, you are explicitly
    allowing any derived class to override, or extend, the
    functionality defined in this method.
   */
  public virtual void eat(string food)
  {
    _food = food;
    Console.Write("Currently eating {0}", food);
  }

}

class Firefox : Animal
{
  public double furThickness { get; set; }
  public int cutenessLevel { get; set; }

  // Overriding Animal.eat()
  public override void eat(string leaf)
  {
    /*
      By overriding a parent class' implementation of a
      method, you can add more specific behavior and conditions
      to how the method will affect the object.
     */
    if (leaf == "palm" || leaf == "bamboo" || leaf == "eucalyptus" || leaf == "willow")
    {
      food = leaf;
      base.eat(leaf);  // Invoking the logic in Animal.eat()
    } else {
      Console.WriteLine("Firefox can't eat that");
    }
  }

}
