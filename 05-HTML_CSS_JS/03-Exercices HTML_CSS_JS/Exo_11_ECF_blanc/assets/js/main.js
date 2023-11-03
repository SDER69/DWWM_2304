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
      noteEliminatoire: 12,
      message:""

    }
  },
  async mounted() {
    let json = await Db.fetchJson(apiUrl)

    json.forEach((item) => {
      let c = new Student(item)
      this.students.push(c)

    })
   //this.sortTab()
   this.trier()
   console.log(this.students)
    

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
     
    }
    
  },
  methods: {
    //================TRI METHODE 1============================
    /*sortTab(){
      this.students.sort(function (a, b) {
        return b.grade - a.grade;
      })*/
  
    //================TRI METHODE 2============================
  trier(){
      this.students.sort((a, b) => {
          if(a.grade > b.grade) {
              return -1;
          } 
          if(a.grade < b.grade) {
              return 1;
          } 
          return 0;
      })

      this.triAsc = !this.triAsc;
  },

  ajouterLigne(){
    this.students.push(this.message)
    
    
   
}
 
  }
}


createApp(app).mount("#app")
