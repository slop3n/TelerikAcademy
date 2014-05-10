function printNumbers() {
    var input = document.getElementById("input").value;
    for (var i = 1; i <= parseInt(input); i++) {
        jsConsole.writeLine(i);
    }
}