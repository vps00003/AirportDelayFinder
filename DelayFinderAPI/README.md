# DelayFinder Project Design Vision & API Documentation (who did what)
## _NOTE: INDIVIDUAL API DOCUMENTATION BELOW PROJECT DESIGN VISION_

## Project Design Vision Proposed Pages (Potential Designs, not final)
### 1 - Home Page 
Home page will provide links to other created pages and will display the name of the application. Will look to include some graphics to make the page have some other content for the user. Will potentially look to integrate our external api here, hopefully a weather radar type external api.
### 2 - Delay Finder Informational Page including GET Information Page
Will look to provide background information about main causes of weather related flight delay and potential regions where delays are more likely. Will look to implement our GET APIs in order to allow the user to retrieve information about an Airport or an Airline here. Potential for some sort of drop down functionality allowing user to select from limited selection of airlines and airports in initial prototype.
### 3 - Airline Post Page
This proposed page will allow a user to input a specific airline into the database using a post api we created. Will utilize the 'CRUD' functionality within razor pages to allow for seamless user entry, deletion, etc.
### 4 - Airport Post Page
This proposed page will allow a user to input a specific airport into the database using a post api we created. Will utilize the 'CRUD' functionality within razor pages to allow for seamless user entry, deletion, etc.
### 5 - Delay Search Page
This proposed page will allow a user to search using a AirportID and date to find delays for a specific airport & time, potential utilization of searchdelay api.
### 6 - Airline Rating Search Page
This proposed page will allow a user to search for airlines with a delay rating greater than a value they input, the delay-rating-greater-than/{delayRating} api will look to be used here.

# **APIS**: includes description, input, output, and chatgpt prompts
## IMPORTANT NOTE: Make sure that you read the way the data is formatted in the DatabaseData very carefully. The formatting of IDs and some fields may differ from the usual style, testing the APIs will not work if the correct data format is not entered!

## /api/Flights/searchDelay - **_VIVEK SRIRAM_**
### **Does**?: 

retrieves list of delay time for a flight leaving a specific airport at a specific time

### **Input**: 

{departureAirportID}: ForeignKey of AirportID in Flight table unique identifier
{departureTime}: assigned departure time to each entry in the flight entity

### **Output**:
list that contains the delay time for the users inputted departureAirportID and departureTime

### **CHAT GPT PROMPT USE**

"I'm continuously getting a 500 error when i try to run this api, can you find the error in my code" I then pasted my code for the api into chat gpt. It added some packages to my code, and made small changes to syntax in my code it seems. I later figured out the error was mainly in the naming conventions in the database.

## /api/Airlines/delay-rating-greater-than/{delayRating} - **_VIVEK SRIRAM_**
### **Does**?: 
returns a list of airlines with a better delay rating than the user input

### **Input**: 

{delayRating}: A value assigned to all airlines, string

### **Output**:

returns a list of airports that have a delay rating greater than the value inputted by the user

### **CHAT GPT PROMPT USE**

I was running into more 500 error issues once the code had compiled, specifically something to do with the 'await' part of the FlightService code. I had originally based my code on the 2/27 lecture video, but this didn't seem to work. i pasted my code into chat GPT and asked it to find the reason it returned this solution:

 ``` var flights = await _dbContextClass.Flights ```
    ``` .FromSqlRaw("exec searchFlightDelays @DepartureAirportID, @DepartureTime", ```
        ``` departureAirportIDParam, departureTimeParam) ```
    ``` .ToListAsync();  ```

     
## /api/Airline/{AirlineID} - **_TYLER MCCOY_**
### **Does**?: 

retrieves the ratings for a particular airline

### **Input**: 

{AirlineID}: The unique identifier for airlines in the system

### **Output**:

returns a list of airlines, which contain the following attributes:

 public string AirlineID 
 
 public string AirlineName 
 
 public string AirlineRating 
 
 public string AirlineDelayRating 
 
### **CHAT GPT PROMPT USE**
Used chatgpt to help iron out 500 errors with issues in controller and services by pasting code and asking it to fix errors.
## /api/Airports/{AirportID} - **_NOAH ALBERTI_**
### **Does**?: 

retrieves the information about an airport

### **Input**: 

{AirportID}: The unique identifier for airports in the system

### **Output**:

returns a list of airports, which contain the following attributes:
public string CityID
    
public string AirportID

public string AirportName 

public string AirportRunwayCount

public string AirportAvgYearlyPassengers

public string AirportDestinationCount
### **CHAT GPT PROMPT USE**
Asked chat gpt to find my errors in code when found them testing the api in swagger.

## /api/airline/ - **_NOAH ALBERTI_**
### **Does**?: 

allows for post of a new airline into system

### **Input**: 

all of the attributes of airline entity:

public string AirlineID 
 
public string AirlineName 
 
public string AirlineRating 
 
public string AirlineDelayRating 

### **Output**:

after user enters attributes, new airline can be added to db

### **CHAT GPT PROMPT USE**

convert sqlserver sp code into aspnet
asked chatgpt to find reason for 500 error by pasting code

## /api/Airports/ - **_TYLER MCCOY_**
### **Does**?: 

allows for post of a new airport into system

### **Input**: 

all of the attributes of airport entity:

public string CityID
    
public string AirportID

public string AirportName 

public string AirportRunwayCount

public string AirportAvgYearlyPassengers

public string AirportDestinationCount

### **Output**:

after user enters attributes, new airport can be added to db

### **CHAT GPT PROMPT USE**
- change SQL into asp.net for api creation
- 500 error returned when ran on swagger, pasted parts of code to try and find error.
