function IsNameEmpty() {
    if (document.getElementById('Name').value == "") {
        document.getElementById('spanErrorDisplay').style.display = 'inline';
        document.getElementById("spanErrorDisplay").innerHTML = "ms insert some thing or go";
        return false;
    }
    return true;
}