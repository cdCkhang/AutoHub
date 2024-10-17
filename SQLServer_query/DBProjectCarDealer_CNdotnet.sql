use master 
go
IF EXISTS (SELECT * FROM sysdatabases where name ='ProjectcnDotNet_CDM')
	DROP DATABASE ProjectcnDotNet_CDM
GO
CREATE DATABASE ProjectcnDotNet_CDM
GO 
use ProjectcnDotNet_CDM
go

CREATE table AccountList 
(
	Account_ID varchar(3) PRIMARY KEY NOT NULL,
	Account_Username varchar(20),
	Account_Password varchar(20),
	IsManager tinyint
)

create table CUSTOMERS 
(
	Customer_ID varchar(6) PRIMARY KEY NOT NULL,	
	FullName varchar(50),
	CreditCardNumber varchar(50),
	Contact_Number varchar(20),	
	Email varchar(30),
	Info_Address varchar(30)
)

create table MANUFACTURER 
(
	Man_ID varchar(4) PRIMARY KEY NOT NULL,
	Man_Name varchar(20),
	Man_Location varchar(20)
)

create table CARS 
(
	Car_ID varchar(6) PRIMARY KEY NOT NULL,
	Model_Name varchar(20),
	Man_ID varchar(4),
	Model_Year int,
	PaintColor varchar(6),	
	Price int
	FOREIGN KEY (Man_ID) REFERENCES MANUFACTURER (Man_ID)
)

create table SALESPERSON
(
	SalesPerson_ID varchar(8) PRIMARY KEY NOT NULL,
	FullName varchar(30),
	ContactNumber varchar(20),	
	Email varchar(30),
	Info_Address varchar(30),
	Salary int
)

create table TRANSACTIONS
(
	Transaction_ID varchar(6) PRIMARY KEY NOT NULL
	CHECK (Transaction_ID LIKE '[A-Z][A-Z]-[0-9][0-9][0-9]'),
	Customer_ID varchar(6),
	SalesPerson_ID varchar(8),
	Car_ID varchar(6),
	Taxes_Fees int,
	FOREIGN KEY (Customer_ID) REFERENCES CUSTOMERS(Customer_ID),
	FOREIGN KEY (SalesPerson_ID) REFERENCES SALESPERSON(SalesPerson_ID),
	FOREIGN KEY (Car_ID) REFERENCES CARS(Car_ID)
)


INSERT INTO AccountList VALUES ('000','admin','dotnet',1)
INSERT INTO AccountList VALUES ('001','nhanvien1','nhanvien1',0)
INSERT INTO AccountList VALUES ('002','nhanvien2','nhanvien2',0)

INSERT INTO CUSTOMERS VALUES
('CS901','Smith John',123102,0223456221,'Sj12@gmail.com','12th Avenue, Yonkers'),
('CS811','Sazs Sheila',328731,0331298164,'HavEve201@gmail.com','3rd Evenly, Buffalo'),
('CS209','Litt Louis',31233,0188574012,'Pearman22@gmail.com','26th Wall Street, New York')


INSERT INTO MANUFACTURER VALUES
('TYT', 'Toyota', 'Japan'),
('HNDA', 'Honda', 'Japan'),
('FORD', 'Ford', 'United States'),
('CHER', 'Chevrolet', 'United States'),
('BMW', 'BMW', 'Germany'),
('MERC', 'Mercedes-Benz', 'Germany'),
('NISS', 'Nissan', 'Japan'),
('AUDI', 'Audi', 'Germany'),
('VOLK', 'Volkswagen', 'Germany'),
('TSLA', 'Tesla', 'United States');

INSERT INTO CARS VALUES
('CT0218', 'Camry','TYT', 2020, 'red', 27650),          
('HCV175', 'Civic', 'HNDA', 2019,'black', 29500),          
('FFR273', 'F-150', 'FORD', 2021, 'white',30200),          
('CHM388', 'Malibu', 'CHER' , 2022, 'black', 31000),         
('B3S007', '3 Series','BMW', 2020, 'brown' , 30600),       
('EMC222', 'E-Class','MERC', 2021,'black', 33000),        
('NSA061', 'Altima', 'NISS',2018,'red', 26400),         
('ADA400', 'A4','AUDI', 2022,'white', 27490),             
('VWJ420', 'Jetta','VOLK', 2019,'brown', 28200),          
('TSM003', 'Model 3','TSLA', 2021,'black', 30150)


INSERT INTO SALESPERSON VALUES
('SP2213','Carolina',022392211,'SC213@gmail.com','28th Denz',5600),
('SP9017','Eren Yeager',0113254762,'headless@gmail.com','Rose',6000)

INSERT INTO TRANSACTIONS VALUES 
('TS-203','CS901','SP2213','ADA400',35),
('TS-788','CS209','SP9017','EMC222',29)

SELECT * FROM AccountList
SELECT * FROM TRANSACTIONS
SELECT * FROM CUSTOMERS
SELECT * FROM CARS
SELECT * FROM SALESPERSON

SELECT TRANSACTION_ID, Taxes_Fees, 'Total Price($)' = Price + Price *(Taxes_Fees*0.01)
FROM TRANSACTIONS T INNER JOIN CARS C ON C.Car_ID = T.Car_ID