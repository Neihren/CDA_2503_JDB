USE db_agence_voyage;

INSERT INTO t_country (country_code, country_name)
VALUES
   ('FR', 'France'),
   ('DE', 'Allemagne'),
   ('BE', 'Belgique'),
   ('IT', 'Italie'),
   ('MA', 'Maroc'),
   ('UA', 'Ukraine'),
   ('GB', 'Ecosse');

INSERT INTO t_city (country_code, city_name)
VALUES
   ('FR', 'Paris'),
   ('FR', 'Mulhouse'),
   ('DE', 'Rust'),
   ('BE', 'Bruxelles'),
   ('IT', 'Milan'),
   ('IT', 'Rome'),
   ('UA', 'Chernobyl'),
   ('GB', 'Édimbourg'),
   ('MA', 'Marrakech');

INSERT INTO t_theme (theme_name, theme_description)
VALUES
   ('Montage', "Partez à la découverte de panoramas grandioses, respirez l'air pur et profitez de randonnées inoubliables au cœur des sommets."),
   ('Plage', 'Sable fin, eau cristalline et détente au bord de la mer pour des vacances 100% farniente.'),
   ('Soleil', "Destinations chaudes et lumineuses pour profiter d'un climat idéal toute l'année."),
   ("Sports d'hivers", 'Ski, snowboard et activités de neige au cœur des plus belles stations alpines.'),
   ('Sports nautiques', ''),
   ('Culture', "Immersion dans l'histoire, l'art et les traditions locales à travers visites et rencontres."),
   ('Gastronomique', 'Séjours gourmands pour savourer les spécialités et la cuisine authentique des régions.'),
   ('Aventure', 'Expéditions uniques, sensations fortes et découvertes hors des sentiers battus.');


INSERT INTO t_service (service_name, service_description)
VALUES
   ("All inclusive", "Profitez d'un séjour sans souci où tout est compris : repas, boissons et activités à volonté."),
   ("Service d'étage", "Savourez le confort d'un service personnalisé directement dans votre chambre, à toute heure."),
   ("Piscine", "Détente et plaisir garantis dans une eau rafraîchissante sous le soleil."),
   ("Piscine chaffée", "Profitez d'une baignade agréable toute l'année, même par temps frais."),
   ("Coach sportif", ""),
   ("pratique du golf", "Perfectionnez votre swing sur des parcours d'exception avec vue panoramique.");


ALTER TABLE
	`t_com`
MODIFY
	`com_code_1` VARCHAR(5) NULL;

INSERT INTO t_com (com_code, com_name, com_password, com_code_1)
VALUES
   ('A1B2C', 'Jean Charles', '1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7', NULL),
   ('D3E4F', 'Marie Curie', '1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7', 'A1B2C'),
   ('G5H6I', 'Louis Pasteur', '1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7', 'D3E4F'),
   ('J7K8L', 'Simone de Beauvoir', '1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7', 'G5H6I'),
   ('M9N0O', 'Albert Einstein', '1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7', 'J7K8L');
   
UPDATE
	t_com
SET
	com_code_1 = 'M9N0O'
WHERE
	com_code = 'A1B2C';
	
ALTER TABLE
	`t_com`
MODIFY
	`com_code_1` VARCHAR(5) NOT NULL;

INSERT INTO t_client (client_lastname, client_firstname, client_email, client_phone, client_added, client_password, com_code)
VALUES
   ('Martin', 'Sophie', 'sophie.martin@example.com', '0601020304', '2019-12-05' ,'1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7' ,'G5H6I'),
   ('Dupont', 'Julien', 'julien.dupont@example.com', '0605050607', '2020-03-15' ,'2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7' ,'J7K8L'),
   ('Leroy', 'Alice', 'alice.leroy@example.com', '0612345678', '2021-08-17' ,'3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7' ,'M9N0O'),
   ('Olivier', 'Thomas', 'thomas.olivier@example.com', '0609090909', '2023-07-29' ,'4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7' ,'A1B2C'),
   ('Bernard', 'Marie', 'marie.bernard@example.com', '0622334455', '2024-01-23' ,'5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t1u2v3w4x5y6z7' ,'D3E4F');

INSERT INTO t_trip (trip_title, trip_available, trip_start, trip_end, trip_price, trip_overview, trip_description, city_code)
VALUES
   ('Séjour touristique', '666', '2025-11-14', '2025-11-21', '899', 'Hotel 4*, pension complète', "Profitez d'un hôtel 4 étoiles avec pension complète pour un séjour alliant confort et détente.", '9'),
   ('Séjour Gastronomique', '124', '2025-10-27', '2025-10-01', '399', "Hébergement en chambre d'hôte", "Découvrez la richesse culinaire locale en séjournant en chambre d'hôte avec repas raffinés.", '2'),
   ('Voyage Aventure', '248', '2025-11-07', '2025-11-10', '1299', 'Réservé au groupes de 3 et +', "Partez en groupe pour une expérience unique alliant sensations fortes et découverte.", '7'),
   ('Destination Vert-Bouteille', '600', '2025-12-10', '2025-12-16', '849', 'Randonnées et gastronomie', "", '8'),
   ('Europa Park', '45', '2025-10-27', '2025-10-29 ', '99', 'hébergement inclus', "Amusez-vous dans ce parc d'attractions avec hébergement inclus pour un confort optimal.", '3');

INSERT INTO jt_trip_theme (trip_code, theme_code)
VALUES
   ('1', '3'),
   ('2', '7'),
   ('3', '8'),
   ('4', '1'),
   ('5', '8');

INSERT INTO jt_trip_service (trip_code, service_code)
VALUES
   ('1', '1'),
   ('2', '6'),
   ('3', '4'),
   ('4', '2'),
   ('5', '6');

