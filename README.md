# **DELAYFINDER**

### IMPORTANT NOTES: 
Please see below to find links to README documentation for ASSIGNMENT 4 (Design Vision for pages and API documentation) and ASSIGNMENT 5 (Who worked on what Razor Pages and general non-dynamic pages of the website), respectively. The link to the repository from ASSIGNMENT 3 that contains the database creation, population, and SP creation is also linked below!

## App Overview
This application is designed to be a collaborative travel information platform. Our vision was to create a platform where users can enter their own ratings on the delay performance of specific airlines, airports, and flight routes; therefore, allowing other users to view this information and make informed decisions. Our intial prototype of the platform incorporates several created APIs in order to allow for the collaborative user-entry features of the platform.

### Developer Documentation
DelayFinder seeks to keep a "open-source" or collaborative platform in mind with our design. If you are looking to drive this project forwards, please consider investing time into incorporating searchable features using our already created APIs GetAirportDetails or GetAirlinesRatingGreaterThan. We currently lack the time and resources to drive a successful implementation of these apis, but believe they will play a big role in the success of this web application.

## Deployment Guide
The first step in deployment is making sure the database is loaded in SQLServer. You should take each file from the SQL repository [SEE BELOW] and run them one by one. Start by running the database creation, then the database data, and finally run each of the stored procedures. Then you can open the code by clicking the green Code button and run it in the visual studio vm.

### Potential pitfalls
Make sure that you read the way the data is formatted in the DatabaseData very carefully. The formatting of IDs and the value's you are entering are critical to ensuring APIs work as intended.

You may need to adjust the data source in appsettings.json if you are unable to test the validity of APIs in Swagger or you run into issues accessing CRUD pages in our web app, for example ``` "DefaultConnection": "Data Source=lab8L4JUY; ``` should reflect the data source that you create the SQL files in.

## Errors?
If you run in to errors while trying to run any portion of the DelayFinder, please reach out to one of us. Online tools such as Google, StackExchange, or ChatGPT can also be helpful in solving minor problems.

# REPOSITORY WITH DATABASE CREATION (Assgn 3)
[Link to Repository with Data Creation files](https://github.com/vps00003/assgn3/blob/main/DatabaseData.sql)

# Web Pages & Razor Page Overview README (Assign 5)
[here](AirportDelayFinder/README.md)

# API README (Assgn 4)
[here](DelayFinderAPI/README.md)


