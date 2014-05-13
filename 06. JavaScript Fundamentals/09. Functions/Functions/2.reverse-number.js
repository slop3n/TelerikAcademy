function reverseNumber() {
    var input = document.getElementById('number').value;
    var reversed = [];

    for (var i = input.length - 1; i >= 0; i--) {
        reversed[input.length - 1 - i] = input[i];
    }

    jsConsole.writeLine(reversed.join(""));
}