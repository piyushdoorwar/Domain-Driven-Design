# Library Management System 🛠️

Welcome to the **Library Management System**, a project demonstrating the **Domain-Driven Design (DDD)** pattern implemented with **.NET 8**, **PostgreSQL**, **Entity Framework Core**, and **Swagger** for API documentation.

---

## **What is Domain-Driven Design (DDD)?** 🤔

**DDD** is a software design philosophy that emphasizes focusing on the core domain and domain logic of an application. It’s about aligning your code with the real-world problem you're solving, ensuring that your application structure mirrors the business processes and rules.

### Key Concepts in DDD:
1. **Domain Layer**: The heart of your application. Contains entities, value objects, and domain logic.
2. **Application Layer**: Coordinates tasks and delegates work to the domain. It contains use cases (e.g., `BorrowBookHandler`).
3. **Infrastructure Layer**: Handles communication with external resources like databases and APIs.
4. **Clean Architecture**: Layers your application to ensure separation of concerns and flexibility.

---

## **Project Features** ✨

- Implements **DDD and Clean Architecture** principles.
- Uses **PostgreSQL** as the database.
- **Entity Framework Core** for data access and migrations.
- **Swagger** for API exploration and testing.
- CRUD operations for managing books in a library.
- Implements a use case for borrowing a book.

---

## **Technologies Used** 🛠️

- **.NET 8**
- **PostgreSQL**
- **Entity Framework Core**
- **Swagger** (Swashbuckle)

---

## **Setup Instructions** ⚙️

### **1. Clone the Repository**

```bash
git clone https://github.com/your-username/library-management-ddd.git
cd library-management-ddd
```

---

### **2. Install Dependencies**

Ensure you have the following installed on your machine:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- Any IDE or text editor (e.g., Visual Studio, Visual Studio Code)

---

### **3. Configure PostgreSQL**

1. Install PostgreSQL locally if not already installed.
2. Update the `appsettings.json` file with your PostgreSQL credentials:
   ```json
   {
     "ConnectionStrings": {
       "LibraryDatabase": "Host=localhost;Port=5432;Database=LibraryManagement;Username=postgres;Password=yourpassword"
     }
   }
   ```

---

### **4. Run Migrations**

To create the database schema and seed data, run the following commands:

1. **Add Migrations** (already included in the project):
   ```bash
   dotnet ef migrations add InitialCreate
   ```
2. **Apply Migrations**:
   ```bash
   dotnet ef database update
   ```

This will create the `Books` table in the `LibraryManagement` database and populate it with seed data.

---

### **5. Run the Project**

Run the application:

```bash
dotnet run
```

The project will start on `http://localhost:5000` (or another port if configured).

---

### **6. Test the API with Swagger**

Navigate to the Swagger UI to explore and test the API:

```
http://localhost:5000/swagger
```

#### Available Endpoints:
- **GET /api/books**: Retrieve all books.
- **POST /api/books/{id}/borrow**: Borrow a book by its ID.

---

## **Project Architecture** 🏗️

### **Folders and Layers**
1. **Domain**: Core logic (e.g., `Book` entity).
2. **Application**: Use cases (e.g., `BorrowBookHandler`).
3. **Infrastructure**: Database setup and EF Core repositories.
4. **Controller**: Entry point for HTTP requests.

### **Why Use DDD?**
- Aligns code with business processes.
- Reduces technical debt by focusing on the domain.
- Improves code maintainability and scalability.

---

## **Testing the Application** ✅

After running migrations and starting the application:
1. Use **Swagger** to test the endpoints.
2. Verify the database changes using your PostgreSQL client (e.g., `pgAdmin` or DBeaver).

---

## **Future Enhancements** 🚀

- Add authentication and authorization.
- Extend domain logic for returning books.
- Introduce a search feature for books.
- Add pagination and filtering for large datasets.

---

## **Contributing** 🤝

Feel free to fork the repository and submit pull requests. Contributions and feedback are always welcome!

---

## **License** 📜

This project is licensed under the [MIT License](LICENSE).

---

Enjoy exploring **Domain-Driven Design** with this project! 🎉
