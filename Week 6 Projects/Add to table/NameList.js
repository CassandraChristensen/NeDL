/*Validate and Add Method*/
/* function ValidateAndAdd(){ */
    /* Declare variable, then get value and place into variable  */
    /* var theNewWord = document.forms["myForm"]["newWord"].value;
    var theNewNumber = document.forms["myForm"]["newNumber"].value; */

    /*if statement*/
    /* if (theNewWord == "")
    {
        alert ("Please enter a word")
        return false;
    }
    else if ((theNewNumber != 1) && (theNewNumber !=2))
    {
        alert ("Please choose 1 or 2.")
        return false;
    }
    else 
    {
        if (theNewNumber = 1){
            var tableRef = document.getElementById("myTable1")
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;}
        else
        {
            var tableRef = document.getElementById("myTable2")
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
        }
        return true;
    }
} */


function validateANDadd() {
    // place the values in the form into variables
    var theNewWord = document.forms["myForm"]["newWord"].value;
    var theNewNumber = document.forms["myForm"]["newNumber"].value;
    // validate that something was entered as a word
    if (theNewWord == "") {
      // no word was entered so tell the user
      alert("Please enter a word to check");
      return false;
    }
    // validate that a 1 or 2 was entered as a number
    else if ((theNewNumber != 1) && (theNewNumber != 2)) {
      // a 1 or 2 was not entered as the number so tell user and clear the field
      alert("Please enter a 1 or 2 for the list.");
      document.forms["myForm"]["newNumber"].value = "";
      return false;
    }
    else {
        // a word was entered and a 1 or 2 was entered as the number 
        // so add the word to the proper table 
        if (theNewNumber==1){
           var tableRef = document.getElementById("myList1");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;}
        else{
           var tableRef = document.getElementById("myList2");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;}
        // erase the form fields
        document.forms["myForm"]["newWord"].value = "";
        document.forms["myForm"]["newNumber"].value = "";
        return true;
    }
  }
/*Validate and Add Method*/

/*Validate and Add Method*/
