function sommeCaracteres(chaine) {
    chaine = chaine.toUpperCase()
    let nbCar = chaine.length;
    let somme = 0;
    for (let i = 0; i < nbCar; i++) {
        somme += chaine.charCodeAt(i) - 64
    }
    return somme
}

/*let pseudo = document.querySelector("#prenom")
document.querySelector("#prenom").addEventListener("blur", function () {
    console.log(sommeCaracteres(pseudo.value));

})*/



function calculerSigne(month) {
    let val = month
    let signe = ""
    const signs = ["Capricorne", "Verseau", "Poisson", "Belier", "Taureau",
        "Gémeaux", "Cancer", "Lion", "Vierge", "Balance", "Scorpion", "Sagittaire"]

    signe = signs[val];

    return signe;
}

function recuperationMois() {
    let valeur = document.querySelector("#date_naissance").value;
    let maDate = new Date(valeur);
    let mois = maDate.getMonth();
    //console.log("type du mois : "+typeof(mois))
    return mois;
}

document.querySelector("#date_naissance").addEventListener("blur", function () {
    console.log(calculerSigne(recuperationMois()));
})

function formok() {
    let testControle = true;
    /*let texte = document.forms["formulaire"]["texte_saisi"].value;*/
    let nom = document.forms["formulaire"]["nom_utilisateur"].value;
    let prenom = document.forms["formulaire"]["prenom_utilisateur"].value;
    /*let email = document.forms["formulaire"]["email_utilisateur"].value;*/
    let date = document.forms["formulaire"]["date_naissance"].value;
    if (nom == null || nom == "", prenom == null
        || prenom == "", /*email == null || email == "",*/ date == null || date == "") {
        console.log("Veuillez remplir tous les champs obligatoires");
        testControle = false;
    }
    return testControle;
}

function calculerPseudo() {
    let mois = recuperationMois();
    let signe = calculerSigne(mois);
    let nom = sommeCaracteres(document.querySelector("#nom").value);
    let prenom = sommeCaracteres(document.querySelector("#prenom").value);
    let somme = nom + prenom;
    let pseudo = signe + somme;
    return pseudo
}

function validationOk() {
    if (formok()) {
        document.getElementById("pseudo").value = calculerPseudo();
        document.querySelector("#valider").disabled = false;
    }
}

document.querySelector("#nom").addEventListener("blur", function () {
    validationOk();
});

document.querySelector("#prenom").addEventListener("blur", function () {
    validationOk();
});

document.querySelector("#date_naissance").addEventListener("change", function () {
    validationOk();
});

// Récupération d'un cookie : 1ère méthode
/*function valider(nom,valeur){
    let dateJour = new Date();
    let dateExpire = new Date(dateJour.getFullYear(),dateJour.getMonth() +1,dateJour.getDate());
    dateExpire = dateExpire.toUTCString();
    document.cookie = nom + '=' + valeur + '; expires =' + dateExpire + 'SameSite = lax';// ou strict pour l'utilisation seulement pour le site
}*/

// Récupération d'un cookie : 2ème méthode
function valider(nom, valeur) {
    let dateExpire = new Date(Date.now() + 86400000); //86400000ms = 1 jour
    dateExpire = dateExpire.toUTCString();
    document.cookie = nom + '=' + valeur + '; expires =' + dateExpire + 'SameSite = lax';// ou strict pour l'utilisation seulement pour le site
}

document.getElementById('valider').addEventListener('click', function () {
    valider('nom', document.getElementById('nom').value);
    valider('prenom', document.getElementById('prenom').value)
    window.location.href = "accueil.html";
})

// difference en jours avec l'anniv

/*function nbJoursAnniv(date) {
    let dateForm = document.querySelector('#' + date).value;
    let dateN = new Date(dateForm);
    let dateDuJour = new Date();
    let dateAnniv = new Date(dateDuJour.getFullYear(), dateN.getMonth(), dateN.getDate());

    let diff = dateAnniv.getTime() - dateDuJour.getTime();
    let diffDays = diff / (1000 * 24 * 3600);
    diffDays = Math.trunc(diffDays);

    if (diffDays < 0) {
        dateAnniv = new Date((dateDuJour.getFullYear() + 1), dateN.getMonth(), dateN.getDate());
        diff = dateAnniv.getTime() - dateDuJour.getTime();
        diffDays = diff / (1000 * 24 * 3600);
        diffDays = Math.round(diffDays);

    }

    console.log(diffDays);

}

/*function nbJoursAnniv(dateAnniv) {
    dateAnniv = new Date(document.querySelector("#date_naissance").value);
    let dateJour = new Date();
    dateAnniv = new Date(dateJour.getFullYear(),dateAnniv.getMonth(),dateAnniv.getDate())
    
    let diffTemps = dateAnniv.getTime() - dateJour.getTime()
    let diffJours = diffTemps / (1000 * 3600 *24)
    diffJours = Math.trunc(diffJours)

    if(diffJours < 0){
        dateAnniv=new Date(dateJour.getFullYear()+1),dateAnniv.getMonth(),dateAnniv.getDate()
        diffTemps = dateAnniv.getTime()-dateJour.getTime()
        diffJours = diffTemps / (1000 * 3600 * 24)
        diffJours = Math.round(diffJours)

    }
    console.log(diffJours)
}*/

/*function diffdate(d1,d2){
	var nbJours = d2.getTime() - d1.getTime();
    if (nbJours < 0) {
        let dateAnniv = new Date((dateDuJour.getFullYear() + 1), dateN.getMonth(), dateN.getDate());
        
        diffDays = nbJours / (1000 * 24 * 3600);
        diffDays = Math.round(diffDays);

    }
	return Math.ceil(WNbJours/(1000*60*60*24));
}*/

/*var Date1 = new Date(2015,0,1);
var Date2 = new Date(2011,0,1);
 
alert(diffdate(Date1,Date2) + ' jours');


/*let date=document.querySelector("#date_naissance").value
document.querySelector("#date_naissance").addEventListener("change", function () {
    nbJoursAnniv(date);
});*/

var first = "23/09/2023";
var second;

var x = new Date(first);
var y = new Date(second);

// seconds = milliseconds/1000
// minutes = seconds/60
// hours = minutes/60
// Days = hours/24

const diffInDays = Math.floor((x - y) / (1000 * 60 * 60 * 24));
console.log(diffInDays);

