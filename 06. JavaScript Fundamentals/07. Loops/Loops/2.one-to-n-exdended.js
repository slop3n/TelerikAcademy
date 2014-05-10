function printNumbers() {
    var input = document.getElementById("input").value;
    for (var i = 1; i < parseInt(input) ; i++) {
        if (i % 3 != 0 && i % 7 != 0) {
            jsConsole.writeLine(i);
        }
    }
}