/* App 10000 mètres */

import { Participant } from './Participant.js'
import { Db } from './Db.js'

const apiUrl = "./data/resultats.json"


const app = {
    data() {
        return {
            participants: [],
            nomPrenomGagnant: "",
            pays:[],
            checkedPays : []
        }
    },
    async mounted() {
        let json = await Db.fetchJson(apiUrl)

        json.forEach((item) => {
            let c = new Participant(item)
            this.participants.push(c)
        })

        json.forEach((item) => {
            let c = new Participant(item)
            this.pays.push(c)
        })


        this.trier
        this.trierPays
        this.nomPrenomGagnant = this.participants[0].prenom+" "+this.participants[0].nom
        //this.checkPays(checkedPays)
        //console.log(this.nomPrenomGagnant)
        //this.nomPrenomGagnant
        //console.log(this.participants[0])

        //console.log(this.participants)
    },
    computed: {
        nbParticipants() {
            return this.participants.length;
        },

        trier() {
            this.participants.sort((a, b) => {
                if (a.temps < b.temps) {
                    return -1;
                }
                if (a.temps > b.temps) {
                    return 1;
                }
                return 0;
            })
        },

        trierPays() {
            this.pays.sort((a, b) => {
                if (a.pays < b.pays) {
                    return -1;
                }
                if (a.pays > b.pays) {
                    return 1;
                }
                return 0;
            })
        },


        

        methods:{
            filtrer(){
                this.part.filter(valeur => {
                    if(this.participants.pays === this.pays.pays )
                    return true;
                })
            
        }
        
        } 

     

    }

}


Vue.createApp(app).mount("#app");

