//Create
function AddFunction(){
    //Step 1: Declare variable, assign type, go to the HTML document, forms, myForm, bookName, value, assign to variable.
    var addBook : string = document.forms["myForm"]["bookName"].value;

    //Step 2: Declare variable for table, get access to the value by using GetElementId, assign type, HTMLTableElement
    var tableRef = document.getElementById("myTable") as HTMLTableElement;

    //Step 3: Validate the user input information using if statement. 
    if (addBook == ""){
        alert("Please enter a book title into the text box");
        return false;
    }
    //Step 4: else statement > Info is valid > Create row in the table and insert the user's value to it as all uppercase. 
    else {
        tableRef.insertRow(tableRef.rows.length).innerHTML = addBook.toUpperCase();
        document.forms["myForm"]["bookName"].value = "";
        return true;
    }

}

//Update

//Delete
function DeleteFunction(){
    //Step 1: Declare variable, assign type, go to the HTML document, forms, myForm, bookName, value, assign to variable.
    var deleteBook : string = document.forms["myForm"]["bookName"].value;

    //Step 2: Declare variable for table, get access to the value by using GetElementId, assign type, HTMLTableElement
    var tableRef = document.getElementById("myTable") as HTMLTableElement;

    //Step 3: Create a bool variable for finding book name
    var bookFound : boolean = false;

    //Create a for loop, loop through each row in the table, to do a linear search for the bookName. 
    //If match, to userinput to ALL CAPS, deleterow from table: Update the form to blank, raise flag that name was found in list. 
    //If bookName not found, send an alert to borrow. Also update the form to blank. 
    for ( var index : number = 0; index < tableRef.rows.length; index++){
        if (tableRef.rows[index].innerHTML == deleteBook.toUpperCase()){
            tableRef.deleteRow(index);
            bookFound = true;
            return true;
        }
    }
    if (bookFound == false){
        alert ("please enter a book name in the list already")
    }
}

//Transfer to new list?
function MoveToAlreadyRead() {
    //Move from TBR to ReadAlready
//Step 1: Declare variable, assign type, go to the HTML document, forms, myForm, bookName, value, assign to variable.
var moveList : string = document.forms["myForm"]["bookName"].value;

var bookFound : boolean = false;

//Step 2: Declare variable for table 1 and 2, get access to the value by using GetElementId, assign type, HTMLTableElement
var tableRef1 = document.getElementById("myTable") as HTMLTableElement;

var tableRef2 = document.getElementById("myTable2") as HTMLTableElement;

//For loop to find a match of the word 
for (var index: number = 0; index < tableRef1.rows.length; index++){
    if (tableRef1.rows[index].innerHTML == moveList.toUpperCase()){
        tableRef1.deleteRow(index);
        tableRef2.insertRow(tableRef2.rows.length).innerHTML = moveList.toUpperCase();
        document.forms["myForm"]["bookName"].value = "";
        bookFound = true;
        return true;
    }
}
if (bookFound == false){
    alert("Please enter a book that is already on the first list.");
    return false;
}

}

//Clear all function
function ClearAllFunction(){
    this.tableRef = document.getElementById("myTable");
    this.tableRef.innerHTML = "";
}

//Make table into an array 
function createArrayDeleteBook(){


    var deleteBookTitle : string = document.forms["myForm"]["bookName"].value;
    var table = document.getElementById("myTable") as HTMLTableElement;
    var tableArray : string[] = [];
    
    if (deleteBookTitle == ""){
        alert("Fail. Try again.");
        return false;
    }
    else{
    
        for (var i : number = 0; i < table.rows.length; i++){
            tableArray.push(table.rows[i].innerHTML);
            
        }
        if (tableArray.includes(deleteBookTitle)){
            let deleteBookIndex = -1;
            deleteBookIndex = tableArray.indexOf(deleteBookTitle);
            tableArray.splice(deleteBookIndex, 1);
            tableArray.forEach(item => {
                (table.insertRow(table.rows.length)).innerHTML = tableArray[i];
                
            })
        }
        for(var i : number = 0; i < tableArray.length; i++){
            (table.insertRow(table.rows.length)).innerHTML = tableArray[i];
           return true;
        }
    }


}