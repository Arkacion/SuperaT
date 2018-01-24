-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 24-01-2018 a las 10:53:26
-- Versión del servidor: 5.7.19
-- Versión de PHP: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `superat`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `description`
--

DROP TABLE IF EXISTS `description`;
CREATE TABLE IF NOT EXISTS `description` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `id_file` varchar(64) COLLATE utf8_bin NOT NULL,
  `date` date NOT NULL,
  `time` date NOT NULL,
  `max` float NOT NULL,
  `min` float NOT NULL,
  `deff_max_min` float NOT NULL,
  `s_01` float NOT NULL,
  `s_02` float NOT NULL,
  `s_03` float NOT NULL,
  `s_04` float NOT NULL,
  `s_05` float NOT NULL,
  `s_06` float NOT NULL,
  `s_07` float NOT NULL,
  `s_08` float NOT NULL,
  `s_09` float NOT NULL,
  `s_10` float NOT NULL,
  `s_11` float NOT NULL,
  `s_12` float NOT NULL,
  `s_13` float NOT NULL,
  `s_14` float NOT NULL,
  `s_15` float NOT NULL,
  `s_16` float NOT NULL,
  `s_17` float NOT NULL,
  `s_18` float NOT NULL,
  `s_19` float NOT NULL,
  `s_20` float NOT NULL,
  `s_21` float NOT NULL,
  `s_22` float NOT NULL,
  `s_23` float NOT NULL,
  `s_24` float NOT NULL,
  `s_25` float NOT NULL,
  `s_26` float NOT NULL,
  `s_27` float NOT NULL,
  `s_28` float NOT NULL,
  `s_29` float NOT NULL,
  `s_30` float NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `user_id` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `description`
--

INSERT INTO `description` (`Id`, `user_id`, `id_file`, `date`, `time`, `max`, `min`, `deff_max_min`, `s_01`, `s_02`, `s_03`, `s_04`, `s_05`, `s_06`, `s_07`, `s_08`, `s_09`, `s_10`, `s_11`, `s_12`, `s_13`, `s_14`, `s_15`, `s_16`, `s_17`, `s_18`, `s_19`, `s_20`, `s_21`, `s_22`, `s_23`, `s_24`, `s_25`, `s_26`, `s_27`, `s_28`, `s_29`, `s_30`) VALUES
(1, 1, 'dfdsfd113iebn', '2018-01-18', '2000-02-12', 10, 45, 300, 100, 110, 110, 110, 113, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 100, 110, 110, 110, 113, 200, 223, 123, 457, 342),
(2, 1, 'dfdsfd113iebn', '2018-01-18', '2000-02-12', 565, 30, 545, 100, 110, 321, 110, 234, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 120, 110, 110, 343, 113, 234, 223, 123, 457, 124),
(3, 1, 'dfdsfd113iebn', '2018-01-18', '2000-02-12', 324, 123, 300, 100, 110, 110, 110, 113, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 456, 754, 232, 454, 113, 200, 223, 123, 457, 546),
(4, 1, 'ef234qr4f', '2018-01-18', '2000-02-12', 10, 45, 300, 100, 110, 110, 110, 113, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 100, 110, 110, 110, 113, 200, 223, 123, 457, 342),
(5, 1, '4rt43f13iebn', '2018-01-18', '2000-02-12', 565, 30, 545, 100, 110, 321, 110, 234, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 120, 110, 110, 343, 113, 234, 223, 123, 457, 124),
(6, 1, 'dfddefqef113iebn', '2017-12-28', '2000-02-12', 324, 123, 300, 100, 110, 110, 110, 113, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 456, 754, 232, 454, 113, 200, 223, 123, 457, 546),
(7, 1, 'farw34wt3', '2018-01-18', '2000-02-12', 10, 45, 300, 100, 110, 110, 110, 113, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 100, 110, 110, 110, 113, 200, 223, 123, 457, 342),
(8, 1, 'fa4t43fq4r', '2017-12-04', '2000-02-12', 565, 30, 545, 100, 110, 321, 110, 234, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 120, 110, 110, 343, 113, 234, 223, 123, 457, 124),
(9, 1, 'dfdsfd113iebn', '2017-12-10', '2000-02-12', 324, 123, 300, 100, 110, 110, 110, 113, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 456, 754, 232, 454, 113, 200, 223, 123, 457, 546),
(10, 1, 'd4qefawf', '2018-01-18', '2000-02-12', 10, 45, 300, 123, 12123, 123, 343, 343, 123, 223, 123, 451, 213, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 100, 110, 110, 110, 113, 200, 223, 123, 457, 342),
(11, 1, 'dffd1afefa13iebn', '2018-01-12', '2000-02-12', 565, 30, 545, 123, 123, 435, 656, 234, 200, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 120, 110, 110, 343, 113, 234, 223, 123, 457, 124),
(12, 1, 'dffdcefaw113iebn', '2017-12-08', '2000-02-12', 324, 656, 300, 6562, 1231, 1231, 1232, 222, 123, 223, 123, 451, 300, 100, 110, 110, 110, 113, 200, 223, 123, 452, 300, 456, 754, 232, 454, 113, 200, 223, 123, 457, 546),
(13, 1, 'dffdcefaw113iebn', '2017-12-08', '2000-02-12', 324, 656, 300, 6562, 1231, 1231, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(32) COLLATE utf8_bin DEFAULT NULL,
  `Surname` varchar(64) COLLATE utf8_bin DEFAULT NULL,
  `Dni` char(9) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Dni` (`Dni`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`Id`, `Name`, `Surname`, `Dni`) VALUES
(1, 'Medico1', 'Psy', '33223133R');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
