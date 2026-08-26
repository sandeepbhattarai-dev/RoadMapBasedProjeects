using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.DataBase
{
  public class Usertbl
  {
    public List<User> _users = new List<User>
    {
      new User{Id=1, UserName="admin",Email="admin@gmail.com", Password="Pass@123"}
    };
  }
}
