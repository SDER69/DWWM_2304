class Student
{
    constructor(_studentFromJson)
    {
      if(_studentFromJson !== undefined) {
        Object.assign(this,_studentFromJson)
        this.nom = this.getName()
        this.prenom = this.getSurname()
        //this.setFullName(_studentFromJson.fullname)
      }        
    }

    /*setFullName(_fullname) {
      this.fullname = _fullname;
      this.nom = this.getName()
      this.prenom = this.getSurname()
    }*/

    getName(){
        if (typeof this.fullname === 'string') {
            let name = this.fullname.split(" ")
            return name[0]
            //const result = str.split(',');
            //console.log(result);
          } else {
            
            return("La variable n'est pas une chaine de caractères");
          }
       
    }

    getSurname(){
        if (typeof this.fullname === 'string') {
            let surname = this.fullname.split(" ")
            return surname[1]
            
          } else {
            
            return("La variable n'est pas une chaine de caractères");
          }
       
    }
}
   

export { Student }
