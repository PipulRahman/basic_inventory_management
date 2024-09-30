 Inventory Management System (SPA Project)

Overview:

This is a Single Page Application (SPA) developed in ASP.NET Core 6, aimed at managing an inventory system. It allows users to manage customers, categories, products, and orders with dynamic functionality.

###Technology Stack:

	Language: C#
	Framework: ASP.NET Core (version 6)
	Database: Microsoft SQL Server (MSSQL)
	ORM: Entity Framework Core
	Frontend: jQuery, AJAX
	Authentication: ASP.NET Core Identity
	Architecture: 3-Layer (MVC) architecture with ViewModel

###Configuration:
Before running the project, update the ConnectionStrings section in appsettings.json with your database settings:

	Server: Your SQL Server name
	User Id: Your database user ID
	Password: Your database password

###Features:

1. User Registration & Authentication:
	* Users can register with a valid email(admin@gmail.com) and password(Admin@123), then log in to access the application.

2. User Role Assignment:
	*The project includes user role management, allowing different roles to be assigned to users for managing access to various features.

3. Dashboard:
Once logged in, users are directed to the home page, where they can view various lists:

	*Customer List
	*Category List
	*Product and Stock List
	*Order List

4. Dynamic Data Management:
Users can dynamically add new:

	*Customers
	*Categories
	*Products (with stock details)
	*Orders
