function controleSaisieQuantite() {

    let quantite1 = document.querySelector('#affichage_quantite_1')
    let quantite2 = document.querySelector('#affichage_quantite_2')

    let valQuantite1 = quantite1.value
    let valQuantite2 = quantite2.value

    if (valQuantite1 < 0 || valQuantite1 > 1000000 || isNaN(valQuantite1)
        || valQuantite2 < 0 || valQuantite2 > 1000000 || isNaN(valQuantite2)) {
        console.log("Vous devez entrer un nombre compris entre 0 et 1 000 000")
    }
}


function controleSaisienombre( uneChaine)
{let test =uneChaine.value;

    let unNombre=true;
    if (test < 0 || test > 1000000 || isNaN(test))
    {
         unNombre=false;
    }
console.log("valeur du test:"+unNombre);
    return unNombre;
}

let txtsaisie=document.getElementById("affichage_quantite_1");

txtsaisie.addEventListener("blur",
function(){
    if( controleSaisienombre(txtsaisie)==false)
    {
        txtsaisie.value='';
        txtsaisie.focus();
    }
})


function controleSaisiePu() {

    let affichagePu1 = document.querySelector('#affichage_pu_1')
    let affichagePu2 = document.querySelector('#affichage_pu_2')

    let valAffichagePu1 = affichagePu1.value
    let valAffichagePu2 = affichagePu2.value

    if (valAffichagePu1 < 0 || valAffichagePu1 > 1000000 || isNaN(valAffichagePu1)
        || valAffichagePu2 < 0 || valAffichagePu2 > 1000000 || isNaN(valAffichagePu2)) {
        alert("Vous devez entrer un nombre compris entre 0,1 et 1 000 000")
    }
}




let quantite1 = document.getElementById('affichage_quantite_1')
let quantite2 = document.querySelector('#affichage_quantite_2')
let affichagePu1 = document.getElementById('affichage_pu_1')
let affichagePu2 = document.getElementById('affichage_pu_2')
let ssTotal1 = document.getElementById("ss_total_1")
let ssTotal2 = document.querySelector('#ss_total_2')
let total = document.querySelector('#total')


quantite1.value = 1
affichagePu1.value = 0
ssTotal1.value = 0
total.value = 0
quantite1.onchange, affichagePu1.onchange = () => {
    console.log(quantite1.value)
    console.log(affichagePu1.value)
    //quantite1.value = parseFloat(quantite1.value)

    ssTotal1.value = quantite1.value * affichagePu1.value
    total.value = ssTotal1.value
}

quantite2.value = 1
affichagePu2.value = 0
ssTotal2.value=0
total.value = 0
quantite2.onchange, affichagePu2.onchange = () => {
    console.log(quantite2.value)
    console.log(affichagePu2.value)
    //quantite2.value = parseFloat(quantite1.value)

    ssTotal2.value = quantite2.value * affichagePu2.value
    total.value = parseFloat(ssTotal1.value) + parseFloat(ssTotal2.value)
    //total.value = ssTotal1.value + ssTotal2
}






