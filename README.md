## Farmer Product Management System - Agri-Energy

 ## Overview

The Farmer Product Management System is a web-based application designed to streamline the process of managing agricultural products. The system supports two types of users—Farmers and Employees—and provides role-specific access to efficiently manage product data, farmer profiles, and perform filtered product searches.

-------------------------------------------------------------------------------------------------------------------------------------------

## Features

1. Database Development and Integration
    - Designed and implemented a relational database to manage detailed records of farmers and their products.
    - The database is populated with sample data to simulate real-world usage and ensure robust testing and demonstration capabilities.
2. User Roles and Authentication
    - Farmer Role:
      - Add new products with essential details such as name, category, and production date.
      - View a personal list of added products.
    - Employee Role:
      - Add new farmer profiles including all required personal and contact information.
      - View a comprehensive list of products submitted by any farmer.
      - Apply filters such as date range and product category for efficient product searches.
    - Secure Login System:
      - Role-based access control to restrict functionality based on user type.
      - Authentication mechanism ensures secure handling of user credentials and sessions.
3. Functional Capabilities
    - For Farmers:
      - Product submission form with validation and input fields for:
        - Product name
        - Product category
        - Production date
    - For Employees:
       - Add new farmer profiles.
       - View and manage all products across the platform.
    - Filter products based on:
       - Date range
       - Product type/category
5. User Interface and Experience
     - Clean, intuitive UI designed for both technical and non-technical users.
     - Fully responsive design optimized for:
      - Desktops
      - Tablets
      - Smartphones
     - Accurate and clear data presentation throughout the interface to minimize errors and improve usability.

-------------------------------------------------------------------------------------------------------------------------------------------

## Technologies Used

- **Backend**: ASP.NET MVC (C#)
- **Frontend**: Razor Pages, HTML, CSS, Bootstrap
- **Database**: SQL Server Management Studio (SSMS)
- **Authentication**: ASP.NET Identity (Role-based)

-------------------------------------------------------------------------------------------------------------------------------------------

## Setup Instructions

Follow these steps to set up the development environment:

### Step 1: Clone the Repository

```bash
git clone https://github.com/your-username/agri-energy.git
cd agri-energy
```

### Step 2: Database Setup
Open SSMS.
Run the SQL script provided in /Database/Seed.sql or set up using ApplicationDbContext migrations.
Make sure the connection string in appsettings.json matches your local database.

### Step 3: Configure the Project
Open the solution in Visual Studio.
Restore NuGet packages.
Build the project to ensure all dependencies are correctly installed.

### Step 4: Run the Application
Press F5 in Visual Studio or press teh run button in Visula Studio

-------------------------------------------------------------------------------------------------------------------------------------------

## User Credentials (For Demo)

- Farmer:
  - Email: farmer@gmail.com
  - Password: Password1!
- Employee:
  - Username: test1@gmail.com
  - Password:  Password1!

-------------------------------------------------------------------------------------------------------------------------------------------

## Coming Soon

- Chat and Discussion Boards
- Payment Inputs and Options
- Redesign of UI with enhanced responsiveness
- Educational Content and Webinars
- Project Collaboration and Green Energy Grants Information

-------------------------------------------------------------------------------------------------------------------------------------------

## License

This project is open-source and available under the MIT License.

