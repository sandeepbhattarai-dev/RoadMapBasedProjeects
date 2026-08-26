using RoadMapBasedProjects.DataBase;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Services
{
  public class CurrentUser
  {
    private readonly List<User> _users;
    public CurrentUser(Usertbl usertbl)
    {
      _users = usertbl._users;
    }

    string loggedInUser = string.Empty;

    public bool IsLoggedIn(string userName)
    {
      return userName.Equals(loggedInUser);
    }


    public bool Login(string username)
    {
      if (!IsLoggedIn(username))
      {
        if (GetUserByUsername(username) != null)
        {
          loggedInUser = GetUserByUsername(username);
          return true;
        }
      }
      return false;
    }

    public string GetUserByUsername(string username)
    {
      foreach (var item in _users)
      {
        if (item.UserName == username) return item.UserName;
      }
      return string.Empty;
    }

    public bool currentuser()
    {
      return !string.IsNullOrEmpty(loggedInUser);
    }

    public string whoami()
    {
      return loggedInUser;
    }


    public bool logout()
    {
      loggedInUser = string.Empty;
      if (string.IsNullOrEmpty(loggedInUser))
      {
        return true;
      }
      return false;
    }
  }
}
