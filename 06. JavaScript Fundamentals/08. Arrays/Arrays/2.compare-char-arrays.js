function compareTwoCharArrays() {
    var arrayOne = document.getElementById('arrayOne').value;
    var arrayTwo = document.getElementById('arrayTwo').value;
    arrayOne.split(' ', ',', '.', ';');
    arrayTwo.split(' ', ',', '.', ';');
    if (arrayOne.length != arrayTwo.length) {
        jsConsole.writeLine("Arrays have different number of elements")
    }
    for (var i = 0, l = arrayOne.length; i < l; i++) {
        if (arrayOne[i] != arrayTwo[i]) {
            jsConsole.writeLine("Arrays have different elements on position " + i);
        }
    }
}