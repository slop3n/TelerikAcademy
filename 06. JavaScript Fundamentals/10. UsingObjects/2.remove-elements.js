Array.prototype.remove = function(element){
	for (var i = 0; i < this.length; i++) {
		if(this[i] == element){
			this.splice(i, 1);
		}
	};
}

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
console.log('The full array is ' + arr);
arr.remove(1);
console.log('The array without selected elements is ' + arr)