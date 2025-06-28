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
-- Insert fake data 
INSERT INTO OwnerDetails (OwnerName, OwnerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, NoPlat, RegFees)
VALUES
('John Smith', '1234567890123', '5550101234', 'Toyota Corolla 2003-2007', 'ENG00123456', 'CHS00123456', 'ABC123', 2000),
('Emily Johnson', '2345678901234', '5550102345', 'Toyota Probox', 'ENG00234567', 'CHS00234567', 'DEF456', 1800),
('Michael Williams', '3456789012345', '5550103456', 'Toyota Corolla 2014', 'ENG00345678', 'CHS00345678', 'GHI789', 4000),
('Sarah Brown', '4567890123456', '5550104567', 'Honda Reborn 10-12', 'ENG00456789', 'CHS00456789', 'JKL012', 3500),
('David Jones', '5678901234567', '5550105678', 'Honda Civic 12-14', 'ENG00567890', 'CHS00567890', 'MNO345', 4000),
('Jennifer Garcia', '6789012345678', '5550106789', 'Toyota Corolla 2009-2013', 'ENG00678901', 'CHS00678901', 'PQR678', 3000),
('Robert Miller', '7890123456789', '5550107890', 'Suzuki Alto VXR', 'ENG00789012', 'CHS00789012', 'STU901', 1400),
('Jessica Davis', '8901234567890', '5550108901', 'Suzuki Cultus 9-12', 'ENG00890123', 'CHS00890123', 'VWX234', 1400),
('Thomas Rodriguez', '9012345678901', '5550109012', 'Toyota Corolla 2003-2007', 'ENG00901234', 'CHS00901234', 'YZA567', 2000),
('Elizabeth Martinez', '0123456789012', '5550110123', 'Toyota Probox', 'ENG01012346', 'CHS01012346', 'BCD890', 1800),
('Daniel Wilson', '1122334455667', '5550111234', 'Toyota Corolla 2014', 'ENG10123456', 'CHS10123456', 'CDE123', 4000),
('Amanda Anderson', '2233445566778', '5550112345', 'Honda Reborn 10-12', 'ENG20234567', 'CHS20234567', 'EFG456', 3500),
('Christopher Taylor', '3344556677889', '5550113456', 'Honda Civic 12-14', 'ENG30345678', 'CHS30345678', 'HIJ789', 4000),
('Ashley Thomas', '4455667788990', '5550114567', 'Toyota Corolla 2009-2013', 'ENG40456789', 'CHS40456789', 'KLM012', 3000),
('Matthew Hernandez', '5566778899001', '5550115678', 'Suzuki Alto VXR', 'ENG50567890', 'CHS50567890', 'NOP345', 1400),
('Nicole Moore', '6677889900112', '5550116789', 'Suzuki Cultus 9-12', 'ENG60678901', 'CHS60678901', 'QRS678', 1400),
('Andrew Martin', '7788990011223', '5550117890', 'Toyota Corolla 2003-2007', 'ENG70789012', 'CHS70789012', 'TUV901', 2000),
('Samantha Jackson', '8899001122334', '5550118901', 'Toyota Probox', 'ENG80890123', 'CHS80890123', 'UVW234', 1800),
('Joshua Thompson', '9900112233445', '5550119012', 'Toyota Corolla 2014', 'ENG90901234', 'CHS90901234', 'WXY567', 4000),
('Megan White', '0011223344556', '5550120123', 'Honda Reborn 10-12', 'ENG01012347', 'CHS01012347', 'XYZ890', 3500); 
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

