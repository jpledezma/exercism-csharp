object CollatzCalculator {
    fun computeStepCount(start: Int): Int {
        if (start < 1){
        throw IllegalArgumentException("Start must not be less than 1.")
    }
        var steps = 0
    var currentValue = start
    while (currentValue > 1) {
        if (currentValue % 2 == 0) {
            currentValue /= 2
        }
        else{
            currentValue = currentValue * 3 + 1
        }
        steps++
    }

    return steps
    }
}
