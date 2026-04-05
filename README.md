# zest-student-management
# Student Management System - Zest India Assignment

Full Stack Student Management System built using ASP.NET Core Web API and React.

## Features

### Backend
- ASP.NET Core Web API
- CRUD Operations
- JWT Authentication
- Layered Architecture
- Global Exception Middleware
- Swagger Documentation
- SQLite Database

### Frontend
- React UI
- Add Student
- Edit Student
- Delete Student
- Search Students
- Clean UI

## API Endpoints

POST /api/Auth/login

GET /api/Student  
POST /api/Student  
PUT /api/Student/{id}  
DELETE /api/Student/{id}  

## Run Backend

dotnet restore  
dotnet run  

Swagger:
http://localhost:5006/swagger

## Run Frontend

cd student-ui  
npm install  
npm start  

Frontend:
http://localhost:3000
