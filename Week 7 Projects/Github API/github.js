async function getGitHubUsername() {
    //Build the API Call string by starting with the URL (This is Called the root-endpoint)
    var apiString =  "https://api.github.com/users";

    //next add the parameters that the user entered from the text box into a variable 
    var newGitHubUsername = document.forms["myForm"]["newGitHub"].value;

    //This is the full path, so adding the root endpoint, adding the query parameters, then adding the rest of the path based on user's input. 
    apiString = apiString + "/" + newGitHubUsername + "/repos";


    //alert the string (url)
    alert(apiString);

    // now make the API call the web service using the string (fetch) and store what is returned in response. 
    //Use await so the app won't move forward until the response has fully been rcvd 
    var response = await fetch(apiString);

    alert(response.status);

    //Check the status property of the response object, 200-299 is valid
    if (response.status >= 200 && response.status <=299){

    //put the json file into a JSON object
    //Use await so the app won't move forward until the json file has fully been made into jsonDataObject
        var jsonDataObject = await response.json();

    //Create the user feedback with the repos and links
        var theNewRepos = "";
        for (var aRepo in jsonDataObject) {
            theNewRepos += "<p><a href=" +jsonDataObject[aRepo].html_url + ">" + jsonDataObject[aRepo].name + "</a></p>";
        }

    } else {
        theNewRepos = "<p>Error accessing GitHub, status: " + response.status + ": " + response.statusText;
    }
    
    

    //clear the list incase anything was previously in it 
    document.getElementById("repos").innerHTML = "";
    document.getElementById("username").innerHTML = "";


    //Stringify and print out the JSON object fields. 
    document.getElementById("username").innerHTML = newGitHubUsername;
    document.getElementById("repos").innerHTML = theNewRepos;

    return true;
}