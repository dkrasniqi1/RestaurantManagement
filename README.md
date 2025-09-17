# Restaurant Management System

A desktop application built with **C# WinForms** and **SQL Server LocalDB** for managing restaurant operations.  
The system provides tools for administrators and cashiers to handle daily workflows such as product management, stock tracking, customer handling, and order processing.

 Features
User Authentication
  - Register new users  
  - Login with roles (Admin, Cashier)  

  Product Management 
  - Add, edit, delete products  
  - Upload product images  
  - Set price, type, unit, and status  

  Stock Management 
  - Automatic stock updates when orders are placed  
  - Track sold quantities and remaining stock  
  - Status: Available, Low Stock, Out of Stock  

  Order Processing 
  - Add customer orders  
  - Calculate total price, payment, and change  
  - Print invoice/receipt  

  Dashboard & Statistics
  - Sales overview  
  - Product performance  
  - Quick access for Admins  

Technologies Used
- C# WinForms
- .NET Framework
- SQL Server LocalDB (`restaurant.mdf`)

 Project Structure
- `RegisterForm` – User registration  
- `Form1` – Login form  
- `Admin.cs` – Administrator panel  
- `CashierForm.cs` – Cashier panel  
- `AddProduct.cs` – Product management  
- `AddUsers.cs` – User management  
- `Customers.cs` – Customer management  
- `OrdersForm.cs` – Order handling  
- `StockManagement.cs` – Stock tracking  
- `Dashboard.cs` – Statistics  
