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