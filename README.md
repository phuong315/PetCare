# Pet Care Services Application

This is a web application for selling pet care services at home. The application allows users to view available products and services, place orders, and manage their orders efficiently.

## Features

- **Home Page**: Provides an overview of the services offered.
- **Product Management**: Users can view, create, and delete products.
- **Order Management**: Users can view, create, and delete orders.

## Project Structure

- **Controllers**: Contains the logic for handling requests.
  - `HomeController.cs`: Manages home page requests.
  - `OrdersController.cs`: Handles order-related requests.
  - `ProductsController.cs`: Manages product-related requests.

- **Models**: Defines the data structures.
  - `Order.cs`: Represents an order with properties like OrderId, CustomerName, PetType, and OrderDate.
  - `Product.cs`: Represents a product with properties like ProductId, Name, Description, and Price.

- **Views**: Contains the Razor views for rendering UI.
  - `Home/Index.cshtml`: Home page view.
  - `Orders/Index.cshtml`: View for displaying orders.
  - `Products/Index.cshtml`: View for displaying products.

- **Data**: Manages database context and migrations.
  - `ApplicationDbContext.cs`: Configures the database connection and sets up DbSet properties.
  - `Migrations`: Contains migration files for database schema changes.

- **wwwroot**: Contains static files.
  - `css`: Stylesheets for the application.
  - `js`: JavaScript files for client-side functionality.
  - `lib`: Third-party libraries and dependencies.

- **Configuration Files**:
  - `appsettings.json`: Contains application settings and database connection strings.
  - `Program.cs`: Entry point of the application.
  - `Startup.cs`: Configures services and middleware.

## Getting Started

1. Clone the repository.
2. Update the `appsettings.json` file with your database connection string.
3. Run the application using your preferred method.

## Contributing

Feel free to submit issues or pull requests for improvements and bug fixes.