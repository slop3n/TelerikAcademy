function exchangeValues() {
    var firstNum = jsConsole.readInteger("#inputOne");
        secondNum = jsConsole.readInteger("#inputTwo");

    if (firstNum > secondNum) {
        var temp = secondNum;
        secondNum = firstNum;
        firstNum = temp;
    }

    jsConsole.writeLine("First number is: " + firstNum + " Second number is: " + secondNum);
}