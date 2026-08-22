using RoadMapBasedProjects.DTOs;
using RoadMapBasedProjects.Enums;

namespace RoadMapBasedProjects.ViewModel
{
  public class HobbyAndEnumviewModel
  {
    public IEnumerable<string>? HobbyNames { get; set; }
    public Genders[]? Genders { get; set; }

    public RegistrationDTO? Registration { get; set; }
  }
}