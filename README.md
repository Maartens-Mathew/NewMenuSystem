# 🍴 NewMenuSystem

A WPF-based food and drinks menu ordering system designed for restaurants, built with C#, XAML, and the MVVM architectural pattern. 🍽️💻

---

## 📝 Project Overview

**NewMenuSystem** is a desktop application intended for waitrons to capture and manage customer orders on a device. This project represents a personal learning milestone, functioning as my first solo development effort in C# and WPF, and provided hands-on experience with architectural layering and the MVVM pattern.

Key goals and features:
- 📱 Device-based order entry for food and drinks
- 🖼️ UI crafted with WPF and XAML for a modern desktop experience
- 🏛️ MVVM structure enabling separation of concerns and maintainability
- 🗄️ Microsoft Access database connectivity

Although the application did not progress beyond initial features, it remains a complete example of an MVVM-patterned, data-driven WPF application.

---

## ✨ Features

- 🛒 **Menu and Order Capture:** Interfaces dedicated for ordering and managing existing orders.
- 🧑‍🍳 **Waitron Selector:** UI portion allowing staff selection and order allocation.
- 🔄 **Navigation:** Simple modular structure, using navigation classes, to decouple different forms and functionalities.
- 🎨 **Styling:** Custom themes for menu buttons and core UI elements.
- 🔗 **Database Access:** Connection and read/write support for a Microsoft Access database.

---

## ⚙️ Technology Stack

- **Language:** C#  
- **UI Framework:** WPF with XAML  
- **Architecture:** MVVM (Model-View-ViewModel)  
- **Database:** Microsoft Access  

---

## 📁 Project Structure

```
├── App.config, App.xaml, App.xaml.cs
├── MainWindow.xaml, MainWindow.xaml.cs
├── Forms/
│   ├── ExistingOrder.xaml (+.cs)
│   ├── OrderMenu.xaml (+.cs)
│   ├── WaitronSelector.xaml (+.cs)
│   └── NavigationClasses/
├── MVVM/
│   ├── ViewModels/
│   └── Views/
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.Designer.cs / Resources.resx
│   ├── Settings.Designer.cs / Settings.settings
├── Themes/
│   └── MenuButtonTheme.xaml
├── TestApp.csproj, TestApp.sln
```
- Most business and UI logic is separated into `Forms` and `MVVM` directories.
- Reusable styles are placed in `Themes/MenuButtonTheme.xaml`.
- The `Properties` folder contains project configuration and resource files.

---

## 🚀 Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Maartens-Mathew/NewMenuSystem.git
   ```

2. **Requirements:**
   - Visual Studio 2017+ (with .NET desktop development workload) 🏗️
   - Microsoft Access (for database file, not bundled in repo)

3. **Build & Run:**
   - Open `TestApp.sln` in Visual Studio.
   - Restore NuGet packages (if needed), then build and run the project.

4. **Database Configuration:**
   - Ensure an Access database with the required schema is present and the connection string in `App.config` is updated.

---

## 🖼️ Screenshots

_Add your screenshots here to showcase the UI!_

---

## 🙏 Acknowledgements

- Inspired by modern POS and restaurant management needs.
- Developed as an educational project focused on practical implementation of MVVM and WPF.

---

## 📜 License

This project is provided as-is for learning and demonstration purposes. Adapt freely!

---

> Developed by [Maartens-Mathew](https://github.com/Maartens-Mathew) 🚀
