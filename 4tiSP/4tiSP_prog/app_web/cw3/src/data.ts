export const Dane = ["sdsfsf","dsdsddd","dddddd"];

export const Users:Array<User> = await GetUsers();

interface User{
    id:number,
    name:string,
    username:string,
    email:string
}
async function GetUsers() {
    const res = await fetch('https://jsonplaceholder.typicode.com/users');
    const users = await res.json();
    return users;
}