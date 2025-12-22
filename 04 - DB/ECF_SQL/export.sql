-- --------------------------------------------------------
-- Hôte:                         localhost
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


-- Listage de la structure de la base pour db_architecte
CREATE DATABASE IF NOT EXISTS `db_architecte` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_uca1400_ai_ci */;
USE `db_architecte`;

-- Listage de la structure de table db_architecte. adresses
CREATE TABLE IF NOT EXISTS `adresses` (
  `adresse_id` int(11) NOT NULL AUTO_INCREMENT,
  `adresse_code_postal` char(5) NOT NULL,
  `adresse_ville` varchar(50) NOT NULL,
  `adresse_num_voie` int(11) DEFAULT NULL,
  `adresse_voie` varchar(255) NOT NULL,
  PRIMARY KEY (`adresse_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.adresses : ~5 rows (environ)
INSERT INTO `adresses` (`adresse_id`, `adresse_code_postal`, `adresse_ville`, `adresse_num_voie`, `adresse_voie`) VALUES
	(1, '06000', 'Nice', 27, 'Rue Dabray'),
	(2, '06380', 'Sospel', 16, 'Rue de la Republique'),
	(3, '68200', 'Mulhouse', 7, 'Boulevard des Nations'),
	(4, '13500', 'Martigues', 12, 'Av. Georges Braque'),
	(5, '75017', 'Paris', 27, 'Rue des Renaudes');

-- Listage de la structure de table db_architecte. clients
CREATE TABLE IF NOT EXISTS `clients` (
  `client_ref` int(11) NOT NULL AUTO_INCREMENT,
  `client_nom` varchar(50) NOT NULL,
  `client_telephone` char(16) NOT NULL,
  `type_client_id` int(11) NOT NULL,
  `adresse_id` int(11) NOT NULL,
  PRIMARY KEY (`client_ref`),
  KEY `type_client_id` (`type_client_id`),
  KEY `adresse_id` (`adresse_id`),
  CONSTRAINT `clients_ibfk_1` FOREIGN KEY (`type_client_id`) REFERENCES `type_clients` (`type_client_id`),
  CONSTRAINT `clients_ibfk_2` FOREIGN KEY (`adresse_id`) REFERENCES `adresses` (`adresse_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.clients : ~5 rows (environ)
INSERT INTO `clients` (`client_ref`, `client_nom`, `client_telephone`, `type_client_id`, `adresse_id`) VALUES
	(1, 'Ville de Nice', '0450047785', 2, 1),
	(2, 'BOSS', '0615486223', 3, 2),
	(3, 'Lili', '0685941335', 1, 3),
	(4, 'ESCALA', '0102529164', 4, 4),
	(5, 'Mystère', '0000000000', 5, 5);

-- Listage de la structure de table db_architecte. employes
CREATE TABLE IF NOT EXISTS `employes` (
  `emp_matricule` int(11) NOT NULL AUTO_INCREMENT,
  `emp_nom` varchar(50) NOT NULL,
  `emp_prenom` varchar(50) NOT NULL,
  `emp_date_embauche` date NOT NULL,
  `fonction_id` int(11) NOT NULL,
  PRIMARY KEY (`emp_matricule`),
  KEY `fonction_id` (`fonction_id`),
  CONSTRAINT `employes_ibfk_1` FOREIGN KEY (`fonction_id`) REFERENCES `fonctions` (`fonction_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.employes : ~7 rows (environ)
INSERT INTO `employes` (`emp_matricule`, `emp_nom`, `emp_prenom`, `emp_date_embauche`, `fonction_id`) VALUES
	(1, 'Roussotte', 'Kévin', '2023-08-02', 1),
	(2, 'Schieber', 'Florian', '2023-08-03', 2),
	(3, 'Robson', 'Natana', '2023-08-04', 3),
	(4, 'Golay', 'Jerry', '2023-08-07', 1),
	(5, 'Neymar', 'Jean', '2023-08-07', 2),
	(6, 'Desplantes', 'Guillaume', '2023-08-07', 2),
	(7, 'Desplanques', 'Guy', '2010-08-07', 3);

-- Listage de la structure de table db_architecte. fonctions
CREATE TABLE IF NOT EXISTS `fonctions` (
  `fonction_id` int(11) NOT NULL AUTO_INCREMENT,
  `fonction_nom` varchar(50) NOT NULL,
  PRIMARY KEY (`fonction_id`),
  UNIQUE KEY `fonction_nom` (`fonction_nom`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.fonctions : ~3 rows (environ)
INSERT INTO `fonctions` (`fonction_id`, `fonction_nom`) VALUES
	(3, 'Administratif'),
	(1, 'Architecte'),
	(2, 'Dessinateur');

-- Listage de la structure de table db_architecte. participer
CREATE TABLE IF NOT EXISTS `participer` (
  `emp_matricule` int(11) NOT NULL,
  `projet_ref` int(11) NOT NULL,
  PRIMARY KEY (`emp_matricule`,`projet_ref`),
  KEY `projet_ref` (`projet_ref`),
  CONSTRAINT `participer_ibfk_1` FOREIGN KEY (`emp_matricule`) REFERENCES `employes` (`emp_matricule`),
  CONSTRAINT `participer_ibfk_2` FOREIGN KEY (`projet_ref`) REFERENCES `projets` (`projet_ref`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.participer : ~10 rows (environ)
INSERT INTO `participer` (`emp_matricule`, `projet_ref`) VALUES
	(2, 1),
	(3, 1),
	(7, 1),
	(5, 2),
	(6, 2),
	(5, 3),
	(2, 4),
	(3, 4),
	(6, 4),
	(7, 4);

-- Listage de la structure de table db_architecte. projets
CREATE TABLE IF NOT EXISTS `projets` (
  `projet_ref` int(11) NOT NULL AUTO_INCREMENT,
  `projet_date_depot` date NOT NULL,
  `projet_date_fin_prevue` date NOT NULL,
  `projet_date_fin_effective` date DEFAULT NULL,
  `projet_superficie_totale` int(11) NOT NULL,
  `projet_superficie_batie` int(11) NOT NULL,
  `projet_prix` decimal(10,2) NOT NULL,
  `client_ref` int(11) NOT NULL,
  `emp_matricule` int(11) NOT NULL,
  `adresse_id` int(11) NOT NULL,
  `type_travaux_id` int(11) NOT NULL,
  `type_projet_id` int(11) NOT NULL,
  PRIMARY KEY (`projet_ref`),
  KEY `client_ref` (`client_ref`),
  KEY `emp_matricule` (`emp_matricule`),
  KEY `adresse_id` (`adresse_id`),
  KEY `type_travaux_id` (`type_travaux_id`),
  KEY `type_projet_id` (`type_projet_id`),
  CONSTRAINT `projets_ibfk_1` FOREIGN KEY (`client_ref`) REFERENCES `clients` (`client_ref`),
  CONSTRAINT `projets_ibfk_2` FOREIGN KEY (`emp_matricule`) REFERENCES `employes` (`emp_matricule`),
  CONSTRAINT `projets_ibfk_3` FOREIGN KEY (`adresse_id`) REFERENCES `adresses` (`adresse_id`),
  CONSTRAINT `projets_ibfk_4` FOREIGN KEY (`type_travaux_id`) REFERENCES `type_travaux` (`type_travaux_id`),
  CONSTRAINT `projets_ibfk_5` FOREIGN KEY (`type_projet_id`) REFERENCES `type_projets` (`type_projet_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.projets : ~5 rows (environ)
INSERT INTO `projets` (`projet_ref`, `projet_date_depot`, `projet_date_fin_prevue`, `projet_date_fin_effective`, `projet_superficie_totale`, `projet_superficie_batie`, `projet_prix`, `client_ref`, `emp_matricule`, `adresse_id`, `type_travaux_id`, `type_projet_id`) VALUES
	(1, '2022-11-02', '2022-08-12', '2022-09-27', 500, 250, 9999.99, 5, 1, 1, 1, 1),
	(2, '2022-12-15', '2023-01-14', '2023-01-14', 700, 690, 100000.00, 4, 1, 2, 5, 3),
	(3, '2023-01-02', '2023-10-01', NULL, 500, 300, 5412.00, 3, 4, 3, 4, 4),
	(4, '2023-02-10', '2023-10-02', NULL, 200, 190, 4000.00, 2, 1, 4, 3, 2),
	(5, '2023-04-23', '2023-12-22', NULL, 90, 50, 2500.00, 1, 4, 5, 3, 2);

-- Listage de la structure de table db_architecte. type_clients
CREATE TABLE IF NOT EXISTS `type_clients` (
  `type_client_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_client_libelle` varchar(50) NOT NULL,
  PRIMARY KEY (`type_client_id`),
  UNIQUE KEY `type_client_libelle` (`type_client_libelle`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.type_clients : ~5 rows (environ)
INSERT INTO `type_clients` (`type_client_id`, `type_client_libelle`) VALUES
	(5, 'autre'),
	(3, 'institution privée'),
	(2, 'institution publique'),
	(1, 'Particulier'),
	(4, 'promoteur');

-- Listage de la structure de table db_architecte. type_projets
CREATE TABLE IF NOT EXISTS `type_projets` (
  `type_projet_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_projet_libelle` varchar(50) NOT NULL,
  PRIMARY KEY (`type_projet_id`),
  UNIQUE KEY `type_projet_libelle` (`type_projet_libelle`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.type_projets : ~7 rows (environ)
INSERT INTO `type_projets` (`type_projet_id`, `type_projet_libelle`) VALUES
	(2, 'Appartement'),
	(3, 'Chalet'),
	(6, 'Ecole'),
	(5, 'Hôpital'),
	(4, 'Immeuble'),
	(7, 'locaux commerciaux'),
	(1, 'Maison');

-- Listage de la structure de table db_architecte. type_travaux
CREATE TABLE IF NOT EXISTS `type_travaux` (
  `type_travaux_id` int(11) NOT NULL AUTO_INCREMENT,
  `type_travaux_libelle` varchar(50) NOT NULL,
  PRIMARY KEY (`type_travaux_id`),
  UNIQUE KEY `type_travaux_libelle` (`type_travaux_libelle`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_architecte.type_travaux : ~5 rows (environ)
INSERT INTO `type_travaux` (`type_travaux_id`, `type_travaux_libelle`) VALUES
	(2, 'Aménagement'),
	(1, 'Construction'),
	(4, 'Réhabilitation'),
	(3, 'Rénovation'),
	(5, 'Restauration');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
