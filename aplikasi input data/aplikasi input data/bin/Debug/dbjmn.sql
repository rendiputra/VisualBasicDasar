-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 09, 2018 at 09:09 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 5.6.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbjmn`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblmahasiswa`
--

CREATE TABLE `tblmahasiswa` (
  `nimmhs` varchar(6) NOT NULL,
  `namamhs` varchar(100) NOT NULL,
  `alamatmhs` varchar(100) NOT NULL,
  `teleponmhs` varchar(100) NOT NULL,
  `jurusanmhs` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblmahasiswa`
--

INSERT INTO `tblmahasiswa` (`nimmhs`, `namamhs`, `alamatmhs`, `teleponmhs`, `jurusanmhs`) VALUES
('112233', 'Gerry ', 'Bekasi', '08521321323', 'Sistem Informasi'),
('121213', 'Raihan Nasuha', 'Bogor', '0851321323', 'Teknik Informasi'),
('121223', 'M Hanif', 'Bekasi', '085621321213', 'Teknik Informasi'),
('123123', 'Rendi Putra Pradana', 'Bekasi', '08562132124', 'Sistem Informasi'),
('123213', 'Ari R', 'Bekasi', '085123213', 'Sistem Informasi');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblmahasiswa`
--
ALTER TABLE `tblmahasiswa`
  ADD PRIMARY KEY (`nimmhs`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
