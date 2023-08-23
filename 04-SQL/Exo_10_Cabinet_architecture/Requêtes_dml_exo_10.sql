USE exo_10_cabinet_architecture;

INSERT INTO type_travaux 
(type_travaux_id, type_travaux_libelle) 
VALUES
(1, 'Construction'),
(2, 'Aménagement'),
(3, 'Rénovation'),
(4, 'Réhabilitation'),
(5, 'Restauration');


INSERT INTO fonctions 
(fonction_id, fonction_nom)
VALUES
(1,'Architecte'),
(2,'Dessinateur'),
(3,'Administratif');

INSERT INTO type_clients(type_client_id,type_client_libelle)
VALUES 
(1,'Particulier'),
(2,'institution publique'),
(3,'institution privée'),
(4,'promoteur'),
(5,'autre');

INSERT INTO type_projets 
(type_projet_id, type_projet_libelle)
VALUES
(1, "Maison"),
(2, "Appartement"),
(3, "Chalet"),
(4, "Immeuble"), 
(5, "Hôpital"),
(6, "Ecole"),
(7, "locaux commerciaux");

INSERT INTO adresses
(adresse_code_postal, adresse_ville, adresse_num_voie, adresse_voie)
VALUES 
('06000', 'Nice', 27, 'Rue Dabray'),
('06380', 'Sospel', 16, 'Rue de la Republique'),
('68200', 'Mulhouse', 7, 'Boulevard des Nations'),
('13500', 'Martigues', 12, 'Av. Georges Braque'),
('75017', 'Paris', 27, 'Rue des Renaudes');

INSERT INTO clients(client_nom, client_telephone, type_client_id, adresse_id)
VALUES
    ('Ville de Nice', '0450047785', 2, 1),
    ('BOSS', '0615486223', 3, 2),
    ('Lili', '0685941335', 1, 3),
    ('ESCALA', '0102529164', 4, 4),
    ('Mystère', '0000000000', 5, 5);

INSERT INTO employes(emp_matricule, emp_nom, emp_prenom, emp_date_embauche, fonction_id) VALUES 
(1, "Roussotte", "Kévin", "2023-08-02", 1),
(2, "Schieber", "Florian", "2023-08-03", 2),
(3, "Robson", "Natana", "2023-08-04", 3),
(4, "Golay", "Jerry", "2023-08-07", 1),
(5, "Neymar", "Jean", "2023-08-07", 2),
(6, "Desplantes", "Guillaume", "2023-08-07", 2),
(7, "Desplanques", "Guy", "2010-08-07", 3);

INSERT INTO projets 
(   projet_ref, projet_date_depot, projet_date_fin_prevue, projet_date_fin_effective,projet_superficie_totale, projet_superficie_batie,
    projet_prix, client_ref, emp_matricule, adresse_id, type_travaux_id, type_projet_id )
VALUES 
('1', '2022-11-02', '2022-08-12', '2022-09-27', '500', '250', '9999.99', '5', '1', '1', '1', '1'),
('2', '2022-12-15', '2023-01-14', '2023-01-14', '700', '690', '100000', '4', '1', '2', '5', '3'),
('3', '2023-01-02', '2023-10-01', NULL,         '500', '300', '5412', '3', '4', '3', '4', '4'),
('4', '2023-02-10', '2023-10-02', NULL,         '200', '190', '4000', '2', '1', '4', '3', '2'),
('5', '2023-04-23', '2023-12-22', NULL,         '90', '50', '2500', '1', '4', '5', '3', '2');

INSERT INTO participer (emp_matricule,projet_ref)
VALUES 
(2,1),
(3,1),
(7,1),
(6,2),
(5,2),
(5,3),
(6,4),
(7,4),
(2,4),
(3,4);



/*-------------------------------------------------------REQUETES-------------------------------------------------------------*/

/* 1. Sélectionner l'identifiant, le nom de tous les clients dont le numéro de téléphone commence par '04' */
SELECT client_ref,client_nom,client_telephone
FROM clients 
WHERE client_telephone LIKE '04%';



/* 2. Sélectionner l'identifiant, le nom et le type de tous les clients qui sont des particuliers */
/*1ere méthode*/
SELECT c.client_ref,c.client_nom,tp.type_client_id,tp.type_client_libelle
FROM clients c
INNER JOIN type_clients tp ON c.type_client_id = tp.type_client_id 
WHERE tp.type_client_libelle = 'Particulier';

/*2eme méthode*/
SELECT c.client_ref,c.client_nom,tp.type_client_id,tp.type_client_libelle
FROM clients c
INNER JOIN type_clients tp ON c.type_client_id = tp.type_client_id AND tp.type_client_libelle = 'Particulier';



