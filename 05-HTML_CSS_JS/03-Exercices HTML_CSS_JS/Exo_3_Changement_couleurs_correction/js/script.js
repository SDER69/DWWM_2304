console.log("hello World");

function testchamps(_champ) {
    var testbool = false;
    var regex = /^[0-9A-F]{2}$/;
    var chaine = document.querySelector("#" + _champ).value.toUpperCase();
    if (regex.test(chaine) == true) {
        testbool = true;

    } else {
        document.getElementById(_champ).value = "";
        document.getElementById(_champ).focus();
        console.log("deux caractères en code hexadecimal !!");
    }


    return testbool;

}

function genererCouleur( _champ){

    if (testchamps(_champ)==true) {
        let couleur ="#" + document.getElementById("rouge").value + document.getElementById("vert").value +document.getElementById("bleu").value; 
     document.body.style.backgroundColor=couleur;   
    }
} 
/* je n'utilise pas le foreach et on va associer un évènement à chaque zone input type text mais on aurait pu passer par un tableau avec querySelectorAll*/
document.querySelector("#rouge").addEventListener('blur', function() {
    genererCouleur('rouge');
})
document.querySelector("#vert").addEventListener('blur', function() {
    genererCouleur('vert');
})
document.querySelector("#bleu").addEventListener('blur', function() {
    genererCouleur('bleu');
})

function generercouleurbtn(_rouge, _vert, _bleu) {
    let couleur = "#" + _rouge + _vert + _bleu;
    document.body.style.backgroundColor = couleur;
}

/* je n'utilise pas le foreach et on va associer un évènement à chaque input type button mais on aurait pu passer par un tableau avec querySelectorAll*/

document.querySelector("#btnrouge").addEventListener("click",
    function () {
          let rouge=  document.querySelector("#rouge").value="ff";
            let vert=document.querySelector("#vert").value="00";
             let bleu =document.querySelector("#bleu").value="00";
            generercouleurbtn(rouge,vert,bleu);
    });

    document.querySelector("#btnvert").addEventListener("click",
    function () {
          let rouge=  document.querySelector("#rouge").value="00";
            let vert=document.querySelector("#vert").value="ff";
             let bleu =document.querySelector("#bleu").value="00";
            generercouleurbtn(rouge,vert,bleu);
    });
    document.querySelector("#btnbleu").addEventListener("click",
    function () {
          let rouge=  document.querySelector("#rouge").value="00";
            let vert=document.querySelector("#vert").value="00";
             let bleu =document.querySelector("#bleu").value="ff";
            generercouleurbtn(rouge,vert,bleu);
    });



