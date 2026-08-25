# EduCore 🎓

EduCore is an educational platform backend built with ASP.NET Core.

The project is being developed as a learning-focused, real-world backend project with a focus on clean architecture, authentication, authorization, and test-driven development.

> 🚧 This project is currently under active development.

---

## 🏗️ Architecture

The project follows a layered architecture:

- **EduCore.Api** – API layer, controllers, middleware, and application configuration
- **EduCore.Application** – Application contracts and business logic abstractions
- **EduCore.Domain** – Core domain entities and business models
- **EduCore.Infrastructure** – Database access, Identity, and external service implementations

```text
API
 ↓
Application
 ↓
Domain

Infrastructure
 ↕
Application / Domain
```

---

## 🚀 Current Features

### 🔐 Authentication & Identity

- ASP.NET Core Identity
- User registration
- User login
- Password validation policies
- Unique email support
- JWT-based authentication
- JWT token generation and validation
- Claims-based user information inside JWT tokens

### 🛡️ Authorization

- Authentication and Authorization middleware
- Role-Based Authorization
- JWT role claims
- Role-protected API endpoints

Current system roles:

- Student
- Teacher
- Admin

### 👤 Role Management

- Default `Student` role assigned during registration
- Role seeding during application startup
- Admin-protected role management functionality
- User role management using ASP.NET Core Identity's `UserManager`
- Role validation using `RoleManager`

### 🗄️ Data Access

- Entity Framework Core
- SQL Server
- EF Core migrations
- ASP.NET Core Identity database integration

### 🔧 Dependency Injection

The project uses ASP.NET Core's built-in Dependency Injection container for managing application services and dependencies.

Examples include:

- Authentication services
- JWT services
- User and role management services

### 📖 API Documentation & Testing

- Swagger / OpenAPI documentation
- JWT authentication support in Swagger
- API testing with Postman

---

## 🛠️ Technology Stack

- C#
- .NET / ASP.NET Core
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- JWT Bearer Authentication
- Swagger / OpenAPI

---

# 🗺️ Roadmap

## Phase 1 – Authentication & Authorization 🔄

- [x] ASP.NET Core Identity setup
- [x] User registration
- [x] User login
- [x] JWT authentication
- [x] Role seeding
- [x] Basic authorization
- [x] Role-Based Authorization
- [ ] Complete Admin role management
- [ ] Security review and authentication finalization

---

## Phase 2 – Test-First Development 🧪

Future features will be developed using a Test-First approach:

```text
Write Test
    ↓
Test Fails 🔴
    ↓
Implement Feature
    ↓
Test Passes 🟢
    ↓
Refactor 🔵
```

Planned testing tools and practices:

- xUnit
- Moq
- Unit Testing
- Integration Testing
- Test-Driven Development (TDD) principles

Dependencies will be mocked where appropriate, while the actual business logic being tested will remain real.

---

## Phase 3 – Core Educational Features 📚

### Course Management

- [ ] Create courses
- [ ] View courses
- [ ] Update courses
- [ ] Delete courses
- [ ] Teacher course management

### Educational Content

- [ ] Course sections
- [ ] Lessons
- [ ] Educational videos and content

### Enrollment

- [ ] Student enrollment
- [ ] Enrollment validation
- [ ] Student course access

### Comments and Interaction

- [ ] Comments
- [ ] Authorization and ownership rules
- [ ] Content moderation

---

## Phase 4 – User & Admin Management 👥

Planned management features include:

- [ ] User management
- [ ] User role management
- [ ] Admin endpoints
- [ ] Teacher features
- [ ] Student features

---

## Phase 5 – Production Readiness ⚙️

Planned improvements:

- [ ] Global exception handling
- [ ] Logging
- [ ] Request validation
- [ ] Pagination
- [ ] Caching where appropriate
- [ ] Integration testing
- [ ] Security improvements
- [ ] Performance improvements

---

## 🎯 Learning Goals

EduCore is designed not only as an application but also as a practical learning project.

The goal is to gain hands-on experience with:

- Clean and layered architecture
- ASP.NET Core Identity
- Authentication and Authorization
- JWT
- Role-Based Access Control
- Dependency Injection
- Entity Framework Core
- Unit Testing and Mocking
- Test-Driven Development
- Building maintainable backend applications

---

## 📌 Project Status

🚧 **Active Development**

The Authentication and Authorization foundation is currently being completed.
Core educational features will be developed afterward using a Test-First development workflow.
