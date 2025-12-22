-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           11.8.3-MariaDB-ubu2404 - mariadb.org binary distribution
-- SE du serveur:                debian-linux-gnu
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour db_fournisseurs
CREATE DATABASE IF NOT EXISTS `db_fournisseurs` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_uca1400_ai_ci */;
USE `db_fournisseurs`;

-- Listage de la structure de procédure db_fournisseurs. afficher_employe
DELIMITER //
CREATE PROCEDURE `afficher_employe`()
BEGIN
	SELECT
		codeEmpl,
		nom,
		salaire
	FROM
		employe
	ORDER BY
		nom ASC;
END//
DELIMITER ;

-- Listage de la structure de procédure db_fournisseurs. afficher_produit_fournisseur
DELIMITER //
CREATE PROCEDURE `afficher_produit_fournisseur`(IN p_codeF CHAR(6))
BEGIN
	SELECT
		A.nomA AS "Nom Article",
		A.`type` AS "Type Article",
		A.nomR AS "Rayon"
	FROM
		ligne_bon_de_livraison AS L
	INNER JOIN
		articles AS A ON A.codeA = L.codeA
	WHERE
	L.codeF = p_codeF;
END//
DELIMITER ;

-- Listage de la structure de procédure db_fournisseurs. afficher_prod_outFournisseur
DELIMITER //
CREATE PROCEDURE `afficher_prod_outFournisseur`(IN p_codeF CHAR(6), OUT p_nomfournisseur VARCHAR(50))
BEGIN
	SELECT
		A.nomA AS "Nom Article",
		A.`type` AS "Type Article",
		A.nomR AS "Rayon"
	FROM
		ligne_bon_de_livraison AS L
	INNER JOIN
		articles AS A ON A.codeA = L.codeA
	WHERE
	L.codeF LIKE p_codeF;
	SELECT
		nomF INTO p_nomfournisseur
	FROM
		fournisseurs
	WHERE codeF = p_codeF;
END//
DELIMITER ;

