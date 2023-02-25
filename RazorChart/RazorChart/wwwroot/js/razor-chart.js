window.insertLabels = () => {
    var arcs = document.querySelectorAll(".char-series");

    arcs.forEach(x => {
        var pathLen = x.getTotalLength();
        var labelValueText = x.getAttribute('data-val');
        var labelCategoryText = x.getAttribute('data-category');

        var pathDistance = pathLen * 0.3;
        var midpoint = x.getPointAtLength(pathDistance)

        var svg = x.ownerSVGElement;
        var valueText = document.createElementNS("http://www.w3.org/2000/svg", "text");
        var categoryText = document.createElementNS("http://www.w3.org/2000/svg", "text");

        if (midpoint.x > 100) {
            midpoint.x > 230 ? midpoint.x += 60 : midpoint.x += 20
        } else {
            midpoint.x < 230 ? midpoint.x -= 60 : midpoint.x -= 20
        }

        if (midpoint.y > 100) {
            midpoint.y > 230 ? midpoint.y += 60 : midpoint.y += 20
        } else {
            midpoint.y < 230 ? midpoint.y -= 60 : midpoint.y -= 20
        }

        valueText.setAttribute("x", midpoint.x);
        valueText.setAttribute("y", midpoint.y + 15);
        valueText.setAttribute("text-anchor", "middle");
        valueText.textContent = labelValueText;

        categoryText.setAttribute("x", midpoint.x);
        categoryText.setAttribute("y", midpoint.y);
        categoryText.setAttribute("text-anchor", "middle");
        categoryText.textContent = labelCategoryText;

        svg.appendChild(valueText);
        svg.appendChild(categoryText);
    })



}