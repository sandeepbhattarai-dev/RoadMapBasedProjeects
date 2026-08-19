using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Data
{
  public interface IUserRepo
  {
    User GetById(int id);
    void Create(User user);
    bool Delete(User user);
    bool Edit(User user);
    IEnumerable<User> Read();
  }

}
