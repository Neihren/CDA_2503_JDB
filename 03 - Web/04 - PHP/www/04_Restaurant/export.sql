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


-- Listage de la structure de la base pour guide
CREATE DATABASE IF NOT EXISTS `guide` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `guide`;

-- Listage de la structure de procédure guide. afficherListeNote
DELIMITER //
CREATE PROCEDURE `afficherListeNote`(
	IN `p_limite` double
)
BEGIN
	SELECT
		nom, 
		adresse,
		prix,
		commentaire,
		note,
		visite AS "Date de Visite"
	FROM
		restaurants
	WHERE
		note >= p_limite;
END//
DELIMITER ;

-- Listage de la structure de procédure guide. afficherListePrix
DELIMITER //
CREATE PROCEDURE `afficherListePrix`(IN p_limite_inf DOUBLE, IN p_limite_sup DOUBLE )
BEGIN
	SELECT
		nom, 
		adresse,
		prix,
		commentaire
		note,
		visite AS "Date de Visite"
	FROM
		restaurants
	WHERE
		Prix BETWEEN p_limite_inf AND p_limite_sup;
END//
DELIMITER ;

-- Listage de la structure de table guide. restaurants
CREATE TABLE IF NOT EXISTS `restaurants` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) NOT NULL,
  `adresse` varchar(250) NOT NULL,
  `prix` decimal(8,2) NOT NULL,
  `commentaire` mediumtext NOT NULL,
  `note` double NOT NULL,
  `visite` date NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `check_restaurants_note` CHECK ((`note` between 0 and 10))
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Listage des données de la table guide.restaurants : ~11 rows (environ)
INSERT INTO `restaurants` (`id`, `nom`, `adresse`, `prix`, `commentaire`, `note`, `visite`) VALUES
	(2, 'BONJOUR', '6 route de Neuf Brisach, 68000, Colmar, France', 25.75, 'Une des meilleurs pizzéria de la région Service très agréable, efficace et souriant Salle principale un peu\r\nbruyante mais cela donne un côté italien je recommande', 8, '2020-02-04'),
	(3, 'Le Coin des Saveurs', '12 Avenue des Lilas, 68100 Mulhouse', 32.90, 'Cuisine française généreuse, service impeccable et cadre chaleureux.', 7, '2021-04-12'),
	(4, 'Chez Marcelin', '78 Rue de Belfort, 68200 Mulhouse', 42.00, 'Ambiance familiale, produits locaux et plats du terroir revisités.', 5, '2022-02-27'),
	(5, 'L\'âtre des Amis', '45 Boulevard de la République, 68000 Colmar', 27.50, 'Bonne adresse pour les repas conviviaux, spécialités alsaciennes excellentes.', 9, '2020-07-15'),
	(6, 'Bistro du Clocher', '3 Place du Clocher, 68240 Kaysersberg', 35.20, 'Petit bistrot charmant, carte variée mais service parfois lent.', 4, '2021-10-02'),
	(7, 'La Table Étoilée', '21 Rue des Étoiles, 68130 Altkirch', 60.10, 'Expérience gastronomique raffinée, chef créatif et carte renouvelée.', 10, '2022-12-05'),
	(8, 'Maison de Lumière', '9 Chemin du Canal, 68870 Bartenheim', 25.80, 'Un décor moderne et lumineux, plats simples mais savoureux.', 6, '2021-08-19'),
	(9, 'Café des Rosiers', '15 Rue des Rosiers, 68300 Saint-Louis', 19.60, 'Petit déjeuner copieux, pâtisseries maison et terrasse agréable.', 8, '2021-03-11'),
	(10, 'Chez Bastien', '66 Route de Strasbourg, 67210 Obernai', 53.25, 'Les poissons y sont cuisinés à la perfection, service attentionné.', 9, '2019-11-21'),
	(11, 'Le Relais d\'Azur', '2 Allée de la Plage, 68128 Village-Neuf', 38.80, 'Fruits de mer frais, belle vue et ambiance détendue.', 5, '2021-06-30'),
	(12, 'Balcon de Montmartre', '17 Rue du Balcon, 75018 Paris', 49.99, 'Restaurant romantique avec vue exceptionnelle, cuisine fine et inventive.', 7, '2022-05-14');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
