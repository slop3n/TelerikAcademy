function substrinSearch(input, key) {
    var counter = 0;
    for (var i = 0; i < input.length; i++) {
        if (input.substr(i, key.length).toLowerCase() == key) {
            counter++;
        }
    }

    return counter;
}

var input = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
var keyword = "in";
console.log(substrinSearch(input, keyword));