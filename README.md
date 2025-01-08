# Dependency Injection Project

## Getting Started: Cloning the Project
To get started with this project, follow these steps:

1. **Open a Terminal or Command Prompt**  
   Make sure Git is installed on your system. If not, [download and install Git](https://git-scm.com/).

2. **Clone the Repository**  
   Run the following command to clone the project to your local machine:  
   ```bash
   git clone https://github.com/Pra-j/Dependency-Injection.git
   ```
   
3. **After cloning, navigate into the project directory:**
    ```bash
    cd dependency-injection-project
    ```
    
4. **Open the Project in Your Preferred IDE**
---


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
