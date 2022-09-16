package exercises

fun main(){
    val film = Film("jakis");
    val game = Game("RPG super")
    val person = Person("Jan","Nowak",45)
    println(person.age)
    //println(person.firstName)
    println(film.getTitle());
    println(game.info());
}
class Film constructor(title: String){
    private var _title:String = title
    fun getTitle():String{
        return this._title
    }
    override fun toString(): String {
        return "Film o tytule: "+ this._title
    }
}
class Game(title: String){
    var _title = title;
    fun info(){
        println("Gra o tytule: "+ _title)
    }
}
class Person(private var firstName:String,private var lastName:String,var age:Int){

}
