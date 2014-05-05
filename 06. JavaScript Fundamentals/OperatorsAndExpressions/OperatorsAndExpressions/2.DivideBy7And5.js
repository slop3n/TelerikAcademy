function divisibleNumber() {

    var num = jsConsole.readInteger("#input");

    if (num % 5 ===0 && num % 7 === 0) {
        jsConsole.writeLine("The number can be divided by 5 and 7");
    }

    else {
        jsConsole.writeLine("The number can't be divided by 5 and 7");
    }
}