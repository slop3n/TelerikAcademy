var canvas = document.getElementById("the-canvas");
var context = canvas.getContext("2d");
context.fillStyle = "lightblue";
context.strokeStyle = "blue";
context.beginPath();
context.arc(100, 200, 50, 0, 360 * Math.PI / 180);
context.fill();
context.stroke();

context.beginPath();
context.moveTo(100, 200);
context.lineTo(220, 195);
context.stroke();

context.beginPath();
context.arc(220, 195, 15, 0, 2 * Math.PI);
context.stroke();

context.beginPath();
context.moveTo(210, 183);
context.lineTo(202, 175);
context.stroke();

context.beginPath();
context.moveTo(230, 205);
context.lineTo(239, 215);
context.stroke();

context.beginPath();
context.arc(360, 195, 50, 0, 360 * Math.PI / 180)
context.fill();
context.stroke();

context.beginPath();
context.moveTo(220, 195);
context.lineTo(350, 120);
context.moveTo(360, 195);
context.lineTo(345, 70);
context.lineTo(380, 50);
context.moveTo(345, 70);
context.lineTo(300, 80);
context.moveTo(350, 120);
context.lineTo(190, 120);
context.lineTo(100, 200);
context.moveTo(220, 195);
context.lineTo(180, 90);
context.lineTo(210, 90);
context.moveTo(180, 90);
context.lineTo(150, 90);
context.stroke();

