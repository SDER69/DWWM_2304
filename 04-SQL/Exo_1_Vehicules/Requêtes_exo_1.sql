USE exo_1_vehicules;

DROP TABLE IF EXISTS Vehicules;
DROP TABLE IF EXISTS Personnes;

CREATE TABLE IF NOT EXISTS Personnes
(
	id_personne INT PRIMARY KEY AUTO_INCREMENT,
	nom VARCHAR(50) NOT NULL,
	prenom VARCHAR(50) NOT NULL,
	num_rue INT NOT NULL,
	rue VARCHAR(100) NOT NULL,
	cp VARCHAR(5) NOT NULL,
	ville VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS Vehicules
(
	immatriculation INT PRIMARY KEY,
	marque VARCHAR(50) NOT NULL,
	kilometrage INT NOT NULL,
	date_mise_en_service DATE NOT NULL,
	id_personne INT NOT NULL
);	
					
ALTER TABLE Vehicules
ADD CONSTRAINT FOREIGN KEY (id_personne) REFERENCES Personnes(id_personne);	
ALTER TABLE Personnes
ADD
CONSTRAINT CK_cp CHECK (cp < 96000);

INSERT INTO personnes (id_personne,nom,prenom,num_rue,rue,cp,ville)
 VALUES
 (1,'Rébecca', 'Armand','12','rue de la Liberté','69250','Lyon'),
 (2,'Dupont', 'Marc','20','rue des Brosses','69140','Lyon'),
 (3,'Martin', 'Eric','25','rue des Alouettes','75000','Paris'),
 (4,'Herbert', 'Michel','102','boulevard Saint-Michel','96000','Paris');

