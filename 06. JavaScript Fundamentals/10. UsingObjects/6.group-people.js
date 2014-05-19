/* Write a function that groups an array of persons by 
age, first or last name. The function must return an 
associative array, with keys - the groups, and values -
arrays with persons in this groups
 Use function overloading (i.e. just one function) */
 function group(people, prop) {
    switch (prop) {
        case "firstname":
        case "lastname":
        case "age":
            {
                var groups = {};

                people.map(function (p) {
                    if (!groups[p[prop]]){
                        groups[p[prop]] = new Array();
                    }
                    groups[p[prop]].push(p);
                });

                return groups;
            }
        default:
            throw new Error("No such property in Person.");
    }
}

var people = [
{ firstname:'Gosho', lastname: 'Petrov', age: 32 },
{ firstname:'Atanas', lastname:'Angelov', age:15 },
{ firstname:'Bay', lastname: 'Ivan', age: 82 },
{ firstname:'Naughty', lastname: 'Joro', age: 20 } ];

var grouped = group(people, "age");
console.log(grouped);