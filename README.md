# ABB ACS Software

ABB ACS Software is a web application developed using ASP.NET Core for the backend, React for the frontend, and SQL Server for the database.

## Features

- User authentication and authorization
- Dashboard for monitoring access control systems
- User management
- Access control settings
- Audit trail tracking

## Technologies Used

- **Backend:** ASP.NET Core, C#
- **Frontend:** React
- **Database:** SQL Server

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository:

```bash
git clone https://github.com/your-username/ABB_ACS_Software.git

2. Install dependencies:

cd ABB_ACS_Software
npm install   # For frontend dependencies
dotnet restore   # For backend dependencies


3. Setup the database:

Create a SQL Server database
Update the connection string in appsettings.json file in the backend project (Server directory)

4. Run the application:

dotnet run   # For starting the backend server
npm start   # For starting the frontend server

5. Access the application in your browser:

https://localhost:5173
