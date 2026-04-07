# Student Management System - ASP.NET Core Web API

## Features

* CRUD Operations for Students
* JWT Authentication
* Global Exception Handling Middleware
* Serilog Logging
* Swagger API Documentation
* Layered Architecture (Controller, Service, Repository)

## Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* JWT Authentication
* Serilog
* Swagger
* xUnit (Unit Testing)

## Database

Student Table Fields:

* Id
* Name
* Email
* Age
* Course
* CreatedDate

## Setup Instructions

### 1. Clone Repository

```
git clone https://github.com/yourusername/StudentManagementAPI.git
```

### 2. Update Connection String

Update in `appsettings.json`

### 3. Run Database Script

Execute SQL script in SQL Server

### 4. Run Project

Press F5 or run:

```
dotnet run
```

### 5. Swagger URL

```
https://localhost:xxxx/swagger
```

## JWT Authentication

1. Call `/api/auth/login`
2. Copy token
3. Click Authorize in Swagger
4. Enter:

```
 your_token
```

## Project Structure

```
Controllers
Services
Repository
Models
Middleware
Data
```

## Author
Sabah Fakir

