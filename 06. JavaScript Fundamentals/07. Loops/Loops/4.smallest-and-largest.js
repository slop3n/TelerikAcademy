function findSmallestAndLargest() {
    var first;
    var last;
    var array = [document, window, navigator];
    for (var i = 0; i < 3; i++) {
        first = 'zz';
        last = 'AA';
        for (var property in array[i]) {
            if (property < first) {
                first = property;
            }
            if (property > last) {
                last = property;
            }
        }
        jsConsole.writeLine('The smallest property in ' + array[i] + ' is ' + first);
        jsConsole.writeLine('The largest property in ' + array[i] + ' is ' + last);
    }
}