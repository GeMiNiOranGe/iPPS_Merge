# 🙌 Contributing to Pepro

Thank you for considering contributing to **Pepro**, a WinForms C# project for managing employees, projects, and more.

We welcome all contributions — whether it's fixing bugs, proposing features, refactoring, or improving documentation.

## 🧰 Before You Start

### ✅ Prerequisites

To contribute, make sure you have:

- Visual Studio 2022 or later
- .NET 9+
- SQL Server (Express/Developer)
- Git installed

### 📦 Project Setup

Please refer to the `README.md` for full installation and database setup instructions before contributing.

## 💡 How to Contribute

### 🔀 1. Fork & Clone

```bash
git clone https://github.com/GeMiNiOranGe/Pepro.git
cd Pepro
git checkout -b feature/your-feature-name
```

### 🛠️ 2. Make Changes

Follow the [Code Style Guidelines](./CODE_STYLE.md) for consistency.

Try to:

* Keep commits small and focused
* Write descriptive commit messages
* Avoid mixing unrelated changes

### 🧪 3. Test Your Changes

* Run the application and test your changes manually
* Confirm the app builds successfully
* Make sure no existing functionality is broken

### 📤 4. Create a Pull Request

When you're ready:

1. Push your branch:

   ```bash
   git push origin feature/your-feature-name
   ```

2. Open a Pull Request:

   * Target: `main`
   * Fill in the PR template (if available)
   * Describe what you changed and **why**
   * Add screenshots if it's UI-related
   * Mention related issues (e.g. `Closes #12`)

## 🐞 Reporting Bugs

If you found a bug:

* Create a new GitHub issue
* Include:

  * Steps to reproduce
  * Expected vs. actual behavior
  * Screenshots (if applicable)
  * Error messages or stack traces

## 💬 Communication

For discussions, questions, or ideas, use:

* GitHub Discussions
* Issues (for bug reports or feature requests)

We aim for a collaborative and respectful environment. Please follow the [Code of Conduct](./CODE_OF_CONDUCT.md) (if available).

## 🧼 House Rules

* Respect existing code and structure.
* Avoid writing business logic in UI (WinForms) code-behind.
* Use `DataAccess` or `Business` layers when appropriate.
* Format your code before committing.
* Follow the naming and structure in [`CODE_STYLE.md`](./CODE_STYLE.md).

Thank you again for your contribution! 🙏
