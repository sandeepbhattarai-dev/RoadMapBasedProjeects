using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Data
{
  public class UserRepo : IUserRepo
  {

    public User GetById(int id)
    {
      User? userone = _users.FirstOrDefault(x => x.Id == id);
      return userone;
    }
    private readonly List<User> _users = new()
    {
      new User {Id = 1, Name = "Ron", Descripton = "My name is Ron"}
    };

    public void Create(User user)
    {
      user.Id = _users.Count + 11;
      _users.Add(user);
      
    }

    public bool Delete(User user) 
    {
      bool flag = false;
      if (user != null)
      {
        foreach (var tuser in _users)
        {
          if (tuser.Id == user.Id)
          {
            flag = _users.Remove(tuser);
            return flag;
          }
        }
      }
      return flag; 
    }

    public bool Edit(User user) 
    {
      bool flag = false;
      if (user != null)
      {
        foreach (var item in _users)
        {
          if(item.Id == user.Id)
          {
            item.Name = user.Name;
            item.Descripton = user.Descripton;
            flag = true;
          }
        }

      }
      return flag; 
    }

    public IEnumerable<User> Read() { return _users; }
  }
}
