-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 29, 2017 at 11:27 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.6.23




/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sais`
--

-- --------------------------------------------------------

--
-- Table structure for table `employeedb`
--

CREATE TABLE employeedb (
  e_id int NOT NULL,
  employee_id varchar(50) NOT NULL,
  employee_firstname varchar(50) NOT NULL,
  employee_lastname varchar(50) NOT NULL,
  employee_gender varchar(10) NOT NULL,
  employee_email varchar(50) NOT NULL,
  employee_password varchar(50) NOT NULL,
  employee_position varchar(50) NOT NULL,
  employee_status varchar(50) NOT NULL
);

--
-- Dumping data for table `employeedb`
--

INSERT INTO employeedb (e_id, employee_id, employee_firstname, employee_lastname, employee_gender, employee_email, employee_password, employee_position, employee_status) VALUES
(1, 'EMP00000', 'Paul Joseph Nunez', 'Radin', 'Male', 'pauljoseph@yahoo.com', '12345', 'Manager', 'available'),
(2, 'EMP00001', 'Marie', 'Santos', 'Female', 'mariesantos@gmail.com', '1234567890', 'Employee', 'deleted'),
(3, 'EMP00002', 'John', 'Nunez', 'Male', 'johnwnunez@gmail.com', 'qwerty', 'Manager', 'deleted'),
(4, 'EMP00003', 'Johnny', 'Goode', 'Male', 'johnnygoode@yahoo.com', 'rtyuiop', 'Employee', 'available'),
(5, 'EMP00004', 'wad', 'gawf', 'Male', 'awd', 'wsadw', 'Employee', 'deleted'),
(6, 'EMP00005', 'awd', '21gea', 'Male', 'gead', 'htdhkyugj', 'Manager', 'deleted'),
(7, 'EMP00006', 'wadwa', 'jtjfea', 'Male', 'jyjthr', 'awf2q135', 'Manager', 'deleted'),
(8, 'EMP00007', 'awfwa', 'rrhrdhjrw', 'Male', 'awfw', '231521', 'Manager', 'deleted'),
(9, 'EMP00008', 'podwaop', '2139i', 'Female', 'opdwamopd', '12u3091', 'Employee', 'available'),
(10, 'EMP00009', 'iwjda90', 'odwa09djaw', 'Female', 'j90', 'jopdw', 'Manager', 'available'),
(11, 'EMP000010', 'Simplicio', 'Liwanag III', 'Male', 'math.english_3rd@yahoo.com', '123456answer', 'Manager', 'available');

-- --------------------------------------------------------

--
-- Table structure for table `productdb`
--

CREATE TABLE productdb (
  p_id int NOT NULL,
  product_id varchar(50) NOT NULL,
  product_name varchar(50) NOT NULL,
  product_descr text NOT NULL,
  product_price int NOT NULL,
  product_quantity int NOT NULL,
  product_owner varchar(50) NOT NULL,
  product_status varchar(20) NOT NULL
) ;

--
-- Dumping data for table `productdb`
--

INSERT INTO productdb (p_id, product_id, product_name, product_descr, product_price, product_quantity, product_owner, product_status) VALUES
(1, 'PR00000', 'Nameless', 'No description', 100, 50, 'None', 'deleted'),
(2, 'PR00001', 'Apple', 'Fruit', 5, 498, 'Farm', 'available'),
(3, 'PR00002', 'Cabbage', 'Vegetable', 30, 298, 'Farm', 'available'),
(4, 'PR00003', 'Coffee', 'Caffeine', 70, 500, 'Royal Coffee', 'deleted'),
(5, 'PR00004', 'Orange', 'Fruit', 15, 198, 'Farm 2', 'available'),
(6, 'PR00005', 'Ice Coffee', 'Beverage', 20, 1000, 'Master Coffee', 'available'),
(7, 'PR00006', 'Cheese', 'Dairy Product', 90, 100, 'Dairy Factory', 'available'),
(8, 'PR00007', 'milo', 'cereal', 10, 50, 'milo company', 'available'),
(9, 'PR00008', 'choco', 'sweet taste', 1100, 5, 'god', 'available'),
(10, 'PR00009', 'ice', 'cold and cool', 10, 100, 'jesus', 'available'),
(11, 'PR000010', 'water', 'hot and cool drink', 50, 100, 'me', 'available'),
(12, 'PR000011', 'can goods', 'tuna', 15, 15, 'lord', 'available'),
(13, 'PR000012', 'stuff', 'random', 100, 50, 'my dog', 'available'),
(14, 'PR000013', 'tea', 'yuck', 14, 100, 'lord', 'available'),
(15, 'PR000014', 'milk', 'dairy product', 120, 500, 'milk farm', 'available'),
(16, 'PR000015', 'Coke', 'Softdrinks', 25, 300, 'Coca Cola', 'available');

-- --------------------------------------------------------

--
-- Table structure for table `salestrandb`
--

CREATE TABLE salestrandb (
  salestran_id varchar(20) NOT NULL,
  salestran_prodname varchar(50) NOT NULL,
  salestran_price decimal NOT NULL,
  salestran_quantity decimal NOT NULL
);

--
-- Dumping data for table `salestrandb`
--

INSERT INTO salestrandb (salestran_id, salestran_prodname, salestran_price, salestran_quantity) VALUES
('TRANS00001', 'Apple', 5, 2),
('TRANS00001', 'Cabbage', 30, 2),
('TRANS00002', 'Apple', 5, 2),
('TRANS00002', 'Cabbage', 30, 5),
('TRANS00002', 'Ice Coffee', 20, 1),
('TRANS00002', 'Orange', 15, 1),
('TRANS00003', 'Apple', 5, 1),
('TRANS00003', 'Cabbage', 30, 1),
('TRANS00003', 'Orange', 15, 1),
('TRANS00004', 'Apple', 5, 2),
('TRANS00004', 'Cabbage', 30, 2),
('TRANS00004', 'Orange', 15, 1),
('TRANS00005', 'Orange', 15, 1);

-- --------------------------------------------------------

--
-- Table structure for table `transactdb`
--

CREATE TABLE transactdb (
  stp_id int NOT NULL,
  transact_id varchar(50) NOT NULL,
  transact_tprice decimal NOT NULL,
  transact_change decimal NOT NULL
);

--
-- Dumping data for table `transactdb`
--

INSERT INTO transactdb (stp_id, transact_id, transact_tprice, transact_change) VALUES
(1, 'TRANS00001', 70, 10),
(2, 'TRANS00002', 175.5, 24.5),
(3, 'TRANS00003', 50, 10),
(4, 'TRANS00004', 85, 5),
(5, 'TRANS00005', 13.5, 986.5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employeedb`
--
ALTER TABLE employeedb
  ADD PRIMARY KEY (e_id);

--
-- Indexes for table `productdb`
--
ALTER TABLE productdb
  ADD PRIMARY KEY (p_id);

--
-- Indexes for table `transactdb`
--
ALTER TABLE transactdb
  ADD PRIMARY KEY (stp_id);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employeedb`
--
ALTER TABLE employeedb
  ADD e_id int IDENTITY(1,1);
--
-- AUTO_INCREMENT for table `productdb`
--
ALTER TABLE productdb
  ADD p_id int IDENTITY(1,1);
--
-- AUTO_INCREMENT for table `transactdb`
--
ALTER TABLE transactdb
 ADD stp_id int IDENTITY(1,1);
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
