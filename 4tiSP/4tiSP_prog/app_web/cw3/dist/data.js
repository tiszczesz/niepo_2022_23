export const Dane = ["sdsfsf", "dsdsddd", "dddddd"];
export const Users = await GetUsers();
async function GetUsers() {
    const res = await fetch('https://jsonplaceholder.typicode.com/users');
    const users = await res.json();
    return users;
}
