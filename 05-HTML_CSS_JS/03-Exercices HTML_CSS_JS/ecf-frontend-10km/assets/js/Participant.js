class Participant {
    constructor(_studentFromJson) {
        this.pays = _studentFromJson.pays;
        this.nom = '';
        this.prenom = ''
        this.temps = this.secondesEnMinutes(_studentFromJson.temps)
        this.setFullName(_studentFromJson.nom);
    }

    setFullName(_fullName) {
        let myFullName = _fullName.split(" ");
        this.nom = myFullName[0];
        this.prenom = myFullName[1];
    }

    secondesEnMinutes(totalSecondes) {
        
        let heures = Math.floor(totalSecondes / 3600);
        let minutes = Math.floor((totalSecondes - (heures * 3600)) / 60);
        let secondes = totalSecondes - (heures * 3600) - (minutes * 60);


        if (heures < 10) { heures = "0" + heures; }
        if (minutes < 10) { minutes = "0" + minutes; }
        if (secondes < 10) { secondes = "0" + secondes; }
        
       
        return minutes + "mins" + secondes + "s"
    }

}



export { Participant }







