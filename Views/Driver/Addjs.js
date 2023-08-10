function showAleart() {
    if (@(ViewBag.isSaved ? "true" : "false")) {
        alert("New Driver Successfully Added!");
    }
}

$(document).ready(function () {
    showAleart();
});
