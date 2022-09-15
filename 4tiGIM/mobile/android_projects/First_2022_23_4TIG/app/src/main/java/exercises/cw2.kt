package exercises

import java.util.*
import kotlin.random.Random.Default.nextInt


fun main(){
    //cw21();
    //cw22();
    //cw23();
    //print(isPrimal(21));
    cw24();
}

fun cw21(){
    print("Podaj ile liczb: ");
    val sc = Scanner(System.`in`);
    val howMany = sc.nextInt();
    print("Przez ile podzielne: ");
    val dividedBy = sc.nextInt();
    for (i in 1..howMany){
        println(i*dividedBy);
    }
}
fun cw22(){
    print("Podaj ile liczb: ");
    val sc = Scanner(System.`in`);
    val howMany = sc.nextInt();
    print("Przez ile podzielne: ");
    val dividedBy = sc.nextInt();
    var i = 0;
    while(i++<howMany){
        println(i*dividedBy);
    }
}
fun cw23(){
    val t1 = arrayOf<String>("sdsd","fffff","fffff");
    println("Rozmiar tablicy: "+t1.size);
    for (i in t1){
        println(i);
    }
}
fun cw24(){
    val sc = Scanner(System.`in`);
    print("Podaj rozmiar tablicy: ");
    val size = sc.nextInt();
    val rnd = Random();
    val numbers = IntArray(size)
    for (i in 0..size-1){
        //numbers[i]=(2..Int.MAX_VALUE).random()
        numbers[i] = nextInt(2,200)

    }
    val primals = numbers.filter { isPrimal(it) }
    println("wszystkie")
    for(i in numbers){
        print(i.toString()+" ")
    }
    println("\n\tpierwsze")
    for (i in primals){
        print(i.toString()+" ")
    }
}
fun isPrimal(number:Int):Boolean {
    if(number==1) return false;
    var i =2;
    while(i*i <= number) {    // for( i = 2 ; i*i <= number;i++)

        if(number % i++ == 0 ) return false;
    }
    return true;
}