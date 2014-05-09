﻿function task8() {
    var n = jsConsole.readInteger('#input');
    var ones = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
    var teens = ['ten', 'eleven', 'twelve', 'thir', 'for', 'fif', 'six', 'seven', 'eigh', 'nine'];
    var tens = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];

    if ((n < 0) || (n > 999) || isNaN(n) || n === "") jsConsole.writeLine('Please provide a valid number. E.g. [0 - 999]');
    else jsConsole.writeLine('The name of the number ' + n + ' in english is: ' + Hundreds(n));

    function Tens(n) {
        return (n == 0) ? str = "Zero" : (n < 10) ?
            ones[n] : (n >= 10 && n < 13) ?
            teens[n - 10] : (n > 12 && n < 20) ?
            teens[n - 10] + 'teen' : (n % 10 == 0) ?
            tens[n / 10] : tens[Math.floor(n / 10)] + '-' + ones[n % 10];
    };

    function Hundreds(n) {
        if (n < 100) return Tens(n);
        else {
            return (n % 100 == 0) ? ones[n / 100] + ' hundred' : ones[Math.floor(n / 100)] + ' hundred and ' + Tens(n % 100);
        }
    };
};