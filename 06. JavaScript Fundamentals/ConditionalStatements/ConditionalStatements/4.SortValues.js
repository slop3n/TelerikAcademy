function sortValues() {
    var numOne = jsConsole.readInteger("#inputOne");
    numTwo = jsConsole.readInteger("#inputTwo");
    numThree = jsConsole.readInteger("#inputThree");
    first = 0;
    second = 0;
    third = 0;

    if (numOne>numTwo && numOne > numThree) {
        first = numOne;
        if (numTwo>numThree) {
            second = numTwo;
            third = numThree;
        }
        else {
            second = numThree;
            third = numTwo;
        }
    }
    else if (numTwo>numOne && numTwo>numThree) {
        first = numTwo;
        if (numOne>numThree) {
            second = numOne;
            third = numThree;
        }
        else {
            second = numThree;
            third = numOne;
        }
    }
    else {
        first = numThree;
        if (numOne>numTwo) {
            second = numOne;
            third = numTwo;
        }
        else {
            second = numTwo;
            third = numOne;
        }
    }
    jsConsole.writeLine("The first number is " + first);
    jsConsole.writeLine("The second number is " + second);
    jsConsole.writeLine("The third number is " + third);
}