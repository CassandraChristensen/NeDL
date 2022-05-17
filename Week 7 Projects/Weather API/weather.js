async function getWeatherForecast() {
    //Build the API call string by starting the with the root-endpoint
    var apiString = "https://api.weather.gov/gridpoints/";

    //Add the parameters to the string variable using the drop down list
    var newOffice = document.forms["myForm"]["newOffice"].value;

    //Add the parameters to the apiString 

    apiString = apiString + newOffice + "/31,80/forecast";

    alert (apiString);

    //Fetch the response 

    var response = await fetch (apiString);

    if (response.status >=200 && response.status <=299) {

        alert(response.status);
        var jsonData = await response.json();
    }
    else 
    {
        alert(response.statusText);
    }
    days = jsonData.properties.periods.length;

    document.getElementById("myDays").innerHTML = "";
    document.getElementById("myWeather").innerHTML = "";
    document.getElementById("myTemp").innerHTML = "";

    for (let i=0; i<days; i++) {
        document.getElementById("myDays").innerHTML += jsonData.properties.periods[i].name + "<br><br>";
        document.getElementById("myWeather").innerHTML += jsonData.properties.periods[i].shortForecast + "<br><br>";
        document.getElementById("myTemp").innerHTML += jsonData.properties.periods[i].temperature + " degrees Farenheit" + "<br><br>";
    }


}