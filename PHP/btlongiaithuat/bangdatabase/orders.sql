-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 29, 2021 at 07:03 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbgiaithuat`
--

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `fullname` varchar(100) DEFAULT NULL,
  `phone_number` varchar(20) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `order_date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `fullname`, `phone_number`, `email`, `address`, `order_date`) VALUES
(1, 'fullname', 'phone_number', 'email', 'address', '0000-00-00 00:00:00'),
(2, 'Truong Van', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 17:36:42'),
(3, 'Truong Van1', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 17:37:55'),
(4, 'Truong Van1', '0377222794', 'vantruong08062002@gmail.com', 'hà nội', '2021-12-29 17:38:04'),
(5, 'Truong Van', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 17:42:13'),
(6, 'fullname', 'phone_number', 'email', 'address', '0000-00-00 00:00:00'),
(7, 'Truong Van', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 17:56:23'),
(8, 'Truong Van', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 18:10:32'),
(9, 'Truong Van', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 18:11:18'),
(10, 'Truong Van 9', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 18:13:37'),
(11, 'Truong Van 10', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 18:15:02'),
(12, 'Truong Van 10', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 18:16:32'),
(13, 'Truong Van 11', '0377222794', 'vantruong08062002@gmail.com', 'null', '2021-12-29 18:19:59');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