/* 3. Sélectionner l'identifiant, le nom et le type de tous les clients qui ne sont pas des particuliers */
SELECT c.type_client_id,c.client_nom,tp.type_client_libelle
FROM clients c
INNER JOIN type_clients tp ON c.type_client_id = tp.type_client_id
WHERE tp.type_client_libelle != 'Particulier'
ORDER BY tp.type_client_id ASC;



/* 4. Sélectionner les projets qui ont été livrés en retard */
SELECT projet_ref,projet_date_fin_prevue,projet_date_fin_effective
FROM projets
WHERE projet_date_fin_effective > projet_date_fin_prevue;



/* 5. Sélectionner la date de dépôt, la date de fin prévue, les superficies, le prix de tous les projets 
avec le nom du client et le nom de l'architecte associés au projet */
SELECT DISTINCT p.projet_date_depot,p.projet_date_fin_prevue,p.projet_superficie_totale,p.projet_superficie_batie,p.projet_prix,
c.client_nom,e.emp_nom
FROM projets p
INNER JOIN clients c ON p.adresse_id = c.adresse_id
INNER JOIN employes e WHERE e.fonction_id = 1
ORDER BY e.emp_nom;



/* 6. Sélectionner tous les projets (dates, superficies, prix) avec le nombre d'intervenants autres que le client et l'architecte */
SELECT p.projet_ref,count(e.emp_nom),p.projet_date_depot,p.projet_date_fin_prevue,p.projet_date_fin_effective,p.projet_superficie_totale,p.projet_superficie_batie,p.projet_prix
FROM projets p
INNER JOIN participer pa ON p.projet_ref = pa.projet_ref
INNER JOIN employes e ON pa.emp_matricule = e.emp_matricule
GROUP BY p.projet_ref,p.projet_date_depot,p.projet_date_fin_prevue,p.projet_date_fin_effective,p.projet_superficie_totale,p.projet_superficie_batie,p.projet_prix;



/* 7. Sélectionner les types de projets avec, pour chacun d'entre eux, le nombre de projets associés et le prix moyen pratiqué */
SELECT type_projet_id AS 'type projet id',COUNT(type_projet_id) AS 'nb projets',AVG(projet_prix) AS 'prix moyen pratiqué'
FROM projets 
GROUP BY type_projet_id

SELECT p.type_projet_id AS 'projet id',COUNT(p.type_projet_id) AS 'nb projets',AVG(p.projet_prix) AS 'prix moyen pratiqué',tp.type_projet_libelle AS 'libelle projet'
FROM projets p
inner JOIN type_projets tp ON p.type_projet_id = tp.type_projet_id
GROUP BY p.type_projet_id
ORDER BY p.type_projet_id ASC



/* 8. Sélectionner les types de travaux avec, pour chacun d'entre eux, la superficie du projet la pls grande */
SELECT tt.type_travaux_id,tt.type_travaux_libelle,max(p.projet_superficie_totale)
FROM type_travaux tt
INNER JOIN projets p ON p.type_travaux_id = tt.type_travaux_id
GROUP BY  tt.type_travaux_id,tt.type_travaux_libelle



/* 9. Sélectionner l'ensembles des projets (dates, prix) avec les informations du client (nom, telephone, adresse), le type de travaux et le type de projet. */
SELECT p.projet_date_depot,p.projet_prix,c.client_nom,c.client_telephone,a.adresse_ville,tt.type_travaux_libelle,tp.type_projet_libelle
FROM projets p
INNER JOIN clients c ON p.client_ref = c.client_ref
INNER JOIN type_travaux tt ON p.type_travaux_id = tt.type_travaux_id
INNER JOIN type_projets tp ON p.type_projet_id = tp.type_projet_id
INNER JOIN adresses a ON c.adresse_id = a.adresse_id



/* 10. Sélectionner les projets dont l'adresse est identique au client associé */
SELECT p.projet_ref,c.client_nom,p.adresse_id,a.adresse_code_postal
FROM projets p
INNER JOIN clients c ON p.client_ref = c.client_ref
INNER JOIN adresses a ON c.adresse_id = a.adresse_id
WHERE c.adresse_id = p.adresse_id

/*-------------------------------------------------------REQUETES PROCEDURES STOCKEES-------------------------------------------------------------*/

/* 1. Quels sont les noms, prénoms,matricules des architectes parmi les employes ? */
DELIMITER |
CREATE PROCEDURE recherche_emp_archi()
BEGIN 
SELECT emp_matricule,emp_nom,emp_prenom 
FROM employes
JOIN fonctions ON fonctions.fonction_id = employes.fonction_id
WHERE fonction_nom = 'architecte';
END|
DELIMITER ;

