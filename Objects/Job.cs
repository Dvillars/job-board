using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class Job
  {
    private string _name;
    private string _description;
    private string _contact;
    private static List<Job> _instances = new List<Job> {};
    private static int _counter = 0;

    public Job(string name, string description, string contact)
    {
      _name = name;
      _description = description;
      _contact = contact;
      _instances.Add(this);
      _counter++;
    }

    public string GetName ()
    {
      return _name;
    }

    public string GetDesc()
    {
      return _description;
    }

    public string GetContact()
    {
      return _contact;
    }

    public static List<Job> JobList()
    {
      return _instances;
    }
    public static int GetCounter()
    {
      return _counter;
    }
  }

}
