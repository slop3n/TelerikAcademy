var canvas = document.getElementById("the-canvas");
var ctx = canvas.getContext("2d");
var height = canvas.height;
var width = canvas.width;

ctx.lineWidth = 2;
ctx.fillStyle = "black";

var x = 15;
var y = 15;
var updateX;
var updateY;
var speed = 5;
var radius = 15;

function drawCircle(x, y) {
    ctx.beginPath();
    ctx.arc(x, y, radius, 0, 2 * Math.PI);
    ctx.fill()
    ctx.stroke()
}

function moveCircle() {
    ctx.clearRect(0, 0, width, height);

    if (x <= radius) {
        updateX = speed;
    }
    if (x+radius >= width) {
        updateX = -speed;
    }
    if (y <= radius) {
        updateY = speed;
    }
    if (y+radius >= height) {
        updateY = -speed;
    }

    x += updateX;
    y += updateY;
    drawCircle(x,y)
    requestAnimationFrame(moveCircle)
}

moveCircle()