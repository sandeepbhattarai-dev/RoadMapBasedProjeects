using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Services
{
  public class AuthService : IAuthService
  {
    private User? _user;
    // Login: Checks if user exists, sets current user, returns true/false
    public bool IsLoggedin(string uname)
    {

      return _user != null && _user.UserName == uname;
    }

    public void Login(User user)
    {
      _user = user;

    }
    public void Logout()
    {
      _user = null;
    }

  }
}
