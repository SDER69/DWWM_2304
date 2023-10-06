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

/*function createCells(row, objet) {
    
        if(testDescri(objet)==true)
        {
          
        }
    
}
/*function testDescri(objet) {
   for (var key in objet) {
    let testDescription = false
    if(objet[key] == "description"){
        testDescription = true
    }
 return testDescription;
    
   }
}*/

function fillTable(tabData) {
    var table = document.getElementById("jeu");
    // Creer le header du tableau
    let thead = table.createTHead();
    let headerRow = thead.insertRow();

    for (let key in tabData[0]) {
        titleCell(headerRow, key);
    }
    let tBody = table.createTBody();
    for (let i = 0; i < tabData.length; i++) {
        var bodyRow = tBody.insertRow();
        // Fonction créer les cellules
         createCells(bodyRow,tabData[i])
      /*if(testDescri(tabData[i]) == true){
        createCells(bodyRow,tabData[i])
      }
      else{
        tabData[i]["description"] = "test";
        createCells(bodyRow,tabData[i])
      }*/

    }
}

    // Fonction qui supprime une colonne
    /*function deleteCell(json){
        console.log(json);
        for (let i = 0; i < json.length; i++) {
            console.warn(json[i])
            delete json[i].description;
        }
        return json
    }*/

    /*function addDescription(json)  {
        for (let i = 0; i < json.length; i++) {
            console.warn(json[i])
            insertCell(json[i]) 
        }
        return json
        }*/
    

    // On crée un objet XMLHttpRequest XHR
    let xhr = new XMLHttpRequest();

    var json = "https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json";
    // On initialise notre requête avec la méthode open
    xhr.open("GET", json);


    // On indique le type de format --> json dans ce cas
    xhr.responseType = "json";

    // On envoie la requête
    xhr.send();

    // Une fois que la réponse est reçu
    xhr.onload = function () {
        if (xhr.status != 200) {
            console.log("erreur" + xhr.status + xhr.statusText);
        } else {
            let container = xhr.response;
            console.log(container)

            //deleteCell(container)
            //addDescription(container)
            fillTable(container)
            //console.log(typeof(container))
            console.log(container[1]["name"])
    } 
}







