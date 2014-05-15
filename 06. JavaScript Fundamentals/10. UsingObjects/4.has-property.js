// Write a function that checks if a given object contains a given property

function hasProperty(obj, prpt) {
    for (var i in obj) {
        if (i == prpt) {
            return true;
        }
    }
    return false;
}

var naughtyJoro = {
		naughtyness: 9001,
		coolness: 9001
}

console.log(hasProperty(naughtyJoro, 'naughtyness'));
console.log(hasProperty(naughtyJoro, 'coolness'));
console.log(hasProperty(naughtyJoro, 'yay'));