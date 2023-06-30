-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 29, 2021 at 07:05 PM
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
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `title` varchar(250) NOT NULL,
  `thumbnail` varchar(500) DEFAULT NULL,
  `content` longtext DEFAULT NULL,
  `price` float DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`id`, `title`, `thumbnail`, `content`, `price`, `created_at`, `updated_at`) VALUES
(2, 'iPhone 13 Pro Max 128GB', 'https://images.fpt.shop/unsafe/fit-in/800x800/filters:quality(90):fill(white):upscale()/fptshop.com.vn/Uploads/Originals/2021/9/15/637673217819795830_iphone-13-pro-max-xam-1.jpg', '6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>\r\n6.7\", Super Retina XDR, OLED, 2778 x 1284 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n12.0 MP\r\n<br/>\r\nA15 Bionic\r\n<br/>\r\n128 GB\r\n<br/>', 32990000, '2021-12-27 11:50:50', '2021-12-27 11:50:50'),
(3, 'Samsung Galaxy Z Fold3 5G 256GB', 'https://images.fpt.shop/unsafe/fit-in/800x800/filters:quality(90):fill(white):upscale()/fptshop.com.vn/Uploads/Originals/2021/8/11/637643195814330368_samsung-galaxy-z-fold3-xanh-1.jpg', 'Màn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\nMàn hình chính: 7.6”, Màn hình phụ: 6.2”, HD+, Chính: Dynamic AMOLED 2X, phụ: Dynamic AMOLED 2X, 1768 x 2208 Pixel\r\n<br/>\r\n12.0 MP + 12.0 MP + 12.0 MP\r\n<br/>\r\n10.0 MP\r\n<br/>\r\nSnapdragon 888\r\n<br/>\r\n256 GB\r\n<br/>\r\n', 40990000, '2021-12-27 11:55:34', '2021-12-27 11:55:34');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
