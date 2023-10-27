const apiUrl = "./assets/js/zipcodes.json"

fetch(apiUrl).then((response) => {
    return response.json()
}).then((json) => {
    //console.log(json)
}).catch((error) => {
    //console.error(error)
})

async function fetchUrl(){
    let response = await fetch(apiUrl)
    let json = await response.json()

    //console.log(json)
}

fetchUrl()



    
