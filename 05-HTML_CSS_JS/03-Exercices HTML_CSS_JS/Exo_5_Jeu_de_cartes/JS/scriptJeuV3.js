document.addEventListener("DOMContentLoaded", function () 
{
    fetch("https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json")
        .then(response => {
            if (!response.ok) 
            {
                throw new Error("Réponse HTTP non valide");
            }
            return response.json();
        })
        .then(data => 
            {
            const tableBody = document.querySelector("#jeu tbody");
            data.forEach(item => 
                {
                const row = tableBody.insertRow();
                row.insertCell().textContent = item.id;
                row.insertCell().textContent = item.name;
                row.insertCell().textContent = item.level;
                row.insertCell().textContent = item.description;
                row.insertCell().textContent = item.power;
                row.insertCell().textContent = item.attack;
                row.insertCell().textContent = item.armor;
                row.insertCell().textContent = item.damage;
                row.insertCell().textContent = item.mitigation;
                row.insertCell().textContent = item.played;
                row.insertCell().textContent = item.victory;
                row.insertCell().textContent = item.defeat;
                row.insertCell().textContent = item.draw;
            });
        })
        .catch(error => console.error("Erreur lors du chargement des données JSON", error));
});