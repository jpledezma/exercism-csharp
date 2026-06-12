object Bob {
    fun hey(input: String): String {
        fun isYell(input: String): Boolean{
        if (input.isEmpty()) return true
        var containsALetter = false
        for (c in input){
            if (c.isLetter()){
                containsALetter = true
                break
            }
        }

        return containsALetter && input == input.uppercase()
    }

    val inp = input.trim()
    val response: String = when {
        inp == "" -> "Fine. Be that way!"
        inp[inp.length - 1] == '?' && isYell(inp) -> "Calm down, I know what I'm doing!"
        inp[inp.length - 1] == '?' -> "Sure."
        isYell(inp) -> "Whoa, chill out!"
        else -> "Whatever."
    }
    return response
    }
}
