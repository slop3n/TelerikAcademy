function printFirstBigger() {
    var array = document.getElementById('array').value;
    var numbers = array.split(/[\s,]+/)
    for (var i = 1; i < array.length - 2; i++) {
        if (parseInt(numbers[i - 1]) < parseInt(numbers[i]) && parseInt(numbers[i]) > parseInt(numbers[i + 1])) {
            jsConsole.writeLine("The first bigger element than its neighbours is on position " + (i + 1));
            break;
        }
    }
}