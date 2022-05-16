//1. Create Add Function: Done
function AddFunction(){
    //a. Declare variable, label type, go to document, forms, myform and the name of the item i want, use that value to insert into the variable. 
    var addItem : string = document.forms["myForm"]["itemName"].value;
    

    //b. Validate that the user entered something, if not return with an error. 
    if (addItem == ""){
        alert("Please enter an item to add to the list.");
        return false;
    }
    //c. Add item to table: Declare variable for table, include the type(HTMLTableElement), go to document, get the element that i want to add to the variable use the Id.
    //d. Insert a row into the tables inner HTML, at the end of the table
   
    else {
        var tableRef = document.getElementById("myTable") as HTMLTableElement;
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = addItem.toLowerCase();
        document.forms["myForm"]["itemName"].value = "";
        return true;
    }

}//end add function 

//2. Create Delete Function: Done
function DeleteFunction(){
    //a. Declare variable, label the type, go to document>forms>[form name][formitem], insert that value into variable
    var deleteItem : string = document.forms["myForm"]["itemName"].value;

    var itemFound : boolean = false; 

    //b. Create the table(HTML DOM Table Object), type: HTMLTableElement, assign the value to it by using, GetElementID 
    //c. Do a for loop to search through the table's index and find the word. 
    //d. If found, delete the row. https://www.w3schools.com/jsref/met_table_deleterow.asp
    //e. If not found, give an error

        /* this.tableRef = document.getElementById("myTable");

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
        } */ //THIS WORKS. However, this keyword takes away the type and makes it Any. Should avoid making Any at all cost. 

        var tableRef = document.getElementById("myTable") as HTMLTableElement;

        for (let index: number = 0; index < tableRef.rows.length; index++){
            if (tableRef.rows[index].innerHTML == deleteItem.toLowerCase()){
                tableRef.deleteRow(index);
                itemFound = true;
                return true;
            }
        }
        if (itemFound == false){
            alert("Please enter an item already in the list to delete.");
            return false;
        }
        
   
}//end delete function 

//3. Create Complete Function (Optional)

function CompleteFunction(){

//a. Declare variable, label the type, go to document>forms>[form name][formitem], insert that value into variable
    var completeItem : string = document.forms["myForm"]["itemName"].value;

    var itemFound2 : boolean = false;

//b. Declare tableRef, type: HTMLTable Element (object), allows access to properties. 
//c. For loop to loop through the tables index. 
//d. If that index equals the completeItem variable, then at that index, use the style property and text decoration property to make a line-through the string.
//e. Update the forms value to nothing.
//f. Give error message if the item is not found in the list.
    var tableRef = document.getElementById("myTable") as HTMLTableElement;

            for(let index : number = 0; index < tableRef.rows.length; index++) {
                
                if (tableRef.rows[index].innerHTML == completeItem.toLowerCase()) {
                    tableRef.rows[index].style.textDecorationLine = "line-through";
                    document.forms["myForm"]["itemName"].value="";
                    itemFound2 = true;
                    return true;
                }
            }
            if (itemFound2 == false) {
                alert("Please enter an item already in the list to strike through");
                document.forms["myForm"]["itemName"].value = "";
                return false;
            }
    }

//4. Create Clear All Function: Done 

function ClearAllFunction(){
    this.tableRef = document.getElementById("myTable");
    this.tableRef.innerHTML = "";
}
