-- 1. Donner nom, job, numéro et salaire de tous les employés, 

SELECT
   ENAME,
   JOB,
   EMPNO,
   SAL
FROM
   emp;

-- Puis seulement des employés du département 10

SELECT
   ENAME,
   JOB,
   EMPNO,
   SAL,
   DEPTNO
FROM
   emp
WHERE
   DEPTNO = 10;

-- 2. Donner nom, job et salaire des employés de type MANAGER dont le salaire est supérieur à 2800

SELECT
   ENAME,
   JOB,
   SAL
FROM
   emp
WHERE
   JOB LIKE "MANAGER"
   AND SAL > 2800;

-- 3. Donner la liste des MANAGER n'appartenant pas au département 30

SELECT
   ENAME,
   JOB,
   DEPTNO
FROM
   emp
WHERE
   JOB LIKE "MANAGER"
   AND DEPTNO <> 30;

-- 4. Liste des employés de salaire compris entre 1200 et 1400

SELECT
   ENAME,
   SAL
FROM
   emp
WHERE
   SAL BETWEEN 1200 AND 1400;

-- 5. Liste des employés des départements 10 et 30 classés dans l'ordre alphabétique

SELECT
   ENAME,
   DEPTNO
FROM
   emp
WHERE
   DEPTNO = 10
   OR DEPTNO = 30
ORDER BY ENAME ASC;

-- 6. Liste des employés du département 30 classés dans l'ordre des salaires croissants

SELECT
   ENAME,
   DEPTNO,
   SAL
FROM
   emp
WHERE
   DEPTNO = 30
ORDER BY
   SAL ASC;

-- 7. Liste de tous les employés classés par emploi et salaires décroissants

SELECT
   ENAME
FROM
   emp
ORDER BY
   JOB ASC,
   SAL DESC;

-- 8. Liste des différents emplois

SELECT
   DISTINCT JOB
FROM
   emp;

-- 9. Donner le nom du département où travaille ALLEN

SELECT
   DNAME,
   D.DEPTNO,
   ENAME
FROM
   dept AS D
INNER JOIN
   emp AS E ON E.DEPTNO = D.DEPTNO
WHERE
	ENAME LIKE "ALLEN";

-- 10. Liste des employés avec nom du département, nom, job, salaire classés par noms de départements et par salaires décroissants.

SELECT
   DNAME,
   ENAME,
   SAL
FROM
   emp AS E
INNER JOIN
   dept as D ON D.DEPTNO = E.DEPTNO
ORDER BY
   DNAME DESC,
   SAL DESC;
 
-- 11. Liste des employés vendeurs (SALESMAN) avec affichage de nom, salaire, commissions, salaire + commissions

SELECT
   ENAME,
   SAL,
   COMM,
   SAL + COM AS total
FROM
   emp
WHERE
   JOB LIKE "SALESMAN";

-- 12. Liste des employés du département 20: nom, job, date d'embauche sous forme VEN 28 FEV 1997'

SELECT
   ENAME,
   JOB,
   DATE_FORMAT(HIREDATE, "%a %e %b %Y") AS date_emb
FROM
   emp
WHERE
   DEPTNO = 20;

SELECT 
	ENAME,
	HIREDATE,
	DNAME
FROM
   emp
INNER JOIN
   dept ON emp.DEPTNO = dept.DEPTNO
WHERE
   HIREDATE IN (
      SELECT
         HIREDATE
      FROM
         emp
      INNER JOIN
         dept ON emp.DEPTNO = dept.DEPTNO
      WHERE
         DNAME LIKE 'SALES')
   AND DNAME = 'RESEARCH';

-- 13. Donner le salaire le plus élevé par département

SELECT
   SAL
FROM
   emp
ORDER BY
   SAL DESC
LIMIT
   01;

-- 14. Donner département par département masse salariale, nombre d'employés, salaire moyen par type d'emploi.

