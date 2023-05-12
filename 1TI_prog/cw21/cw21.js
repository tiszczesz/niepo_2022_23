class User{

    constructor(login,firstname,lastname,createDate = new Date().toLocaleDateString(),
    description =''){
        this.login = login;
        this.firstname = firstname;
        this.lastname = lastname;
        this.createDate = createDate;
        this.description = description;
    }
    userToTableRow(){
        return `<tr>
        <td>${this.login}</td>
        <td>${this.firstname}</td>
        <td>${this.lastname}</td>
        <td>${this.createDate}</td>
        <td>${this.description}</td>
        </tr>`;
    }
}
const users = [
    new User("antoni","Antoni","Nowak",new Date(2012,2,12).toLocaleDateString(),"fajny lolo"),
    new User("renia","Renata","Małecka"),
    new User("tomcio","Tomasz","Bomasz",new Date(2019,2,12).toLocaleDateString(),"tomcio paluch"),
    new User("grrrr","Grażyna","Tymacka"),
]
