### 📐 Code Style Guidelines

These conventions aim to keep the codebase clean, consistent, and easy to collaborate on.

# 🔤 Naming Conventions

## General

> **NOTE:** Use plural nouns instead of appending "List". For example:

**Example 1:**

* Use `employees` ✅
* Not `employeeList` ❌

**Example 2:**

* Use `phoneNumbers` ✅
* Not `phoneNumberList` ❌

| Element              | Convention               | Example                              |
| -------------------- | ------------------------ | ------------------------------------ |
| Local variables      | `camelCase`              | `employees`, `totalSalary`           |
| Private fields       | `_camelCase`             | `_connection`, `_logger`             |
| Properties & methods | `PascalCase`             | `GetAllEmployees()`, `GetSalary()`   |
| Classes & interfaces | `PascalCase`, `I` prefix | `EmployeeService`, `IDatabase`       |
| Form classes         | `[Functionality]Form`    | `EmployeeForm`, `LoginForm`          |
| UI control fields    | `camelCase + suffix`     | `saveButton`, `nameTextBox`          |
| File names           | Match class names        | `EmployeeService.cs`, `LoginForm.cs` |

## DTO Naming

### Direct Entity Mapping

When a DTO directly represents an entity (e.g., 1:1 property mapping with no extra fields), use the **`<EntityName>Dto`** naming convention.

**Examples:**

* `EmployeeDto`
* `ProjectDto`
* `DepartmentDto`

This ensures clarity that these DTOs are pure representations of the database entities.

### UI Models (and others)

When the returned object contains **additional joined fields** (attributes not originally part of the entity, such as `Name`, `Title`, etc. - meaning these are **not original properties of the entity**, but come from related entities, and are used by `DataGridView`, `ListView`, or UI custom controls), do **not** use the `Dto` suffix. Instead, use descriptive suffixes like:

* `View` -> for data prepared for UI or presentation
* `Progress` -> when representing progress or tracking status related to an entity

**Examples:**

* `EmployeeView`
* `ProjectProgress` (tracks project progress, e.g., completion percentage)

## Service Method Naming

### 🔹 Basic Methods

Use the entity name directly:

* `Get<Entity>` -> returns a single entity by its identifier
* `Get<Entities>` -> returns a list of entities

**Examples:**

* `GetEmployee`, `GetEmployees`
* `GetEmployeeView`, `GetEmployeeViews`

### 🔹 With Filters

When retrieving filtered data, append `By<FieldName>`:

* Single item:

  * `Get<Entity>By<FieldName>`
* Collection:

  * `Get<Entities>By<FieldName>`

**Examples:**

* `GetEmployeeByDepartmentId`, `GetEmployeeViewByDepartmentId`
* `GetEmployeesByDepartmentId`, `GetEmployeeViewsByDepartmentId`

### 🔹 Data Access Method Naming (with `Many` Convention)

When naming methods in `DataAccess` or `Repository` classes, follow these rules to make the return type (single vs. multiple) explicit in the method name.

| Action          | Single (returns 1 item)        | Multiple (returns collection)                  | Notes                                                              |
| --------------- | ------------------------------ | ---------------------------------------------- | ------------------------------------------------------------------ |
| Get by ID       | `GetById(int id)`              | `GetManyByIds(IEnumerable<int> ids)`           | Use `T?` for nullable single results                               |
| Get by criteria | `GetBy<FieldName>(...)`        | `GetManyBy<FieldName>(...)`                    | Field name indicates the filter criteria                           |
| Get             | `Get()`                        | `GetMany()`                                    |                                                                    |
| Search          | `Search(string keyword)`       | *(Unavailable)*                                |                                                                    |
| Add             | `Add(T entity)`                | *(Implement `AddMany` manually if needed)*     | Use `Add` method when you need to return the newly inserted Entity |
| Insert          | `Insert(T entity)`             | *(Implement `InsertMany` manually if needed)*  |                                                                    |
| Update          | `Update(int id, TUpdate info)` | *(Usually update single items only)*           |                                                                    |
| Delete          | `Delete(int id)`               | `DeleteMany(IEnumerable<int> ids)` (if needed) |                                                                    |

