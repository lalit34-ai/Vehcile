function showAleart() {
    if (@(ViewBag.isSaved ? "true" : "false")) {
        alert("New Car Successfully Added!");
    }
}

$(document).ready(function () {
    showAleart();
});
