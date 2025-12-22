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


-- Listage de la structure de la base pour db_emploi
CREATE DATABASE IF NOT EXISTS `db_emploi` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_uca1400_ai_ci */;
USE `db_emploi`;

-- Listage de la structure de table db_emploi. dept
CREATE TABLE IF NOT EXISTS `dept` (
  `DEPTNO` int(10) unsigned NOT NULL,
  `DNAME` varchar(50) NOT NULL,
  `LOC` varchar(150) NOT NULL,
  PRIMARY KEY (`DEPTNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_uca1400_ai_ci;

-- Listage des données de la table db_emploi.dept : ~4 rows (environ)
INSERT INTO `dept` (`DEPTNO`, `DNAME`, `LOC`) VALUES
	(10, 'ACCOUNTING', 'NEWYORK'),
	(20, 'RESEARCH', 'DALLAS'),
	(30, 'SALES', 'CHICAGO'),
	(40, 'OPERATIONS', 'BOSTON');

-- Listage de la structure de table db_emploi. emp
CREATE TABLE IF NOT EXISTS `emp` (
  `EMPNO` int(10) unsigned NOT NULL,
  `ENAME` varchar(50) NOT NULL,
  `JOB` varchar(50) NOT NULL,
  `MGR` int(10) unsigned DEFAULT NULL,
  `PNO` int(3) DEFAULT NULL,
  `HIREDATE` date NOT NULL,
  `SAL` decimal(8,2) NOT NULL,
  `COMM` int(11) DEFAULT NULL,
  `DEPTNO` int(10) unsigned NOT NULL,
  PRIMARY KEY (`EMPNO`),
  KEY `FK_departement` (`DEPTNO`),
  KEY `FK_emp_PNO` (`PNO`),
  CONSTRAINT `FK_departement` FOREIGN KEY (`DEPTNO`) REFERENCES `dept` (`DEPTNO`),
  CONSTRAINT `FK_emp_PNO` FOREIGN KEY (`PNO`) REFERENCES `PROJET` (`PNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_uca1400_ai_ci;

-- Listage des données de la table db_emploi.emp : ~14 rows (environ)
INSERT INTO `emp` (`EMPNO`, `ENAME`, `JOB`, `MGR`, `PNO`, `HIREDATE`, `SAL`, `COMM`, `DEPTNO`) VALUES
	(7369, 'SMITH', 'CLERK', 7902, 102, '1980-12-17', 800.00, NULL, 20),
	(7499, 'ALLEN', 'SALESMAN', 7698, 101, '1981-02-20', 1600.00, 300, 30),
	(7521, 'WARD', 'SALESMAN', 7698, 101, '1981-02-22', 1250.00, 500, 30),
	(7566, 'JONES', 'MANAGER', 7839, 102, '1981-04-02', 2975.00, NULL, 20),
	(7654, 'MARTIN', 'SALESMAN', 7698, 101, '1981-11-28', 1250.00, 1400, 30),
	(7698, 'BLAKE', 'MANAGER', 7839, 102, '1981-05-01', 2850.00, NULL, 30),
	(7782, 'CLARK', 'MANAGER', 7839, 102, '1981-07-09', 2450.00, NULL, 10),
	(7788, 'SCOTT', 'ANALYST', 7566, 102, '1982-12-09', 3000.00, NULL, 20),
	(7839, 'KING', 'PRESIDENT', NULL, 102, '1981-11-17', 5000.00, NULL, 10),
	(7844, 'TURNER', 'SALESMAN', 7698, 101, '1981-09-08', 1500.00, 0, 30),
	(7876, 'ADAMS', 'CLERK', 7788, 102, '1983-01-12', 1100.00, NULL, 20),
	(7900, 'JAMES', 'CLERK', 7698, 102, '1981-12-03', 950.00, NULL, 30),
	(7902, 'FORD', 'ANALYST', 7566, 102, '1981-12-03', 3000.00, NULL, 20),
	(7934, 'MILLER', 'CLERK', 7782, 102, '1982-01-23', 1300.00, NULL, 10);

-- Listage de la structure de vue db_emploi. Employes
-- Création d'une table temporaire pour palier aux erreurs de dépendances de VIEW
CREATE TABLE `Employes` (
	`Nom Employé` VARCHAR(50) NOT NULL COLLATE 'utf8mb3_uca1400_ai_ci',
	`Poste` VARCHAR(50) NOT NULL COLLATE 'utf8mb3_uca1400_ai_ci',
	`Departement` VARCHAR(50) NOT NULL COLLATE 'utf8mb3_uca1400_ai_ci',
	`Projet` VARCHAR(5) NOT NULL COLLATE 'utf8mb4_uca1400_ai_ci'
) ENGINE=MyISAM;

-- Listage de la structure de table db_emploi. PROJET
CREATE TABLE IF NOT EXISTS `PROJET` (
  `PNO` int(3) NOT NULL,
  `PNAME` varchar(5) NOT NULL,
  `PBUDGET` decimal(8,2) NOT NULL,
  PRIMARY KEY (`PNO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- Listage des données de la table db_emploi.PROJET : ~3 rows (environ)
INSERT INTO `PROJET` (`PNO`, `PNAME`, `PBUDGET`) VALUES
	(101, 'ALPHA', 96000.00),
	(102, 'BETA', 82000.00),
	(103, 'GAMMA', 15000.00);

-- Listage de la structure de vue db_emploi. Employes
-- Suppression de la table temporaire et création finale de la structure d'une vue
DROP TABLE IF EXISTS `Employes`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `Employes` AS select `E`.`ENAME` AS `Nom Employé`,`E`.`JOB` AS `Poste`,`D`.`DNAME` AS `Departement`,`P`.`PNAME` AS `Projet` from ((`emp` `E` join `dept` `D` on(`D`.`DEPTNO` = `E`.`DEPTNO`)) join `PROJET` `P` on(`P`.`PNO` = `E`.`PNO`));

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
