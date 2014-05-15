/* Write a function that makes a deep copy of an object
 The function should work for both primitive and 
reference types */

function person(name){
	return {	
		name:name,
		info: function(){ return 'My name is ' + this.name;}	
	}
}

function clone(obj) {
    // Handle the 3 simple types, and null or undefined
    if (null == obj || "object" != typeof obj) return obj;

	// Handle Date
	if (obj instanceof Date) {
		var copy = new Date();
	    copy.setTime(obj.getTime());
	    return copy;
	}

    // Handle Array
    if (obj instanceof Array) {
        var copy = [];
        for (var i = 0, len = obj.length; i < len; i++) {
            copy[i] = clone(obj[i]);
        }
        return copy;
    } 

    // Handle Object
    if (obj instanceof Object) {
        var copy = {};
        for (var attr in obj) {
            if (obj.hasOwnProperty(attr)) copy[attr] = clone(obj[attr]);
        }
        return copy;
    }

    throw new Error("Unable to copy obj! Its type isn't supported.");
}


a = person('Pesho');

console.log(a.info());
b = clone(a);
console.log(b.info());
