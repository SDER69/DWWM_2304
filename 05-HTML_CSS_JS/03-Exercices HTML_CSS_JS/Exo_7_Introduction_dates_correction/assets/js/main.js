//IMPORTATIONS

import { MaDate } from "./MaDate.js";


// ==============================VARIABLES=====================================
/** @var {HTMLElement} inputDateNaissance champ de saisie de la date de naissance*/
const inputDateNaissance = document.getElementById("dateNaissance")
const btnCalculer = document.getElementById("calculer")
const divResultatDate = document.getElementById("resultatDate")
const divResultatIntervalle = document.getElementById("resultatIntervalle")


// ==============================FONCTIONS=====================================
/**
 * Vérifie que la date passée en paramètre est située dans le passé
 * @param {Date} _date la date à évaluer
 * @returns {boolean} vrai si la date est dans le passé,faux sinon
 */
/*function estDansLePasse(_date){
    if(!(_date instanceof Date)){
         throw new Error("La date fournie n'est pas valide.")
    }
    let dateAujourdhui = new Date()

    return dateAujourdhui > _date

}
// Test de la fonction estDansLePasse()
/*let maDate = new Date("2023-10-12 12:05")
console.log(estDansLePasse(maDate))*/

/**
 * Retourner l'intervalle entre la date du jour et la date fournie en paramètre
 * @param {Date} dateAEvaluer la date à évaluer
 * @returns {Number} l'intervalle en années entre la date du jour et la date fournie en paramètre 
 */
/*function intervalleDates(dateAEvaluer){
    if(!(dateAEvaluer instanceof Date)){
        throw new Error("La date fournie n'est pas valide.")
    }

    let dateAujourdhui = new Date()

    let diffDates = dateAujourdhui - dateAEvaluer
    return parseInt(diffDates/(1000*3600*24*365))  
}*/


// ==============================EVENEMENTS=====================================
/*btnCalculer.addEventListener("click", () => {
    
    let dateNaissance = new Date(inputDateNaissance.value)

    if(estDansLePasse(dateNaissance)){
        divResultatDate.innerHTML = "Vous êtes né le "
        divResultatDate.innerHTML += dateNaissance.toLocaleDateString("fr")
        divResultatDate.innerHTML += " à "
        divResultatDate.innerHTML += dateNaissance.toLocaleTimeString("fr")
        divResultatIntervalle.innerHTML = "Il s'est écoulé "
                                        + intervalleDates(dateNaissance)
                                        + " années depuis votre naissance."
    }else{
        divResultatDate.innerHTML = "Veuillez saisir une date dans le passé."
    }
})*/

// ==============================EVENEMENTS APPEL CLASSE MADATE=====================================
btnCalculer.addEventListener("click", () => {
    
    let dateNaissance = new Date(inputDateNaissance.value)
    const maDate = new MaDate(dateNaissance)

    if(maDate.estDansLePasse()){
        divResultatDate.innerHTML = "Vous êtes né le "
        divResultatDate.innerHTML += dateNaissance.toLocaleDateString("fr")
        divResultatDate.innerHTML += " à "
        divResultatDate.innerHTML += dateNaissance.toLocaleTimeString("fr")
        divResultatIntervalle.innerHTML = "Il s'est écoulé "
                                        + maDate.intervalleDates()
                                        + " années depuis votre naissance."
    }else{
        divResultatDate.innerHTML = "Veuillez saisir une date dans le passé."
    }

});

