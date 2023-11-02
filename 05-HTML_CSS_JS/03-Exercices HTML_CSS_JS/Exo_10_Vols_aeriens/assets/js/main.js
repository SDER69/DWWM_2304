import { Db } from './Db.js'; 
import { Vol } from './Vol.js';

const apiUrl = 'https://arfp.github.io/tp/web/html-css-js/04-flights/flights.json';

const myApp = {
    data() {
        return {
            vols: [],
            triAsc: true
        }
    },

    async mounted(){
        let json = await Db.fetchJson(apiUrl)

        json.forEach((item) => {
            let c = new Vol(item)
            this.vols.push(c)
        })
    },

    methods: {
        trier(event){
            //console.log(event.target.dataset);
            let attribut = event.target.dataset.attribut;
            //console.log(attribut);
            this.vols.sort((a, b) => {
                if(a[attribut] < b[attribut]) {
                    return -1;
                } 
                if(a[attribut] > b[attribut]) {
                    return 1;
                } 
                return 0;
            })

            /*if(this.triAsc === false) {
                this.vols.reverse();
            }*/

            this.triAsc = !this.triAsc;
        }
    }
}

Vue.createApp(myApp).mount('#app');