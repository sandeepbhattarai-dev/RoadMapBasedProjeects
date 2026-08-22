using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Services
{
  public interface IAuthService
  {
    public bool IsLoggedin(string uname);
    public void Login(User user);
  }
}
