fun main() {
    println("Najwieksza liczba z podanych: ${getMax()}")
}


fun getMax():Int{
    var number:Int
    var max = Int.MIN_VALUE
    do {
        print("Podaj liczbe (zero lub ijemna to koniec): ")
        number = readln().toInt()
        if(number!=0 && number>max){
            max = number
        }
    }while (number>0)
    return max
}
