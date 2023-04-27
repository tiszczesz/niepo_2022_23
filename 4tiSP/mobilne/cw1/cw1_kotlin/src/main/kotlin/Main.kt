fun main(args: Array<String>) {
//    println("Hello World!")
//    val a = 23;
//    val b = "ala ma kota";
//    println("Zmienna a = $a \nzmienna b = $b");
//    //a = 56;
//    var c = 45;
//    println(" c = $c");
//    var input:String;
//    print("Podaj imię: ")
//    input = readln()
//    println("Witaj $input");
//    c = 1023;
//    println(" c = $c");
//    println("Program arguments: ${args.joinToString()}")
    println("-------------------------------------------\n");
    println("Podaj a: ");
    var a:Double = readln().toDouble();
    println("Podaj b: ");
    var b:Double = readln().toDouble();
    println("Rozwiazanie rownania $a x + $b = 0 wynosi: ${LinearEq(a,b)}")
}

fun LinearEq(a: Double,b:Double):Double{
    return -b/a;
}