const apiUrl = "https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json"
const { createApp } = Vue

const app = {
    data() {
        return {
            message: 'Bonjour !',
            valeurInput: 'toto'
        }
    },
    mounted(){
        setInterval(() => {
            this.message += 'a'
            //this.message += 'a<br>'
        },1000)
    },
    methods : {
        clickBouton() {
            
        }
    }
}

createApp(app).mount("#app")
