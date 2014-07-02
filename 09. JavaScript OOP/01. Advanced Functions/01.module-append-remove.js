var domModule = (function domModule() {
    var appendChild = function(child, parent) {
        var parentElement = document.querySelector(parent);
        parentElement.appendChild(child);
    }

    var removeChild = function(parent, child) {
        var childElement = document.querySelector(child);
        var parentElement = document.querySelector(parent);
        parentElement.removeChild(childElement);
    }

    var addHandler = function(elementSelector, myEvent, eventHandler) {
        var elements = document.querySelectorAll(elementSelector);
        for (var i = 0; i < elements.length; i++) {
            elements[i].addEventListener(myEvent, eventHandler);
        };
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler
    }
})();


var div = document.createElement('div');
div.innerHTML = 'appended div';
domModule.appendChild(div, '#wrapper')

domModule.removeChild('ul', 'li:first-child')

domModule.addHandler('#clickable', 'click', function() {
    alert('clicked')
});