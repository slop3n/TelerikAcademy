/*Write functions for working with shapes in standard 
Planar coordinate system
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their 
beginning and ending
 L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points
 Check if three segment lines can form a triangle */

function P(pointX, pointY) {
	return {
		pointX: pointX,
		pointY: pointY
	}
}

function L(pointOne, pointTwo) {
	return {
		pointOne: pointOne,
		pointTwo: pointTwo
	}
}

function getLength(pointOne, pointTwo) {
	return Math.sqrt((pointOne.pointX - pointTwo.pointX) * (pointOne.pointX - pointTwo.pointX) + (pointOne.pointY - pointTwo.pointY) * (pointOne.pointY - pointTwo.pointY))
}

function isTrianglePossible(lineOne, lineTwo, lineThree) {
	var lineOneLength = getLength(lineOne.pointOne, lineOne.pointTwo);
	var lineTwoLength = getLength(lineTwo.pointOne, lineTwo.pointTwo);
	var lineThreeLength = getLength(lineThree.pointOne, lineThree.pointTwo);
	if (lineOneLength + lineThreeLength > lineTwoLength && lineThreeLength + lineTwoLength > lineOneLength && lineTwoLength + lineOneLength > lineThreeLength) {
		return "Those lines can make a triangle";
	} else {
		return "Those lines cannot make a triangle";
	};
}

var pointA = P(2, 3);
var pointB = P(5, 2);
var pointC = P(3, 6);
var lineA = L(pointA, pointB);
var lineB = L(pointC, pointB);
var lineC = L(pointA, pointC);
console.log(getLength(pointA, pointB))
console.log(lineA.pointOne)
console.log(lineA.pointTwo)
console.log(getLength(lineA.pointOne, lineA.pointTwo))
console.log(isTrianglePossible(lineA, lineB, lineC))