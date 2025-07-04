-- Create the database
CREATE DATABASE IF NOT EXISTS Karachi_motor_showroom;
USE Karachi_motor_showroom;

-- Create VehicleRates table
CREATE TABLE IF NOT EXISTS VehicleRates (
    VehicleID INT AUTO_INCREMENT PRIMARY KEY,
    VehicleName VARCHAR(100) NOT NULL UNIQUE,
    PerDayRate DECIMAL(10,2) NOT NULL,
    PerWeekRate DECIMAL(10,2) NOT NULL,
    PerMonthRate DECIMAL(10,2) NOT NULL
);

-- Create CustomerDetails table
CREATE TABLE IF NOT EXISTS CustomerDetails (
    CID INT AUTO_INCREMENT PRIMARY KEY,
    CustomerName VARCHAR(100) NOT NULL,
    CustomerNIC VARCHAR(20) NOT NULL,
    PhoneNo VARCHAR(20) NOT NULL,
    VehicleName VARCHAR(100) NOT NULL,
    EngineNo VARCHAR(50) NOT NULL,
    ChasisNo VARCHAR(50) NOT NULL,
    LicensePlate VARCHAR(20) NOT NULL,
    RentFees VARCHAR(50) NOT NULL,
    IsArchive BOOLEAN DEFAULT 0
);

-- Sample data for VehicleRates
INSERT INTO VehicleRates (VehicleName, PerDayRate, PerWeekRate, PerMonthRate) VALUES
('Toyota Corolla', 1500.00, 9000.00, 30000.00),
('Honda Civic', 1800.00, 10800.00, 36000.00),
('Suzuki Alto', 1000.00, 6000.00, 20000.00),
('KIA Sportage', 2500.00, 15000.00, 50000.00),
('Suzuki Cultus', 1200.00, 7200.00, 24000.00);

-- Sample customer
INSERT INTO CustomerDetails (CustomerName, CustomerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, LicensePlate, RentFees) VALUES
('Ali Khan', '42201-1234567-1', '03121234567', 'Toyota Corolla', 'ENG123456', 'CHS654321', 'ABC-123', '1 Week : 9000 Rs');

INSERT INTO CustomerDetails (CustomerName, CustomerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, LicensePlate, RentFees) VALUES
('Ali Khan', '42101-1234567-1', '03001234567', 'Toyota Corolla', 'ENG001', 'CHS001', 'ABC-101', '1 Week : 9000 Rs'),
('Ahmed Raza', '42102-9876543-2', '03011234567', 'Honda Civic', 'ENG002', 'CHS002', 'ABC-102', '1 Month : 36000 Rs'),
('Hassan Ali', '42103-1234987-3', '03021234567', 'Suzuki Alto', 'ENG003', 'CHS003', 'ABC-103', '1 Day : 1000 Rs'),
('Usman Sheikh', '42104-6543210-4', '03031234567', 'KIA Sportage', 'ENG004', 'CHS004', 'ABC-104', '1 Week : 15000 Rs'),
('Tariq Jameel', '42105-1112223-5', '03041234567', 'Suzuki Cultus', 'ENG005', 'CHS005', 'ABC-105', '1 Day : 1200 Rs'),
('Zain Abbas', '42106-7778889-6', '03051234567', 'Toyota Corolla', 'ENG006', 'CHS006', 'ABC-106', '1 Month : 30000 Rs'),
('Bilal Khan', '42107-3216549-7', '03061234567', 'Honda Civic', 'ENG007', 'CHS007', 'ABC-107', '1 Week : 10800 Rs'),
('Farhan Iqbal', '42108-4567890-8', '03071234567', 'Suzuki Alto', 'ENG008', 'CHS008', 'ABC-108', '1 Month : 20000 Rs'),
('Samiullah', '42109-9090909-9', '03081234567', 'KIA Sportage', 'ENG009', 'CHS009', 'ABC-109', '1 Day : 2500 Rs'),
('Rashid Mehmood', '42110-1122334-0', '03091234567', 'Suzuki Cultus', 'ENG010', 'CHS010', 'ABC-110', '1 Week : 7200 Rs'),
('Imran Hashmi', '42111-6677885-1', '03101234567', 'Toyota Corolla', 'ENG011', 'CHS011', 'ABC-111', '1 Day : 1500 Rs'),
('Noman Saeed', '42112-9988776-2', '03111234567', 'Honda Civic', 'ENG012', 'CHS012', 'ABC-112', '1 Week : 10800 Rs'),
('Saad Ahmed', '42113-3344556-3', '03121234567', 'Suzuki Alto', 'ENG013', 'CHS013', 'ABC-113', '1 Week : 6000 Rs'),
('Zeeshan Ali', '42114-2233445-4', '03131234567', 'KIA Sportage', 'ENG014', 'CHS014', 'ABC-114', '1 Month : 50000 Rs'),
('Moiz Khalid', '42115-5566778-5', '03141234567', 'Suzuki Cultus', 'ENG015', 'CHS015', 'ABC-115', '1 Month : 24000 Rs'),
('Shahid Afridi', '42116-8877665-6', '03151234567', 'Toyota Corolla', 'ENG016', 'CHS016', 'ABC-116', '1 Day : 1500 Rs'),
('Sohail Anwar', '42117-1122112-7', '03161234567', 'Honda Civic', 'ENG017', 'CHS017', 'ABC-117', '1 Month : 36000 Rs'),
('Awais Jamil', '42118-6677880-8', '03171234567', 'Suzuki Alto', 'ENG018', 'CHS018', 'ABC-118', '1 Week : 6000 Rs'),
('Yasir Arafat', '42119-8899001-9', '03181234567', 'KIA Sportage', 'ENG019', 'CHS019', 'ABC-119', '1 Week : 15000 Rs'),
('Nashit Raza', '42120-3344999-0', '03191234567', 'Suzuki Cultus', 'ENG020', 'CHS020', 'ABC-120', '1 Day : 1200 Rs');

