using RoadMapBasedProjects.DataBase;
using RoadMapBasedProjects.Models;
namespace RoadMapBasedProjects.Services
{
  public class GetDataFromDb : IGetDataFromDb
  {
    private readonly List<User> _users;
    public GetDataFromDb(Usertbl usertbl)
    {
      _users = usertbl._users;
    }

    public User GetUserById(int Id)
    {
      return _users[Id];
    }
    public bool IsUser(string username)
    {
      foreach (var item in _users)
      {
        if(item.UserName == username)
        {
          return true;
        }
      }
      return false;
    }

    public bool CreateNewUser(Register user)
    {
      if (IsUser(user.UserName))
      {
        return false;
      }
      User newuser = new User()
      {
        Id = NewId(),
        Email = user.Email,
        UserName = user.UserName,
        Password = user.Password,
      };
      _users.Add(newuser);
      return true;
    }

    public int NewId()
    {
      int temp = 0;
      foreach (var item in _users)
      {
        temp = item.Id;
      }
      return temp+11;
    }

    public bool CheckPassword(string password)
    {
      foreach(var item in _users)
      {
        if(password == item.Password) { return true; }
      }
      return false;
    }
      
  }
}
