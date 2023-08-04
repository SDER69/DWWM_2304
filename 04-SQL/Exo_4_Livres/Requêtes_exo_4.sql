USE exo_4_livres;

DROP TABLE IF EXISTS EXEMPLAIRES;
DROP TABLE IF EXISTS LIVRES;

CREATE TABLE IF NOT EXISTS LIVRES
(
	isbn VARCHAR(50) PRIMARY KEY,
	titre VARCHAR(250) NOT NULL	
);

CREATE TABLE IF NOT EXISTS EXEMPLAIRES
(
	num_exemplaire INT,
	isbn VARCHAR(250) NOT NULL,
	etat CHAR NOT NULL /*DEFAULT 'D'*//*1ere méthode*/
);

ALTER TABLE EXEMPLAIRES
ADD CONSTRAINT FK_isbn FOREIGN KEY (isbn) REFERENCES LIVRES (isbn),
ADD CONSTRAINT PK_num_exemplaire_isbn PRIMARY KEY (num_exemplaire,isbn),
ADD CONSTRAINT CK_etat CHECK (etat IN ("D:disponible", "E:emprunté", "P:perdu")),
MODIFY COLUMN etat CHAR NOT NULL DEFAULT 'D';/*2eme méthode*/







				

					






				

					
exemplaires