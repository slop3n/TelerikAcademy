var canvas = document.getElementById("the-canvas");
var context = canvas.getContext("2d");

context.fillStyle = "lightblue";
context.beginPath();
context.arc(350, 350, 120, 0, 2 * Math.PI);
context.fill();

context.beginPath();
context.fillStyle = "blue";
context.strokeStyle = "black";
context.scale(1, 0.2);
context.arc(340, 1200, 130, 0, 2 * Math.PI);
context.fill();
context.stroke();

context.beginPath();
context.lineWidth = "3";
context.strokeStyle = "black"
context.moveTo(300, 1200);
context.quadraticCurveTo(345, 1300, 400, 1200);
context.lineTo(400, 500);
context.lineTo(300, 500);
context.lineTo(300, 1200);
context.fill();
context.stroke();

context.beginPath();
context.lineWidth = "2";
context.arc(350, 500, 50, 0, 2 * Math.PI);
context.fill();
context.stroke();

context.beginPath();
context.scale(0.2, 1);
context.scale(1.5, 1);
context.arc(1000, 1600, 40, 0, 2 * Math.PI);
context.stroke();

context.beginPath();
context.arc(1200, 1600, 40, 0, 2 * Math.PI);
context.stroke();

context.beginPath();
context.scale(2, 1);
context.arc(550, 2050, 100, 0, 2 * Math.PI);
context.stroke();

context.beginPath();
context.fillStyle = "black";
context.scale(1, 1.5);
context.scale(1, 5);
context.arc(495, 213, 3, 0, 2 * Math.PI);
context.stroke();
context.fill();

context.beginPath();
context.arc(595, 213, 3, 0, 2 * Math.PI);
context.stroke();
context.fill();

context.beginPath();
context.moveTo(550, 220);
context.lineTo(530, 240);
context.lineTo(550, 240);
context.stroke();