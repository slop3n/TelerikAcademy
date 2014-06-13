var divs = Array(5);
var centerX = 250;
var centerY = 250;
var radius = 200;
var angle = 0;

window.onload = function () {
    var outer = document.getElementById("container");
    outer.style.width = 500 + "px";
    outer.style.height = 500 + "px";
    outer.style.margin = 20 + "px";
    outer.style.backgroundColor = "skyblue";

    for (var i = 0; i < divs.length; i++) {
        var current = document.createElement("div");
        current.innerHTML = parseInt(i) + 1;
        current.style.width = 20 + "px";
        current.style.height = 20 + "px";
        current.style.borderRadius = 20 + "px";
        current.style.backgroundColor = "blue";
        current.style.textAlign = "center";
        current.style.color = "white";
        current.style.position = "absolute";

        container.appendChild(current);
        divs[i] = current;
    }
}

setInterval(function moveDivs() {
    angle++;
    if (angle == 360) {
        angle = 0;
    }

    for (var i = 0; i < divs.length; i++) {
        var addition = (360 / divs.length) * i;
        var left = centerX + Math.cos((2 * Math.PI / 180) * (angle + addition)) * radius;
        var right = centerY + Math.sin((2 * Math.PI/ 180) * (angle + addition)) * radius;
        divs[i].style.left = left + "px";
        divs[i].style.top = right + "px";
    }
}, 100);