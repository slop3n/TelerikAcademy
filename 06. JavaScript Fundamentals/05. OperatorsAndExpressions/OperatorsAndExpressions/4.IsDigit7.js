function checkNumber() {

    var number = jsConsole.readInteger("#input").toString();
    var num = number.charCodeAt(number.length - 3);
    var result = num - 48;
    if (result == 7) {
        jsConsole.writeLine("The number on third position is 7");
    }
    else {
        jsConsole.writeLine("The number on third position isn't 7");
    }
}