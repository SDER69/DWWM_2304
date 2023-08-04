USE exo_2_et_3_etudiants;

DROP TABLE IF EXISTS NOTATIONS;
DROP TABLE IF EXISTS ETUDIANTS;
DROP TABLE IF EXISTS MATIERES;

CREATE TABLE IF NOT EXISTS ETUDIANTS
(
	id_etudiant INT PRIMARY KEY AUTO_INCREMENT,
	nom VARCHAR(50) NOT NULL,
	prenom VARCHAR(50) NOT NULL,
	date_entree DATE NOT NULL
);

CREATE TABLE IF NOT EXISTS MATIERES
(
	id_matiere INT PRIMARY KEY,
	lib_matiere VARCHAR(250) NOT NULL UNIQUE,
	coefficient INT NOT NULL
);

CREATE TABLE IF NOT EXISTS NOTATIONS
(	
	id_etudiant INT NOT NULL,
	id_matiere INT NOT NULL,
	moyenne DECIMAL(4,2) NOT NULL
);

ALTER TABLE NOTATIONS
ADD CONSTRAINT FOREIGN KEY (id_etudiant) REFERENCES ETUDIANTS (id_etudiant),
ADD CONSTRAINT FOREIGN KEY (id_matiere) REFERENCES MATIERES (id_matiere),
ADD CONSTRAINT PK_id_etudiant_id_matiere PRIMARY KEY (id_etudiant,id_matiere);
				

					
