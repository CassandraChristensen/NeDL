function validateANDadd(){ 
    /* Declare variable, then get value and place into variable  */
    var theNewWord = document.forms["myForm"]["newWord"].value;
    var theNewNumber = document.forms["myForm"]["newNumber"].value; 

    /*if statement*/
    if (theNewWord == "")
    {
        alert("Please enter a word");
        return false;
    }
    else if ((theNewNumber != 1) && (theNewNumber !=2) && (theNewNumber != 3))
    {
        alert("Please choose 1, 2 or 3.");
        document.forms["myForm"]["newNumber"].value = "";
        return false;
    }
    else 
    {
        if (theNewNumber == 1){
            var tableRef = document.getElementById("myList1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;}
        else if (theNewNumber == 2)
        {
            var tableRef = document.getElementById("myList2");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
        }
        else 
        {
            var tableRef = document.getElementById("myList3");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
            
        }
        document.forms["myForm"]["newWord"].value = "";
        document.forms["myForm"]["newNumber"].value = "";
        return true;
    }
} 



  
/*Validate and Add Method*/
function clearList(){
    var tableRef = document.getElementById("myList1");
    tableRef.innerHTML = "";
}

/*Validate and Add Method*/
function clearList2(){
    var tableRef = document.getElementById("myList2");
    tableRef.innerHTML = "";
}

function clearList3(){
    var tableRef = document.getElementById("myList3");
    tableRef.innerHTML = "";
}