function AddFruit() {
    //add the user's info from the form into a variable
    var newFruit = document.forms["myForm"]["newFruit"].value;
    alert("test");
    //validate that the user entered an answer into the box 
    if (newFruit == "") {
        alert("Fail.");
        return false;
    }
    else {
        var myList = document.getElementById("myList").innerHTML = newFruit;
    }
}
