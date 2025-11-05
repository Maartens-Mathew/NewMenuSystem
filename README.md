# 🍔 NewMenuSystem 🍹

Welcome to **NewMenuSystem** – a WPF-powered food & drinks menu ordering system designed to level up the modern dining experience!  
This was my first solo adventure in C# and WPF (with a splash of XAML) and turned out to be a fantastic journey into multi-layered architecture, MVVM, and a little taste of Microsoft Access database wizardry.

---

## 🎯 Project Goals

- 📱 Enable waitrons to capture food & drink orders directly on a device
- 👨‍💻 Explore & implement WPF (XAML) and C# in a real-world scenario
- 🗂️ Connect seamlessly to a Microsoft Access database  
- 🏛️ Apply, experiment, and learn the powerful **MVVM architectural pattern**

---

## 🏗️ Features

- 🍽️ **Order Entry:** Easy UI forms for creating and managing customer orders  
- 🙋 **Waitron Selector:** Pick your server for more personalized service  
- 🔀 **Smooth Navigation:** Modular navigation classes to keep things tidy  
- 🎨 **Theming:** Custom theme files for menu buttons so it looks as good as it works  
- ⚡ **Data-Driven:** CRUD operations through a connected Access database

---

## ⚙️ Tech Stack

- **Language:** C#  
- **UI:** WPF (with XAML)  
- **Architecture:** MVVM  
- **Database:** Microsoft Access  

---

## 🗂️ Project Structure

```
├── App.config / App.xaml / App.xaml.cs
├── MainWindow.xaml / MainWindow.xaml.cs
├── Forms/
│   ├── ExistingOrder.xaml(+.cs)
│   ├── OrderMenu.xaml(+.cs)
│   ├── WaitronSelector.xaml(+.cs)
│   └── NavigationClasses/
├── MVVM/
│   ├── ViewModels/
│   └── Views/
├── Properties/ (AssemblyInfo, Resources, Settings)
├── Themes/ (MenuButtonTheme.xaml)
├── TestApp.csproj / TestApp.sln
```
_💡 Major files keep UI, business logic, and resources separated for clarity and maintainability._

---

## 🚀 Getting Started

1. **Clone the repo:**  
   ```bash
   git clone https://github.com/Maartens-Mathew/NewMenuSystem.git
   ```

2. **Pre-requisites:**  
   - Visual Studio 2017+  
   - .NET desktop workload  
   - Microsoft Access (for database; not included)

3. **Build & Run:**  
   - Open `TestApp.sln` in Visual Studio  
   - Restore all NuGet packages  
   - Build and press F5!

4. **Database Setup:**  
   - Place your Access DB file as needed  
   - Edit your `App.config` for the connection string

---

## 🙏 Acknowledgements

- Inspired by real-world restaurant needs and a hunger for learning tech.
- Special nod to [Microsoft Access](https://www.microsoft.com/en-us/microsoft-365/access) for being a surprisingly handy DB.

---

## 📃 License

Project is free for learning and demo use!  

---

🛠️ Made with passion, caffeine, and curiosity by [Maartens-Mathew](https://github.com/Maartens-Mathew)
