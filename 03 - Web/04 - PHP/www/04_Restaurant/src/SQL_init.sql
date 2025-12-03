USE GUIDE;

DELIMITER |
CREATE PROCEDURE afficherListeNote (IN p_limite double)
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
		note >= p_limite;
END |
DELIMITER ;


SET @noteLimite = 9;

CALL afficherListeNote(@noteLimite);

INSERT INTO `restaurants` (`id`, `nom`, `adresse`, `prix`, `commentaire`, `note`, `visite`) VALUES
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

DELIMITER |
CREATE PROCEDURE afficherListePrix (IN p_limite_inf DOUBLE, IN p_limite_sup DOUBLE )
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
		Prix BETWEEN p_limite_inf AND p_limite_sup;
END |
DELIMITER ;

CALL afficherListePrix (20, 50);

ALTER TABLE
	restaurants 
ADD CONSTRAINT
	check_restaurants_note
CHECK
	(note BETWEEN 0 AND 10);