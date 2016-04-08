using System;

class Animal
{
  private string _name = "";
  private string _food = "";

  public string species { get; set; }

  public string name {
    get
    {
      return _name;
    }
  }

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

  public virtual void eat(string food) {
    _food = food;
    Console.Write("Currently eating {0}", food);
  }

  public virtual void eat(string food, int count) {
    _food = food;
    Console.Write("Currently eating {0} {1}", count, food);
  }


}

class Firefox : Animal {
  public double furThickness { get; set; }
  public int cutenessLevel { get; set; }

  // Constructor function is responsible for
  // executing initialization code
  public Firefox (int cuteness)
  {
    cutenessLevel = cuteness;
  }

  public Firefox (double thickness)
  {
    furThickness = thickness;
  }

  public Firefox (int cuteness, double thickness)
  {
    cutenessLevel = cuteness;
    furThickness = thickness;
  }


  // Overloaded method
  public override void eat(string leaf)
  {
    if (leaf == "palm" || leaf == "bamboo" || leaf == "eucalyptus" || leaf == "willow")
    {
      food = leaf;
      base.eat(leaf);
    } else {
      Console.WriteLine("Firefox can't eat that");
    }
  }

  // Overloaded method
  public override void eat(string leaf, int count)
  {
    if (count > 9)
    {
      if (leaf == "palm" || leaf == "bamboo" || leaf == "eucalyptus" || leaf == "willow")
      {
        food = leaf;
        base.eat(leaf);
      } else {
        Console.WriteLine("Firefox can't eat that");
      }
    } else {
      Console.WriteLine("Not enough food for Firefox");
    }
  }


}
