import { Db } from './Db.js'
import { Cp } from './Cp.js'

const apiUrl = "./assets/js/zipcodes.json"

const { createApp } = Vue

const app = {
    data() {
        return {
           cp: []
        }
    },
    async mounted(){
        let json = await Db.fetchJson(apiUrl)

        json.forEach((item) => {
            let c = new Cp(item)
            this.cp.push(c)
        })

        console.log(this.cp);
    },
    methods : {
       
    }
}

createApp(app).mount("#app")
