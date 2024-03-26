# AirportDelayFinder API Development Documentation & Project Design Vision

## Link to Project Design Vision

# **APIS**

## /api/Flights/searchDelay - **_VIVEK SRIRAM_**
### **Does**?: 

retrieves list of delay time for a flight leaving a specific airport at a specific time

### **Input**: 

{departureAirportID}: ForeignKey of AirportID in Flight table unique identifier
{departureTime}: assigned departure time to each entry in the flight entity

### **Output**:
list that contains the delay time for the users inputted departureAirportID and departureTime

### **CHAT GPT PROMPT USE**

"I'm continuously getting a 500 error when i try to run this api, can you find the error in my code" I then pasted my code for the api into chat gpt

## /api/Airlines/delay-rating-greater-than/{delayRating} - **_VIVEK SRIRAM_**
### **Does**?: 
returns a list of airlines with a better delay rating than the user input

### **Input**: 

{delayRating}: A value assigned to all airlines, string

### **Output**:

returns a list of airports that have a delay rating greater than the value inputted by the user

### **CHAT GPT PROMPT USE**

I was running into more 500 error issues once the code had compiled, specifically something to do with the await part of the FlightService code, i pasted my code into chat GPT and asked it to find the reason it returned this solution:

 var flights = await _dbContextClass.Flights
     .FromSqlRaw("exec searchFlightDelays @DepartureAirportID, @DepartureTime",
         departureAirportIDParam, departureTimeParam)
     .ToListAsync();

     
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

used to convert sqlserver sp code into aspnet

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

### **CHAT GPT PROMPT USE**

Chat Gpt used to change SQL into asp.net for convenience

### **Output**:

after user enters attributes, new airport can be added to db