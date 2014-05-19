function test(text) {
    var array = text.split(" ");

    for (var i = 0; i < array.length; i++) {
        var isPalindrome = true;

        for (var q = 0; q < array[i].length; q++) {
            if (array[i][q].toLowerCase() != array[i][array[i].length - 1 - q].toLowerCase()) {
                isPalindrome = false;
            }
        }

        if (isPalindrome) {
            console.log(array[i]);
        }
    }
}

console.log(test("my name is lamal and i sing solos ride a civic racecar and kayak"))