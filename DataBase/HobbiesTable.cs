using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.DataBase
{
  public class HobbiesTable
  {
    public List<Hobbies> hobbies = new List<Hobbies>
    {
      new Hobbies {Id = 1, Name = "Reading" },

      new Hobbies{ Id = 2, Name = "Sports" },

      new Hobbies{ Id = 3, Name = "Travel" },

      new Hobbies{ Id = 4, Name = "Gaming" },

      new Hobbies{ Id = 5, Name = "Music" }
    };
  }
}