SELECT
   D.DNAME,
   JOB,
   SUM(SAL + COALESCE(E.COMM, 0)) AS masse_salariale,
   COUNT(EMPNO) AS nombre_employes,
   AVG(SAL) AS salaire_moyen
FROM
   emp AS E
INNER JOIN
   dept AS D ON E.DEPTNO = D.DEPTNO
GROUP BY
   D.DNAME,
   JOB;
   
SELECT
   D.DNAME,
   JOB,
   SUM(SAL + IFNULL(E.COMM, 0)) AS masse_salariale,
   COUNT(EMPNO) AS nombre_employes,
   AVG(SAL) AS salaire_moyen
FROM
   emp AS E
INNER JOIN
   dept AS D ON E.DEPTNO = D.DEPTNO
GROUP BY
   D.DNAME,
   JOB;

-- 15. Même question mais on se limite aux sous-ensembles d'au moins 2 employés

SELECT
   D.DNAME,
   JOB,
   SUM(SAL + IFNULL(E.COMM, 0)) AS masse_salariale,
   COUNT(EMPNO) AS nombre_employes,
   AVG(SAL) AS salaire_moyen
FROM
   emp AS E
INNER JOIN
   dept AS D ON E.DEPTNO = D.DEPTNO
GROUP BY
   D.DNAME,
   JOB
HAVING
   nombre_employes >= 2;


-- 16. Liste des employés (Nom, département, salaire) de même emploi que JONES

SELECT
	ENAME,
	D.DNAME,
	JOB,
	SAL
FROM
	emp AS E
INNER JOIN
	dept AS D ON E.DEPTNO = D.DEPTNO
WHERE
	E.JOB = (
		SELECT 
			JOB
		FROM
			emp
		WHERE
			ENAME = 'JONES'
	);
  
SELECT
	E1.ENAME,
	D.DNAME,
	E1.JOB,
	E1.SAL
FROM
	emp E1
INNER JOIN
	emp E2 ON E1.JOB = E2.JOB
INNER JOIN
	dept D ON E1.DEPTNO = D.DEPTNO
WHERE
	E2.ENAME = 'JONES';

-- 17. Liste des employés (nom, salaire) dont le salaire est supérieur à la moyenne globale des salaires

SELECT
   ENAME,
   SAL
FROM
   emp
WHERE
   SAL > 2073
   
SELECT
   E1.ENAME,
   E1.SAL
FROM
   emp AS E1
INNER JOIN
   emp AS E2 ON E2.SAL = E1.SAL
WHERE
   E2.SAL > AVG(E1.SAL)

-- 18. Création d'une table PROJET avec comme colonnes numéro de projet (3 chiffres), nom de projet(5 caractères), budget. Entrez les valeurs suivantes:
-- 101, ALPHA, 96000
-- 102, BETA, 82000
-- 103, GAMMA, 15000

CREATE TABLE PROJET (
   PNO INT(3),
   PNAME VARCHAR(5) NOT NULL,
   PBUDGET DECIMAL(8,2) NOT NULL,
   PRIMARY KEY(PNO)
);

INSERT INTO PROJET (PNO, PNAME, PBUDGET) VALUES
	(101, "ALPHA", 96000),
	(102, "BETA", 82000),
	(103, "GAMMA", 15000);

-- 19. Ajouter l'attribut numéro de projet à la table EMP et affecter tous les vendeurs du département 30 au projet 101, et les autres au projet 102

ALTER TABLE
	emp
ADD COLUMN
	PNO INT(3) AFTER MGR;

UPDATE
	emp
SET
	PNO = 101
WHERE
   JOB LIKE "SALESMAN"
   AND
	DEPTNO = '30';
	
UPDATE
	emp
SET
	PNO = 102
WHERE
   JOB NOT LIKE "SALESMAN"
   OR
	DEPTNO <> 30;

ALTER TABLE
	emp
ADD CONSTRAINT
	FK_emp_PNO FOREIGN KEY (PNO)
REFERENCES
	PROJET (PNO);

