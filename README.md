# E-Commerce Project (N-Tier Architecture)

This is a C# Console Application built to demonstrate the core principles of **N-Tier Architecture**, **Dependency Injection**, and the **Generic Repository Design Pattern**. It serves as a foundational template for building scalable and maintainable applications.

## 🏗️ Architecture & Folder Structure

The project is divided into logical layers to separate concerns, making the codebase easier to manage, test, and scale. Each layer contains `Abstract` (Interfaces) and `Concrete` (Implementation) folders.

*   **Entities Layer:** 
    *   Contains the database objects (Models).
    *   Implements the `IEntity` signature to safely mark classes as database tables (`Product`, `Category`).
*   **DataAccess Layer (DAL):** 
    *   Handles all database operations (CRUD).
    *   Implements the **Generic Repository Pattern** (`IEntityRepository<T>`) to avoid code duplication.
    *   Currently uses an In-Memory data source (`InMemoryProductDal`) for testing purposes without requiring an actual database connection.
*   **Business Layer:** 
    *   Contains the business logic and rules (`ProductManager`).
    *   Communicates with the DataAccess layer via interfaces, adhering to **Dependency Injection** principles.
*   **Console UI (Presentation):** 
    *   The `Program.cs` file acts as the user interface. It requests data from the Business layer and displays it to the user.

## 🚀 Technologies & Design Patterns Used

*   **C# / .NET**
*   **N-Tier (Multi-Tier) Architecture**
*   **Generic Repository Design Pattern**
*   **Dependency Injection (DI)**
*   **SOLID Principles** (Specifically Dependency Inversion and Single Responsibility)

## 💻 How to Run the Project

1. Clone or download the repository to your local machine.
2. Open the solution (`ECommerceProject.sln`) in **Visual Studio**.
3. Set the `ECommerceProject` as the Startup Project.
4. Press `F5` or click the **Start** button to run the application.
5. A console window will appear, displaying the mock product data retrieved from the In-Memory database.

## 🔄 Future Improvements

Because the project is built using interfaces (`IProductDal`, `IProductService`), switching to a real database is seamless. 
*   Add **Entity Framework Core**.
*   Create an `EfProductDal` class connecting to **SQL Server** or **PostgreSQL**.
*   Inject the new `EfProductDal` into the `ProductManager` in `Program.cs` without changing any existing business or entity logic!
