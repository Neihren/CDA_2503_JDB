-- 1. Selectionner l'identifiant et le nom de tous les clients dont le numero de telephone commence par '04'.

SELECT
	client_ref AS Identifiant,
	client_nom AS Nom,
	client_telephone AS Telephone
FROM
	clients
WHERE
	client_telephone LIKE '04%';

-- 2. Selectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers.

SELECT
	client_ref AS Identifiant,
	client_nom AS Nom,
	C.type_client_id AS 'ID type de client',
	type_client_libelle AS 'Libelle type de client'
FROM
	clients AS C
INNER JOIN
	type_clients AS TC ON TC.type_client_id = C.type_client_id
WHERE
	type_client_libelle LIKE 'Particulier';

-- 3. Selectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers.

SELECT
	client_ref AS Identifiant,
	client_nom AS Nom,
	C.type_client_id AS 'ID type de client',
	type_client_libelle AS 'Libelle type de client'
FROM
	clients AS C
INNER JOIN
	type_clients AS TC ON TC.type_client_id = C.type_client_id
WHERE
	type_client_libelle NOT LIKE 'Particulier';

-- 4. Selectionner les projets qui ont ete livres en retard.

SELECT
	projet_ref AS 'Reference Projet',
	projet_date_fin_prevue AS 'Date de fin prevue',
	projet_date_fin_effective AS 'Date de fin effective'
FROM
	projets
WHERE
	projet_date_fin_effective > projet_date_fin_prevue;
	
-- Si l'on considere que ceux qui n'ont pas encore ete livre sont en retard

SELECT
	projet_ref AS 'Reference Projet',
	projet_date_fin_prevue AS 'Date de fin prevue',
	projet_date_fin_effective AS 'Date de fin effective'
FROM
	projets
WHERE
	projet_date_fin_effective > projet_date_fin_prevue
	OR
		projet_date_fin_prevue < CURDATE()
		AND
		projet_date_fin_effective IS NULL;

-- 5. Selectionner la date de depot, la date de fin prevue, les superficies, le prix de tous les projets avec le nom du client et le nom de l'architecte associes au projet.

SELECT
	projet_date_depot AS 'Date de depot',
	projet_date_fin_prevue AS 'Date de fin prevue',
	projet_superficie_totale AS 'Superficie totale',
	projet_superficie_batie AS 'Superficie batie',
	projet_prix AS 'Prix projet',
	client_nom AS 'Nom client',
	emp_nom AS 'Nom Architecte',
	fonction_nom AS 'Fonction Employe'
FROM
	projets AS P
INNER JOIN
	clients AS C ON C.client_ref = P.client_ref
INNER JOIN
	employes AS E ON E.emp_matricule = P.emp_matricule
INNER JOIN
	fonctions AS F ON F.fonction_id = E.fonction_id
WHERE
	fonction_nom LIKE 'Architecte';

-- 6. Selectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte.

SELECT
	projet_date_depot AS 'Date de depot',
	projet_date_fin_prevue AS 'Date de fin prevue',
	projet_date_fin_effective AS 'Date de fin effective',
	projet_superficie_totale AS 'Superficie totale',
	projet_superficie_batie AS 'Superficie batie',
	projet_prix AS 'Prix projet',
	COUNT(E.emp_matricule) AS 'Nombre intervenant'
FROM
	projets AS P
INNER JOIN
	participer AS PA ON PA.projet_ref = P.projet_ref	
INNER JOIN
	employes AS E ON E.emp_matricule = PA.emp_matricule
INNER JOIN
	fonctions AS F ON F.fonction_id = E.fonction_id
WHERE
	fonction_nom NOT LIKE 'Architecte'
GROUP BY
	P.projet_ref;

-- 7. Selectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associes et le prix moyen pratique.

SELECT
	type_projet_libelle AS 'Type de projet',
	COUNT(projet_ref) AS 'Nombre de projets',
	AVG(projet_prix) AS 'Prix Moyen projets'
FROM
	type_projets AS TP
INNER JOIN
	projets AS P ON P.type_projet_id = TP.type_projet_id
GROUP BY
	type_projet_libelle;

-- 8. Selectionner les types de travaux avec, pour chacun d'entre eux, la surperficie du projet la plus grande.

SELECT
	type_travaux_libelle AS 'Type de travaux',
	MAX(P.projet_superficie_totale) AS 'Superficie Total du Projet le plus grand'
FROM
	type_travaux AS TT
INNER JOIN
	projets AS P ON P.type_travaux_id = TT.type_travaux_id
GROUP BY
	type_travaux_libelle;

-- 9. Selectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, téléphone, adresse), le type de travaux et le type de projet.

SELECT
	projet_date_depot AS 'Date depot Projet',
	projet_date_fin_prevue AS 'Date de fin prevue Projet',
	projet_date_fin_effective AS 'Date de fin effective Projet',
	projet_prix AS 'Prix Projet',
	client_nom AS 'Nom Client',
	client_telephone AS 'Telephone Client',
	CONCAT(A.adresse_num_voie, ', ', A.adresse_voie, ' ', A.adresse_code_postal, ' ', A.adresse_ville) AS 'Adresse Client',
	type_travaux_libelle AS 'Type de Travaux',
	type_projet_libelle AS 'Type de Projet'
FROM
	projets AS P
INNER JOIN
	clients AS C ON C.client_ref = P.client_ref
INNER JOIN
	adresses AS A ON A.adresse_id = C.adresse_id
INNER JOIN
	type_travaux AS TT ON TT.type_travaux_id = P.type_travaux_id
INNER JOIN
	type_projets AS TP ON TP.type_projet_id = P.type_projet_id;

-- 10. Selectionner les projets dont l'adresse est identique au client associé.

SELECT
	projet_ref AS 'Reference Projet'
FROM
	projets AS P
INNER JOIN
	clients AS C ON C.client_ref = P.client_ref
WHERE
	P.adresse_id = C.adresse_id;