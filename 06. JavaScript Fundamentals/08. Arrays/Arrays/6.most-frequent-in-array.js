function getMostFrequent() {
    var input = document.getElementById('array').value;
    // regex argument in .split method, to split by space or comma
    var numbers = input.split(/[\s,]+/);
    var counter = 0;
    var maxCounter = 0;
    var element = 0;
    numbers.sort(function (a, b) { return a - b });
    for (var i = 0, length = numbers.length-1; i < length; i++) {
        if (numbers[i] == numbers[i + 1]) {
            counter++;
            if (counter > maxCounter) {
                maxCounter = counter;
                element = numbers[i]
            }
        }
        else {
            counter = 0;
        }

    }
    jsConsole.writeLine("The most frequent element is " + element);
}