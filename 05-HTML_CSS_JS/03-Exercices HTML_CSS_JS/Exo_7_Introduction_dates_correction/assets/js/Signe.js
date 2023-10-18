class Signe
{
    static signesAstro = ["Capricorne","Verseau","Poissons","Bélier","Taureau",
                         "Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"]
    constructor(_date)
    {
        this.dateAnniv = new Date(_date);
        this.periodes = this.genererTableau();
    }

    genererTableau(){
            let annee= this.dateAnniv.getFullYear
            return[
                new Date(annee + '-01-20'),
                new Date(annee + '-02-19'),
                new Date(annee + '-03-21'),
                new Date(annee + '-04-20'),
                new Date(annee + '-05-21'),
                new Date(annee + '-06-21'),
                new Date(annee + '-07-23'),
                new Date(annee + '-08-23'),
                new Date(annee + '-09-23'),
                new Date(annee + '-10-23'),
                new Date(annee + '-11-22'),
                new Date(annee + '-12-22'),
            ]
    }

    calculerSigne(){
        for (let i = 0 ; i < this.periodes.length;i++) {
            if (this.dateAnniv < this.periodes[i]) {
                return this.signesAstro[i]
                
            } else {
                
            }
            
        }
    }


}

export { Signe };