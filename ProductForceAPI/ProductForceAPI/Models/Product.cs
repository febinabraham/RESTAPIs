using ProductForceAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductForceAPI.Models
{
  public abstract class Product
  {
    public string ProductName { get; set; }
    public decimal? Price { get; set; }
    public string Description { get; set; }
    public DateTime? UseBy { get; set; }
    public DateTime ManufacturedDate { get; set; }
    public Category Category { get; set; }

    protected Product(string name, decimal? price, string description, DateTime? useBy, DateTime manDate, Category cat)
    {
      this.ProductName = name;
      this.Price = price;
      this.Description = description;
      this.UseBy = useBy;
      this.ManufacturedDate = manDate;
      this.Category = cat;
    }

    public abstract void DisplayProduct();
  }


}