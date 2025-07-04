# Employee-Management-WindowFormsApplication

👨‍💼 Employee Management System Using C# and Sql in Visual Studio:-
A Windows Forms Application built using C# and Microsoft SQL Server LocalDB, designed to manage employee records efficiently through a clean, user-friendly interface. This desktop application includes user authentication, employee tracking, salary management, and a full suite of CRUD operations.

🛠 Technologies Used:
  C# (.NET Framework)
  Windows Forms (WinForms)
  Microsoft SQL Server Database File (.mdf - LocalDB)


🚀 Key Features
🔐 User Authentication
  Login and registration system
  Redirects new users to register page
  Secure login for existing users

🖥 Dashboard
  Displays employee statistics: total, active, inactive
  Acts as the main hub after login

👤 Employee Management
  Add new employees
  Update employee details
  Delete or mark employees as inactive
  View employee records in a user-friendly interface
  Upload employee images from system files and associate them with records

💸 Salary Management
  Update and manage salaries for active employees only

🚪 Session Control
  Logout via Sign Out button
  Exit application via top-right Exit button

📂 Project Structure
  LoginForm.cs – Handles user login
  RegisterForm.cs – Handles new user registration
  MainForm.cs – Contains the dashboard and navigation
  Dashboard.cs – Displays employee statistics
  AddEmployee.cs – UI and logic for CRUD operations and image upload
  Salary.cs – Manages employee salary updates
