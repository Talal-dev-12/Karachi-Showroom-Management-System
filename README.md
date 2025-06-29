# 🚗 Karachi Motor Showroom - MySQL Database Schema

A well-structured MySQL database for managing **customers**, **vehicles**, and **rental rates** at a vehicle showroom. This system supports customer record management, soft-deletion (archive), and admin login functionality.

---

## 📦 Database Setup

### ✅ Create & Use Database
```sql
CREATE DATABASE Karachi_motor_showroom;
USE Karachi_motor_showroom;
🧾 Table Structures
1. CustomerDetails
Stores customer rental details.

CREATE TABLE CustomerDetails (
    CID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerName NVARCHAR(50) NOT NULL,
    CustomerNIC NVARCHAR(20) NOT NULL,
    PhoneNo NVARCHAR(15) NOT NULL,
    VehicleName NVARCHAR(50) NOT NULL,
    EngineNo NVARCHAR(30) NOT NULL UNIQUE,
    ChasisNo NVARCHAR(30) NOT NULL UNIQUE,
    LicensePlate NVARCHAR(20) NOT NULL UNIQUE,
    RentFees INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    UpdatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    IsArchive TINYINT(1) DEFAULT 0,
    ArchivedAt DATETIME NULL
);
2. VehicleRates
Defines rental pricing per vehicle.

CREATE TABLE VehicleRates (
    VehicleID INT PRIMARY KEY AUTO_INCREMENT,
    VehicleName NVARCHAR(100) NOT NULL UNIQUE,
    PerDayRate DECIMAL(10,2) NOT NULL,
    PerWeekRate DECIMAL(10,2) NOT NULL,
    PerMonthRate DECIMAL(10,2) NOT NULL
);
🚗 Sample Data
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
3. Users
Admin login credentials.
CREATE TABLE Users (
    UserID INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL
);
🔐 Default Admin User

INSERT INTO Users (Username, Password) VALUES ('admin', 'admin123');
🔁 Soft Delete (Archive Logic)
Instead of deleting customers permanently, we use IsArchive:

IsArchive = 0: Visible in GUI

IsArchive = 1: Archived/Hidden but recoverable

-- Archive a customer by CID
UPDATE CustomerDetails 
SET IsArchive = 1, ArchivedAt = NOW() 
WHERE CID = @cid;
📥 Fetching Active Records

SELECT * FROM CustomerDetails 
WHERE IsArchive = 0 
ORDER BY CID DESC;
📤 Restore Archived Customer OPTIONAL 
UPDATE CustomerDetails 
SET IsArchive = 0, ArchivedAt = NULL 
WHERE CID = @cid;
✅ Status
 Customer Management

 Vehicle Pricing

 Soft Delete

 Admin Login

 Auto timestamps

 Unique validations

✨ Technologies Used
MySQL 8+

SQL Syntax

WinForms (C#) for GUI (Optional frontend)

📂 Folder Structure Suggestion
/KarachiMotorShowroom/
├── db/
│   └── showroom_schema.sql
├── app/
│   └── C# WinForms Application Files
├── README.md
📧 Contact
Built by Talal Nadeem
📍 Karachi, Pakistan
📧 m.tallal.nadeem@gmail.com
📌 Project for academic & professional portfolio use.

