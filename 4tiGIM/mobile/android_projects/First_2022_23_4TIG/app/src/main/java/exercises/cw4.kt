package exercises

fun main(){
   val car = Car("Citroen","c3",-250)
    car.maxSpeed = -300
    println("maksymalna predkosc: ${car.maxSpeed}")
    println("marka samochodu: ${car.brand}")
}

class Car(_brand: String,_model:String,_maxSpeed:Int){
    val brand = _brand
        get() = field.uppercase()

    var model = _model
    get() = field
    set(value){
        field = value
    }
    var maxSpeed = _maxSpeed
        get() = field
        set(value){
            field = if(value>=0) value else -value
        }
}