// add_new_bus.js
function showAleart(isSaved) {
    if (isSaved) {
        if (isSaved === "True") {
            alert("New Bus Successfully Added!");
        }
    }
}

$(document).ready(function () {
    showAleart(@ViewBag.isSaved);
});