-- 20. Créer une vue comportant tous les employés avec nom, job, nom de département et nom de projet

CREATE VIEW Employes AS SELECT
   ENAME AS 'Nom Employé',
   JOB AS 'Poste',
   DNAME AS 'Departement',
   PNAME AS 'Projet'
FROM
   emp AS E
INNER JOIN
   dept AS D ON D.DEPTNO = E.DEPTNO
INNER JOIN
   PROJET AS P ON P.PNO = E.PNO;


-- 21. A l'aide de la vue créée précédemment, lister tous les employés avec nom, job, nom de département et nom de projet triés sur nom de département et nom de projet

SELECT
   ENAME AS 'Nom Employé',
   JOB AS 'Poste',
   DNAME AS 'Departement',
   PNAME AS 'Projet'
FROM
   emp AS E
INNER JOIN
   dept AS D ON D.DEPTNO = E.DEPTNO
INNER JOIN
   PROJET AS P ON P.PNO = E.PNO
ORDER BY
	DNAME ASC,
	PNAME ASC;

-- 22. Donner le nom du projet associé à chaque manager

SELECT
	PNAME AS 'Projet',
	ENAME AS 'Manager'
FROM
	PROJET AS P
INNER JOIN
	emp AS E ON E.PNO = P.PNO
WHERE
	JOB LIKE 'MANAGER';

-- PARTIE 2

-- 1. Afficher la liste des managers des départements 20 et 30

SELECT
   ENAME AS 'Manager',
   DEPTNO AS 'Département'
FROM
   emp
WHERE
   JOB LIKE 'MANAGER'
   AND
   (  
      DEPTNO = 20
      OR 
      DEPTNO = 30
   );

-- 2. Afficher la liste des employés qui ne sont pas manager et qui ont été embauchés en 81

SELECT
   ENAME AS 'Employé',
   JOB AS 'Poste',
   HIREDATE AS "Date d'embauche"
FROM
   emp
WHERE
   JOB NOT LIKE 'MANAGER'
   AND 
   YEAR(HIREDATE) = 1981;

-- 3. Afficher la liste des employés ayant une commission

SELECT
   ENAME AS 'Employé',
   COMM AS 'Commission'
FROM
   emp
WHERE
   COMM IS NOT NULL
   AND
   COMM > 0;

-- 4. Afficher la liste des noms, numéros de département, jobs et date d'embauche triés par Numero de Département et JOB les derniers embauches d'abord.

SELECT
   ENAME AS 'Employé',
   DEPTNO AS 'Num département',
   JOB AS 'Poste',
   HIREDATE AS "Date d'embauche"
FROM
   emp
ORDER BY
   DEPTNO ASC,
   JOB ASC,
   HIREDATE DESC;

-- 5. Afficher la liste des employés travaillant à DALLAS

SELECT
   ENAME AS 'Employé'
   LOC AS 'Localisation'
FROM
   emp AS E
INNER JOIN
   dept AS D ON D.DEPTNO = E.DEPTNO
WHERE
   LOC LIKE 'DALLAS';

-- 6. Afficher les noms et dates d'embauche des employés embauchés avant leur manager, avec le nom et date d'embauche du manager.

SELECT
   E.ENAME AS 'Employé',
   E.HIREDATE AS "Date d'embauche",
   E2.ENAME AS 'Manager',
   E2.HIREDATE AS "Date d'embauche"
FROM
   emp AS E
INNER JOIN
   emp AS E2 ON E2.EMPNO = E.MGR
WHERE
   E2.HIREDATE > E.HIREDATE;

-- 7. Lister les numéros des employés n'ayant pas de subordonné.

SELECT
	E.EMPNO AS 'No Employé sans subordonné'
FROM
	emp AS E
LEFT JOIN
	emp AS E2 ON E.EMPNO = E2.MGR
WHERE
	E2.EMPNO IS NULL;

-- 8. Afficher les noms et dates d'embauche des employés embauchés avant BLAKE.

