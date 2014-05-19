﻿function format(str) {
    var selfArguments = arguments

    return str.replace(/{(\d+)}/g, function (match, p1) {
        return selfArguments[+p1 + 1]
    })
}

console.log(format("{0}, {1}", 123, 123))