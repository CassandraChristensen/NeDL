function validateANDadd() {
    //Declare variables, get the data from HTML and insert into variable
    var newMinNumber = document.forms["myForm"]["minRange"].value;
    var newMaxNumber = document.forms["myForm"]["maxRange"].value;
    var newNumber = document.forms["myForm"]["newNumber"].value;

    //Validate that something was entered for the min value
    if (newMinNumber == "") {
        alert("Please enter a number for the min value");
        return false;
    }

    //Validate that something was entered for the max value
    else if (newMaxNumber == "") {
        alert("Please enter a number for the max value");
        return false;
    }

    //Validate that the min is less than the max
    else if (parseInt(newMinNumber) > parseInt(newMaxNumber)) {
        alert("Please enter a maximum value, that is greater than the minimum value.");
        return false;
    }

    //Validate that something was entered for the new number
    else if (newNumber == "") {
        alert("Please enter a number to be included in the list");
        return false;
    }
    
    //Validate that the number is in the range
    else if ((parseInt(newNumber) > parseInt(newMaxNumber)) || (parseInt(newNumber) < (parseInt(newMinNumber)))) {
        alert("Please a number that is between the minimum and maximum range.")
        return false;
    } 

    //Add the numbers to the table 
    //Create an object of the table
    var tableRef = document.getElementById("myList1");
    (tableRef.insertRow(tableRef.rows.length)).innerHTML = newNumber;

    //Calculate and display the mean: Total of all the values, divided by the number of values. 
    var totalValue = 0;  //total value of all the numbers 
    var count = tableRef.rows.length;  //count is the number of numbers in the table
    for (let aRow = 0; aRow < count; aRow++){
        totalValue += parseInt(((tableRef.rows[aRow]).innerHTML));
    }
    var theAverage = totalValue/count;
    var labelRef1 = document.getElementById("theMean");
    labelRef1.innerHTML = theAverage.toFixed(3);


    //Calculate and display the median: Middle number in a list of numbers ordered from lowest to highest, will need to sort the numbers then, that's why we will put them into an array
    //first move the numbers to an array (this will be used for the mode too)

    //next for the array of numbers

    //Calculate and display the mode: Value that appears most often in a set of data. So will need to count how many times each number shows in the data. 

    //endFindMeanMedianMode function

    //Create a clear all function
}

