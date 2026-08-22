using RoadMapBasedProjects.DataBase;

namespace RoadMapBasedProjects.Services
{
  public class GetHobbies : IGetHobbies
  {
    private readonly HobbiesTable _dbhb;
    public GetHobbies(HobbiesTable dbhb)
    {
      _dbhb = dbhb;
    }
    public IEnumerable<string> GetAllHobbies()
    {
      //var item = HobbiesTable.hobbies;
      //IEnumerable<string> names = HobbiesTable.hobbies.Select(item => item.Name != null ? item.Name : "");
      return _dbhb.hobbies.Select(item => item.Name != null ? item.Name : "");
    }
  }
}
