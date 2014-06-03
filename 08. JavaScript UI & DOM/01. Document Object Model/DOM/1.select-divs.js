function myQuerySelector() {
    var elements = document.querySelectorAll("div div");

    for (var i = 0; i < elements.length; i++) {
        console.log(elements[i].innerHTML)
    }
}

function myTagSelector() {
    var elements = document.getElementsByTagName("div");
    for (var i = 0; i < elements.length; i++) {
        var current = elements[i].getElementsByTagName("div")[0];
        console.log(current);
    }
}
