async function getQuote() {  //this is my'GET' Method, and performs a READ operation (CRUD)

    //Build the API Call string by starting with the URL (This is Called the root-endpoint)
    var apiString = "https://api.quotable.io/random";

    //next add the parameters to the strng using the drop down list 
    var theNewLength = document.getElementById("newQuoteLength").value;

    var minLength = 0; 
    var maxLength = 1000;
    if (theNewLength == 1) //the user wants a short one 
    {
        maxLength = 50;
    }
    else if (theNewLength == 2) //the user wants a medium one
    {
        minLength = 50;
        maxLength = 250;
    }
    else //the user wants a long one
    {
        minLength =250;
    }

    //This is the full path, so adding the root endpoint, adding the query parameters, then adding the rest of the path based on user's input. 
    apiString = apiString + "?minLength=" + minLength + "&maxLength=" + maxLength;

    alert(apiString);

    // now make the API call the web service using the string and store what is returned in response 
    var response = await fetch(apiString);

    //Finally print both the quote and author 
    //document.getElementById("")

    var jsonData = await response.json(); //read the sponse as JSON 

    document.getElementById("myRawData").innerHTML = JSON.stringify(jsonData);
    

    //Stringify and printo ut the JSON object fields after removing the quotes
    var theNewQuote = JSON.stringify(jsonData.content);
    theNewQuote = theNewQuote.substring(1,theNewQuote.length-1);
    document.getElementById("theQuote").innerHTML = theNewQuote;
    var theNewAuthor = JSON.stringify(jsonData.author);
    theNewAuthor = theNewAuthor.substring(1,theNewAuthor.length-1);
    document.getElementById("theAuthor").innerHTML = theNewAuthor;

    var theDateAdded = JSON.stringify(jsonData.dateAdded);
    theDateAdded = theDateAdded.substring(1,theDateAdded.length-1);
    document.getElementById("theDate").innerHTML = theDateAdded;
   
    return true;
}