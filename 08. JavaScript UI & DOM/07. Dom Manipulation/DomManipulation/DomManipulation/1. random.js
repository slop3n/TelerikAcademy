function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}
function create() {
    var random = getRandomInt(1, 10);

    for (var i = 0; i < random; i++) {
        var currentDiv = document.createElement("div");
        currentDiv.style.backgroundColor = "#" + getRandomInt(000000, 999999).toString() ;
        currentDiv.style.height = getRandomInt(20, 100) + "px";
        currentDiv.style.width = getRandomInt(20, 100) + "px";
        currentDiv.style.color = "#" + getRandomInt(000000, 999999).toString();
        currentDiv.style.position = "absolute";
        currentDiv.style.top = getRandomInt(0, 100) + "%";
        currentDiv.style.left = getRandomInt(0, 100) + "%";
        var strong = document.createElement("strong");
        strong.innerHTML = "div";
        currentDiv.appendChild(strong);

        currentDiv.style.borderRadius = getRandomInt(0, 50) + "px";
        currentDiv.style.borderColor = "#" + getRandomInt(000000, 999999).toString();
        currentDiv.style.borderWidth = getRandomInt(1, 20) + "px";
        currentDiv.style.borderStyle = ['solid', 'dashed', 'dotted'][getRandomInt(0, 2)];
        currentDiv.style.textAlign = "center";
        container.appendChild(currentDiv);
    }
}