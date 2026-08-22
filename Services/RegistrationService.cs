using RoadMapBasedProjects.DataBase;
using RoadMapBasedProjects.DTOs;
using RoadMapBasedProjects.Models;
using System.Xml.Linq;

namespace RoadMapBasedProjects.Services
{
  public class RegistrationService : IRegistrationService
  {
    private readonly UsersTable _db;
    public RegistrationService(UsersTable db)
    {
      _db = db;
    }

    public RegistrationResult Register(RegistrationDTO registrationDTO)
    {
      RegistrationResult result = new RegistrationResult(false);
      if (!string.IsNullOrEmpty(registrationDTO.UserName) && UsernameExist(registrationDTO.UserName))
      {
        result.ErrorMessage = "Username already exists, try something unique";
        return result;
      }


      if(!string.IsNullOrEmpty(registrationDTO.PhoneNumber) && PhoneNumberExist(registrationDTO.PhoneNumber))
      {
        result.ErrorMessage = "Phone Number Already Exist";
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


      _db.users.Add(user);
      return result;
    }

    public bool UsernameExist(string Username)
    {
      foreach (var ind_user in _db.users)
      {
        if(ind_user.UserName == Username){
          return true;
        }
      }

      return false;
    }
    public bool PhoneNumberExist(string PhoneNumber) 
    {
      foreach (var ind_user in _db.users)
      {
        if(ind_user.PhoneNumber == PhoneNumber)
        {
          return true;
        }
      }
      return false; }

    public int GetLast()
    {
      return _db.users.Count();
    }

  }
}
