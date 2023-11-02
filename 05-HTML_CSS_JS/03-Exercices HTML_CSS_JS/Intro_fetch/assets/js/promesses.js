const MAJORITE = 18

const verifierMajorite = (_age) =>{
    return new Promise((resolve,reject) => {
        if(typeof(_age) != "number") {
            reject ("L'âge entré n'est pas valide")
        }
        if(_age >= MAJORITE){
            resolve ("Vous êtes majeur")
        }else{
            reject ("Vous êtes mineur")
        }
    })
}
const nbAnneesAvantRetraite = (_age) => {
    return new Promise((resolve,reject) => {
        if(_age <= 64){
            resolve("Il vous reste x années avant la retraite")
        }else if(_age > 64){
            resolve("Vous êtes à la retraite depuis x années")
        }else{
            rejeter("Vous êtes à la retraite cette année !")
        }
        

    })
}

verifierMajorite(18)
.then((response) => {
    console.log(response);
    return response
}).catch((response) => {
    console.error("ERREUR : "+response)
}).then((response => {

})




