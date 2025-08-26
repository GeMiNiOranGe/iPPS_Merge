### 📐 Code Style Guidelines

These conventions aim to keep the codebase clean, consistent, and easy to collaborate on.

# 🔤 Naming Conventions

## General

> **NOTE:** Use plural nouns instead of appending "List". For example:

**Example 1:**
- Use `employees` ✅
- Not `employeeList` ❌

**Example 2:**
- Use `phoneNumbers` ✅
- Not `phoneNumberList` ❌

| Element              | Convention               | Example                              |
| -------------------- | ------------------------ | ------------------------------------ |
| Local variables      | `camelCase`              | `employees`, `totalSalary`           |
| Private fields       | `_camelCase`             | `_connection`, `_logger`             |
| Properties & methods | `PascalCase`             | `GetAllEmployees()`, `GetSalary()`   |
| Classes & interfaces | `PascalCase`, `I` prefix | `EmployeeService`, `IDatabase`       |
| Form classes         | `[Functionality]Form`    | `EmployeeForm`, `LoginForm`          |
| UI control fields    | `camelCase + suffix`     | `saveButton`, `nameTextBox`          |
| File names           | Match class names        | `EmployeeService.cs`, `LoginForm.cs` |

# 🧱 Code Structure & Style

## 🔸 General Rules

* Always use `{}` for control blocks, even for single-line statements:

    ```csharp
    if (isValid)
    {
        SaveData();
    }
    ```

* Order class members as follows:

    1. Fields  
    2. Constructors  
    3. Properties  
    4. Public methods  
    5. Private methods  

* Use `var` **only when the type is obvious** from the right-hand side:

    ```csharp
    var employee = new Employee();
    ```

    Alternatively (recommended):

    ```csharp
    Employee employee = new();
    ```

* Prefer explicit types for unclear or complex expressions:

    ```csharp
    List<Employee> employees = GetEmployees();
    ```

* Avoid placing business logic directly in WinForms code-behind. Use separate `Business` or `DataAccess` layers.

# 💬 Comments

* Use `//` for short inline comments that explain *why*, not *what*.
* Use `///` XML documentation comments for all public classes and methods:

    ```csharp
    /// <summary>
    /// Retrieves a list of employees by department.
    /// </summary>
    public List<Employee> GetEmployeesByDepartment(string departmentId) { ... }
    ```

# 🛢️ Database & SQL Access

* Do **not** write raw SQL queries in Forms or UI logic.
* Always use `SqlParameter` to prevent SQL injection.
* Always use full table names, do not use aliases for table names
* Use `PascalCase` for table and column names:
    * Tables: `Employee`, `Project`, `Task`  
    * Columns: `EmployeeId`, `FullName`, `StartDate`

* Store SQL scripts (e.g., schema, seed data) in the `Database/` folder.
* Encapsulate SQL operations inside a `DataAccess` or `Repository` layer.

# 🔣 Enum Naming

Enums should be named using `PascalCase` for both the enum type and its members. This makes them consistent with C# naming conventions and easier to read, especially when working with business logic or mapping enum values to the database.

**Guidelines:**
- Enum type: `PascalCase`
- Enum members: `PascalCase`

**Example:**
```csharp
public enum ProjectStatus
{
    NotStarted,
    InProgress,
    Completed,
    OnHold
}
```

# 📌 Constants and `readonly` Fields

Use different conventions for constants and `readonly` fields to clearly distinguish between compile-time and run-time immutability.

| Element          | Convention                  | Example                            |
| ---------------- | --------------------------- | ---------------------------------- |
| Constants        | `ALL_CAPS_WITH_UNDERSCORES` | `MAX_FILE_SIZE`, `DEFAULT_TIMEOUT` |
| `readonly` field | `_camelCase`                | `_defaultDepartmentId`             |

**Notes:**

* Use `const` for compile-time constants.
* Use `readonly` for values that are assigned at runtime (e.g., in constructor) and do not change afterward.

**Example:**

```csharp
private const int MAX_FILE_SIZE = 1048576;
private readonly string _defaultDepartmentId;
```

# ✅ Miscellaneous Rules

* One class per file.
* Avoid committing changes to auto-generated `.Designer.cs` files unless necessary.
* Format code before committing.
* Prioritize readability and maintainability over brevity.
* Ensure namespaces match the folder structure.
