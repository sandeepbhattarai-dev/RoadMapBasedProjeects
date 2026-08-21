using RoadMapBasedProjects.DTOs;

namespace RoadMapBasedProjects.Services
{
  public struct RegistrationResult
  {
    public RegistrationResult(bool success)
    {
      Success = success;
      ErrorMessage = string.Empty;
    }
    public bool Success;
    public string? ErrorMessage;
  }
  public interface IRegistrationService
  {
    public RegistrationResult Register(RegistrationDTO registrationDTO);
  }
}
