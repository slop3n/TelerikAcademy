function findWord() {
    var text = document.getElementById('text').value;
    var keyword = document.getElementById('keyword').value;
    var textAsArray = text.split(/[\s,]+/);
    var counter = 0;
    var positions = [];
    for (var i = 0, length = textAsArray.length; i < length; i++) {
        if (textAsArray[i] == keyword) {
            counter++;
            positions.push(parseInt(i)+1);
        }
    }
    console.log(textAsArray)
    console.log(text)
    console.log(keyword)
    jsConsole.writeLine("Keyword is met " + counter + " times and on " + positions + " positions");
}