import kotlin.math.hypot
object Darts {

    fun score(x: Number, y: Number): Int {
    val distanceToCenter = hypot(x.toDouble(), y.toDouble())
    val points = if (distanceToCenter > 10){
        0
    }
    else if (distanceToCenter > 5){
        1
    }
    else if (distanceToCenter > 1){
        5
    }
    else {
        10
    }
    return points
    }
}
