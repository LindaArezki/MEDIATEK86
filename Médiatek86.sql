-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 20 avr. 2022 à 08:57
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(11) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  `IDMOTIF` int(11) NOT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`)
  ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `DATEFIN`, `IDMOTIF`) VALUES
(1, '2021-04-17 00:00:00', '2021-05-28 00:00:00', 3),
(1, '2021-05-19 00:00:00', '2021-08-11 00:00:00', 2),
(1, '2021-07-29 00:00:00', '2021-09-15 00:00:00', 3),
(1, '2021-10-13 00:00:00', '2021-08-05 00:00:00', 3),
(2, '2021-04-18 00:00:00', '2021-04-15 00:00:00', 1),
(2, '2021-05-23 00:00:00', '2021-06-08 00:00:00', 1),
(3, '2021-06-02 00:00:00', '2021-11-07 00:00:00', 3),
(4, '2021-04-30 00:00:00', '2021-09-01 00:00:00', 1),
(4, '2021-05-25 00:00:00', '2021-09-09 00:00:00', 2),
(4, '2021-06-25 00:00:00', '2021-05-17 00:00:00', 2),
(4, '2021-06-28 00:00:00', '2021-05-15 00:00:00', 2),
(4, '2021-07-31 00:00:00', '2021-05-17 00:00:00', 1),
(4, '2021-08-08 00:00:00', '2021-04-03 00:00:00', 3),
(4, '2021-09-10 00:00:00', '2021-12-17 00:00:00', 2),
(5, '2021-03-22 00:00:00', '2021-08-02 00:00:00', 2),
(5, '2021-04-30 00:00:00', '2021-05-28 00:00:00', 3),
(5, '2021-09-02 00:00:00', '2021-12-23 00:00:00', 2),
(5, '2021-10-16 00:00:00', '2021-09-03 00:00:00', 2),
(6, '2021-05-23 00:00:00', '2021-11-10 00:00:00', 1),
(6, '2021-06-01 00:00:00', '2021-08-29 00:00:00', 1),
(6, '2021-07-13 00:00:00', '2021-03-30 00:00:00', 2),
(6, '2021-07-24 00:00:00', '2021-11-22 00:00:00', 3),
(6, '2021-07-30 00:00:00', '2021-05-19 00:00:00', 1),
(6, '2021-09-01 00:00:00', '2021-10-25 00:00:00', 3),
(7, '2021-03-15 00:00:00', '2021-09-28 00:00:00', 3),
(7, '2021-03-23 00:00:00', '2021-07-28 00:00:00', 3),
(7, '2021-05-02 00:00:00', '2021-06-02 00:00:00', 1),
(7, '2021-05-20 00:00:00', '2021-12-25 00:00:00', 2),
(7, '2021-10-28 00:00:00', '2021-07-19 00:00:00', 2),
(7, '2021-10-31 00:00:00', '2021-11-11 00:00:00', 3),
(8, '2021-04-01 00:00:00', '2021-04-04 00:00:00', 2),
(8, '2021-04-29 00:00:00', '2021-04-25 00:00:00', 1),
(8, '2021-06-16 00:00:00', '2021-10-23 00:00:00', 2),
(8, '2021-06-30 00:00:00', '2021-11-20 00:00:00', 2),
(8, '2021-07-19 00:00:00', '2021-03-20 00:00:00', 1),
(8, '2021-10-09 00:00:00', '2021-06-05 00:00:00', 1),
(8, '2021-11-01 00:00:00', '2021-06-01 00:00:00', 1),
(8, '2021-11-04 00:00:00', '2021-08-15 00:00:00', 2),
(8, '2021-11-10 00:00:00', '2021-11-26 00:00:00', 3),
(8, '2021-11-18 00:00:00', '2021-12-06 00:00:00', 1),
(8, '2022-01-01 00:00:00', '2021-03-20 00:00:00', 2),
(9, '2021-04-26 00:00:00', '2021-04-27 00:00:00', 1),
(9, '2021-05-09 00:00:00', '2021-09-14 00:00:00', 2),
(9, '2021-05-13 00:00:00', '2021-10-23 00:00:00', 2),
(9, '2021-06-15 00:00:00', '2021-04-25 00:00:00', 2),
(9, '2021-10-05 00:00:00', '2021-03-26 00:00:00', 3),
(10, '2021-03-15 00:00:00', '2021-04-20 00:00:00', 3),
(10, '2021-04-27 00:00:00', '2021-05-11 00:00:00', 2),
(10, '2021-07-07 00:00:00', '2021-06-24 00:00:00', 2),
(10, '2021-07-25 00:00:00', '2021-04-11 00:00:00', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) CHARACTER SET utf16 COLLATE utf16_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacance'),
(2, ' maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(11) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(11) NOT NULL,
  `NOM` varchar(50) COLLATE utf16_unicode_ci DEFAULT NULL,
  `PRENOM` varchar(50) COLLATE utf16_unicode_ci DEFAULT NULL,
  `TEL` varchar(15) COLLATE utf16_unicode_ci DEFAULT NULL,
  `MAIL` varchar(128) COLLATE utf16_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`) USING BTREE,
  KEY `FK_IDSERVICE` (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf16 COLLATE=utf16_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 2, 'Mejia', 'Maggy', '02 46 63 76 58', 'egestas.nunc.sed@hotmail.org'),
(2, 2, 'Lucas', 'Tarik', '06 72 35 21 88', 'etiam.ligula.tortor@icloud.net'),
(3, 2, 'Navarro', 'Patience', '04 13 41 58 61', 'nunc@protonmail.org'),
(4, 3, 'Fulton', 'Salvador', '04 48 22 42 66', 'donec@yahoo.net'),
(5, 2, 'Holder', 'Lesley', '06 36 46 78 67', 'nec.metus@aol.com'),
(6, 1, 'Kline', 'Aimee', '05 49 26 16 78', 'ligula.donec@icloud.org'),
(7, 1, 'Mccray', 'Kylan', '07 71 50 61 72', 'nulla.eget@google.couk'),
(8, 1, 'Schmidt', 'Athena', '01 53 90 76 77', 'hendrerit.consectetuer.cursus@outlook.net'),
(9, 3, 'Douglas', 'Sonia', '06 77 84 37 66', 'enim.commodo@google.ca'),
(10, 2, 'Mitchell', 'Azalia', '08 48 02 42 43', 'primis.in.faucibus@outlook.com'),
(16, 1, 'Arezki', 'Linda', '020101402564', 'LOLOLO');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('Mediatekadmin', 'a3c2c2d72b21f23c9248468183449a55305aea72da418ce4460caf8461f2373c');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(11) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

