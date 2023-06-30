-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 29, 2021 at 07:04 PM
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
-- Table structure for table `phanloai`
--

CREATE TABLE `phanloai` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `thumbnail` varchar(500) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `phanloai`
--

INSERT INTO `phanloai` (`id`, `name`, `thumbnail`, `created_at`, `updated_at`) VALUES
(4, 'Cấu trúc logic cảu máy tính', 'https://image.slidesharecdn.com/bai3tin10-131222063753-phpapp02-141127203024-conversion-gate01/95/bai3tin10-131222063753phpapp02-8-638.jpg?cb=1417120287', NULL, '2021-12-05 17:17:22'),
(6, 'Cây nhị phân và mã Huffman', 'https://khiemle.dev/wp-content/uploads/2020/06/Cay-nhi-phan-trong-cpp-1200x628.jpg', '2021-12-06 10:22:15', '2021-12-06 13:46:45'),
(8, 'Stack', 'https://st.quantrimang.com/photos/image/2018/08/10/cau-truc-du-lieu-ngan-xep-stack-2.jpg', '2021-12-06 17:00:19', '2021-12-06 17:00:19'),
(9, 'vector', 'https://i.pinimg.com/originals/9c/7d/6f/9c7d6f69fd02e068a4c381fadd4ea9b4.png', '2021-12-06 17:23:25', '2021-12-06 17:23:25'),
(10, 'Class', 'https://topdev.vn/blog/wp-content/uploads/2020/12/class.jpg', '2021-12-06 17:29:27', '2021-12-06 17:29:27'),
(12, 'Đệ quy', 'https://wraughk.com/wp-content/uploads/2021/05/tinh-do-phuc-tap-cua-thuat-toan-de-quy-min.jpg', '2021-12-07 08:54:26', '2021-12-07 08:54:26'),
(13, 'Linked List', 'https://cafedev.vn/wp-content/uploads/2020/10/cafedev_circular_Linklist.png', '2021-12-07 09:42:01', '2021-12-07 09:42:01'),
(14, 'String', 'https://i.ytimg.com/vi/4pd-OhwfzJU/maxresdefault.jpg', '2021-12-07 09:31:07', '2021-12-09 08:16:07'),
(15, 'Thuật toán LZW', 'https://cdn.tgdd.vn/hoi-dap/1354895/dinh-dang-anh-tiff-la-gi-cach-chuyen-doi-file-tiff-sang-11-800x450.jpg', '2021-12-10 05:47:06', '2021-12-10 05:47:06'),
(16, 'Thuật toán K-Means', 'https://nguyenvanhieu.vn/wp-content/uploads/2018/08/thuat-toan-phan-cum-k-means.png', '2021-12-10 05:02:56', '2021-12-10 05:02:56');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `phanloai`
--
ALTER TABLE `phanloai`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `phanloai`
--
ALTER TABLE `phanloai`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
