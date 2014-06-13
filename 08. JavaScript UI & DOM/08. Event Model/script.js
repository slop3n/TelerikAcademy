window.onload = function() {
    var task = document.querySelector('#input');
    var addTask = document.querySelector('#addTask');
    var tasks = document.querySelector('#tasks');

    addTask.addEventListener('click', function() {
        var currentDiv = document.createElement('div');
        var currentButton = document.createElement('button');
        var currentSpan = document.createElement('span');
        currentSpan.className = "taskElement";
        currentDiv.className = "divElement";
        currentButton.className = "clickToDelete";

        currentSpan.innerHTML = task.value;
        currentButton.innerHTML = "delete task";
        task.value = "";

        currentButton.addEventListener('click', function() {
            var div = currentButton.parentNode;
            div.remove();
        })
        currentDiv.appendChild(currentSpan)
        currentDiv.appendChild(currentButton);
        tasks.appendChild(currentDiv);

    })
}