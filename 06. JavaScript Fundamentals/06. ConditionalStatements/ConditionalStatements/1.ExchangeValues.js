function exchangeValues() {
    var firstNum = jsConsole.readInteger("#inputOne");
    var secondNum = jsConsole.readInteger("#inputTwo");

    if (firstNum > secondNum) {
        var temp = secondNum;
        var secondNum = firstNum;
        var firstNum = temp;
    }

    jsConsole.writeLine("First number is: " + firstNum + " Second number is: " + secondNum);
}