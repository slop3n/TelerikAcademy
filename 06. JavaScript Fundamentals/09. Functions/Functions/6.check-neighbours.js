function check() {
    var input = document.getElementById('array').value;
    var position = parseInt(document.getElementById('element').value)-1;
    var array = input.split(/[\s,]+/);
    console.log(array);
    if (parseInt(array[position - 1]) < parseInt(array[position]) && parseInt(array[position]) > parseInt(array[position + 1])) {
        jsConsole.writeLine("The number is bigger than its neighbours");
    }
}
