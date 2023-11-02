function date() {
    document.getElementById('affichage_date').valueAsDate = new Date()
}

function heure() {
    let d=new Date()
    let h=d.getHours()
    let m=d.getMinutes()
   
    if (h < 10) {
        h = "0" + h;
    }

    if (m < 10) {
        m = '0' + m;
    }
    let t=h + ":" + m
    document.getElementById('affichage_heure').value = t
   
}
 
 