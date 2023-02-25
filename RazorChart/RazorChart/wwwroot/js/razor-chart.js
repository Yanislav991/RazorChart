window.insertLabels = () => {
    var arcs = document.querySelectorAll(".char-series");

    arcs.forEach(x => {
        var pathLen = x.getTotalLength();
        var pathDistance = pathLen * 0.3;
        var midpoint = x.getPointAtLength(pathDistance)

        var svg = x.ownerSVGElement;

        if (midpoint.x > 100) {
            midpoint.x > 230 ? midpoint.x += 30 : midpoint.x += 20
        } else {
            midpoint.x < 230 ? midpoint.x -= 30 : midpoint.x -= 20
        }

        if (midpoint.y > 100) {
            midpoint.y > 530 ? midpoint.y += 30 : midpoint.y += 10
        } else {
            midpoint.y < 530 ? midpoint.y -= 30 : midpoint.y -= 10
        }
        try {

            svg.appendChild(createText(midpoint.x, midpoint.y + 15, x.getAttribute('data-val')));
            svg.appendChild(createText(midpoint.x, midpoint.y, x.getAttribute('data-category')));
        } catch (err) {
            console.log()
        }
    })
}

function createText(x, y, childContent) {
    var text = document.createElementNS("http://www.w3.org/2000/svg", "text");
    text.setAttribute("x", x);
    text.setAttribute("y", y);
    text.setAttribute("text-anchor", "middle");
    text.setAttribute("font-size", "12px");
    text.textContent = childContent;
    return text;
}