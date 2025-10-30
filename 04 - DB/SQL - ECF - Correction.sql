-- 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone
-- commence par '04'
SELECT client_ref, client_nom, client_telephone  FROM clients
WHERE client_telephone LIKE "04%";




-- 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers
SELECT client_ref, client_nom,type_client_libelle
FROM clients
INNER JOIN type_clients ON type_clients.type_client_id=clients.type_client_id
WHERE type_clients.type_client_libelle='particulier';



-- 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des
-- particuliers
SELECT client_ref, client_nom,type_client_libelle
FROM clients
INNER JOIN type_clients ON type_clients.type_client_id=clients.type_client_id
WHERE type_clients.type_client_libelle !='particulier';

-- 4. Sélectionner les projets qui ont été livrés en retard

SELECT projet_ref, projet_date_fin_prevue, projet_date_fin_effective
FROM projets
WHERE projet_date_fin_effective > projet_date_fin_prevue
OR projet_date_fin_prevue < CURDATE() AND projet_date_fin_effective IS NULL;

-- 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les
-- projets avec le nom du client et le nom de l'architecte associés au projet
SELECT 
	projet_date_depot,
	projet_date_fin_prevue,
	projet_superficie_totale,
	projet_superficie_batie,
	projet_prix,
	client_nom,
	emp_nom, 
	emp_prenom
FROM projets
INNER JOIN employes ON projets.emp_matricule = employes.emp_matricule
INNER JOIN clients ON projets.client_ref = clients.client_ref
;


-- 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres
-- que le client et le responsable (architecte)

-- SELECT
-- 	projet_date_depot,
-- 	projet_date_fin_prevue,
-- 	projet_date_fin_effective,
-- 	projet_superficie_totale,
-- 	projet_superficie_batie,
-- 	projet_prix,
-- 	COUNT(E.emp_matricule) AS 'Nombre Intervenant'
-- FROM
-- 	projets AS P
-- INNER JOIN 
-- 	participer AS PA ON PA.projet_ref = P.projet_ref
-- INNER JOIN
-- 	employes AS E ON E.emp_matricule = PA.emp_matricule
-- INNER JOIN
-- 	fonctions AS F ON F.fonction_id = E.fonction_id
-- WHERE
-- 	fonction_nom NOT LIKE 'Architecte'
-- GROUP BY
-- 	P.projet_ref;
	
	
SELECT
	projet_date_depot,
	projet_date_fin_prevue,
	projet_date_fin_effective,
	projet_superficie_totale,
	projet_superficie_batie,
	projet_prix,
	COUNT(PA.emp_matricule) AS 'Nombre Intervenant'
FROM
	projets AS P
INNER JOIN 
	participer AS PA ON PA.projet_ref = P.projet_ref
GROUP BY
	P.projet_ref;	

-- 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets
-- associés et le prix moyen pratiqué

SELECT type_projet_libelle, COUNT(*), AVG(projet_prix)
FROM projets
INNER JOIN type_projets ON type_projets.type_projet_id = projets.type_projet_id
GROUP BY type_projet_libelle;
 
-- 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la
-- plus grande
SELECT type_travaux_libelle , MAX(projet_superficie_totale)
FROM projets AS p
INNER JOIN type_travaux AS tt ON tt.type_travaux_id = p.type_travaux_id
GROUP BY type_travaux_libelle;


-- 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom,
-- téléphone, adresse), le type de travaux et le type de projet.
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


-- 10. Sélectionner les projets dont l'adresse est identique au client associé.

SELECT projet_ref, adresses.adresse_ville
FROM adresses
NATURAL JOIN projets
NATURAL JOIN clients
WHERE clients.adresse_id = projets.adresse_id;	

