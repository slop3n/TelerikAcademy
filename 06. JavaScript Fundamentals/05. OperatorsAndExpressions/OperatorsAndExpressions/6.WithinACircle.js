function withinCircle() {
    var x = jsConsole.readInteger("#x")
    var y = jsConsole.readInteger("#y")
    var radius = 5;
    var result = (x * x) + (y * y);
    if (result > radius * radius) {
        jsConsole.writeLine("The point is not in the circle")
    }
    else {
        jsConsole.writeLine("The point is in the circle")
    }
}