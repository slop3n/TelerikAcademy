var paper = Raphael("svg-container", 500, 500);
paper.path("M23 39 39 23 79 63 56 85 33 63 73 23 89 39")
    .attr({
    "stroke-width": 10,
    stroke: 'green'
    })
paper.text(180, 40, "Telerik").attr({
    "font-size": 50,
    "font-weight": "bold"
})
paper.circle(268, 34, 4);
paper.text(268, 34, "R").attr({
    "font-size":5
})

paper.text(226, 75, "Develop experiences").attr({
    "font-size":25
})