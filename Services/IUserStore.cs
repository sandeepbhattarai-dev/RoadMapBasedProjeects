namespace RoadMapBasedProjects.Services
{
  public interface IUserStore
  {
    public bool UsernameExist(string Username);
    public bool PhoneNumberExist(string PhoneNumber);
  }
}
