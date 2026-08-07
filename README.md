# My Roadmap

## week-2: Understanding Project Structure and Configuration
- [ ] Tasks:
  - Deep dive into `Program.cs` and `Startup.cs`.
  - Explore `appsettings.json` and environment-specific settings.
  - Configure basic settings in `appsettings.json`.
  - **Project Output:**
    - Modify `appsettings.json` to include a custom configuration section and read these values in a controller action.

## Solution, Explanatioin and Implementation Details:
Step 1: Created a new branch from the dev branch. 

Step 2: In the new branch, I added my custom configuration section in `appsettings.json` like this:
```json
{
  "keys": {
    "publicKey": "lala lala lori",
    "mysupersecret": {
      "mysecret": "secret chai top secret",
      "myothersecret": "yo chai other secret la"
    }
  }
}
```


Step 3: In a new customConfigController, I injected `IConfiguration` and read the values from the custom configuration section:
```csharp
public class CustomConfigController : Controller
{
    private readonly IConfiguration _configuration;

    public CustomConfigController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IActionResult Index()
    {
     string? publickey = _configuration["keys:publicKey"];
     string? mysecret = _configuration["keys:mysupersecret:mysecret"];
     string? myothersecret = _configuration["keys:mysupersecret:myothersecret"];
     return View(new{ publickey, mysecret, myothersecret });
    }
}
```

Step 4: I created a new view for the `CustomConfigurationController` to display the values read from the configuration:
```html
<div>
    <h1>Custom Configuration</h1>
    <p>@Model.publickey</p>
    <p>@Model.mysecret</p>
    <p>@Model.myothersecret</p>
</div>
```

Step 5: I ran the application and navigated to the `CustomConfigController` route. The values from the `appsettings.json` were successfully read and displayed in the view.

Step 6: I committed the changes to the new branch and pushed it to the remote repository.
