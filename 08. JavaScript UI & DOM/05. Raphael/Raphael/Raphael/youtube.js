var paper = Raphael("svg-container", 500, 500);
paper.text(50, 50, "You")
    .attr({
    "font-size": 50,
    fill: "gray"
})
paper.rect(100, 18, 135, 60, 15)
    .attr({
        fill: "red",
        stroke:"red"
    });

paper.text(165, 50, "Tube")
    .attr({
        fill: "white",
        "font-size":50
})