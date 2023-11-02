class Db 
{
    static async fetchJson(url) {
        let reponse = await fetch(url);
        let json = await reponse.json();
        return json;
    }
}

export { Db };