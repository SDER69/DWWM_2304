USE exo_8_avions;

DROP TABLE if EXISTS VOLS;
DROP TABLE if EXISTS PILOTES;
DROP TABLE IF EXISTS avions;
/*SET FOREIGN_KEY_CHECKS = 0;*/

CREATE TABLE IF NOT EXISTS AVIONS
(
	num_avion INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	marque_avion VARCHAR(50) NOT NULL,
	type_avion VARCHAR(30) NOT NULL,
	capacite_avion INT NOT NULL,
	localisation_avion VARCHAR(50) NOT NULL
);
	
CREATE TABLE IF NOT EXISTS PILOTES
(
	num_pilote INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
	nom_pilote VARCHAR(50) NOT NULL,
	adresse_pilote VARCHAR(250) NOT NULL
);

CREATE TABLE IF NOT EXISTS VOLS
(
	num_vol VARCHAR(50) PRIMARY KEY NOT NULL,
	num_avion INT NOT NULL,
	num_pilote INT NOT NULL,
	ville_depart VARCHAR(50) NOT NULL,
	ville_arrivee VARCHAR(50) NOT NULL,
	heure_depart TIME NOT NULL,
	heure_arrivee TIME NOT NULL
);

ALTER TABLE VOLS
ADD CONSTRAINT FK_num_pilote FOREIGN KEY(num_pilote) REFERENCES PILOTES(num_pilote),
ADD CONSTRAINT FK_num_avion FOREIGN KEY(num_avion) REFERENCES avions(num_avion);

ALTER TABLE avions AUTO_INCREMENT=100;

INSERT INTO avions VALUES
(num_avion,'AIRBUS','A320',300,'Nice'),
(num_avion,'BOEING','B707',250,'Paris'),
(num_avion,'AIRBUS','A320',300,'Toulouse'),
(num_avion,'CARAVELLE','Caravelle',200,'Toulouse'),
(num_avion,'BOEING','B747',400,'Paris'),
(num_avion,'AIRBUS','A320',300,'Grenoble'),
(num_avion,'ATR','ATR42',50,'Paris'),
(num_avion,'BOEING','B727',300,'Lyon'),
(num_avion,'BOEING','B727',300,'Nantes'),
(num_avion,'AIRBUS','A340',350,'Bastia');

INSERT INTO pilotes VALUES
(num_pilote,'SERGE','Nice'),
(num_pilote,'JEAN','Paris'),
(num_pilote,'CLAUDE','Grenoble'),
(num_pilote,'ROBERT','Nantes'),
(num_pilote,'SIMON','Paris'),
(num_pilote,'LUCIEN','Toulouse'),
(num_pilote,'BERTRAND','Lyon'),
(num_pilote,'HERVE','Bastia'),
(num_pilote,'LUC','Paris');

INSERT INTO vols VALUES
('IT100',100,1,'Nice','Paris',"7:00:00","9:00:00"),
('IT101',100,2,'Paris','Toulouse',"11:00:00","12:00:00"),
('IT102',101,1,'Paris','Nice',"12:00:00","14:00:00"),
('IT103',105,3,'Grenoble','Toulouse',"9:00:00","11:00:00"),
('IT104',105,3,'Toulouse','Grenoble',"17:00:00","19:00:00"),
('IT105',107,7,'Lyon','Paris',"6:00:00","7:00:00"),
('IT106',109,8,'Bastia','Paris',"10:00:00","13:00:00"),
('IT107',106,9,'Paris','Brive',"7:00:00","8:00:00"),
('IT108',106,9,'Brive','Paris',"19:00:00","20:00:00"),
('IT109',107,7,'Paris','Lyon',"18:00:00","19:00:00"),
('IT110',102,2,'Toulouse','Paris',"15:00:00","16:00:00"),
('IT111',101,4,'Nice','Nantes',"17:00:00","19:00:00"),
('IT112',103,5,'Paris','Nice',"11:00:00","13:00:00"),
('IT113',104,6,'Nice','Paris',"13:00:00","15:00:00");








