package exercises

//import java.math.RoundingMode
import java.text.DecimalFormat


fun main(){
    println(cw1());
    try {
        val df = DecimalFormat("#.##")
        //df.roundingMode = RoundingMode.HALF_EVEN
        println(df.format(Doit2(5.14,0.0,'/')));
    }catch (e:ArithmeticException){
        println(e.message)
    }

}

fun cw1():String {
    val a = 34;
    var b :Double = 34.0
    b = 56.0;
   // var isChecked;

    return (a+b).toString();
}
fun DoIt(a:Double,b:Double,operator:Char='+'):Double{
    if(operator=='+') return a+b;
    if(operator=='-') return a-b;
    if(operator=='*') return a*b;
    if(operator=='/' && b!=0.0)
        return a/b
    else throw ArithmeticException("By zero or wrong operator!!!");
}
fun Doit2(a:Double,b:Double,operator:Char='+'):Double {
    return when (operator) {
        '+' ->  a + b;
        '-' ->  a - b;
        '*' ->  a * b;
        '/' -> {
             if (b != 0.0) a / b else throw ArithmeticException("By zero ")
        }
        else -> throw ArithmeticException("wrong operator!!!")
    }
}


