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
      nomPrenom: "",
      note: 0


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
    //console.log(this.students)


  },
  computed: {
    nbStudents() {
      return this.students.length
    },

    /*avgClass() {
      for (const item of this.students) {
        this.notes.push(item.grade)
      }
      let total = this.notes.reduce((a, b) => a + b, 0)
      let avg = total / this.nbStudents
      return avg.toFixed(2)
    },*/

    avgClass() {
      let sum = 0;

      // Iteration des elements du tableau
      this.students.forEach(function (item, idx) {
        sum += item.grade;
      });

      // Retourne la moyenne des notes
      return (sum / this.students.length).toFixed(2);
    },

    underAvg() {
      this.notesUnderAvg = []
      for (const item of this.students) {
        if (item.grade > this.avgClass)
          this.notesUnderAvg.push(item)
      }
      return this.notesUnderAvg.length
    }
  },

  /*controleSaisieNomPrenom(){
    let student = new Student()
    student.nom = this.nomPrenom.split(" ")
    student.nom = student.nom[0]
    student.prenom = this.nomPrenom.split(" ")
    student.prenom = student.prenom[1]
    if(student.nom.length && student.prenom.length < 2){
      return("Veuillez saisir un nom de plus de 2 lettres")
     }
  }
},*/
  methods: {
    //================TRI METHODE 1============================
    /*sortTab(){
      this.students.sort(function (a, b) {
        return b.grade - a.grade;
      })*/

    //================TRI METHODE 2============================
    trier() {
      this.students.sort((a, b) => {
        if (a.grade > b.grade) {
          return -1;
        }
        if (a.grade < b.grade) {
          return 1;
        }
        return 0;
      })

      this.triAsc = !this.triAsc;
    },

    ajouterLigne() {

      let student = new Student()

      student.fullname = this.nomPrenom
      student.grade = parseInt(this.note)

      //console.log(typeof(student.fullname));
      student.nom = this.nomPrenom.split(" ")
      student.nom = student.nom[0]
      if(student.nom.length < 2)  {
        alert("Veuillez entrer un nom d'une longueur minimum de 2 caractères!");
      }
      student.prenom = this.nomPrenom.split(" ")
      student.prenom = student.prenom[1]
      if(student.prenom.length < 2)  {
        alert("Veuillez entrer un prénom d'une longueur minimum de 2 caractères!");
      }
      else{

      this.students.push(student)
      this.trier()
      //this.notesUnderAvg = []

    }
  }


    //console.log(this.students.length)
    //console.log(this.notes)
    //console.log(this.notesUnderAvg);

  }
}


createApp(app).mount("#app")