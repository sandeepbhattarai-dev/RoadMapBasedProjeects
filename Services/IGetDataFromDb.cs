using RoadMapBasedProjects.Models;
namespace RoadMapBasedProjects.Services
{
  public interface IGetDataFromDb{
    public User GetUserById(int Id);
    public bool IsUser(string username);
    public bool CreateNewUser(Register user);
    public int NewId();
    public bool CheckPassword(string password);
  }
}