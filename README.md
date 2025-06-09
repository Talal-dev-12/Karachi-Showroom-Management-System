🚗 Karachi Showroom Management System
A complete Windows Forms (WinForms) application built using C# and MySQL, designed to manage vehicle owners and rental rates efficiently for a showroom.

🛠️ How to Set Up
1. Clone the Repository
Open your terminal or command prompt and run:


git clone https://github.com/Talal-dev-12/Karachi-Showroom-Management-System.git
2. Set Up the Database
Open MySQL Workbench (or your preferred SQL client) and execute the following:

-- Create Database
CREATE DATABASE KARACHI_MOTOR_SHOWROOM;
USE KARACHI_MOTOR_SHOWROOM;

-- Owner Details Table
CREATE TABLE OwnerDetails (
    AID INT PRIMARY KEY AUTO_INCREMENT,
    OwnerName NVARCHAR(50) NOT NULL,
    OwnerNIC NVARCHAR(20) NOT NULL,
    PhoneNo NVARCHAR(15) NOT NULL,
    VehicleName NVARCHAR(50) NOT NULL,
    EngineNo NVARCHAR(30) NOT NULL UNIQUE,
    ChasisNo NVARCHAR(30) NOT NULL UNIQUE,
    NoPlat NVARCHAR(20) NOT NULL UNIQUE,
    RegFees INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Vehicle Rates Table
CREATE TABLE VehicleRates (
    VehicleID INT PRIMARY KEY AUTO_INCREMENT,
    VehicleName NVARCHAR(100) NOT NULL UNIQUE,
    PerDayRate DECIMAL(10,2) NOT NULL,
    PerWeekRate DECIMAL(10,2) NOT NULL,
    PerMonthRate DECIMAL(10,2) NOT NULL
);

-- Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL
);

-- Insert Admin User
INSERT INTO Users (Username, Password) VALUES ('admin', 'admin123');

-- Insert Sample Vehicle Rates
INSERT INTO VehicleRates (VehicleName, PerDayRate, PerWeekRate, PerMonthRate)
VALUES 
('Corolla 2003-2007', 2000, 12500, 45000),
('Toyota Probox', 1800, 10500, 40000),
('Corolla 2014', 4000, 24500, 90000),
('Honda Reborn 10-12', 3500, 21000, 80000),
('Honda Civic 12-14', 4000, 24500, 96000),
('Corolla 2009-2013', 3000, 17500, 65000),
('Alto VXR', 1400, 7700, 30000),
('Suzuki Cultus 9-12', 1400, 9000, 36000);
3. Update the Connection String
In your code, locate and update the following:

string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";
Ensure user, password, and port match your MySQL configuration

Default MySQL port is 3306. If you’re using MySQL Workbench with a custom port (like 3307), make sure it matches here.

4. Install MySQL Data Package
In Visual Studio:

Go to:
Tools > NuGet Package Manager > Package Manager Console

Run the following command:
Install-Package MySql.Data
This will install the required MySQL connector for .NET.

✅ Features
Add, Edit, and Delete Vehicle Owner Details

Store and Display Rental Rates (Per Day, Week, Month)

Admin Login System

Easy-to-use WinForms UI

Full MySQL backend support

🔍 Tables Included
OwnerDetails – Store all vehicle owner info

VehicleRates – Define vehicle rental prices

Users – Admin login credentials

🧑‍💻 Author
Talal Nadeem
GitHub: @Talal-dev-12

