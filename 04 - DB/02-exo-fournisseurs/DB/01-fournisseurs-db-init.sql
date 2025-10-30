USE db_fournisseurs;

DROP TABLE IF EXISTS ligne_bon_de_livraison;
DROP TABLE IF EXISTS articles;
DROP TABLE IF EXISTS employe;
DROP TABLE IF EXISTS rayon;
DROP TABLE IF EXISTS fournisseurs;

CREATE TABLE fournisseurs(
   codeF CHAR(6),
   nomF VARCHAR(50) NOT NULL,
   adresse VARCHAR(50) NOT NULL,
   PRIMARY KEY(codeF)
);

CREATE TABLE rayon(
   nomR VARCHAR(50),
   etage INT NOT NULL,
   PRIMARY KEY(nomR)
);

CREATE TABLE employe(
   codeEmpl INT,
   nom VARCHAR(50) NOT NULL,
   salaire INT NOT NULL,
   nomR VARCHAR(50) NOT NULL,
   codeSupHierarchique INT NOT NULL,
   PRIMARY KEY(codeEmpl),
   FOREIGN KEY(nomR) REFERENCES rayon(nomR),
   FOREIGN KEY(codeSupHierarchique) REFERENCES employe(codeEmpl)
);

CREATE TABLE articles(
   codeA CHAR(8),
   nomA VARCHAR(255) NOT NULL,
   type VARCHAR(50),
   nomR VARCHAR(50) NOT NULL,
   PRIMARY KEY(codeA),
   FOREIGN KEY(nomR) REFERENCES rayon(nomR)
);

CREATE TABLE ligne_bon_de_livraison(
   codeF CHAR(6),
   codeA CHAR(8),
   quantité VARCHAR(50),
   PRIMARY KEY(codeF, codeA),
   FOREIGN KEY(codeF) REFERENCES fournisseurs(codeF),
   FOREIGN KEY(codeA) REFERENCES articles(codeA)
);


-- Insertion des fournisseurs
INSERT INTO fournisseurs VALUES
('FABCDE', 'Alpha', '12 rue des Lilas'),
('FABCFG', 'Beta', '34 avenue des Roses'),
('FBCDEF', 'Gamma', '56 boulevard des Pins'),
('FCDEFG', 'Delta', '78 impasse des Tulipes'),
('FDEFGH', 'Epsilon', '90 place des Marguerites');

-- Insertion des rayons
INSERT INTO rayon VALUES
('Electroménager', 1),
('Jouets', 2),
('Vêtements', 1),
('Alimentation', 0),
('Bricolage', 2);

-- Insertion des employés
INSERT INTO employe VALUES
(1, 'Martin', 2000, 'Electroménager', 1),
(2, 'Durand', 1800, 'Jouets', 1),
(3, 'Lefevre', 1700, 'Vêtements', 1),
(4, 'Bernard', 1600, 'Alimentation', 1),
(5, 'Dubois', 1850, 'Bricolage', 1);

-- Insertion des articles
INSERT INTO articles VALUES
('A0000001', 'Aspirateur', 'Electroménager', 'Electroménager'),
('A0000002', 'Poupée', 'Jouet', 'Jouets'),
('A0000003', 'T-shirt', 'Vêtement', 'Vêtements'),
('A0000004', 'Pain', 'Aliment', 'Alimentation'),
('A0000005', 'Marteau', 'Outil', 'Bricolage'),
('A0000006', 'Réfrigérateur', 'Electroménager', 'Electroménager'),
('A0000007', 'Voiture télécommandée', 'Jouet', 'Jouets'),
('A0000008', 'Jean', 'Vêtement', 'Vêtements'),
('A0000009', 'Lait', 'Aliment', 'Alimentation'),
('A0000010', 'Tournevis', 'Outil', 'Bricolage');


-- Insertion des lignes de bon de livraison
INSERT INTO ligne_bon_de_livraison VALUES
('FABCDE', 'A0000001', '10'),
('FABCFG', 'A0000002', '20'),
('FBCDEF', 'A0000003', '15'),
('FCDEFG', 'A0000004', '50'),
('FDEFGH', 'A0000005', '5'),
('FABCDE', 'A0000006', '8'),
('FABCFG', 'A0000007', '12'),
('FBCDEF', 'A0000008', '18'),
('FCDEFG', 'A0000009', '30'),
('FDEFGH', 'A0000010', '7'),
('FABCDE', 'A0000002', '5'),
('FABCFG', 'A0000003', '9'),
('FBCDEF', 'A0000004', '22'),
('FCDEFG', 'A0000005', '3'),
('FDEFGH', 'A0000001', '6'),
('FABCDE', 'A0000003', '11'),
('FABCFG', 'A0000004', '14'),
('FBCDEF', 'A0000005', '9'),
('FCDEFG', 'A0000006', '7'),
('FDEFGH', 'A0000007', '13'),
('FABCDE', 'A0000008', '16'),
('FABCFG', 'A0000009', '21'),
('FBCDEF', 'A0000010', '4'),
('FCDEFG', 'A0000001', '12'),
('FDEFGH', 'A0000002', '8');

/* ajouter une colonne a article */
ALTER table articles ADD COLUMN prix DECIMAL(5,2) NOT NULL DEFAULT '0';

 
/* mise a jour des prix */
UPDATE articles SET prix=120 WHERE codeA='A0000001';
UPDATE articles SET prix=50 WHERE codeA='A0000002';
UPDATE articles SET prix=10 WHERE codeA='A0000003';
UPDATE articles SET prix=1 WHERE codeA='A0000004';
UPDATE articles SET prix=12 WHERE codeA='A0000005';
UPDATE articles SET prix=500 WHERE codeA='A0000006';
UPDATE articles SET prix=20 WHERE codeA='A0000007';
UPDATE articles SET prix=40 WHERE codeA='A0000008';
UPDATE articles SET prix=1.5 WHERE codeA='A0000009';
UPDATE articles SET prix=3 WHERE codeA='A0000010';