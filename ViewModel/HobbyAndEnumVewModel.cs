using RoadMapBasedProjects.DTOs;
using RoadMapBasedProjects.Enums;

namespace RoadMapBasedProjects.ViewModel
{
  public class HobbyAndEnumViewModel
  {
    public IEnumerable<string>? HobbyNames { get; set; }
    public Gender[]? Genders { get; set; }

    public RegistrationDTO? Registration { get; set; }
  }
}