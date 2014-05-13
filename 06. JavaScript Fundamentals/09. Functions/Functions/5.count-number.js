function test() {
    var array = document.getElementById('array').value;
    var numArray = array.split(/[\s,]+/);
    var key = document.getElementById('number').value;
    jsConsole.writeLine("The number is met " + countNumbers(numArray, key));
}

function countNumbers(array, key) {
    var counter = 0;
    for (var i = 0; i < array.length; i++) {
        if (key == parseInt(array[i])) {
            counter++
        }
    }
    return counter;
}