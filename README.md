# WeatherMvc

# Tech Stack:
This web application is built with .NET Core MVC 3.1 and SQL Server Express.
There is currently no JavaScript in the application.

# Functionality
This web app takes a user's address and sends it to Google's Geocode API and gets the coordinates of the user input (among other things). Then, with those coordinates, the app calls DarkSky to get the current weather information.

# Past State:
Previously, this app used controller methods to make API calls to Google and DarkSky. 

Behind the scenes,the app takes the user's input, HTML encodes it, then sends it to Google's Geocoding API.
The JSON results from Google contain the coordinates of the user's address (along with much more information). 
In the same method, the app uses those coordinates to call DarkSky's weather API for current weather information.

The application saves the Geocoding and Weather results in a SQL Server Express database. 

# Current State - Application

Currently, this application uses Application Services to make API calls to Google and Dark Sky, save data to the database. 
This current refactor uses Dependency Injection to create two services:
1. Location Service (ILocationService)
2. Weather Service (IWeatherService)

This will will seperate business logic from the controllers and (hopefully) make debugging specific calls easier.


Eventually, the user will have the following:
Reporting - pre written reports with customizable parameters. 
Past Forecasts - possibly integrate with DarkSky's "time machine" api. 

UI Upgrades

# Future State - Infrastructure
This app will be deployed to an Azure App Service with a SQL Server database online.

Possibly use some DevOps tools? Docker, Terraform (lots of work). Not sure yet. 
