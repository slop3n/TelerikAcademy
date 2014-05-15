function P(pointX, pointY) {
	return{
	pointX: pointX,
	pointY: pointY
	}
}

function L(pointOne, pointTwo){
	return{
	pointOne: pointOne,
	pointTwo: pointTwo
	}
}

function getLength(pointOne, pointTwo){
	 return Math.sqrt((pointOne.pointX - pointTwo.pointX) * (pointOne.pointX - pointTwo.pointX) + (pointOne.pointY - pointTwo.pointY) * (pointOne.pointY - pointTwo.pointY))
}

function isTrianglePossible(lineOne, lineTwo, lineThree){
	var lineOneLength = getLength(lineOne.pointOne, lineOne.pointTwo);
	var lineTwoLength = getLength(lineTwo.pointOne, lineTwo.pointTwo);
	var lineThreeLength = getLength(lineThree.pointone, lineThree.pointTwo);
	if (lineOneLength + lineThreeLength > lineTwoLength && lineThreeLength + lineTwoLength > lineOneLength && lineTwoLength + lineOneLength > lineThreeLength) {
		return "true";
	} 
	else{ 
		return "false";
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
console.log(isTrianglePossible(lineA,lineB,lineC))




