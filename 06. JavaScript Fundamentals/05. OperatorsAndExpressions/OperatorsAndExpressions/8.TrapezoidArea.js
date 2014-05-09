function TrapezoidArea(){
    var a = jsConsole.readFloat("#a");
    var b = jsConsole.readFloat("#b");
    var h = jsConsole.readFloat("#h");
    var result = ((a + b) / 2) * h
    jsConsole.writeLine("The area of this trapezoid is: " + result)
}