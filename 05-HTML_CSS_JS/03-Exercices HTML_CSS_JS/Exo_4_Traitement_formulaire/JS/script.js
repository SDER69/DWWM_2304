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
    valider('date_naissance',document.getElementById('date_naissance').value)
    valider('pseudo',document.getElementById('pseudo').value)
    window.location.href = "accueil.html";
})

// 1ère méthode //
function nbJoursAnniv() {
    let dateJour = new Date(); // récupérer la date du jour
    console.log("dateJour : " + dateJour)
    let annee =new Date()
    annee = dateJour.getFullYear();
    var dateAnni = new Date(document.querySelector("#date_naissance").value); // récupérer la date d'anni
    console.log("dateAnni : " + dateAnni);
    let diff = dateAnni.getTime() - dateJour.getTime();
    diff = Math.ceil(diff / (1000 * 3600 * 24));

    if(dateAnni.getFullYear() == dateJour.getFullYear() && dateAnni.getMonth() < dateJour.getMonth()){
        dateJour = new Date();
        let enCours = new Date()
        enCours = dateAnni.setFullYear(dateJour.getFullYear()+1);
        diff = dateAnni.getTime() - dateJour.getTime();
        diff = Math.ceil(diff / (1000 * 3600 * 24));
        //diff = Math.abs(diff)
    }

    // Traitement du mois d'octobre //
    else if(dateAnni.getFullYear() == dateJour.getFullYear() && dateAnni.getMonth() == dateJour.getMonth()){ 
        dateJour = new Date();
        let enCours = new Date()
        
        if(dateAnni.getDate() < dateJour.getDate()){
          //dateJour = new Date();
          //let enCours = new Date()
          enCours = dateAnni.setFullYear(dateJour.getFullYear()+1);
          diff = dateAnni.getTime() - dateJour.getTime();
          diff = Math.ceil(diff / (1000 * 3600 * 24));

        }
        else{
            //dateJour = new Date();
            //let enCours = new Date()
            //enCours = dateAnni.setFullYear(dateJour.getFullYear());
            diff = dateAnni.getTime() - dateJour.getTime();
            diff = Math.ceil(diff / (1000 * 3600 * 24));
        } 
    }

    else if (dateAnni.getFullYear() == dateJour.getFullYear()) {
        let diff = dateAnni.getTime() - dateJour.getTime();
        diff = Math.ceil(diff / (1000 * 3600 * 24));
        //diff = Math.abs(diff)
    }

    else if(dateAnni.getFullYear() < dateJour.getFullYear() && dateAnni.getMonth() == dateJour.getMonth() ) {
        dateJour = new Date();
        let enCours = new Date()
        enCours = dateAnni.setFullYear(dateJour.getFullYear()+1);
        //console.log("dateEnCours = "+ enCours.getFullYear());
        diff = dateAnni.getTime() - dateJour.getTime();
        diff = Math.ceil(diff / (1000 * 3600 * 24));
        //diff = Math.abs(diff)
    }

    else{
        dateJour = new Date();
        let enCours = new Date()
        enCours = dateAnni.setFullYear(dateJour.getFullYear());
        diff = dateAnni.getTime() - dateJour.getTime();
        diff = Math.ceil(diff / (1000 * 3600 * 24));

    }
    console.log (Math.abs(diff));
    return Math.abs(diff);
}

document.querySelector("#date_naissance").addEventListener("change", function () {
    nbJoursAnniv();
});

// 2ème méthode  //
/*function nbJoursAnniv(dateAnnivStr)
{
    var dateActuelle = new Date();
    var tabDateAnniv = dateAnnivStr.split('/');
    var jourAnniv = new Date(dateActuelle.getFullYear(), tabDateAnniv[1]-1,tabDateAnniv[0]);
    
    if (jourAnniv < dateActuelle)
    {   
        jourAnniv.setFullYear(dateActuelle.getFullYear()+1);
        var diff = jourAnniv-dateActuelle;
    }
    else
    {       
        var diff =  jourAnniv-dateActuelle;
    }
    var retour = Math.floor(diff / (1000*60*60*24));
    console.log(retour)
    return retour;
}
    let dateAnniv = new Date()
    let dateAnnee = new Date().getFullYear()
    let dateMois = new Date().getMonth()
    let dateJour = new Date().getDay()

    dateAnniv = document.querySelector("#date_naissance").value

    /*dateAnnee = dateAnniv.getFullYear()
    dateMois = dateAnniv.getMonth()
    dateJour = dateAnniv.getDay()
    console.log("valeur dateAnniv :"+typeof(dateAnniv))
    console.log("dateAnniv"+dateAnniv)
    document.querySelector("#date_naissance").addEventListener("change", function () {
    nbJoursAnniv(dateAnnee+dateMois+dateJour);
});*/


function getCookie(name) {
    const cookies = document.cookie.split('; ')
    const value = cookies
        .find(c => c.startsWith(name + "="))
        ?.split('=')[1];
        console.log("valeur = "+value);
    if (value === undefined) {
        return null;
    } 

    return decodeURIComponent(value);
}

document.querySelector("#date_naissance").addEventListener("change", function () {
    console.log(getCookie("nom"))
    console.log(getCookie("prenom"))
});


