function writeEquation() {
    var numOne = jsConsole.readInteger("#inputOne");
    numTwo = jsConsole.readInteger("#inputTwo");
    numThree = jsConsole.readInteger("#inputThree");
    d = Math.sqrt(numTwo * numTwo - (4 * numOne * numThree));
    firstX = (-numTwo + d) / (2 * numOne);
    secondX = (-numTwo - d) / (2 * numOne);
    if ((numTwo * numTwo - (4 * numOne * numThree)) < 0) {
        jsConsole.writeLine("There are no real roots that solve this equation");
    }
    else if (firstX != secondX) {
        jsConsole.writeLine("The first real root of X is: " + firstX);
        jsConsole.writeLine("The second real root of X is: " + secondX);
    }
    else if (firstX == secondX) {
        jsConsole.writeLine("The only real root of X is: " + firstX);
    }
}