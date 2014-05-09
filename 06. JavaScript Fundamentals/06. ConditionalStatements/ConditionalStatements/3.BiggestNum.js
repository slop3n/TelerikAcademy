function findBiggest() {
    var numOne = jsConsole.readInteger("#inputOne");
    numTwo = jsConsole.readInteger("#inputTwo");
    numThree = jsConsole.readInteger("#inputThree");
    if (numOne > numTwo) {
        if (numOne > numThree) {
            jsConsole.writeLine("The biggest number is the first");
        }
    }
    if (numTwo > numOne) {
        if (numTwo > numThree) {
            jsConsole.writeLine("The biggest number is the second");
        }
    }
    if (numThree > numOne) {
        if (numThree > numTwo) {
            jsConsole.writeLine("The biggest number is the third");
        }
    }
}