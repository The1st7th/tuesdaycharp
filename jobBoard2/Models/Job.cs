using System;
using System.Collections.Generic;
namespace Jobs.Models
{
  public class Job
  {
    private string _title;
    private string _description;
    public static List<Job> _instances = new List<Job>() {};

    public Job (string title, string description)
    {
      _title = title;
      _description = description;
    }
    public string GetTitle(){
      return _title;
    }
    public void SetTitle(string title){
      _title = title;
    }
    public string GetDescription(){
      return _description;
    }
    public void SetDescription(string description){
      _description = description;
    }
    public static List<Job> GetAll(){
      return _instances;
    }
    public void Save(){
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}
