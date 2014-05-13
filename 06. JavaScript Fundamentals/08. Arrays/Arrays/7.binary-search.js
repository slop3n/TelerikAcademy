function binarySearch() {
    var input = document.getElementById('array').value;
    // regex argument in .split method, to split by space or comma
    var numbers = input.split(/[\s,]+/);
    var element = parseInt(document.getElementById('element').value);
    var max = numbers.length - 1;
    var min = 0;
    numbers.sort(function (a, b) { return a - b });
    while (max >= min) {
        var middle = (parseInt(min + max)) / 2;
        if (numbers[middle] == element) {
            jsConsole.writeLine("The position on which the element is placed is " + (parseInt(middle) + 1));
            break;
        }
        else if (numbers[middle] < element) {
            min = parseInt(middle) + 1;
        }
        else {
            max = parseInt(middle) - 1;
        }
    }
}