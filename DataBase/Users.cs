using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.DataBase
{
  public class Users
  {
    public List<User> users = new List<User> 
    {
      new User { Id = 1, Email="sandy@gmail.com", PhoneNumber = "7894561235", Gender = 0, Name="Sandeep", Password="Pass@123$", UserName="sandy", hobbies = [] }
    };
  }
}
