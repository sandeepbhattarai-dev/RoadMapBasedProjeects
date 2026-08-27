using RoadMapBasedProjects.Models;
using System.Text.Json;

namespace RoadMapBasedProjects.Services
{
  public class ReadFromFileService
  {
    private readonly string _filePath = "Data/Producttbl.json";
    public bool FileExist()
    {
      if (File.Exists(_filePath))
      {
        return true;
      }
      return false;
    }

    public List<Product> FileRead()
    {
      if (FileExist())
      {
        string fileContent = File.ReadAllText(_filePath);
        if (!string.IsNullOrEmpty(fileContent))
        {
          List<Product>? products = JsonSerializer.Deserialize<List<Product>>(fileContent);
          return products ?? [];
        }
      }
      return [];
    }


    public bool FileWrite(List<Product> products)
    {
      if (FileExist())
      {
        string filecontent = JsonSerializer.Serialize(products);
        File.WriteAllText(_filePath, filecontent);
        return true;
      }
      return false;
    }

  }
}