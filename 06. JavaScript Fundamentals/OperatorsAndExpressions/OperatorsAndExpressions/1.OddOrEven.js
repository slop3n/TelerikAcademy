function oddOrEven() {
    var number = jsConsole.readInteger("#inputNumber");

    jsConsole.writeLine("The number " + number + " is " + (number % 2 === 0 ? "even!" : "odd!"));
}