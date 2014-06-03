function printInsideDiv() {
    var input = document.getElementsByName("input")[0].value;
    var output = document.getElementById('output')
    output.innerText = input;
    console.log(input)
}