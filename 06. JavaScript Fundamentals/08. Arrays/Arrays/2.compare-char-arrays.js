function compareTwoCharArrays() {
    var arrayOne = document.getElementById('arrayOne').value;
    var arrayTwo = document.getElementById('arrayTwo').value;

    // regex argument in .split method, to split by space or comma
    var arrOne = arrayOne.split(/[\s,]+/);
    var arrTwo = arrayTwo.split(/[\s,]+/);
    if (arrOne.length != arrTwo.length) {
        jsConsole.writeLine("Arrays have different number of elements")
    }
    for (var i = 0, l = arrOne.length; i < l; i++) {
        if (arrOne[i] != arrTwo[i]) {
            jsConsole.writeLine("Arrays have different elements on position " + i);
        }
    }
}