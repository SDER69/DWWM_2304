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

function nbJoursAnniv(chaineDate) {
    let dateJour = new Date(); // récupérer la date du jour
    console.log("dateJour : " + dateJour)
    let annee =new Date()
    annee = dateJour.getFullYear();
    var dateAnni = new Date(chaineDate); // récupérer la date d'anni
    console.log("dateAnni : " + dateAnni);
    let diff = dateAnni.getTime() - dateJour.getTime();
    if (dateAnni.getFullYear() == dateJour.getFullYear()) {
        diff = Math.ceil(diff / (1000 * 3600 * 24));
    }
    else if(dateAnni.getFullYear() < dateJour.getFullYear()) {
        dateJour = new Date();
        let enCours = new Date()
        enCours = dateAnni.setFullYear(dateJour.getFullYear()+1);
        diff = dateAnni.getTime() - dateJour.getTime();
        diff = Math.ceil(diff / (1000 * 3600 * 24));
    }
    else{
            dateJour = new Date();
            let enCours = new Date()
            enCours = dateAnni.setFullYear(dateJour.getFullYear());
            diff = dateAnni.getTime() - dateJour.getTime();
            diff = Math.ceil(diff / (1000 * 3600 * 24));
    }
    return diff;
}


function ecrireAccueil(){
    if(getCookie('nom') != null){
        document.querySelector('#cell_nom').textContent = getCookie('nom')
        document.querySelector('#cell_prenom').textContent = getCookie('prenom')
        document.querySelector('#cell_dateNaissance').textContent = getCookie('date_naissance')
        document.querySelector('#cell_pseudo').textContent = getCookie('pseudo')
        let chaineDate =  getCookie('date_naissance')
        document.querySelector("#cell_nbJours").textContent = nbJoursAnniv(chaineDate)
    }
   
}
ecrireAccueil();

