namespace TreehouseDefense
{
  class Invader
  {
    // Using getter and setters are common practics, to ensure noone has complete access over a class. It's also good for future proofing code
    private readonly Path _path;

    private int _pathStep = 0;

    public MapLocation Location => _path.GetLocationAt(_pathStep);

    public Invader(Path path)
    {
      _path = path;
    }
    public void Move() =>  _pathStep += 1;
  }
}
