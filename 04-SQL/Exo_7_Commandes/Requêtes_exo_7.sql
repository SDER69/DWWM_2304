USE exo_7_commandes;

DROP TABLE IF EXISTS ACHATS;
DROP TABLE IF EXISTS COMMANDES;
DROP TABLE IF EXISTS BUVEURS;
DROP TABLE IF EXISTS VINS;
DROP TABLE IF EXISTS vignerons;
DROP VIEW if EXISTS buveurs_vw;


CREATE TABLE IF NOT EXISTS VIGNERONS
(
	num_vig INT PRIMARY KEY,
	nom_vig VARCHAR(50) NOT NULL,
	prenom_vig VARCHAR(50) NOT NULL,
	ville_vig VARCHAR(50) NOT NULL,
	CONSTRAINT U_nom_prenom UNIQUE(nom_vig,prenom_vig)
);

CREATE TABLE IF NOT EXISTS VINS
(
	num_vin INT PRIMARY KEY,
	millesime DATE NOT NULL,
	num_vig INT NOT NULL
);

CREATE TABLE IF NOT EXISTS BUVEURS
(
	num_buv INT PRIMARY KEY,
	nom_buv VARCHAR(50) NOT NULL,
	prenom_buv VARCHAR(50) NOT NULL,
	ville_buv VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS COMMANDES
(
	num_com INT PRIMARY KEY,
	date_comm DATE NOT NULL,
	num_buv INT NOT NULL
);

CREATE TABLE IF NOT EXISTS ACHATS
(
	num_vin INT NOT NULL,
	num_com INT NOT NULL,
	quantite INT NOT NULL
);

ALTER TABLE VINS
ADD CONSTRAINT FK_num_vig FOREIGN KEY(num_vig) REFERENCES VIGNERONS(num_vig);

ALTER TABLE COMMANDES
ADD CONSTRAINT FK_num_buv FOREIGN KEY(num_buv) REFERENCES BUVEURS(num_buv);

ALTER TABLE ACHATS
ADD CONSTRAINT PK_num_vin_num_com PRIMARY KEY (num_vin,num_com),
ADD CONSTRAINT FK_num_vin FOREIGN KEY(num_vin) REFERENCES VINS(num_vin),
ADD CONSTRAINT FK_num_com FOREIGN KEY(num_com) REFERENCES COMMANDES(num_com);

CREATE INDEX nom_buv_index ON buveurs (nom_buv);
CREATE INDEX prenom_buv_index ON buveurs(prenom_buv); 

INSERT INTO buveurs VALUES(1,'Tournesol','Tryphon','Geneve'),
(2,'Lampion','Séraphin','Paris');

insert INTO commandes VALUES(25,'2023-01-12',1),
(30,'2023-02-06',1),(37,'2023-05-04',2),(39,'2023-05-06',2);

CREATE VIEW buveurs_vw AS
  SELECT nom_buv,prenom_buv,ville_buv,num_com
  FROM buveurs,commandes ORDER BY nom_buv ASC







