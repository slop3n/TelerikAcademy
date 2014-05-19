function replaceNBSP(input) {
    var nbsp = "&nbsp;";
    var result = '';
    for (var i = 0; i < input.length; i++) {
        if (input[i-1] == ' ' && input[i] == ' ' ) {
            result += nbsp;
        }
        else {
            result += input[i]
        }
    }

    return result;
}

var test = " i    liek trains     "
console.log(replaceNBSP(test))