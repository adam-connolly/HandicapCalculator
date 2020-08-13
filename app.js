function addTableRow() {
    var table = document.getElementById("handicapIndexTable");
    var tableRows = table.tBodies[0].rows.length;
    var nextRound = tableRows + 1;
    var row = table.insertRow();
    var cell1 = row.insertCell();
    var cell2 = row.insertCell();
    var cell3 = row.insertCell();
    var cell4 = row.insertCell();
    var cell5 = row.insertCell();
    var cell6 = row.insertCell();
    cell1.innerHTML = "Round #4";
}