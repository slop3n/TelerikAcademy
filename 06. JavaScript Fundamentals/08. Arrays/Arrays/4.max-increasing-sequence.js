function getSequence() {
    var input = document.getElementById('array').value;
    // regex argument in .split method, to split by space or comma
    var numbers = input.split(/[\s,]+/);
    var maxLength = 1;
    var length = 1;
    var startPosition = 0;
    for (var i = 0, l = numbers.length - 1; i < l - 1; i++) {
        if (parseInt(numbers[i]) + 1 == parseInt(numbers[i + 1])) {
            length++;
            if (length > maxLength) {
                maxLength = length;
                startPosition = i - length + 2;
            }
        }
        else {
            length = 1;
        }
    }
    for (var i = 0, l = maxLength; i < l; i++) {
        jsConsole.writeLine(parseInt(numbers[startPosition]) + i);
    }
}