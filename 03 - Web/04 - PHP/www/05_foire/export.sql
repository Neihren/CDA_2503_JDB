-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           8.0.30 - MySQL Community Server - GPL
-- SE du serveur:                Win64
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


-- Listage de la structure de la base pour foire68
CREATE DATABASE IF NOT EXISTS `foire68` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `foire68`;

-- Listage de la structure de table foire68. candidats
CREATE TABLE IF NOT EXISTS `candidats` (
  `id_user` int unsigned NOT NULL AUTO_INCREMENT,
  `lastname_user` varchar(50) NOT NULL,
  `firstname_user` varchar(50) NOT NULL,
  `mail_user` varchar(150) NOT NULL,
  `pass_user` varchar(500) NOT NULL,
  `departement_user` int unsigned NOT NULL,
  `age_user` tinyint unsigned NOT NULL,
  `archive_user` tinyint NOT NULL,
  PRIMARY KEY (`id_user`),
  UNIQUE KEY `UNIQUE_candidats_mail` (`mail_user`),
  KEY `FK_departementUser_idDept` (`departement_user`),
  CONSTRAINT `FK_departementUser_idDept` FOREIGN KEY (`departement_user`) REFERENCES `departements` (`id_dep`),
  CONSTRAINT `check_candidats_age` CHECK ((`age_user` >= 18)),
  CONSTRAINT `CK_archive` CHECK ((`archive_user` in (0,1))),
  CONSTRAINT `UNIQUE_candidats_mailFormat` CHECK ((`mail_user` like _utf8mb4'%_@_%'))
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table foire68.candidats : ~50 rows (environ)
INSERT INTO `candidats` (`id_user`, `lastname_user`, `firstname_user`, `mail_user`, `pass_user`, `departement_user`, `age_user`, `archive_user`) VALUES
	(1, 'Martin', 'Gabriel', 'gabriel.martin@email.fr', 'Gabriel2024!', 75, 24, 0),
	(2, 'Bernard', 'Léa', 'lea.bernard@test.com', 'Chocolat123', 69, 31, 0),
	(3, 'Thomas', 'Lucas', 'lucas.thomas@provider.net', 'Lucas1980', 33, 45, 0),
	(4, 'Petit', 'Emma', 'emma.petit@email.fr', 'EmmaPetit!', 13, 19, 0),
	(5, 'Robert', 'Louis', 'louis.robert@webmail.org', 'Azerty123', 59, 52, 1),
	(6, 'Richard', 'Jade', 'jade.richard@email.fr', 'Jade_2025', 44, 28, 0),
	(7, 'Durand', 'Hugo', 'hugo.durand@test.com', 'HugoBoss99', 31, 22, 0),
	(8, 'Dubois', 'Chloé', 'chloe.dubois@provider.net', 'Soleil!123', 6, 35, 0),
	(9, 'Moreau', 'Arthur', 'arthur.moreau@email.fr', 'ArthurM92', 92, 41, 0),
	(10, 'Laurent', 'Manon', 'manon.laurent@webmail.org', 'ManonLola', 17, 26, 0),
	(11, 'Simon', 'Jules', 'jules.simon@test.com', 'JulesVerne', 29, 33, 0),
	(12, 'Michel', 'Zoé', 'zoe.michel@email.fr', 'Zoe_Michel', 67, 29, 0),
	(13, 'Lefebvre', 'Raphaël', 'raphael.lefebvre@provider.net', 'Raphael54!', 54, 58, 1),
	(14, 'Leroy', 'Alice', 'alice.leroy@email.fr', 'Wonderland', 76, 21, 0),
	(15, 'Roux', 'Nathan', 'nathan.roux@test.com', 'Nathan1234', 83, 37, 0),
	(16, 'David', 'Lina', 'lina.david@webmail.org', 'LinaDavid95', 95, 25, 0),
	(17, 'Bertrand', 'Paul', 'paul.bertrand@email.fr', 'Paulo_21', 21, 49, 0),
	(18, 'Morel', 'Sarah', 'sarah.morel@provider.net', 'SarahM35!', 35, 30, 0),
	(19, 'Fournier', 'Tom', 'tom.fournier@test.com', 'TomTomGO', 49, 23, 0),
	(20, 'Girard', 'Camille', 'camille.girard@email.fr', 'Camille62', 62, 55, 1),
	(21, 'Bonnet', 'Théo', 'theo.bonnet@webmail.org', 'TheoBonnet91', 91, 27, 0),
	(22, 'Dupont', 'Louise', 'louise.dupont@email.fr', 'Loulou78!', 78, 32, 0),
	(23, 'Lambert', 'Adam', 'adam.lambert@test.com', 'Adam_Lambert', 14, 20, 0),
	(24, 'Fontaine', 'Mila', 'mila.fontaine@provider.net', 'MilaF85', 85, 44, 0),
	(25, 'Rousseau', 'Nolan', 'nolan.rousseau@email.fr', 'NolanR50', 50, 36, 0),
	(26, 'Vincent', 'Eva', 'eva.vincent@webmail.org', 'EvaVincent01', 1, 24, 0),
	(27, 'Muller', 'Enzo', 'enzo.muller@test.com', 'Ferrari68', 68, 29, 0),
	(28, 'Lefevre', 'Anna', 'anna.lefevre@email.fr', 'Anna_Paris', 75, 18, 0),
	(29, 'Faure', 'Mathis', 'mathis.faure@provider.net', 'Mathis19!', 19, 42, 0),
	(30, 'Andre', 'Elena', 'elena.andre@email.fr', 'Elena38Isere', 38, 31, 0),
	(31, 'Mercier', 'Axel', 'axel.mercier@test.com', 'AxelM42!', 42, 53, 1),
	(32, 'Blanc', 'Inès', 'ines.blanc@webmail.org', 'InesB08', 8, 26, 0),
	(33, 'Guerin', 'Ethan', 'ethan.guerin@email.fr', 'EthanG93', 93, 22, 0),
	(34, 'Boyer', 'Louna', 'louna.boyer@provider.net', 'LounaB24', 24, 39, 0),
	(35, 'Garnier', 'Sacha', 'sacha.garnier@test.com', 'Sacha84!', 84, 34, 0),
	(36, 'Chevalier', 'Juliette', 'juliette.chevalier@email.fr', 'Juju_60', 60, 47, 0),
	(37, 'Francois', 'Maël', 'mael.francois@webmail.org', 'MaelF72', 72, 19, 0),
	(38, 'Legrand', 'Romane', 'romane.legrand@email.fr', 'Romane28!', 28, 28, 0),
	(39, 'Gauthier', 'Liam', 'liam.gauthier@test.com', 'LiamG11', 11, 33, 0),
	(40, 'Garcia', 'Jeanne', 'jeanne.garcia@provider.net', 'Jeanne66!', 66, 61, 1),
	(41, 'Perrin', 'Noah', 'noah.perrin@email.fr', 'NoahP56', 56, 25, 0),
	(42, 'Robin', 'Lola', 'lola.robin@webmail.org', 'LolaR89', 89, 21, 0),
	(43, 'Clement', 'Tiago', 'tiago.clement@test.com', 'Tiago03!', 3, 40, 0),
	(44, 'Morin', 'Agathe', 'agathe.morin@email.fr', 'AgatheM37', 37, 30, 0),
	(45, 'Nicolas', 'Antoine', 'antoine.nicolas@provider.net', 'Antoine45', 45, 56, 0),
	(46, 'Henry', 'Julia', 'julia.henry@email.fr', 'JuliaH94!', 94, 23, 0),
	(47, 'Roussel', 'Valentin', 'valentin.roussel@test.com', 'Valentin80', 80, 27, 0),
	(48, 'Mathieu', 'Clara', 'clara.mathieu@webmail.org', 'ClaraM51', 51, 35, 0),
	(49, 'Gautier', 'Gabin', 'gabin.gautier@email.fr', 'Gabin22!', 22, 18, 0),
	(50, 'Masson', 'Margaux', 'margaux.masson@provider.net', 'Margaux75', 75, 46, 0),
	(51, 'Haddock', 'Gabriel', 'gabrel.martin@email.fr', 'Gabriel2024!', 75, 24, 1),
	(52, 'feaf', 'feafea', 'geagea@test.com', '$2y$10$KaYYQTVyfrGsbct9IyLjlutF2gAOYj4D/KEs1srFldU1dDlzTT4.i', 1, 19, 0),
	(53, 'test', 'geagea', 'geaga@geag.com', '$2y$10$nIHEvPa1lZdR6zp47W4wA.vhmZbdtL6aiEmCQkSYAfg4VDd3hSiFu', 1, 18, 0),
	(54, 'ùôj', 'ùohjù', 'oh@kg.com', '$2y$10$4gRE0QpOeOsbZMUhmRYkSuE3XMUIifuVQkHwmGbi0zJuLsHGmH1/S', 1, 18, 0),
	(55, 'NTest', 'PTest', 'etest@test.com', '$argon2id$v=19$m=65536,t=4,p=1$NFRNTFVoZ3YvMU1hb0JjRw$xU0E+HTPkbA+BDSN+eP94N9MNXoZdOBoziMKUPVpsiE', 1, 19, 0),
	(56, 'De Brito', 'Jessy', 'jdebrito@test.com', '$argon2id$v=19$m=65536,t=4,p=1$RWZyNVUxclhVaDZiQXNOTw$U3LSGPGA2TPjb6N+eZgmwBUm5zJz+Esc3vXzyDJc33I', 77, 19, 0),
	(57, 'jean', 'dupont', 'jdupont@test.com', '$argon2id$v=19$m=65536,t=4,p=1$N0Jyd05FYndKd0c4aHVFNA$WBBwMd8dH/666YBjsc9Xoyu8EbaBoTPeIoXTmRB1nLo', 95, 19, 0);

-- Listage de la structure de table foire68. departements
CREATE TABLE IF NOT EXISTS `departements` (
  `id_dep` int unsigned NOT NULL,
  `Name` varchar(50) NOT NULL,
  `dep_actif` int unsigned NOT NULL,
  `dep_taux` decimal(5,2) NOT NULL,
  PRIMARY KEY (`id_dep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table foire68.departements : ~95 rows (environ)
INSERT INTO `departements` (`id_dep`, `Name`, `dep_actif`, `dep_taux`) VALUES
	(1, '01 - Ain', 1, 1.00),
	(2, '02 - Aisne', 1, 1.00),
	(3, '03 - Allier', 1, 1.00),
	(4, '04 - Alpes-de-Haute-Provence', 1, 1.00),
	(5, '05 - Hautes-Alpes', 1, 1.00),
	(6, '06 - Alpes-Maritimes', 1, 1.00),
	(7, '07 - Ardèche', 1, 1.00),
	(8, '08 - Ardennes', 1, 1.00),
	(9, '09 - Ariège', 1, 1.00),
	(10, '10 - Aube', 1, 1.00),
	(11, '11 - Aude', 1, 1.00),
	(12, '12 - Aveyron', 1, 1.00),
	(13, '13 - Bouches-du-Rhône', 1, 1.00),
	(14, '14 - Calvados', 1, 1.00),
	(15, '15 - Cantal', 1, 1.00),
	(16, '16 - Charente', 1, 1.00),
	(17, '17 - Charente-Maritime', 1, 1.00),
	(18, '18 - Cher', 1, 1.00),
	(19, '19 - Corrèze', 1, 1.00),
	(20, '2A 2B - Départements Corse', 1, 1.00),
	(21, '21 - Côte-d Or', 1, 1.00),
	(22, '22 - Côtes-d Armor', 1, 1.00),
	(23, '23 - Creuse', 1, 1.00),
	(24, '24 - Dordogne', 1, 1.00),
	(25, '25 - Doubs', 1, 1.00),
	(26, '26 - Drôme', 1, 1.00),
	(27, '27 - Eure', 1, 1.00),
	(28, '28 - Eure-et-Loir', 1, 1.00),
	(29, '29 - Finistère', 1, 1.00),
	(30, '30 - Gard', 1, 1.00),
	(31, '31 - Haute-Garonne', 1, 1.00),
	(32, '32 - Gers', 1, 1.00),
	(33, '33 - Gironde', 1, 1.00),
	(34, '34 - Hérault', 1, 1.00),
	(35, '35 - Ille-et-Vilaine', 1, 1.00),
	(36, '36 - Indre', 1, 1.00),
	(37, '37 - Indre-et-Loire', 1, 1.00),
	(38, '38 - Isère', 1, 1.00),
	(39, '39 - Jura', 1, 1.00),
	(40, '40 - Landes', 1, 1.00),
	(41, '41 - Loir-et-Cher', 1, 1.00),
	(42, '42 - Loire', 1, 1.00),
	(43, '43 - Haute-Loire', 1, 1.00),
	(44, '44 - Loire-Atlantique', 1, 1.00),
	(45, '45 - Loiret', 1, 1.00),
	(46, '46 - Lot', 1, 1.00),
	(47, '47 - Lot-et-Garonne', 1, 1.00),
	(48, '48 - Lozère', 1, 1.00),
	(49, '49 - Maine-et-Loire', 1, 1.00),
	(50, '50 - Manche', 1, 1.00),
	(51, '51 - Marne', 1, 1.00),
	(52, '52 - Haute-Marne', 1, 1.00),
	(53, '53 - Mayenne', 1, 1.00),
	(54, '54 - Meurthe-et-Moselle', 1, 1.00),
	(55, '55 - Meuse', 1, 1.00),
	(56, '56 - Morbihan', 1, 1.00),
	(57, '57 - Moselle', 1, 1.00),
	(58, '58 - Nièvre', 1, 1.00),
	(59, '59 - Nord', 1, 1.00),
	(60, '60 - Oise', 1, 1.00),
	(61, '61 - Orne', 1, 1.00),
	(62, '62 - Pas-de-Calais', 1, 1.00),
	(63, '63 - Puy-de-Dôme', 1, 1.00),
	(64, '64 - Pyrénées-Atlantiques', 1, 1.00),
	(65, '65 - Hautes-Pyrénées', 1, 1.00),
	(66, '66 - Pyrénées-Orientales', 1, 1.00),
	(67, '67 - Bas-Rhin', 1, 1.00),
	(68, '68 - Haut-Rhin', 1, 1.00),
	(69, '69 - Rhône', 1, 1.00),
	(70, '70 - Haute-Saône', 1, 1.00),
	(71, '71 - Saône-et-Loire', 1, 1.00),
	(72, '72 - Sarthe', 1, 1.00),
	(73, '73 - Savoie', 1, 1.00),
	(74, '74 - Haute-Savoie', 1, 1.00),
	(75, '75 - Paris', 1, 1.00),
	(76, '76 - Seine-Maritime', 1, 1.00),
	(77, '77 - Seine-et-Marne', 1, 1.00),
	(78, '78 - Yvelines', 1, 1.00),
	(79, '79 - Deux-Sèvres', 1, 1.00),
	(80, '80 - Somme', 1, 1.00),
	(81, '81 - Tarn', 1, 1.00),
	(82, '82 - Tarn-et-Garonne', 1, 1.00),
	(83, '83 - Var', 1, 1.00),
	(84, '84 - Vaucluse', 1, 1.00),
	(85, '85 - Vendée', 1, 1.00),
	(86, '86 - Vienne', 1, 1.00),
	(87, '87 - Haute-Vienne', 1, 1.00),
	(88, '88 - Vosges', 1, 1.00),
	(89, '89 - Yonne', 1, 1.00),
	(90, '90 - Territoire de Belfort', 1, 1.00),
	(91, '91 - Essonne', 1, 1.00),
	(92, '92 - Hauts-de-Seine', 1, 1.00),
	(93, '93 - Seine-Saint-Denis', 1, 1.00),
	(94, '94 - Val-de-Marne', 1, 1.00),
	(95, '95 - Val-dOise', 1, 1.00);

-- Listage de la structure de table foire68. erreur
CREATE TABLE IF NOT EXISTS `erreur` (
  `id_erreur` tinyint unsigned NOT NULL AUTO_INCREMENT,
  `erreur` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_erreur`),
  UNIQUE KEY `erreur` (`erreur`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table foire68.erreur : ~0 rows (environ)
INSERT INTO `erreur` (`id_erreur`, `erreur`) VALUES
	(1, 'Erreur : Le candidat n\'est pas archivé.'),
	(2, 'Erreur : Le candidat ne peut être supprimé car il n\'est pas archivé.');

-- Listage de la structure de déclencheur foire68. before_delete_candidat
SET @OLDTMP_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';
DELIMITER //
CREATE TRIGGER `before_delete_candidat` BEFORE DELETE ON `candidats` FOR EACH ROW BEGIN
		IF OLD.archive_user <> 1
			THEN
				INSERT INTO Erreur (erreur) VALUES
					('Erreur : Le candidat n\'est pas archivé.');
		END IF;
	END//
DELIMITER ;
SET SQL_MODE=@OLDTMP_SQL_MODE;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
