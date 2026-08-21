using RoadMapBasedProjects.DTOs;
using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.Services
{
  public class RegistrationService : IRegistrationService, IUserStore
  {
    public RegistrationResult Register(RegistrationDTO registrationDTO)
    {
      RegistrationResult result = new RegistrationResult(false);
      if (UsernameExist())
      {
        result.ErrorMessage = "UserName already Exist, try something unique";
        return result;
      }
      if (PhoneNumberExist())
      {
        result.ErrorMessage = "PhoneNumber already Exist, try something unique";
        return result;
      }

      User user = new User();
      user.Name = registrationDTO.Name;
      user.Gender = registrationDTO.Gender;
      user.UserName = registrationDTO.UserName;
      user.PhoneNumber = registrationDTO.PhoneNumber;
      user.Email = registrationDTO.Email;
      user.Id = GetLast() + 11;
      user.Password = registrationDTO.Password + "$";
      

      
      return result;
    }
  }
}
