using System;

namespace TreehouseDefense
{
  class Game
  {
    public static void Main()
    {
      Map map = new Map(8, 5);

      try
      {
        MapLocation maplocation = new MapLocation(20, 20, map);
      }
      //pass the exception message from the MapLocation class, typically passed through as a paramter called ex
      //Order of catch expressions are important, from specifc to more general
      catch(OutofBoundsException)
      {
        Console.WriteLine(ex.Message);
      }
      catch(TreehouseDefenseException)
      {
        Console.WriteLine("Unhandled TreehouseDefenseException")
      }
      catch(Exception)
      {
        Console.WriteLine("Unhandled Exception")
      }
    }
  }
}
