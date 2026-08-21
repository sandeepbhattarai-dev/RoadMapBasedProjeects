using RoadMapBasedProjects.DataBase;

namespace RoadMapBasedProjects.Services
{
  public class GetHobbies : IGetHobbies
  {
    public IEnumerable<string> GetAllHobbies()
    {
      //var item = HobbiesTable.hobbies;
      //IEnumerable<string> names = HobbiesTable.hobbies.Select(item => item.Name != null ? item.Name : "");
      return HobbiesTable.hobbies.Select(item => item.Name != null ? item.Name : "");
    }
  }
}
