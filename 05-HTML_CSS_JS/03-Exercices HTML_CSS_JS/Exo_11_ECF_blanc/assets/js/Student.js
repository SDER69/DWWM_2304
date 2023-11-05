class Student
{
    constructor(_studentFromJson)
    {
        Object.assign(this,_studentFromJson)
        this.nom = this.getName()
        this.prenom = this.getSurname()
    }

    getName(){
        if (typeof this.fullname === 'string') {
            let name = this.fullname.split(" ")
            return name[0]
            //const result = str.split(',');
            //console.log(result);
          } else {
            // 👇️ this runs
            return('The variable does NOT store a string');
          }
       
    }

    getSurname(){
        if (typeof this.fullname === 'string') {
            let surname = this.fullname.split(" ")
            return surname[1]
            
          } else {
            
            return('The variable does NOT store a string');
          }
       
    }
}
   

export { Student }
