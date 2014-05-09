function checkBit() {
    var input = jsConsole.readInteger("#input");
    var mask = 1 << 2;
    var num = mask & input;
    var result = num >> 2;
    jsConsole.writeLine("The bit on position 3 is: " + result);
}