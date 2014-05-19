/* Write a function that removes all elements with a 
given value
 Attach it to the array type
 Read about prototype and how to attach methods */

Array.prototype.remove = function(element){
	for (var i = 0; i < this.length; i++) {
		if(this[i] == element){
			this.splice(i, 1);
			i--;
		}
	};
}

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
var arr2= [2,2,2,2,3,3,2,2,1,1,1,3,2,321,2,3,4,2,2,2,2,1,1,2,3,2,2,1,1,1,2,3,4,2,5]
console.log('The full array is ' + arr);
arr.remove(1);
console.log('The array without selected elements is ' + arr)
arr2.remove(2);
console.log(arr2)