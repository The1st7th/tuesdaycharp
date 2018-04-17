using System.Collections.Generic;
using System;
namespace Cars.Models
{
  public class Car
  {
    private string _model;
    private int _price;
    private static List<Car> _instances = new List<Car> {};

    public Car (string model, int price)
    {
      _model= model;
      _price = price;
    }

    public void SetModel(string model){
      _model = model;
    }
    public void SetPrice(int price){
      _price = price;
    }
    public string GetModel(){
      return _model;
    }
    public int GetPrice (){
      return _price;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }


}
