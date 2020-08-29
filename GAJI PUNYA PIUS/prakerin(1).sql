-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 01 Agu 2019 pada 05.41
-- Versi server: 10.1.31-MariaDB
-- Versi PHP: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `prakerin`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `absensi`
--

CREATE TABLE `absensi` (
  `Nip` varchar(20) NOT NULL,
  `Nama_karyawan` varchar(40) NOT NULL,
  `Jabatan` varchar(15) NOT NULL,
  `Tanggal` varchar(20) NOT NULL,
  `Jam_masuk` varchar(6) NOT NULL,
  `Jam_keluar` varchar(6) NOT NULL,
  `Jam_lembur` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `anggota`
--

CREATE TABLE `anggota` (
  `nip` varchar(20) NOT NULL DEFAULT '',
  `Nama` varchar(30) DEFAULT NULL,
  `Alamat` varchar(30) DEFAULT NULL,
  `Telepon` varchar(15) DEFAULT NULL,
  `Simpanan_Wajib` int(11) DEFAULT NULL,
  `Simpanan_Pokok` int(11) DEFAULT NULL,
  `Simpanan_SukaRela` int(11) DEFAULT NULL,
  `Saldo` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `anggota`
--

INSERT INTO `anggota` (`nip`, `Nama`, `Alamat`, `Telepon`, `Simpanan_Wajib`, `Simpanan_Pokok`, `Simpanan_SukaRela`, `Saldo`) VALUES
('0112040', 'Joko', 'Bogor', '089860254263', 100000, 250000, 50000, 400000),
('0119090', 'Dennis', 'Jakarta Pusat', '082279457274', 50000, 250000, 475000, 75000),
('0113101', 'Ririn', 'Cikarang', '081345410515', 50000, 250000, 300000, 600000),
('0110000', 'setyo', 'Klender', '082263955240', 100000, 250000, 200000, 600000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `golongan`
--

CREATE TABLE `golongan` (
  `Golongan` int(11) NOT NULL,
  `Tunjang_keluarga` varchar(12) NOT NULL,
  `Tunjangan_anak` varchar(12) NOT NULL,
  `Tunjangan_transpor` varchar(12) NOT NULL,
  `Tunjangan_makan` varchar(12) NOT NULL,
  `Tunjangan_lembur` varchar(12) NOT NULL,
  `Asuransi_kesehatan` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `golongan`
--

INSERT INTO `golongan` (`Golongan`, `Tunjang_keluarga`, `Tunjangan_anak`, `Tunjangan_transpor`, `Tunjangan_makan`, `Tunjangan_lembur`, `Asuransi_kesehatan`) VALUES
(1, '1000000', '500000', '50000', '30000', '75000', '5000000'),
(2, '1500000', '750000', '50000', '30000', '75000', '5000000'),
(3, '2000000', '1000000', '50000', '30000', '75000', '5000000'),
(4, '2500000', '1250000', '50000', '30000', '75000', '5000000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jabatan`
--

CREATE TABLE `jabatan` (
  `Kode_jabatan` varchar(10) NOT NULL,
  `Nama_jabatan` varchar(15) NOT NULL,
  `Gaji_pokok` varchar(12) NOT NULL,
  `Tunjangan_jabatan` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jabatan`
--

INSERT INTO `jabatan` (`Kode_jabatan`, `Nama_jabatan`, `Gaji_pokok`, `Tunjangan_jabatan`) VALUES
('ADM', 'Administrasi', '9000000', '7500000'),
('DRK', 'Direktur', '27500000', '13500000'),
('GM', 'General Manager', '30000000', '15000000'),
('MKT', 'Marketing', '10000000', '5000000'),
('MNG', 'Manager', '25000000', '12500000'),
('SPV', 'Supervisor', '20000000', '10000000'),
('STF', 'Staff', '7500000', '5000000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `Nip` varchar(15) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Alamat` text NOT NULL,
  `No_telp` varchar(20) NOT NULL,
  `Jenis_kelamin` varchar(15) NOT NULL,
  `Status` varchar(20) NOT NULL,
  `Jumlah_anak` varchar(10) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Kode_golongan` varchar(10) NOT NULL,
  `Kode_jabatan` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `karyawan`
--

INSERT INTO `karyawan` (`Nip`, `Nama`, `Alamat`, `No_telp`, `Jenis_kelamin`, `Status`, `Jumlah_anak`, `Email`, `Kode_golongan`, `Kode_jabatan`) VALUES
('0110000', 'setyo', 'Klender', '082263955240', 'Laki-laki', 'Belum Menikah', '0', 'setyokumolo@gmail.com', '1', 'DRK'),
('0112040', 'Joko', 'Bogor', '089860254263', 'Laki-laki', 'Menikah', '3', 'Jokoanwar@gmail.com', '1', 'MNG'),
('0113101', 'Ririn', 'Cikarang', '081345410515', 'Perempuan', 'Menikah', '2', 'Ririnsulis@gmail.com', '2', 'ADM'),
('0119090', 'Dennis', 'Jakarta Pusat', '082279457274', 'Laki-laki', 'Menikah', '2', 'Dennisyogi@gmail.com', '3', 'STF');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pengambilan`
--

CREATE TABLE `pengambilan` (
  `ID_Pengambilan` char(12) NOT NULL DEFAULT '',
  `Tanggal` date DEFAULT NULL,
  `nip` varchar(20) DEFAULT NULL,
  `Jumlah` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pengambilan`
--

INSERT INTO `pengambilan` (`ID_Pengambilan`, `Tanggal`, `nip`, `Jumlah`) VALUES
('ABL190513001', '2019-05-13', '0112040', 50000),
('ABL190513002', '2019-05-13', '0119090', 50000),
('ABL190513003', '2019-05-13', '0113101', 100000),
('ABL190725001', '2019-07-25', '0110000', 100000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `penggajian`
--

CREATE TABLE `penggajian` (
  `nip` varchar(20) NOT NULL,
  `nomor` varchar(20) NOT NULL,
  `tanggal` varchar(20) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` text NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `jabatan` varchar(20) NOT NULL,
  `status` varchar(10) NOT NULL,
  `jumlah_anak` varchar(10) NOT NULL,
  `golongan` varchar(20) NOT NULL,
  `gaji_pokok` varchar(12) NOT NULL,
  `tunjangan_jabatan` varchar(12) NOT NULL,
  `tunjangan_keluarga` varchar(12) NOT NULL,
  `tunjangan_anak` varchar(12) NOT NULL,
  `uang_lembur` varchar(12) NOT NULL,
  `uang_makan` varchar(12) NOT NULL,
  `asuransi_kesehatan` varchar(12) NOT NULL,
  `uang_transport` varchar(12) NOT NULL,
  `uang_total_kehadiran` varchar(50) NOT NULL,
  `uang_total_lembur` varchar(50) NOT NULL,
  `pendapatan` varchar(50) NOT NULL,
  `pengeluaran` varchar(50) NOT NULL,
  `gaji_bersih` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penggajian`
--

INSERT INTO `penggajian` (`nip`, `nomor`, `tanggal`, `nama`, `alamat`, `no_telp`, `email`, `jabatan`, `status`, `jumlah_anak`, `golongan`, `gaji_pokok`, `tunjangan_jabatan`, `tunjangan_keluarga`, `tunjangan_anak`, `uang_lembur`, `uang_makan`, `asuransi_kesehatan`, `uang_transport`, `uang_total_kehadiran`, `uang_total_lembur`, `pendapatan`, `pengeluaran`, `gaji_bersih`) VALUES
('0110000', '0000000002', 'Selasa, 30 Juli 2019', 'setyo', 'Klender', '082263955240', 'setyokumolo@gmail.com', 'Administrasi', 'Belum Meni', '0', '1', '9000000', '7500000', '1000000', '500000', '75000', '30000', '5000000', '50000', '1875000', '1725000', '10805000', '1875000', '8930000'),
('0119090', '0000000001', 'Kamis, 25 April 2019', 'Dennis', 'Jakarta Pusat', '082279457274', 'Dennisyogi@gmail.com', 'Administrasi', 'Menikah', '2', '1', '9000000', '7500000', '1000000', '500000', '75000', '30000', '5000000', '50000', '1575000', '1500000', '10580000', '1575000', '9005000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `simpanan`
--

CREATE TABLE `simpanan` (
  `ID_Simpanan` char(12) NOT NULL DEFAULT '',
  `Tanggal` date DEFAULT NULL,
  `nip` varchar(20) DEFAULT NULL,
  `Jenis_Simpanan` varchar(30) DEFAULT NULL,
  `Jumlah` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `simpanan`
--

INSERT INTO `simpanan` (`ID_Simpanan`, `Tanggal`, `nip`, `Jenis_Simpanan`, `Jumlah`) VALUES
('SPN190513001', '2019-05-13', '0112040', 'Wajib', 50000),
('SPN190513002', '2019-05-13', '0119090', 'Suka Rela', 250000),
('SPN190513003', '2019-05-13', '0113101', 'Suka Rela', 100000),
('SPN190725001', '2019-07-25', '0119090', 'Suka Rela', 75000);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `absensi`
--
ALTER TABLE `absensi`
  ADD PRIMARY KEY (`Nip`);

--
-- Indeks untuk tabel `anggota`
--
ALTER TABLE `anggota`
  ADD PRIMARY KEY (`nip`);

--
-- Indeks untuk tabel `golongan`
--
ALTER TABLE `golongan`
  ADD PRIMARY KEY (`Golongan`);

--
-- Indeks untuk tabel `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`Kode_jabatan`);

--
-- Indeks untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`Nip`);

--
-- Indeks untuk tabel `pengambilan`
--
ALTER TABLE `pengambilan`
  ADD PRIMARY KEY (`ID_Pengambilan`);

--
-- Indeks untuk tabel `penggajian`
--
ALTER TABLE `penggajian`
  ADD PRIMARY KEY (`nip`);

--
-- Indeks untuk tabel `simpanan`
--
ALTER TABLE `simpanan`
  ADD PRIMARY KEY (`ID_Simpanan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
