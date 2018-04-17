using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Cars.Models;

namespace Cars.Controllers
{
    public class CarsController : Controller
    {

        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CarForm()
        {
            return View();
        }
        [HttpPost("/cars")]
        public ActionResult Create()
        {
          Car newCar = new Car (Request.Form["new-car"], int.Parse(Request.Form["new-car-price"]));
          Console.WriteLine(int.Parse(Request.Form["new-car-price"]));
          newCar.Save();
          List<Car> allCars = Car.GetAll();
          return View("Index", allCars);
        }

        [HttpPost("/cars/delete")]
        public ActionResult DeleteAll()
        {
            Car.ClearAll();
            return View();
        }

    }
}
