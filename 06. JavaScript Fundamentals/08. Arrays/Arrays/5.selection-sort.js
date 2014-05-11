function sort() {
    var input = document.getElementById('array').value;
    // regex argument in .split method, to split by space or comma
    var numbers = input.split(/[\s,]+/);
    var temp;
    for (var i in numbers) {
        for (j = 0; j < numbers.length; j++) {
            var min = parseInt(numbers[j]);
            if (parseInt(numbers[i]) < parseInt(min)) {
                min = parseInt(numbers[i]);
                temp = parseInt(numbers[j]);
                numbers[j] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
    console.log(numbers)
    for (var i =0, l = numbers.length; i < l; i++) {
        jsConsole.writeLine(numbers[i])
    }
}