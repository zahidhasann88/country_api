# Country API

## Overview
The **Country Management API** is a RESTful API developed using .NET 5 and Entity Framework. It is designed for managing country names through Create, Read, Update, and Delete (CRUD) operations. This project was built for skill growth and learning purposes, providing practical experience with modern web technologies.

## Features
- **Create**: Add new countries to the database.
- **Read**: Retrieve a list of all countries stored in the database.
- **Update**: Modify the details of existing countries.
- **Delete**: Remove countries from the database.

## Technologies Used
- **.NET 5**: A modern, scalable, and high-performance framework for building web applications and APIs.
- **Entity Framework Core**: An Object-Relational Mapper (ORM) that simplifies data access by allowing developers to work with databases using .NET objects.

## Endpoints
- **GET /api/countries**: Retrieve all countries.
- **GET /api/countries/{id}**: Retrieve a specific country by ID.
- **POST /api/countries**: Add a new country.
- **PUT /api/countries/{id}**: Update an existing country by ID.
- **DELETE /api/countries/{id}**: Delete a country by ID.

## Getting Started
### Prerequisites
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Visual Studio](https://visualstudio.microsoft.com/) or any other preferred IDE
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other compatible database

### Installation
1. **Clone the Repository**:
   ```sh
   git clone <repository-url>