-- Listage de la structure de table db_fournisseurs. articles
CREATE TABLE IF NOT EXISTS `articles` (
  `codeA` char(8) NOT NULL,
  `nomA` varchar(255) NOT NULL,
  `type` varchar(50) DEFAULT NULL,
  `nomR` varchar(50) NOT NULL,
  `prix` decimal(5,2) NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`codeA`),
  KEY `nomR` (`nomR`),
  CONSTRAINT `articles_ibfk_1` FOREIGN KEY (`nomR`) REFERENCES `rayon` (`nomR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_fournisseurs.articles : ~10 rows (environ)
INSERT INTO `articles` (`codeA`, `nomA`, `type`, `nomR`, `prix`) VALUES
	('A0000001', 'Aspirateur', 'Electroménager', 'Electroménager', 120.00),
	('A0000002', 'Poupée', 'Jouet', 'Jouets', 50.00),
	('A0000003', 'T-shirt', 'Vêtement', 'Vêtements', 10.00),
	('A0000004', 'Pain', 'Aliment', 'Alimentation', 1.00),
	('A0000005', 'Marteau', 'Outil', 'Bricolage', 12.00),
	('A0000006', 'Réfrigérateur', 'Electroménager', 'Electroménager', 500.00),
	('A0000007', 'Voiture télécommandée', 'Jouet', 'Jouets', 20.00),
	('A0000008', 'Jean', 'Vêtement', 'Vêtements', 40.00),
	('A0000009', 'Lait', 'Aliment', 'Alimentation', 1.50),
	('A0000010', 'Tournevis', 'Outil', 'Bricolage', 3.00);

-- Listage de la structure de table db_fournisseurs. employe
CREATE TABLE IF NOT EXISTS `employe` (
  `codeEmpl` int(11) NOT NULL,
  `nom` varchar(50) NOT NULL,
  `salaire` int(11) NOT NULL,
  `nomR` varchar(50) NOT NULL,
  `codeSupHierarchique` int(11) NOT NULL,
  PRIMARY KEY (`codeEmpl`),
  KEY `nomR` (`nomR`),
  KEY `codeSupHierarchique` (`codeSupHierarchique`),
  CONSTRAINT `employe_ibfk_1` FOREIGN KEY (`nomR`) REFERENCES `rayon` (`nomR`),
  CONSTRAINT `employe_ibfk_2` FOREIGN KEY (`codeSupHierarchique`) REFERENCES `employe` (`codeEmpl`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_fournisseurs.employe : ~5 rows (environ)
INSERT INTO `employe` (`codeEmpl`, `nom`, `salaire`, `nomR`, `codeSupHierarchique`) VALUES
	(1, 'Martin', 2000, 'Electroménager', 1),
	(2, 'Durand', 1800, 'Jouets', 1),
	(3, 'Lefevre', 1700, 'Vêtements', 1),
	(4, 'Bernard', 1600, 'Alimentation', 1),
	(5, 'Dubois', 1850, 'Bricolage', 1);

-- Listage de la structure de table db_fournisseurs. fournisseurs
CREATE TABLE IF NOT EXISTS `fournisseurs` (
  `codeF` char(6) NOT NULL,
  `nomF` varchar(50) NOT NULL,
  `adresse` varchar(50) NOT NULL,
  PRIMARY KEY (`codeF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_fournisseurs.fournisseurs : ~5 rows (environ)
INSERT INTO `fournisseurs` (`codeF`, `nomF`, `adresse`) VALUES
	('FABCDE', 'Alpha', '12 rue des Lilas'),
	('FABCFG', 'Beta', '34 avenue des Roses'),
	('FBCDEF', 'Gamma', '56 boulevard des Pins'),
	('FCDEFG', 'Delta', '78 impasse des Tulipes'),
	('FDEFGH', 'Epsilon', '90 place des Marguerites');

-- Listage de la structure de table db_fournisseurs. ligne_bon_de_livraison
CREATE TABLE IF NOT EXISTS `ligne_bon_de_livraison` (
  `codeF` char(6) NOT NULL,
  `codeA` char(8) NOT NULL,
  `quantité` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codeF`,`codeA`),
  KEY `codeA` (`codeA`),
  CONSTRAINT `ligne_bon_de_livraison_ibfk_1` FOREIGN KEY (`codeF`) REFERENCES `fournisseurs` (`codeF`),
  CONSTRAINT `ligne_bon_de_livraison_ibfk_2` FOREIGN KEY (`codeA`) REFERENCES `articles` (`codeA`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_fournisseurs.ligne_bon_de_livraison : ~21 rows (environ)
INSERT INTO `ligne_bon_de_livraison` (`codeF`, `codeA`, `quantité`) VALUES
	('FABCDE', 'A0000001', '10'),
	('FABCDE', 'A0000002', '5'),
	('FABCDE', 'A0000003', '11'),
	('FABCDE', 'A0000006', '8'),
	('FABCDE', 'A0000008', '16'),
	('FABCFG', 'A0000002', '20'),
	('FABCFG', 'A0000003', '9'),
	('FABCFG', 'A0000004', '14'),
	('FABCFG', 'A0000007', '12'),
	('FABCFG', 'A0000009', '21'),
	('FBCDEF', 'A0000003', '15'),
	('FBCDEF', 'A0000004', '22'),
	('FBCDEF', 'A0000005', '9'),
	('FBCDEF', 'A0000008', '18'),
	('FBCDEF', 'A0000010', '4'),
	('FCDEFG', 'A0000001', '12'),
	('FCDEFG', 'A0000004', '50'),
	('FCDEFG', 'A0000005', '3'),
	('FCDEFG', 'A0000006', '7'),
	('FCDEFG', 'A0000009', '30'),
	('FDEFGH', 'A0000001', '6'),
	('FDEFGH', 'A0000002', '8'),
	('FDEFGH', 'A0000005', '5'),
	('FDEFGH', 'A0000007', '13'),
	('FDEFGH', 'A0000010', '7');

-- Listage de la structure de table db_fournisseurs. rayon
CREATE TABLE IF NOT EXISTS `rayon` (
  `nomR` varchar(50) NOT NULL,
  `etage` int(11) NOT NULL,
  PRIMARY KEY (`nomR`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_fournisseurs.rayon : ~5 rows (environ)
INSERT INTO `rayon` (`nomR`, `etage`) VALUES
	('Alimentation', 0),
	('Bricolage', 2),
	('Electroménager', 1),
	('Jouets', 2),
	('Vêtements', 1);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
