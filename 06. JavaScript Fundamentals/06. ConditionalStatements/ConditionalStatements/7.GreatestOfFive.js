function getGreatest() {
    var firstNum = jsConsole.readInteger("#inputOne");
    secondNum = jsConsole.readInteger("#inputTwo");
    thirdNum = jsConsole.readInteger("#inputThree");
    fourthNum = jsConsole.readInteger("#inputFour");
    fifthNum = jsConsole.readInteger("#inputFive");
    if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum) {
        jsConsole.writeLine("First number is greatest");
    }
    else if (secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum) {
        jsConsole.writeLine("Second number is greatest");
    }
    else if (thirdNum > fourthNum && thirdNum > fifthNum) {
        jsConsole.writeLine("Third number is greatest");
    }
    else if (fourthNum > fifthNum) {
        jsConsole.writeLine("Fourth number is biggest");
    }
    else {
        jsConsole.writeLine("Fifth number is biggest");
    }
}