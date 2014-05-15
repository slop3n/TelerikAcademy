/* Write a function that groups an array of persons by 
age, first or last name. The function must return an 
associative array, with keys - the groups, and values -
arrays with persons in this groups
 Use function overloading (i.e. just one function) */
function dynamicSort(property) {
    var sortOrder = 1;
    if(property[0] === "-") {
        sortOrder = -1;
        property = property.substr(1);
    }
    return function (a,b) {
        var result = (a[property] < b[property]) ? -1 : (a[property] > b[property]) ? 1 : 0;
        return result * sortOrder;
    }
}

var People = [
{ firstname:'Gosho', lastname: 'Petrov', age: 32 },
{ firstname:'Bay', lastname: 'Ivan', age: 82 },
{ firstname:'Naughty', lastname: 'Joro', age: 20 } ];