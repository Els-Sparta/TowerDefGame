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
        Path path = new Path(
          new [] {
            new MapLocation(0, 2, map),
            new MapLocation(1, 2, map),
            new MapLocation(2, 2, map),
            new MapLocation(3, 2, map),
            new MapLocation(4, 2, map),
            new MapLocation(5, 2, map),
            new MapLocation(6, 2, map),
            new MapLocation(7, 2, map)
          }
        );

      }
      //pass the exception message from the MapLocation class, typically passed through as a paramter called ex
      //Order of catch expressions are important, from specifc to more general
      catch(OutofBoundsException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch(TreehouseDefenseException)
      {
        Console.WriteLine("Unhandled TreehouseDefenseException");
      }
      catch(Exception ex)
      {
        Console.WriteLine("Unhandled Exception: " + ex);
      }
    }
  }
}
