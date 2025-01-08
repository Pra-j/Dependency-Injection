# Dependency Injection Project

## To-Do List

### 1. Modify Files in Services Folder
- **NameService.cs**  
  - Update the file with your name.

- **AgeService.cs**  
  - Update the file with your age.

- **RollService.cs**  
  - Update the file with your roll number.

---

### 2. Optional Task
Explore and implement a **different method** to pass data from the `HomeController` to the view.  
Examples include:
- **ViewData**
- **Create View Model**

---

### Folder Structure
```plaintext
Dependency Injection/
├── Connected Services/
├── Dependencies/
├── Properties/
├── wwwroot/
├── Controllers/
│   ├── HomeController.cs
│   └── TestController.cs
├── Models/
│   └── ErrorViewModel.cs
├── Services/
│   ├── AgeService.cs
│   ├── HomeService.cs
│   ├── IAgeService.cs
│   ├── IHomeService.cs
│   ├── INameService.cs
│   ├── IRollService.cs
│   ├── ITestService.cs
│   ├── NameService.cs
│   ├── RollService.cs
│   └── TestService.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── Shared/
│   └── Test/
│       ├── Index.cshtml
│       ├── _ViewImports.cshtml
│       └── _ViewStart.cshtml
├── appsettings.json
├── Program.cs
└── Startup.cs

