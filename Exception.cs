namespace TreehouseDefense
{
  class TreehouseDefenseException : System.Exception
  {
    public TreehouseDefenseException()
    {

    }

    public TreehouseDefenseException(string message) : base(message)
    {

    }
  }

  class OutofBoundsException : TreehouseDefenseException
  {
    public OutofBoundsException()
    {

    }

    public OutofBoundsException(string message) : base(message)
    {

    }
  }
}
