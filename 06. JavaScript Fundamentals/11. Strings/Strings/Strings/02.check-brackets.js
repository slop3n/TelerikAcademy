function checkBrackets(input) {
    var openBracketsCounter = 0;
    var closedBracketsCounter = 0;
    for (var i = 0; i < input.length; i++) {
        if (input[i] == '(') {
            openBracketsCounter++;
        }
        if (input[i] == ')') {
            closedBracketsCounter++;
        }
    }
    if (closedBracketsCounter != openBracketsCounter) {
        return ("It's not a valid expression");
    }
    else if (input[0] == '+' || input[0] == '-' || input[0] == '/' ||
             input[0] == '*' || input[0] == ')' || input[input.Length - 1] == '+' ||
             input[input.Length - 1] == '-' || input[input.Length - 1] == '/' ||
             input[input.Length - 1] == '*' || input[input.Length - 1] == '(') {
        return ("It's not a valid expression");
    }
    else {
        return ("The expression is valid");
    }
}

console.log(checkBrackets("(5+5+6)(*"))