import { Db } from './Db.js';
import { Student } from './Student.js'

const apiUrl = "./assets/js/eval.json"

const { createApp } = Vue

const app = {
  data() {
    return {
      students: [],
      notes: [],
      notesUnderAvg: [],
      triNotes: []
    }
  },
  async mounted() {
    let json = await Db.fetchJson(apiUrl)

    json.forEach((item) => {
      let c = new Student(item)
      this.students.push(c)

    })
    
  
    
   
  },
  computed: {
    nbStudents() {
      return this.students.length
    },

    avgClass() {
      for (const item of this.students) {
        this.notes.push(item.grade)
      }
     
      let total = this.notes.reduce((a, b) => a + b, 0)
      let avg = total / this.nbStudents
      
      return avg.toFixed(2)
    },

    underAvg() {
      for (const item of this.students) {
        if(item.grade > this.avgClass)
        this.notesUnderAvg.push(item)
      }
      return this.notesUnderAvg.length
    },

    trier(){
        this.students.grade.sort((a, b) => {
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
    },


  methods: {
    
    /*avgClass(){
      for(const item of this.students){
        //return(this.students[item]['grade']) -> avec le for in
         //return(item.grade) // avec le for of
         
        
        this.notes.push(item.grade)
        
       
      }
      return this.notes
      
     let total = this.notes.reduce((a,b) => a + b,0)
     let avg = total/this.nbStudents().toFixed(2)
     console.log(avg)
     return avg
    */
  }
}

createApp(app).mount("#app")
