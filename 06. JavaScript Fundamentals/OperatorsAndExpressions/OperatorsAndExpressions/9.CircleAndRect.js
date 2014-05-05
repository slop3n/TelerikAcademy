function withinCircle() {
    var pointX = jsConsole.readInteger("#x");
        pointY = jsConsole.readInteger("#y");
        circleX = 1;
        circleY = 1;
        radius = 3;
        rect1 = 1;
        rect2 = -1;
        rect3 = 7;
        rect4 = -3;
        insideCircle = (pointX - circleX) * (pointX - circleX) + (pointY - circleY) * (pointY - circleY) < (radius) * (radius);
        outsideRect = pointX < rect1 || pointX > rect3 || pointY > rect2 || pointY < rect4;
    if (insideCircle && outsideRect) {
        jsConsole.writeLine("The point is inside");
    }
    else {
        jsConsole.writeLine("The point is outside");
    }
}