/* Appel de la procédure */
CALL recherche_emp_archi();



/* 2. Renvoyer la liste des salariés pour une "fonction" donnée en paramétre. Stored procedure. */
DELIMITER |
CREATE PROCEDURE recherche_emp_par_fonction(IN p_fonction_nom VARCHAR(50))
BEGIN
SELECT employes.emp_nom, employes.emp_prenom, employes.emp_date_embauche
FROM employes 
JOIN fonctions ON fonctions.fonction_id= employes.fonction_id
WHERE fonctions.fonction_nom=p_fonction_nom; 
END|
DELIMITER ;

/* Appel de la procédure */
SET @fonction_nom := 'dessinateur';
CALL recherche_emp_par_fonction(@fonction_nom);



/* 3. Renvoyer le nombre "effectif" en variable de sortie pour une fonction donnée en 
paramètre */
DELIMITER |
CREATE PROCEDURE nb_effectif_par_fonction(IN p_nom_fonction VARCHAR(50), OUT p_nb_effectif INT)
SELECT COUNT(employes.emp_matricule) INTO p_nb_effectif
FROM employes
JOIN fonctions ON employes.fonction_id = fonctions.fonction_id
WHERE fonctions.fonction_nom = p_nom_fonction;
END|
DELIMITER ;

/* Appel de la procédure */
SET @nom_fonction := 'architecte';
CALL nb_effectif_par_fonction(@nom_fonction,@nb_effectif);
SELECT @nb_effectif;



/* 4. Créer une procédure stockée qui affiche la liste des projets(projet_ref,projet_date_fin_prevue,projet_prix)
pour un nom d'employe en entrée.
Celui-ci sera un architecte. */

/* 1ere méthode */
DELIMITER |
CREATE PROCEDURE liste_projets_par_employe(IN p_nom_employe VARCHAR(50) )
BEGIN 
SELECT projets.projet_ref,projets.projet_date_fin_prevue,projets.projet_prix
FROM projets
JOIN employes ON projets.emp_matricule = employes.emp_matricule
WHERE  employes.emp_nom = p_nom_employe;
END|
DELIMITER ;

/* Appel de la procédure */
SET @nom_employe := 'Schieber';
CALL liste_projets_par_employe(@nom_employe);


/* 2eme méthode */
DELIMITER |
CREATE PROCEDURE afficher_liste_projet(IN p_nom_salarie VARCHAR(50)) 
BEGIN
SELECT fonctions.fonction_nom
FROM fonctions
JOIN employes ON fonctions.fonction_id= employes.fonction_id
WHERE employes.emp_nom=p_nom_salarie;
SELECT projets.projet_ref, projets.projet_date_fin_prevue,projets.projet_prix
FROM projets
JOIN employes ON projets.emp_matricule=employes.emp_matricule
WHERE employes.emp_nom=p_nom_salarie; 
END|
DELIMITER ;

/* Appel de la procédure */
SET @nom_salarie='roussotte';
CALL afficher_liste_projet(@nom_salarie);



/* 5. Créer une procédure stockée qui prend le nom d'un salarié en entrée et qui renvoie son ancienneté en années dans une variable (out). */
DELIMITER |
CREATE PROCEDURE nb_annees_anciennete_employe(IN p_nom_employe VARCHAR(50), OUT p_nb_annees INT)
BEGIN
SELECT TIMESTAMPDIFF(YEAR,employes.emp_date_embauche,CURDATE()) INTO p_nb_annees
FROM employes WHERE employes.emp_nom = p_nom_employe;
END|
DELIMITER ;

/* Appel de la procédure */
SET @nom_employe := 'desplanques';
CALL nb_annees_anciennete_employe(@nom_employe,@nb_annees);
SELECT @nb_annees;



/* 6. Utilisation paramètre IN OUT.
Créer une procédure qui prend en paramètre un id de projet (IN) qui récupére son prix projet et l'ajoute
dans la variable (cumul) dans le paramètre IN OUT défini. */
DELIMITER |
CREATE PROCEDURE cumul_projets(IN p_projet_ref INT, INOUT p_prix_projet DECIMAL(10,2))
BEGIN
	SELECT p_prix_projet + projets.projet_prix INTO p_prix_projet
	FROM projets WHERE projets.projet_ref = p_projet_ref;
END |

DELIMITER ;

/* Appel de la procédure */
SET @cumul = 0;

CALL cumul_projets(1,@cumul);
SELECT @cumul AS cumul_1;

CALL cumul_projets(2,@cumul);
SELECT @cumul AS cumul_2;

CALL cumul_projets(3,@cumul);
SELECT @cumul AS cumul_3;

	


