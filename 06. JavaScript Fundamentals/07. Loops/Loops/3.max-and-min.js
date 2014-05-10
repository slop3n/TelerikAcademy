function findMinAndMax() {
    var num = document.getElementById("input").value;
    var numbers = num.split(' ');
    var min;
    var max;
    numbers.sort(function (a, b) { return a - b });
    min = numbers[0];
    max = numbers[numbers.length - 1];
    jsConsole.writeLine("Min value is " + min + " and Max value is " + max);
}