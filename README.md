# NewsAPI

A RESTful API built with ASP.NET Core (.NET 8) for managing news-related entities such as Banners and Categories. The project uses Entity Framework Core for data access and ASP.NET Core Identity for authentication and authorization.

## Features

- CRUD operations for Banners and Categories
- Generic repository and unit of work patterns
- Custom error handling and response wrapping
- ASP.NET Core Identity integration
- Swagger/OpenAPI documentation

## Project Structure

- **NewsAPI.App**: Main ASP.NET Core Web API project
- **NewsAPI.AppHandler**: Contains generic handlers, error handling, mapping, and wrappers
- **NewsAPI.Domain**: Entity and DTO definitions
- **NewsAPI.Infastrcture**: Data access and Identity context

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server (or compatible connection string)

### Setup

1. **Clone the repository:**
   
```
   git clone <repository-url>
   cd NewsAPI
   
```

2. **Configure the database:**
   - Update `appsettings.json` in `NewsAPI.App` with your SQL Server connection strings for `DefaultConnection` and `AppIdentityConnection`.

3. **Apply migrations:**
   
```
   dotnet ef database update --project NewsAPI.App
   
```

4. **Run the application:**
   
```
   dotnet run --project NewsAPI.App
   
```

5. **Access Swagger UI:**
   - Navigate to `https://localhost:<port>/swagger` in your browser.

## API Endpoints

### Banners

- `GET /api/Banners` - List all banners
- `GET /api/Banners/{id}` - Get a banner by ID
- `POST /api/Banners` - Create a new banner
- `PUT /api/Banners/{id}` - Update an existing banner
- `DELETE /api/Banners/{id}` - Delete a banner

### Categories

- `GET /api/Category` - List all categories
- `GET /api/Category/{id}` - Get a category by ID
- `POST /api/Category` - Create a new category
- `PUT /api/Category/{id}` - Update an existing category
- `DELETE /api/Category/{id}` - Delete a category

## Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core 8.0
- ASP.NET Core Identity
- Swashbuckle (Swagger)
- C# 12

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.

**What was included and why:**
- Project overview, features, and structure for clarity.
- Setup instructions based on .NET 8 and EF Core.
- API endpoint documentation for quick reference.
- Technology stack and contribution guidelines.

Let me know if you need a more detailed section or want to include usage examples!