SELECT
	E.ENAME AS 'Nom',
	E.HIREDATE AS 'Date embauche'
FROM
	emp AS E
INNER JOIN
	emp AS E2 ON E2.ENAME = 'BLAKE'
WHERE
	E.HIREDATE < E2.HIREDATE;

-- 9. Afficher les employés embauchés le même jour que FORD.

SELECT
	E.ENAME AS 'Nom',
	E.HIREDATE AS 'Date embauche'
FROM
	emp AS E
INNER JOIN
	emp AS E2 ON E2.ENAME = 'FORD'
WHERE
	E.HIREDATE = E2.HIREDATE;

-- 10. Lister les employés ayant le même manager que CLARK.

SELECT
	E.ENAME AS 'Nom',
	E.MGR 'Manager'
FROM
	emp AS E
INNER JOIN
	emp AS E2 ON E2.ENAME = 'CLARK'
WHERE
	E.MGR = E2.MGR;

-- 11. Lister les employés ayant même job et même manager que TURNER.

SELECT
	E.ENAME AS 'Nom',
	E.JOB 'Poste'
FROM
	emp AS E
INNER JOIN
	emp AS E2 ON E2.ENAME = 'TURNER'
WHERE
	E.MGR = E2.MGR
	AND
	E.JOB = E2.JOB;

-- 12. Lister les employés du département RESEARCH embauchés le même jour que quelqu'un du département SALES.

SELECT
   E.ENAME,
   E.HIREDATE
FROM
   emp AS E
INNER JOIN
   dept AS D ON E.DEPTNO = D.DEPTNO
INNER JOIN
   emp AS E2 ON E.HIREDATE = E2.HIREDATE
INNER JOIN
   dept AS D2 ON E2.DEPTNO = D2.DEPTNO
WHERE
   D.DNAME = 'RESEARCH'
   AND D2.DNAME = 'SALES';

-- 13. Lister le nom des employés et également le nom du jour de la semaine correspondant à leur date d'embauche.

SELECT
   ENAME AS 'Nom',
   DATE_FORMAT(HIREDATE, '%W')
FROM
   emp;


-- 14. Donner, pour chaque employé, le nombre de mois qui s'est écoulé entre leur date d'embauche et la date actuelle.

SELECT
  ENAME,
  HIREDATE,
  TIMESTAMPDIFF(MONTH, HIREDATE, CURDATE()) AS mois_ecoules
FROM
  emp;

-- 15. Afficher la liste des employés ayant un M et un A dans leur nom.

SELECT
	ENAME
FROM
	emp
WHERE
	ENAME LIKE '%M%'
  	AND ENAME LIKE '%A%';


-- 16. Afficher la liste des employés ayant deux 'A' dans leur nom.

SELECT
	ENAME
FROM
	emp
WHERE
	ENAME LIKE '%A%A%';


-- 17. Afficher les employés embauchés avant tous les employés du département 10.

SELECT
	ENAME,
	HIREDATE
FROM
	emp
WHERE
	HIREDATE < ALL (
		SELECT
			HIREDATE
		FROM
			emp
		WHERE
			DEPTNO = 10
);


-- 18. Sélectionner le métier où le salaire moyen est le plus faible.

SELECT
	JOB
FROM
	emp
GROUP BY
	JOB
ORDER BY
	AVG(SAL) ASC
LIMIT 1;


-- 19. Sélectionner le département ayant le plus d'employés.

SELECT
	d.DEPTNO,
	d.DNAME,
	COUNT(e.EMPNO) AS nombre_employes
FROM
	dept d
INNER JOIN
	emp e ON d.DEPTNO = e.DEPTNO
GROUP BY
	d.DEPTNO, d.DNAME
ORDER BY
	nombre_employes DESC
LIMIT 1;


-- 20. Donner la répartition en pourcentage du nombre d'employés par département selon le modèle ci-dessous
-- Département Répartition en % 
-- ----------- ----------------
-- 10 21.43 
-- 20 35.71 
-- 30 42.86


