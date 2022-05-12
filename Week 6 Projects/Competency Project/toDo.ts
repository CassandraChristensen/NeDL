//1. Create Add Function
function AddFunction(){
    //a. Declare variable, label type, go to document, forms, myform and the name of the item i want, use that value to insert into the variable. 
    var addItem : string = document.forms["myForm"]["itemName"].value;

    //b. Validate that the user entered something, if not return with an error. 
    if (addItem == ""){
        alert("Please enter an item to add to the list.");
        return false;
    }
    //c. Add item to table: Declare variable for table, include the type, go to documnet, get table that i want to add to.
    //d. Insert a row into the tables inner HTML, at the end of the table
    //e. Had to use 'this' keyword to remove error: ""Property 'insertRow' does not exist on type 'HTMLElement'"". Once added, works fine. 
    //f. Why was i getting that error? 
    else {
        this.tableRef = document.getElementById("myTable");
        (this.tableRef.insertRow(this.tableRef.rows.length)).innerHTML = addItem;
        document.forms["myForm"]["itemName"].value = "";
        return true;
    }

}//end add function 

//2. Create Delete Function
function DeleteFunction(){
    //a. Declare variable, label the type, go to document>forms>[form name][formitem], insert that value into variable
    var deleteItem : string = document.forms["myForm"]["itemName"].value;

    var itemFound : boolean = false; 
    //b. Validate the value entered, if  not return with an error 
    /* if (deleteItem == "") {
        alert("Please enter an item to delete from the list.");
        return false;
    } */
    //c. Create the table, assign the value to it by using, GetElementID, then do a for loop to search through the table and find the word. 
    //d. If not found, give an error
    //e. If found, delete the row. https://www.w3schools.com/jsref/met_table_deleterow.asp

        this.tableRef = document.getElementById("myTable");

        for(let index : number = 0; index < this.tableRef.rows.length; index++) {
            //loop through rows 
            
            if (this.tableRef.rows[index].innerHTML == deleteItem) {
                (this.tableRef.deleteRow(index)).innerHTML;
                document.forms["myForm"]["itemName"].value = "";
                itemFound = true;
                return true;
            }
        }
        if (itemFound == false) {
            alert("Please enter an item already in the list to delete");
            document.forms["myForm"]["itemName"].value = "";
            return false;
        }
        
   
}//end delete function 
//3. Create Complete Function (Optional)

//4. Create Clear All Function: Done 

function ClearAllFunction(){
    this.tableRef = document.getElementById("myTable");
    this.tableRef.innerHTML = "";
}
