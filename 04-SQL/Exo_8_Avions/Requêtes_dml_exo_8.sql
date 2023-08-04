USE exo_8_avions;

/*Question 1 : 1 Quels sont les vols au départ de Paris entre 12h et 14h ?*/
SELECT* FROM vols
WHERE ville_depart="Paris" AND (heure_depart BETWEEN ("12:00:00") AND ("14:00:00"));



/*Question 2 : Quels sont les pilotes dont le nom commence par "S" ?*/
/*SELECT* FROM pilotes WHERE LEFT(nom_pilote, 1) = 'S';*//*1ere méthode*/
SELECT* FROM pilotes WHERE nom_pilote LIKE 'S%';/*2eme méthode*/



/*Question 3 : Pour chaque ville, donner le nombre et les capacités minimum et maximum des avions qui s'y trouvent.*/
SELECT COUNT(localisation_avion) AS nb_avion,localisation_avion,MIN(capacite_avion), MAX(capacite_avion)
FROM avions
GROUP BY localisation_avion



/*Question 4 : Pour chaque ville, donner la capacité moyenne des avions qui s'y trouvent et cela par type d'avion.*/
SELECT COUNT(*),localisation_avion,AVG(capacite_avion) AS capacite_moyenne,marque_avion
FROM avions
GROUP BY localisation_avion,marque_avion



/*Question 5 : Quelle est la capacité moyenne des avions pour chaque ville ayant plus de 1 avion ? */
SELECT count(localisation_avion) AS "nb appareils",localisation_avion,AVG(capacite_avion) AS capacite_moyenne
FROM avions
GROUP BY localisation_avion
HAVING COUNT(localisation_avion) > 1



/*Question 6 : Quels sont les noms des pilotes qui habitent dans la ville de localisation d'un Airbus */
/*1ere méthode*/
SELECT nom_pilote,adresse_pilote
FROM pilotes,avions
WHERE pilotes.adresse_pilote = avions.localisation_avion AND avions.marque_avion = "AIRBUS";
 /*2eme méthode*/
SELECT nom_pilote,adresse_pilote FROM pilotes
WHERE adresse_pilote IN (SELECT localisation_avion FROM avions WHERE marque_avion = "AIRBUS");



/*Question 7 : Quels sont les noms des pilotes qui conduisent un Airbus et qui habitent dans la ville de localisation d'un Airbus ?*/
/*1ere méthode*/
SELECT nom_pilote,adresse_pilote FROM pilotes
WHERE adresse_pilote IN (SELECT localisation_avion FROM avions WHERE marque_avion = "AIRBUS")
AND num_pilote IN (SELECT vols.num_pilote FROM avions JOIN vols ON avions.num_avion=vols.num_avion AND avions.marque_avion = "AIRBUS" )
/*2eme méthode*/
SELECT distinct nom_pilote,adresse_pilote
FROM pilotes  
INNER JOIN vols ON pilotes.num_pilote = vols.num_pilote
INNER JOIN avions ON vols.num_avion = avions.num_avion 
WHERE pilotes.adresse_pilote = avions.localisation_avion AND avions.marque_avion = "AIRBUS";



/*Question 8 : Quels sont les noms des pilotes qui conduisent un Airbus ou qui habitent dans la ville de localisation d'un Airbus ? */
/*1ere méthode*/
SELECT nom_pilote,adresse_pilote FROM pilotes
WHERE adresse_pilote IN (SELECT localisation_avion FROM avions WHERE marque_avion = "AIRBUS")
OR num_pilote IN (SELECT vols.num_pilote FROM avions JOIN vols ON avions.num_avion=vols.num_avion AND avions.marque_avion = "AIRBUS")

/*2eme méthode*/
SELECT distinct pilotes.nom_pilote
FROM pilotes  
INNER JOIN vols ON pilotes.num_pilote = vols.num_pilote
INNER JOIN avions ON vols.num_avion = avions.num_avion AND avions.marque_avion="AIRBUS"
UNION
SELECT DISTINCT pilotes.nom_pilote
FROM pilotes
WHERE pilotes.adresse_pilote IN(SELECT DISTINCT localisation_avion FROM avions WHERE avions.marque_avion = "AIRBUS")

/*3eme méthode*/
SELECT DISTINCT pilotes.nom_pilote, pilotes.adresse_pilote
FROM pilotes
JOIN vols  ON pilotes.num_pilote = vols.num_pilote
JOIN avions ON vols.num_avion = avions.num_avion OR pilotes.adresse_pilote = avions.localisation_avion
WHERE avions.marque_avion = 'AIRBUS'



/*Question 9 : Quels sont les noms des pilotes qui conduisent un Airbus sauf ceux qui habitent dans la ville de localisation d'un Airbus ?*/
/*1ere méthode*/
SELECT DISTINCT pilotes.nom_pilote, pilotes.adresse_pilote
FROM pilotes
JOIN vols  ON pilotes.num_pilote = vols.num_pilote
JOIN avions ON vols.num_avion = avions.num_avion AND NOT pilotes.adresse_pilote = avions.localisation_avion
WHERE avions.marque_avion = 'AIRBUS'

/*2eme méthoode*/
SELECT DISTINCT  nom_pilote,adresse_pilote
FROM pilotes JOIN avions
WHERE num_pilote IN (SELECT  num_pilote FROM vols INNER JOIN avions ON vols.num_avion = avions.num_avion WHERE marque_avion = 'AIRBUS' )
AND NOT adresse_pilote IN (SELECT localisation_avion FROM avions WHERE marque_avion = 'AIRBUS')



/*Question 10 : Quels sont les vols ayant un trajet identique ( VD, VA ) à ceux assurés par Serge ?*/
SELECT num_vol, ville_depart, ville_arrivee FROM vols 
WHERE ville_depart IN (SELECT V.ville_depart FROM vols AS V JOIN pilotes AS P ON P.num_pilote = V.num_pilote AND P.nom_pilote = 'SERGE')
AND ville_arrivee IN (SELECT V.ville_arrivee FROM vols AS V JOIN pilotes AS P ON P.num_pilote = V.num_pilote AND P.nom_pilote = 'SERGE')
AND num_pilote <> (SELECT num_pilote FROM pilotes WHERE nom_pilote = 'SERGE')



/*Question 11 : Donner toutes les paires de pilotes habitant la même ville (sans doublon). */
SELECT  COUNT(adresse_pilote)
FROM pilotes
GROUP BY adresse_pilote
HAVING COUNT(adresse_pilote) > 1







