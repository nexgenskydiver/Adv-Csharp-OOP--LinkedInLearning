# Advanced C#: Object-Oriented Programming
# LinkedIn Learning Practice

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

## 📖 Overview
This repo contains my hands-on code samples and exercises from the **LinkedIn Learning: Advanced C#: Object-Oriented Programming** course.  
Each module/chapter lives in its own folder, with a Visual Studio solution and project(s) for that topic.

## 🗂️ Table of Contents
- [Prerequisites](#-prerequisites)  
- [Getting Started](#-getting-started)  
- [Folder Structure](#-folder-structure)  
- [How to Run](#-how-to-run)  
- [Branching & Commits](#-branching--commits)  
- [Contributing](#-contributing)  
- [License](#-license)  
- [Acknowledgements](#-acknowledgements)  

---

## 🔧 Prerequisites
- [.NET SDK 8.0 (or your target version)](https://dotnet.microsoft.com/)  
- Visual Studio 2022 (Community/Professional) with **.NET desktop development** workload  
- Git (for commit & push)

---

## 🚀 Getting Started
1. Clone this repo locally:  
   ```bash
   git clone https://github.com/your-username/Learning-CSharp-LinkedInLearning.git
   cd Learning-CSharp-LinkedInLearning
   ```
2. Open the solution file in Visual Studio:  
   ```text
   LearningCSharpLinkedInLearning.sln
   ```
3. Select the project you want to explore and press **F5** (Debug) or **Ctrl+F5** (Run without debugging).

---

## 📁 Folder Structure
```
Learning-CSharp-LinkedInLearning/
│
├─ .github/                # GitHub workflows (optional)
├─ Module01_Basics/        # Chapter 1 exercises
│   ├─ Module01.sln
│   └─ Module01.ConsoleApp/
│
├─ Module02_OOP/           # Chapter 2 exercises
│   ├─ Module02.sln
│   └─ Module02.Library/
│
├─ Module03_Collections/   # and so on…
│
├─ README.md
├─ LICENSE
└─ .gitignore
```

---

## ▶️ How to Run
1. Navigate into the module folder you want to try:  
   ```bash
   cd Module02_OOP
   ```
2. Restore packages & build:  
   ```bash
   dotnet restore
   dotnet build
   ```
3. Run the console app (or test project) with:  
   ```bash
   dotnet run --project Module02.ConsoleApp
   ```

---

## 🌿 Branching & Commits
- **feature/module-##** – make a branch for major exercises (e.g. `feature/module-02-oop`)  
- Commit often with clear messages:  
  - ✅ `Add basic class inheritance examples (Module02)`  
  - 🔧 `Fix null-reference exception in Person.cs`

---

## 🤝 Contributing
This is my personal learning repo—feel free to:  
- Fork & tinker on your own  
- Submit PRs if you spot typos or improvements  
- Raise issues for suggestions on better patterns

---

## 📜 License
This work is licensed under the [MIT License](LICENSE).

---

## 🙏 Acknowledgements
- [LinkedIn Learning: Learning C#](https://www.linkedin.com/learning/advanced-c-sharp-object-oriented-programming) by [Joe Marini]  
- The .NET community and official docs at https://docs.microsoft.com/dotnet/
