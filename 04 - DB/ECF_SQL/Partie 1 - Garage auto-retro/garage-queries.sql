-- Partie 1 - Garage auto-retro

--	Ajout contrainte cle primaire

ALTER TABLE
	realisations
ADD PRIMARY KEY
	(id_rea);
	
-- Ajout auto-incrementation	

ALTER TABLE
	realisations
MODIFY
	id_rea INT UNSIGNED AUTO_INCREMENT;
	
-- Ajout auto-incrementation et cle primaire
	
ALTER TABLE
	images
MODIFY
	id_img INT UNSIGNED PRIMARY KEY AUTO_INCREMENT;
	
-- Regle de gestion 1 - Une image

-- 2) Commande SQL pour modifier la table reaslisation et y ajouter la cle etrangere id_image

ALTER TABLE
	realisations
ADD
	id_img INT UNSIGNED;
	
ALTER TABLE
	realisations
ADD CONSTRAINT
	FK_id_img
FOREIGN KEY	(id_img) REFERENCES images(id_img);

-- Regle de gestion 2 - Plusieurs images

-- 2) Commande SQL pour creer la table d'association

CREATE TABLE image_utilise(
   id_rea INT UNSIGNED,
   id_img INT UNSIGNED,
   PRIMARY KEY(id_rea, id_img),
   FOREIGN KEY(id_rea) REFERENCES realisations(id_rea),
   FOREIGN KEY(id_img) REFERENCES images(id_img)
);

-- 3) Requete pour trouver toutes les images associés à une réalisations

SELECT
	id_rea,
	I.id_img,
	url_img,
	nom_img,
	text_img,
	ext_img
FROM
	images AS I
INNER JOIN
	image_utilise AS IU ON IU.id_img = I.id_img
WHERE id_rea = 1;

-- Regle de gestion 3 - Image principale

-- 2) Ajout de la colonne 'is_main_img' de type boolean pour savoir si l'image est l'image pricipale ou non

ALTER TABLE
	image_utilise
ADD
	is_main_img BOOLEAN DEFAULT 0;
