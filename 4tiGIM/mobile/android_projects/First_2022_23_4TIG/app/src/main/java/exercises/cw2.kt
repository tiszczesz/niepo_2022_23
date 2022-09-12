package exercises

import java.util.Scanner;


fun main(){
    //cw21();
    //cw22();
    //cw23();
    print(isPrimal(21));
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
fun isPrimal(number:Int):Boolean {
    if(number==1) return false;
    var i =2;
    while(i*i <= number) {    // for( i = 2 ; i*i <= number;i++)

        if(number % i++ == 0 ) return false;
    }
    return true;
}