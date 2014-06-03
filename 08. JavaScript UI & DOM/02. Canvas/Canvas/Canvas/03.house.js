var canvas = document.getElementById("the-canvas");
var ctx = canvas.getContext("2d");
ctx.strokeStyle = "black";
ctx.fillStyle = "red";
ctx.lineWidth = 3;

//house skeleton
ctx.beginPath();
ctx.rect(100, 200, 300, 300);
ctx.fill();
ctx.lineTo(250, 40);
ctx.lineTo(400, 200);
ctx.fill();
ctx.moveTo(120, 500);
ctx.lineTo(120, 400);
ctx.moveTo(120, 400);
ctx.bezierCurveTo(140, 380, 180, 380, 200, 400);
ctx.moveTo(200, 500);
ctx.lineTo(200, 400);
ctx.moveTo(160, 500);
ctx.lineTo(160, 385);
ctx.stroke();

//handles
ctx.beginPath();
ctx.arc(150, 450, 4, 0, 2 * Math.PI)
ctx.stroke();
ctx.beginPath();
ctx.arc(170, 450, 4, 0, 2 * Math.PI)
ctx.stroke();

//windows
ctx.fillStyle = "black";
ctx.beginPath();
ctx.fillRect(120, 250, 50, 35);
ctx.fillRect(173, 250, 50, 35);
ctx.fillRect(120, 288, 50, 35);
ctx.fillRect(173, 288, 50, 35);

ctx.fillRect(250, 250, 50, 35);
ctx.fillRect(303, 250, 50, 35);
ctx.fillRect(250, 288, 50, 35);
ctx.fillRect(303, 288, 50, 35);

ctx.fillRect(250, 350, 50, 35);
ctx.fillRect(303, 350, 50, 35);
ctx.fillRect(250, 388, 50, 35);
ctx.fillRect(303, 388, 50, 35);
ctx.fill();

//chimney
ctx.fillStyle = "red";
ctx.beginPath();
ctx.moveTo(330, 140);
ctx.lineTo(330, 50);
ctx.lineTo(300, 50)
ctx.lineTo(300, 140);
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.scale(1, 0.3);
ctx.arc(315, 165, 15, 0, 2 * Math.PI);
ctx.stroke();
ctx.fill();