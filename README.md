# School Management System - ASP.NET Core Web API

## 🚀 Project Overview
The **School Management System** is a robust, scalable, and maintainable solution built with **ASP.NET Core** following the **Clean Architecture** pattern. The project provides key functionalities for managing school operations, including user authentication, course management, student evaluation, discussions, certificate generation, and more.

## 🛠 Key Features

- **User Authentication**: Secure JWT authentication with role-based access (Admin, Teacher, Student).
- **Course Management**: Admins can add and update courses, while teachers can track student progress.
- **Student Evaluation**: Grading, performance tracking, and feedback management.
- **Discussion Forums**: Course-specific forums for interaction between students and teachers.
- **Certificate Generation**: Auto-generated digital certificates upon course completion.
- **Notifications**: Alerts for course updates, deadlines, and event reminders via email.
- **Video Management**: Upload, manage, and stream course videos.
- **API Testing**: API documentation and testing with Swagger.
- **Unit Testing**: System reliability ensured with xUnit.
- **Data Validation**: Input checks using Fluent Validation.
- **CORS Configuration**: Secure cross-origin resource sharing.

## 📜 Technologies & Design Patterns

- **Clean Architecture** for project structure
- **CQRS** (Command Query Responsibility Segregation) & **Mediator Design Pattern**
- **Generic Repository Pattern** for data management
- **Entity Framework Core** & **SQL Server** for database operations
- **JWT Authentication** with role-based authorization
- **Fluent Validation** for data validation
- **xUnit** for unit testing
- **SwaggerGen** for API documentation
- **CORS (Cross-Origin Resource Sharing)** for secure API requests
- **Email Services** for notifications
- **Localization**: Supports English and Arabic

## 🔧 Installation & Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/school-management-system.git
   cd school-management-system
