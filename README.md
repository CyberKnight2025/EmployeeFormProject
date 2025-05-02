# Employee Form - VB.NET Windows Forms Application

## Overview
This project is a VB.NET Windows Forms application that connects to a SQL Server database and manages employee records. It allows users to view, add, update, and delete employee information using a clean graphical user interface (GUI).

## Features
- Load employee data from SQL Server
- Display employee data in a DataGridView
- Add new employees
- Update existing employee records
- Delete selected employees
- Exit application gracefully
- Try...Catch error handling for SQL operations

## Technical Details
- Language: VB.NET (Visual Basic .NET)
- Framework: .NET Framework 4.8
- Database: SQL Server Express
- UI Framework: Windows Forms (WinForms)
- Version Control: GitHub

## Setup Instructions
1. Clone this repository.
2. Open the solution file (`EmployeeFormProject.sln`) in Visual Studio.
3. Update the database connection string inside `Form1.vb`.
4. Build and run the project.

## Why This Project
This project demonstrates core VB.NET development skills including working with databases, handling user inputs through forms, applying structured exception handling, and implementing CRUD (Create, Read, Update, Delete) operations.

## Future Improvements
- Add search functionality.
- Improve UI with better styling (modern WinForms).
- Implement Entity Framework for easier data management.
- Add user authentication and authorization.

  ## Project Comparison
| Feature                         |  Employee Form Project                                        | Employee Directory Project                                    |
|---------------------------------|---------------------------------------------------------------|---------------------------------------------------------------|
| **Main Focus**                  | Basic Employee Form Layout (Early version)                    | Full Employee Management System (Table + Form + Buttons)      |
| **DataGridView**                | (no table of employees shown)                                 | Add, Update, Delete, Exit (Buttons Functional Concept)        |
| **CRUD Operations**             | Layout Only (no functional backend yet)                       | Add, Update, Delete, Exit (Buttons Functional Concept)        |
| **UI Completeness**             | Simple static form layout                                     | Finished clean layout with data and polish                    |
| **Real-World Simulation**       | Draft form structure only                                     | Mimics a working Employee Directory System                    |

## Related Project
Explore the [EmployeeDirectory](https://github.com/CyberKnight2025/EmployeeDirectory) project to see a more complete system!
