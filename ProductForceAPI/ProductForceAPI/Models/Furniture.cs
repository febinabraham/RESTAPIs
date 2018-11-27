using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductForceAPI.Common;

namespace ProductForceAPI.Models
{
  public class Furniture : Product
  {
    public Furniture(decimal? price, string description, string furnitureName, DateTime manufactureDate) :
      base(furnitureName, price, description, null, manufactureDate, Category.Furnishing)
    {

    }
    public override void DisplayProduct()
    {
      Console.WriteLine($"Product Name : {this.ProductName} \n Price: {this.Price} \n Man Date: {this.ManufacturedDate:yyyy-MM-dd}");
    }
  }
}