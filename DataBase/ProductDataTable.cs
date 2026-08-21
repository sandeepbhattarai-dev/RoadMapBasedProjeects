using RoadMapBasedProjects.Models;


namespace RoadMapBasedProjects.Data
{
  public class ProductDataTable
  {
    List<Product> products = new List<Product>
    {
      new Product
      {
          Id = 1,
          Name = "Laptop",
          Category = "Electronics",
          Price = 65000,
          Stock = 12
      },
      new Product
      {
          Id = 2,
          Name = "Smartphone",
          Category = "Electronics",
          Price = 25000,
          Stock = 25
      },
      new Product
      {
          Id = 3,
          Name = "Wireless Headphones",
          Category = "Accessories",
          Price = 3500,
          Stock = 40
      },
      new Product
      {
          Id = 4,
          Name = "Mechanical Keyboard",
          Category = "Accessories",
          Price = 4500,
          Stock = 18
      },
      new Product
      {
          Id = 5,
          Name = "Gaming Mouse",
          Category = "Accessories",
          Price = 1800,
          Stock = 30
      },
      new Product
      {
          Id = 6,
          Name = "Monitor",
          Category = "Electronics",
          Price = 15000,
          Stock = 10
      },
      new Product
      {
          Id = 7,
          Name = "Office Chair",
          Category = "Furniture",
          Price = 8500,
          Stock = 8
      },
      new Product
      {
          Id = 8,
          Name = "Backpack",
          Category = "Bags",
          Price = 2200,
          Stock = 35
      },
      new Product
      {
          Id = 9,
          Name = "USB-C Cable",
          Category = "Accessories",
          Price = 600,
          Stock = 75
      },
      new Product
      {
          Id = 10,
          Name = "External SSD",
          Category = "Storage",
          Price = 7500,
          Stock = 15
      }
};
  }
}