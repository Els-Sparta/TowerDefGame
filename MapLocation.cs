namespace TreehouseDefense
{
  // the colon, shows that the MapLocation is a subclass of the Point class
  class MapLocation : Point
  {
    //Also needs a constructor and call the same parameters as the points class, in this case. This is done using base(x, y) base : parent class
    public MapLocation(int x, int y, Map map) : base(x,y)
    {
      if (!map.OnMap(this))
      {
        throw new OutofBoundsException(x + "," + y + " is outside the boundaries of the map.");
      }
    }
  }
}
