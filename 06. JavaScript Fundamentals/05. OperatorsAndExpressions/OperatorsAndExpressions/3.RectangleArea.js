function calculateArea() {
    var width = jsConsole.readFloat("#width")
    var height = jsConsole.readFloat("#height")
    var result = width * height;
    jsConsole.writeLine("The area of this rectangle is: " + result)
}