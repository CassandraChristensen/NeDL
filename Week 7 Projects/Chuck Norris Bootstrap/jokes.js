async function getJoke() {

    //Create an apiString variable using the root end-point

    var apiString = "https://api.chucknorris.io";

    //Get the userinput from the drop down menu
    var newJokeCategory = document.getElementById("newCategory").value;

    //Include the path and query parameters 
    apiString = apiString + "/jokes/random?category=" + newJokeCategory;

    //Show the url using an alert just to validate it's working to this point.
    alert(apiString);

    //Make the API call the web service using the apiString and store what is returned in the response.
    //Use await so that computer won't move to next step until this is complete. 
    var response = await fetch(apiString);


    //Validate the status, and if not valid, alert user with the status. 
    if (response.status >=200 && response.status<=299) {
        
        alert("Valid status: " + response.status);
        //Put json file into a json object. By reading the response as a json file. 
        var jsonDataObject = await response.json();
    }
    else {
        alert("Error status" + response.status);
    }

    //Print the joke


    //Make sure that the field where joke is going to be printed is empty
    document.getElementById("jokeCategory").innerHTML = "";
    document.getElementById("newJoke").innerHTML = "";

    //Raw Data
    document.getElementById("rawData").innerHTML=JSON.stringify(jsonDataObject);
    

    //Stringify the jsonObject and the property i want to print.
    var newCategory = JSON.stringify(jsonDataObject.categories);
    var newJoke = JSON.stringify(jsonDataObject.value);
    

    //Remove the quotations
    newCategory = newCategory.substring(2,newCategory.length-2);
    newJoke = newJoke.substring(1,newJoke.length-1);

    //Print
    document.getElementById("jokeCategory").innerHTML = "Category: " + newCategory.toUpperCase();
    document.getElementById("newJoke").innerHTML = "<em>" + newJoke + "</em>";




}