function getSign() {
    var numOne = jsConsole.readInteger("#inputOne");
    var numTwo = jsConsole.readInteger("#inputTwo");
    var numThree = jsConsole.readInteger("#inputThree");
    if (numOne < 0 && (numTwo < 0 || numThree < 0)) {
        jsConsole.writeLine("The sign is positive")
    }
    else if (numTwo < 0 && (numOne < 0 || numThree < 0)) {
        jsConsole.writeLine("The sign is positive")
    }
    else if (numThree < 0 && (numOne < 0 || numTwo < 0)) {
        jsConsole.writeLine("The sign is positive")
    }
    else if (numOne > 0 && numTwo > 0 && numThree > 0) {
        jsConsole.writeLine("The sign is positive")
    }
    else {
        jsConsole.writeLine("The sign is negative")
    }
}