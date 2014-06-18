window.onload = function insertElements() {
    var originalDiv = $('<div/>').text("original div").appendTo('#container');

    var beforeDiv = $('<div/>').text("inserted before original div");
    originalDiv.before(beforeDiv);

    var afterDiv = $('<div/>').text("inserted after original div");
    originalDiv.after(afterDiv)
}