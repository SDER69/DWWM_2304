// 3 façons de déclarer une fonction
/*function maFonction_1(){
    this.toto  = 1
    
    this.operation = function(){
        return "maValeur"
    }      
}

maFonction_1.prototype.operation = function(){
    return 'maValeur'
}

maFonction_2 = function(){
    return "maFonction2"
}

maFonction_3 = () => {
    return "maFonction3"
}

let monObjet = new maFonction_1()
console.log(monObjet.operation())
*/

class MaDate
{
    static ageDepartRetraite = 67;
    static ageMajorite = 18;
    /**
     * constructeur
     * @param {Date} _date la date de naissance
     */
    constructor(_date){
        this.dateAujourdhui = new Date();
        this.dateNaissance = _date;
    }
    /**
     * retourne vrai si la date de naissance est dans le passé
     * @returns { boolean } vrai si la date est dans le passé sinon faux
     */
    estDansLePasse(){
        return this.dateAujourdhui > this.dateNaissance;
    }
    
    /**
     * retourne le nombre d'années entre aujourd'hui et la date de naissance
     * @returns { Number } le nombre d'années entre aujourd'hui et la date de naissance
     */
    intervalleDates(){
        let diffDates = this.dateAujourdhui - this.dateNaissance;
        return parseInt(diffDates/(1000*3600*24*365));
    }
}

    export { MaDate }

/*const maSuperDate = {
    dateAujourdhui : new Date(),
    dateNaissance : new Date(),

    estDansLePasse: function(){
        console.log(this.dateAujourdhui);
    },

    estDansLePasse2: () => {
        console.log(maSuperDate.dateAujourdhui);
    }

}*/



