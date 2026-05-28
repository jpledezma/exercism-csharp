fun reverse(input: String): String {
    var reversedString = ""
    for (i in input.length - 1 downTo 0) {
        reversedString += input[i]
    }
    return reversedString
}
