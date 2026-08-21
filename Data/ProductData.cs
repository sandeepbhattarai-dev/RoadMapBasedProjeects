using RoadMapBasedProjects.Models;


namespace RoadMapBasedProjects.Data
{
  public class ProductData
  {
    List<Product> products = new List<Product>
    {
      new Product
      {
          Id = 1,
          Name = "Laptop",
          Category = "Electronics",
          Price = 65000,
          Stock = 12
      },
      new Product
      {
          Id = 2,
          Name = "Smartphone",
          Category = "Electronics",
          Price = 25000,
          Stock = 25
      },
      new Product
      {
          Id = 3,
          Name = "Wireless Headphones",
          Category = "Accessories",
          Price = 3500,
          Stock = 40
      },
      new Product
      {
          Id = 4,
          Name = "Mechanical Keyboard",
          Category = "Accessories",
          Price = 4500,
          Stock = 18
      },
      new Product
      {
          Id = 5,
          Name = "Gaming Mouse",
          Category = "Accessories",
          Price = 1800,
          Stock = 30
      },
      new Product
      {
          Id = 6,
          Name = "Monitor",
          Category = "Electronics",
          Price = 15000,
          Stock = 10
      },
      new Product
      {
          Id = 7,
          Name = "Office Chair",
          Category = "Furniture",
          Price = 8500,
          Stock = 8
      },
      new Product
      {
          Id = 8,
          Name = "Backpack",
          Category = "Bags",
          Price = 2200,
          Stock = 35
      },
      new Product
      {
          Id = 9,
          Name = "USB-C Cable",
          Category = "Accessories",
          Price = 600,
          Stock = 75
      },
      new Product
      {
          Id = 10,
          Name = "External SSD",
          Category = "Storage",
          Price = 7500,
          Stock = 15
      }
};
  }

  public class UsersData
  {
    List<User> users = new List<User>
    {
     new User
      {
        Id = 1,
        Name = "Rahul Sharma",
        Password = "Rahul@123",
        UserId = "rahul01",
        Email = "rahul.sharma@example.com",
        PhoneNumber = "9876543210",
        Gender = "Male"
      },

    new User
    {
        Id = 2,
        Name = "Priya Singh",
        Password = "Priya@456",
        UserId = "priya02",
        Email = "priya.singh@example.com",
        PhoneNumber = "9876543211",
        Gender = "Female"
    },

    new User
    {
        Id = 3,
        Name = "Amit Kumar",
        Password = "Amit@789",
        UserId = "amit03",
        Email = "amit.kumar@example.com",
        PhoneNumber = "9876543212",
        Gender = "Male"
    },

    new User
    {
        Id = 4,
        Name = "Sneha Das",
        Password = "Sneha@321",
        UserId = "sneha04",
        Email = "sneha.das@example.com",
        PhoneNumber = "9876543213",
        Gender = "Female"
    },

    new User
    {
        Id = 5,
        Name = "Arjun Mehta",
        Password = "Arjun@654",
        UserId = "arjun05",
        Email = "arjun.mehta@example.com",
        PhoneNumber = "9876543214",
        Gender = "Male"
    },

    new User
    {
        Id = 6,
        Name = "Ananya Roy",
        Password = "Ananya@987",
        UserId = "ananya06",
        Email = "ananya.roy@example.com",
        PhoneNumber = "9876543215",
        Gender = "Female"
    },

    new User
    {
        Id = 7,
        Name = "Vikash Thapa",
        Password = "Vikash@111",
        UserId = "vikash07",
        Email = "vikash.thapa@example.com",
        PhoneNumber = "9876543216",
        Gender = "Male"
    },

    new User
    {
        Id = 8,
        Name = "Neha Gupta",
        Password = "Neha@222",
        UserId = "neha08",
        Email = "neha.gupta@example.com",
        PhoneNumber = "9876543217",
        Gender = "Female"
    },

    new User
    {
        Id = 9,
        Name = "Rohan Verma",
        Password = "Rohan@333",
        UserId = "rohan09",
        Email = "rohan.verma@example.com",
        PhoneNumber = "9876543218",
        Gender = "Male"
    },

    new User
    {
        Id = 10,
        Name = "Kavya Sharma",
        Password = "Kavya@444",
        UserId = "kavya10",
        Email = "kavya.sharma@example.com",
        PhoneNumber = "9876543219",
        Gender = "Female"
    }
};
  }

  public class Hobby
  {
    List<Hobbies> hobbies = new List<Hobbies>
    {
      new Hobbies
      {
          Id = 1,
          Name = "Reading"
      },

      new Hobbies
      {
          Id = 2,
          Name = "Sports"
      },

      new Hobbies
      {
          Id = 3,
          Name = "Travel"
      },

      new Hobbies
      {
          Id = 4,
          Name = "Gaming"
      },

      new Hobbies
      {
          Id = 5,
          Name = "Music"
      }
    };

    public class UserHobbies
    {
      List<UserHobby> userHobbies = new List<UserHobby>
    {
    new UserHobby { UserId = 1, HobbyId = 1 },
    new UserHobby { UserId = 1, HobbyId = 2 },
    new UserHobby { UserId = 1, HobbyId = 5 },

    new UserHobby { UserId = 2, HobbyId = 1 },
    new UserHobby { UserId = 2, HobbyId = 3 },
    new UserHobby { UserId = 2, HobbyId = 5 },

    new UserHobby { UserId = 3, HobbyId = 2 },
    new UserHobby { UserId = 3, HobbyId = 3 },
    new UserHobby { UserId = 3, HobbyId = 4 },

    new UserHobby { UserId = 4, HobbyId = 1 },
    new UserHobby { UserId = 4, HobbyId = 3 },
    new UserHobby { UserId = 4, HobbyId = 4 },

    new UserHobby { UserId = 5, HobbyId = 2 },
    new UserHobby { UserId = 5, HobbyId = 4 },
    new UserHobby { UserId = 5, HobbyId = 5 },

    new UserHobby { UserId = 6, HobbyId = 1 },
    new UserHobby { UserId = 6, HobbyId = 3 },
    new UserHobby { UserId = 6, HobbyId = 5 },

    new UserHobby { UserId = 7, HobbyId = 2 },
    new UserHobby { UserId = 7, HobbyId = 3 },
    new UserHobby { UserId = 7, HobbyId = 4 },

    new UserHobby { UserId = 8, HobbyId = 1 },
    new UserHobby { UserId = 8, HobbyId = 2 },
    new UserHobby { UserId = 8, HobbyId = 5 },

    new UserHobby { UserId = 9, HobbyId = 2 },
    new UserHobby { UserId = 9, HobbyId = 3 },
    new UserHobby { UserId = 9, HobbyId = 4 },

    new UserHobby { UserId = 10, HobbyId = 1 },
    new UserHobby { UserId = 10, HobbyId = 3 },
    new UserHobby { UserId = 10, HobbyId = 4 }
};
    }
  }
}
