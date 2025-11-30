🚀 ECommerce API – .NET 9 + JWT + EF Core + SQL Server

A clean and modular E-Commerce REST API built with .NET 9, Entity Framework Core, JWT Authentication, and SQL Server, designed for learning modern backend development with secure API practices.

📌 Project Overview

This project is a fully functional backend API that demonstrates real-world e-commerce functionality:

🔐 Authentication & Authorization

Register users with hashed passwords (BCrypt)

Login with email + password

Generate secure JWT tokens

Restrict protected routes using [Authorize]

Role-based access possible for admin/user

🛒 Core E-Commerce Modules Implemented

User Registration & Login

Product CRUD (secure)

JWT Token Validation

SQL Server relational database

EF Core Code-First Migrations

🧪 Swagger API Documentation

Interactive API testing via Swagger UI:

Test endpoints with/without JWT token

Login → copy token → Authorize → test secure API

🛠 Tech Stack
Layer	Technology
Backend	ASP.NET Core 9 Web API
Authentication	JWT Bearer Tokens, BCrypt
Database	SQL Server
ORM	Entity Framework Core 9
Documentation	Swagger / OpenAPI
Architecture	Services Layer + Controllers + EF Core Models
Tools	Visual Studio 2022 / VS Code
📂 Folder Structure
ECommerceSolution/
│── ECommerce.Api/
│   ├── Controllers/
│   ├── Data/
│   ├── DTOs/
│   ├── Helpers/ (JwtTokenGenerator)
│   ├── Migrations/
│   ├── Models/
│   ├── Services/
│   ├── Properties/
│   ├── Program.cs
│   └── appsettings.json (ignored)
│
└── ECommerceSolution.sln

🚀 How to Run the Project
1️⃣ Restore Packages
dotnet restore

2️⃣ Apply Migrations
Add-Migration InitialCreate
Update-Database

3️⃣ Run API
dotnet run

4️⃣ Open Swagger
https://localhost:7082/swagger

🔑 Testing JWT Authentication
1. Register a user

POST → /api/auth/register

2. Login

POST → /api/auth/login

Copy the returned token:

eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...

3. Authorize

Click “Authorize” → Bearer <token> → Authorize

Now protected endpoints (POST/PUT/DELETE Product) will work.

🌱 Branch Strategy (Recommended)

Use GitHub Flow:

main → production-ready code
dev → active development
feature/<feature-name> → feature branches
hotfix/<issue-name> → urgent production fixes

Example:
feature/add-cart-module
feature/add-admin-role


After feature is complete:

Raise PR → merge into dev

After testing → merge dev → main

📘 Features Completed

✔ User Registration
✔ User Login (JWT Token)
✔ BCrypt Password Hashing
✔ JWT Token Generator
✔ Product CRUD
✔ Authorization with JWT
✔ Swagger UI Integration
✔ SQL Server + EF Core Setup
✔ Clean service-based architecture
