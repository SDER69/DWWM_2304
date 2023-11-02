function validationBonjour() {
    let prenom = document.querySelector("#prenom").value
    let age = document.querySelector("#age").value
    if (prenom != "" && age > 0) {
        document.querySelector('#bonjour').innerHTML = "Bonjour <span>" + prenom + "</span>,votre âge est : <span>" + age + "</span> ans."
    }
    else {
        document.querySelector('#bonjour').textContent = "Compléter/corriger le formulaire"
    }
}

function validationMajorite() {
    let age = document.querySelector("#age").value
    if (age >= 18) {
        document.querySelector('#majorite').innerHTML = "Vous êtes <span>majeur.</span>"
    }
    else {
        document.querySelector('#majorite').innerHTML = "Vous êtes <span>mineur.</span>"
    }
}

function validationRetraite() {
    let age = document.querySelector("#age").value
    const ageRetraite = 64
    if (age < ageRetraite) {
        let nbAnnees = ageRetraite - age
        document.querySelector('#retraite').innerHTML = "Il vous reste <span>" + nbAnnees + "</span> années avant la retraite."

    }

    else if (age > ageRetraite) {
        let nbAnnees = age - ageRetraite
        document.querySelector('#retraite').innerHTML = "Vous êtes à la retraite depuis " + nbAnnees + " années."
    }

    else {
        document.querySelector('#retraite').textContent = "Vous prenez votre retraite cette année !"
    }
}



