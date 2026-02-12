# Patient Transfer Report API

## Project Overview

This project replaces an legacy **Entity Framework 6 implementation** that was experiencing performance timeouts under heavy load. The new solution is a high-performance REST API built with **.NET** and **Dapper** to efficiently generate a **Patient Transfer Report** by joining data from three database tables:

* Patients
* Transfers
* Facilities

The system is designed with scalability, performance, and clean architecture in mind.

---

## Scenario

The existing EF6-based system was unable to handle high traffic and complex joins efficiently. The goal of this project is to:

* Improve database performance
* Prevent SQL injection vulnerabilities
* Apply clean **N-tier architecture**
* Build a fast and maintainable REST API

---

## Requirements Implemented

### 1. High-Performance Data Access with Dapper (+2)

The project uses **Dapper** as a lightweight ORM for fast SQL execution and minimal overhead.

Benefits:

* Faster query execution than EF6
* Direct SQL control
* Async database operations
* Efficient object mapping

---

### 2. SQL Injection Prevention (+1)

All database queries use **parameterized SQL** with Dapper.

Example:

```csharp
var result = await connection.QueryAsync<PatientTransferReport>(
    sql,
    new { StartDate = startDate, EndDate = endDate });
```

This ensures:

* No dynamic SQL concatenation
* Safe input handling
* Protection from SQL injection attacks

---

### 3. N-Tier Architecture (Separation of Concerns)

The project follows a clean layered architecture:

```
API Layer → Business Layer → Data Layer → Database
```

#### Layers

**API Layer**

* Handles HTTP requests
* Exposes REST endpoints
* Uses dependency injection

**Business Layer**

* Contains business logic
* Coordinates data operations

**Data Layer**

* Implements Dapper repositories
* Executes optimized SQL queries

**Domain Layer**

* Defines models and DTOs

This separation improves:

* Maintainability
* Testability
* Scalability

---

## Project Structure

```
PatientTransferSystem
│
├── PatientTransfer.API
│   └── Controllers
│
├── PatientTransfer.Business
│   └── Services
│
├── PatientTransfer.Data
│   └── Repositories
│
└── PatientTransfer.Domain
    └── Models
```

---

## Database Schema

The report joins data from:

* **Patients** – patient information
* **Transfers** – transfer records
* **Facilities** – facility details

The API performs optimized joins to fetch the transfer report efficiently.

---

## Getting Started

### Prerequisites

* .NET 10 SDK
* SQL Server
* Visual Studio

---

### Setup Steps

1. Clone the repository

```
git clone <repository-url>
```

2. Configure the database connection in `appsettings.json`

```
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

3. Create database tables and seed test data

4. Run the project

```
F5 or dotnet run
```

5. Open Swagger

```
https://localhost:<port>/swagger
```

---

## API Endpoint

### Get Patient Transfer Report

```
GET /api/transfer/report
```

Query parameters:

* `startDate`
* `endDate`

Example:

```
/api/transfer/report?startDate=2025-01-01&endDate=2025-12-31
```

---

## Performance Optimizations

* Dapper for lightweight data access
* Async database operations
* Optimized SQL joins
* Scoped dependency injection
* Minimal object mapping overhead

---

## Testing

The API can be tested using:

* Swagger UI
* Postman
* Browser GET requests

---

## Summary

This project demonstrates how replacing EF6 with Dapper and applying N-tier architecture significantly improves performance and maintainability. It provides a secure, scalable solution for generating patient transfer reports under heavy load.

---
