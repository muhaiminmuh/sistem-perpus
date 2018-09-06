-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 11, 2018 at 05:50 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_peminjam`
--

CREATE TABLE `data_peminjam` (
  `id_peminjam` char(10) NOT NULL,
  `nama_peminjam` varchar(25) NOT NULL,
  `alamat` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_peminjam`
--

INSERT INTO `data_peminjam` (`id_peminjam`, `nama_peminjam`, `alamat`) VALUES
('K001', 'Utamirah', 'Klaten'),
('K002', 'Suryani', 'Jogjakarta'),
('K003', 'Indiana Inka Sukmara', 'Surakarta'),
('K004', 'Taufan Firmansyah', 'Sukoharjo'),
('K005', 'William Micko Saputra', 'Sukoharjo'),
('K006', 'Drupadi', 'Surakarta');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_buku`
--

CREATE TABLE `tabel_buku` (
  `kode` char(10) NOT NULL,
  `judul` varchar(25) NOT NULL,
  `pengarang` varchar(30) NOT NULL,
  `penerbit` varchar(30) NOT NULL,
  `tahun` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_buku`
--

INSERT INTO `tabel_buku` (`kode`, `judul`, `pengarang`, `penerbit`, `tahun`) VALUES
('B01', 'Bahasa Indonesia', 'Tarigan', 'PT. Gramedia', '2006'),
('I01', 'Ilmu Pengetahuan Alam', 'Taringan', 'PT. Gramedia', '2006'),
('M01', 'Matematika', 'Choirul', 'PT. Gramedia', '2006'),
('P01', 'Pemrogramman Visual', 'Yudistiro', 'Tiga Serangkai', '2014');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_peminjaman`
--

CREATE TABLE `tabel_peminjaman` (
  `kode_peminjaman` char(10) NOT NULL,
  `id_peminjam` varchar(10) NOT NULL,
  `kode` varchar(10) NOT NULL,
  `tanggal_peminjaman` varchar(30) NOT NULL,
  `tanggal_pengembalian` varchar(30) NOT NULL,
  `lama` int(3) NOT NULL,
  `biaya_administrasi` int(10) NOT NULL,
  `total_biaya` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_peminjaman`
--

INSERT INTO `tabel_peminjaman` (`kode_peminjaman`, `id_peminjam`, `kode`, `tanggal_peminjaman`, `tanggal_pengembalian`, `lama`, `biaya_administrasi`, `total_biaya`) VALUES
('B01', 'K001', 'M01', 'Kamis, 21 Desember 2017', 'Minggu, 24 Desember 2017', 3, 1500, 4500),
('B02', 'K002', 'P01', 'Sabtu, 09 Desember 2017', 'Sabtu, 13 Januari 2018', 4, 1500, 6000),
('B03', 'K006', 'P01', 'Rabu, 13 Desember 2017', 'Minggu, 17 Desember 2017', 4, 1500, 6000),
('B04', 'K006', 'I01', 'Jumat, 29 Desember 2017', 'Minggu, 31 Desember 2017', 2, 1500, 3000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_peminjam`
--
ALTER TABLE `data_peminjam`
  ADD PRIMARY KEY (`id_peminjam`);

--
-- Indexes for table `tabel_buku`
--
ALTER TABLE `tabel_buku`
  ADD PRIMARY KEY (`kode`);

--
-- Indexes for table `tabel_peminjaman`
--
ALTER TABLE `tabel_peminjaman`
  ADD PRIMARY KEY (`kode_peminjaman`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