#### ✅ Guidelines:

* **Always use `Many`** for methods returning a collection (`IEnumerable<T>`).
* **Do not use a suffix** for methods returning a single entity.
* Keep this consistent across **all DataAccess/Repository classes**.
* When adding new methods, ensure there is no naming collision with existing methods that differ only by return type (C# does not allow overloads that differ only by return type).

#### 📌 Example: `EmployeeDataAccess`

```csharp
public class EmployeeDataAccess
{
    #region Retrieve data
    // Retrieve a single record (single result)
    public Employee? GetById(int employeeId);
    public Employee? GetByDepartmentId(int departmentId);
    public Employee? GetByAssignmentId(int assignmentId);
    public Employee? GetByProjectId(int projectId);

    // Retrieve multiple records (collections)
    public IEnumerable<Employee> GetMany();
    public IEnumerable<Employee> GetManyByIds(IEnumerable<int> employeeIds);
    public IEnumerable<Employee> GetManyByDepartmentId(int departmentId);
    public IEnumerable<Employee> GetManyByAssignmentId(int assignmentId);
    public IEnumerable<Employee> GetManyByProjectId(int projectId);
    public IEnumerable<PhoneNumber> GetManyPhoneNumbers(int employeeId);
    #endregion

    #region Utility methods
    // Find a single employee by a unique column (e.g., Username, Email, etc.)
    public Employee Find(string searchValue);
    // Find all matching employees
    public IEnumerable<Employee> Search(string searchValue);
    #endregion

    #region Create/Update/Delete methods
    // Single operation (single record)
    public Employee? Add(Employee employee);
    public int Insert(Employee employee);
    public int Update(int employeeId, EmployeeUpdate info);
    public int Delete(int employeeId);

    // Bulk operations (multiple records)
    public IEnumerable<Employee> AddMany(IEnumerable<Employee> employees);
    public int InsertMany(IEnumerable<Employee> employees);
    // `public int UpdateMany();` -> No `UpdateMany`
    public int DeleteMany(IEnumerable<int> employeeIds);
    #endregion
}
```

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

**Example:**

```csharp
/// <summary>
/// Retrieves a list of employees by department.
/// </summary>
public List<Employee> GetEmployeesByDepartment(string departmentId)
{
    // my code
}
```

# 🛢️ Database & SQL Access

* Do **not** write raw SQL queries in Forms or UI logic.

* Always use `SqlParameter` to prevent SQL injection.

* Always use full table names; do not use aliases for table names.

* Use `PascalCase` for table and column names:

  * Tables: `Employee`, `Project`, `Task`
  * Columns: `EmployeeId`, `FullName`, `StartDate`

* Store SQL scripts (e.g., schema, seed data) in the `Database/` folder.

* Encapsulate SQL operations inside a `DataAccess` or `Repository` layer.

# 🔣 Enum Naming

Enums should be named using `PascalCase` for both the enum type and its members. This makes them consistent with C# naming conventions and easier to read, especially when working with business logic or mapping enum values to the database.

**Guidelines:**

* Enum type: `PascalCase`
* Enum members: `PascalCase`

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

Use different conventions for constants and `readonly` fields to clearly distinguish between compile-time and runtime immutability.

| Element          | Convention                  | Example                            |
| ---------------- | --------------------------- | ---------------------------------- |
| Constants        | `ALL_CAPS_WITH_UNDERSCORES` | `MAX_FILE_SIZE`, `DEFAULT_TIMEOUT` |
| `readonly` field | `_camelCase`                | `_defaultDepartmentId`             |

**Notes:**

* Use `const` for compile-time constants.
* Use `readonly` for values that are assigned at runtime (e.g., in the constructor) and do not change afterward.

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
