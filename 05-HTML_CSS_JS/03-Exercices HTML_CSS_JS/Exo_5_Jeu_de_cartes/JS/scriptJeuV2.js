function addCell(tr, text) {
    let td = tr.insertCell();
    td.textContent = text;
    return td;
}

function titleCell(row, text) {
    let cell = document.createElement("th");
    cell.textContent = text;
    row.appendChild(cell)
}

function createCells(row, objet) {
    for (const key in objet) {
        addCell(row, objet[key]);
    }
}

function fillTable(tabData)
{ var table= document.getElementById("jeu");
console.log(tabData);
//creer le header du tableau;
let thead=table.createTHead();
let headerRow= thead.insertRow();
for (let key in tabData[0]) {

    titleCell(headerRow,key);
  
} 
let tBody= table.createTBody();
for (let i =0; i < tabData.length; i ++) {

    var bodyrow=tBody.insertRow();
    // creer cellules fonction
        createCells(bodyrow,tabData[i]);
    
    }
} 

fetch("https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json")
.then(response => response.json())
.then( response => fillTable(response))
.catch(
    error => console.log("Erreur : " + error)
);