-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 31, 2023 at 08:19 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbapi`
--

-- --------------------------------------------------------

--
-- Table structure for table `pemesanan`
--

CREATE TABLE `pemesanan` (
  `id_pemesan` int(11) NOT NULL,
  `nama_pemesanan` varchar(50) DEFAULT '',
  `email` varchar(50) DEFAULT '',
  `no_hp` int(20) DEFAULT 0,
  `tanggal_lahir` varchar(50) DEFAULT '',
  `bayar` varchar(50) DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pemesanan`
--

INSERT INTO `pemesanan` (`id_pemesan`, `nama_pemesanan`, `email`, `no_hp`, `tanggal_lahir`, `bayar`) VALUES
(1, 'reza ramadhan', 'rezaramadan@gmail.com', 830786712, '12-05-2000', '30000');

-- --------------------------------------------------------

--
-- Table structure for table `tb_agen`
--

CREATE TABLE `tb_agen` (
  `id_agen` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL DEFAULT '',
  `no_telpon` int(12) NOT NULL DEFAULT 0,
  `alamat` varchar(100) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tb_kendaraan`
--

CREATE TABLE `tb_kendaraan` (
  `id_kendaraan` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL DEFAULT '',
  `daya_angkut` varchar(50) NOT NULL DEFAULT '',
  `harga` varchar(50) NOT NULL DEFAULT '',
  `id_rute` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tb_rute`
--

CREATE TABLE `tb_rute` (
  `id_rute` int(11) NOT NULL,
  `asal` varchar(100) NOT NULL DEFAULT '',
  `tujuan` varchar(100) NOT NULL DEFAULT '',
  `nama` varchar(50) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tb_tiket`
--

CREATE TABLE `tb_tiket` (
  `id_tiket` int(11) NOT NULL,
  `id_pemesan` int(11) DEFAULT NULL,
  `nama_pemesan` varchar(50) DEFAULT NULL,
  `id_kendaraan` int(11) DEFAULT NULL,
  `id_rute` int(11) DEFAULT NULL,
  `id_agen` int(11) DEFAULT NULL,
  `tangal_berangkat` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `passwd` varchar(50) NOT NULL,
  `rolename` enum('admin','dosen','mahasiswa') NOT NULL DEFAULT 'mahasiswa'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `passwd`, `rolename`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 'admin'),
(2, 'sokid', '202cb962ac59075b964b07152d234b70', 'dosen'),
(3, 'farhan', '202cb962ac59075b964b07152d234b70', 'mahasiswa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pemesanan`
--
ALTER TABLE `pemesanan`
  ADD PRIMARY KEY (`id_pemesan`),
  ADD UNIQUE KEY `nama_pemesanan` (`nama_pemesanan`);

--
-- Indexes for table `tb_agen`
--
ALTER TABLE `tb_agen`
  ADD PRIMARY KEY (`id_agen`),
  ADD UNIQUE KEY `nama` (`nama`);

--
-- Indexes for table `tb_kendaraan`
--
ALTER TABLE `tb_kendaraan`
  ADD PRIMARY KEY (`id_kendaraan`),
  ADD UNIQUE KEY `nama` (`nama`),
  ADD KEY `FK_tb_kendaraan_tb_rute` (`id_rute`);

--
-- Indexes for table `tb_rute`
--
ALTER TABLE `tb_rute`
  ADD PRIMARY KEY (`id_rute`),
  ADD UNIQUE KEY `nama` (`nama`);

--
-- Indexes for table `tb_tiket`
--
ALTER TABLE `tb_tiket`
  ADD PRIMARY KEY (`id_tiket`),
  ADD UNIQUE KEY `nama_pemesan` (`nama_pemesan`),
  ADD KEY `FK__pemesanan` (`id_pemesan`),
  ADD KEY `FK__tb_kendaraan` (`id_kendaraan`),
  ADD KEY `FK__tb_rute` (`id_rute`),
  ADD KEY `FK__tb_agen` (`id_agen`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idx` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_kendaraan`
--
ALTER TABLE `tb_kendaraan`
  ADD CONSTRAINT `FK_tb_kendaraan_tb_rute` FOREIGN KEY (`id_rute`) REFERENCES `tb_rute` (`id_rute`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tb_tiket`
--
ALTER TABLE `tb_tiket`
  ADD CONSTRAINT `FK__pemesanan` FOREIGN KEY (`id_pemesan`) REFERENCES `pemesanan` (`id_pemesan`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK__tb_agen` FOREIGN KEY (`id_agen`) REFERENCES `tb_agen` (`id_agen`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK__tb_kendaraan` FOREIGN KEY (`id_kendaraan`) REFERENCES `tb_kendaraan` (`id_kendaraan`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK__tb_rute` FOREIGN KEY (`id_rute`) REFERENCES `tb_rute` (`id_rute`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
