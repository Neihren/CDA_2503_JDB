/* 1. Sélectionner tous les employés (codeEmpl, nom, salaire) triés par nom et par ordre alphabétique */ 

SELECT
   codeEmpl,
   nom,
   salaire
FROM
   employe
ORDER BY
   nom ASC;

/* 2. Sélectionner tous les employés (codeEmpl, nom, salaire) avec, pour chaque employé,
   le nom du rayon dans lequel il travaille */

SELECT
   codeEmpl,
   nom,
   salaire,
   nomR
FROM
   employe

/* 3. Sélectionner tous les fournisseurs (codeF, nomF) et le nombre de produits qu'ils fournissent,
   triés par nombre de produits décroissant */
/*   
INSERT INTO
   fournisseurs
VALUES
   ('FZZZZZ', 'toto', '12 rue des Lilas');
*/

SELECT
   codeF,
   nomF,
   (  SELECT
         COUNT(codeA)
      FROM
         ligne_bon_de_livraison
      WHERE
         fournisseurs.codeF = ligne_bon_de_livraison.codeF
   ) AS nombre_produits
FROM
   fournisseurs;

SELECT 
   fournisseurs.codeF, 
   fournisseurs.nomF, 
   COUNT(ligne_bon_de_livraison.codeA) AS nombre_produits
FROM 
   fournisseurs
LEFT JOIN 
   ligne_bon_de_livraison ON fournisseurs.codeF = ligne_bon_de_livraison.codeF
GROUP BY 
   fournisseurs.codeF
ORDER BY
	nombre_produits DESC;
/* 4. Sélectionner le nom des produits, leur type, et le nom du fournisseur associé */

SELECT
   nomA,
   prix,
   nomF
FROM
   articles AS TA
INNER JOIN
   ligne_bon_de_livraison AS TL ON TA.codeA = TL.codeA
INNER JOIN
	fournisseurs AS TF ON TL.codeF = TF.codeF;

/* 5. Sélectionner le nom des produits, leur prix, et le nom du fournisseur pour chaque produit dont 
   le prix est supérieur à la moyenne des prix des produits */

SELECT
   AVG(prix)
FROM
   articles;

SELECT
   nomA,
   prix,
   nomF
FROM
   articles AS TA
INNER JOIN
   ligne_bon_de_livraison AS TL ON TA.codeA = TL.codeA
INNER JOIN
	fournisseurs AS TF ON TL.codeF = TF.codeF
WHERE
   prix > ( SELECT
               AVG(prix)
            FROM
               articles)
;

/* 6. Sélectionner tous les employés (codeEmpl, nom). Pour chaque employé, indiquer le nom du rayon,
   le nombre d'articles associés au rayon  */

SELECT
   codeEmpl,
   nom,
   TE.nomR,
   COUNT(codeA)
FROM
   employe AS TE
INNER JOIN
	rayon AS TR ON TE.nomR = TR.nomR
INNER JOIN
   articles AS TA ON TR.nomR = TA.nomR
GROUP BY
   codeEmpl;

/* 7. Sélectionner tous les articles (codeA, nomA). Pour chaque article, 
   indiquer le nombre de livraisons et la quantité totale livrée. */

SELECT
	TA.codeA,
	nomA,
	COUNT(TA.codeA),
	SUM(quantité)
FROM
	articles AS TA
INNER JOIN
	ligne_bon_de_livraison AS TL ON TA.codeA = TL.codeA
GROUP BY
	TL.codeA;
	 
/* 8. Sélectionner tous les articles (codeA, nomA). Pour chaque article, indiquer le nom du fournisseur,
   le nom et l'étage du rayon où il est stocké, et l'employé qui y travaille (codeEmpl, nom). */

SELECT
	TA.codeA,
	nomA,
	nomF,
	TR.nomR,
	etage,
	codeEmpl,
	nom
FROM
	articles AS TA
INNER JOIN
	ligne_bon_de_livraison AS TL ON TL.codeA = TA.codeA
INNER JOIN
	fournisseurs AS TF ON TF.codeF = TL.codeF
INNER JOIN
	rayon AS TR ON TR.nomR = TA.nomR
INNER JOIN
	employe AS TE ON TE.nomR = TR.nomR;

	
SELECT
	codeA,
	CONCAT(	SELECT
					nomF
				FROM
				)
FROM
	fournisseurs AS TF
INNER JOIN
	ligne_bon_de_livraison AS TL ON TL.codeF = TF.codeF
GROUP BY
	codeA;