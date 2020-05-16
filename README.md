# WeatherMvc

# Tech Stack:
This web application is built with .NET Core MVC 3.1 and SQL Server Express.
There is currently no JavaScript in the application.

# Past State:
Previously, this app used controller versions 
The user enters in their address and gets current weather information. 
Behind the scenes,the app takes the user's input, HTML encodes it, then sends it to Google's Geocoding API.
The JSON results from Google contain the coordinates of the user's address (along with much more information). 
In the same method, the app uses those coordinates to call DarkSky's weather API for current weather information and the 7 day forcast.
The application saves the Geocoding and Weather results in a SQL Server Express database. 

# Current State - Application

Currently, this application uses controller methods to make API calls to Google and Dark Sky, save data to the database and send data to the view. In the current refactor, I will use Dependency Injection to create three services:
1. Location Service (ILocationService)
2. Weather Service (IWeatherService)
3. Save To DB Services (ISaveDb)

This will will seperate business logic from the controllers and (hopefully) make debugging specific calls easier.

Branches for Each Change: 
Location Service: Location_service


Eventually, the user will have the following:
Reporting - pre written reports with customizable parameters. 
Past Forecasts - possibly integrate with DarkSky's "time machine" api. 

UI Upgrades

# Future State - Infrastructure
This app will be deployed to an Azure App Service with a SQL Server database online.

Possibly use some DevOps tools? Docker, Terraform (lots of work). Not sure yet. 
