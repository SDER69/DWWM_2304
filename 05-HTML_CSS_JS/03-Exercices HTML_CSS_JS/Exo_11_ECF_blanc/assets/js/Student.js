class Student
{
    constructor(_studentFromJson)
    {
        Object.assign(this,_studentFromJson)
        this.nom = this.getName()
        this.prenom = this.getSurname()
    }

    getName(){
        let name = this.fullname.split(" ")
        return name[0]
    }

    getSurname(){
        let surname = this.fullname.split(" ")
        return surname[1]
    }
}
export { Student }
