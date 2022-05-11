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
        if (theNewNumber == 1)
        {
            var tableRef = document.getElementById("myList1");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + " : " + PalindromeCheck1(theNewWord);;
        }
        else if (theNewNumber == 2)
        {
            var tableRef = document.getElementById("myList2");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + " : " + isPalindrome(theNewWord);;
        }
        else 
        {
            var tableRef = document.getElementById("myList3");
            (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + " : " + is_palindrome(theNewWord);; 
            
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


//Found on geeksforgeeks.org : https://www.geeksforgeeks.org/how-to-check-whether-a-passed-string-is-palindrome-or-not-in-javascript/
//#3
function reverse( str )
  {
    // variable holds reverse string
    let rev_str = "";

    //Let index = string length minus while, until index is greater/equal to zero; subtract an index each time
    //add the string index to rev_string variable 
    for( let i = str.length-1 ;i >= 0 ;i--)
    {
      rev_str+= str[i];
    }
    // return reverse string
    return rev_str;
  }
 
  //  function checking string is palindrome or not
  function is_palindrome( str )
  {
    reverse_str = reverse(str);
    //  condition checking if reverse str is same as string it is palindrome else not a palindrome
    if( reverse_str === str)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
 


 //#2
 //convert the string to lowercase, this will allow it tell if palindrome regardless of if user enters in lower or capital. 
 //let index equal zero, loop until index is less than the string length, add one to the index each time. 
 //if string index does not equal the string minus 1 and minus index, then return false as not a palindrome. otherwise, return true. 
 const isPalindrome = (string) => {
     string = string.toLowerCase();
     for (let i =0; i<string.length; i+=1){
         if (string[i] !== string[string.length - 1- i]){
             return false;
         }
     }
     return true;
 } 


 //#1
 //split the string in half, reverse it, then join to the string. return the word that is exactly equal to the reverse word?
 function PalindromeCheck1 (theword){
     var reverseword = theword.split("").reverse().join("");
     return theword === reverseword;
 }

 