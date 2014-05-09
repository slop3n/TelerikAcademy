function isPrime() {
    var num = jsConsole.readFloat("#input");
    var divider = 2;
    var maxDivider = Math.sqrt(num);
    var prime = true;

    while (num && (divider <= maxDivider)) {
        if (num % divider == 0) {
            prime = false;
        }
        divider++;
    }
    jsConsole.writeLine("Number " + num + (prime ? " is prime" : " is not prime"));
}