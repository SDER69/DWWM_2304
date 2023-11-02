const { createApp } = Vue

const appExemple = {
    data() {
        return {
            nombre: 0,
            prenom: 'Mike',   
        }
    },

    computed:{
        nombreDouble(){
            return this.nombre * 2
        },
        nombreQuadruple(){
            return this.nombreDouble * 2
        },
        prenomMajuscule(){
            return this.prenom.toUpperCase()
        }

    },

    /*mounted(){
        //this.nombre = localStorage.getItem('nombre') ?? 0
        setInterval(() => { 
            this.nombre++
        },1000)
    },*/
         
    methods : {
        clickBouton()
        {
            this.nombre++
            localStorage.setItem("nombre",this.nombre)
        }
    }
}

createApp(appExemple).mount("#app")

//=============VERSION EN PUR JS=========================//

//============1ere mèthode===============//
/*const bouton = document.getElementById("bouton")
const resultat = document.getElementById("resultat")

bouton.addEventListener('click',() => {
    resultat.innerHTML = parseInt(resultat.innerHTML)+1
})*/

//============2ème mèthode===============//
const bouton = document.getElementById("bouton")
const resultat = document.querySelector("#resultat")

bouton.addEventListener('click',() => {
   let nombre = parseInt(resultat.innerText)
   resultat.innerHTML = ++nombre //nombre + 1 
})