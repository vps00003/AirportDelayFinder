#AirportDelayFinder

[Check Out the Delay Finder](wwwroot.delays.cshtml)

## Project Overview

My project, in its current phase, includes a homepage with statistics on flight delays and their causes. The homepage contains a welcome message with a glowing-typewriter effect, an about section, and images displaying charts on top reasons for airport delays. Additionally, there's a link to the search page, where users can select a date and airport, although the search button is not functional yet due to the absence of data.

## Page Descriptions

### Home Page

The homepage boasts a glowing-typewriter h1 header welcoming users. Below, an about section explains the tool's purpose, with a link to the search page. Images illustrate charts on airport delay causes. Custom CSS is used only for the glowing header text.

### Tool/Search Page

Clicking the 'Access the Delay Predictor Here' link leads to the search page. It features a custom CSS heading, an interactive calendar for selecting travel dates, a dropdown for airports, and a non-functional search button. The page includes a table styled off a custom CSS class to resemble an old flight status board with a black background and green text. Finally, the page has a new HTML element in the form of a list of climate patterns that may delay flights.

# Research Summaries

## Website 1: [FlightStats](https://www.flightstats.com/v2/)

One of the main aspects of this site that I would like to somewhat replicate is the feature where you can select an airport and see the current conditions...

## Website 2: [FAA Flight Delay Information](https://www.fly.faa.gov/flyfaa/usmap.jsp?legacy=true)

From the FAA Flight Delay Information - Air Traffic Control System Command Center, I would eventually like to try and create a similar search result feature...

## Website 3: [FlightAware](https://www.flightaware.com/live/airport/delays%20airport%20delays)

From this website, the main feature that I liked that I would potentially look to incorporate much later in my design may be the map that highlights a few major airports and an overlay of the current weather radar...

## GitHub 1: [ASWS Repository](https://github.com/Federal-Aviation-Administration/ASWS)

This repository seemed to be a more complex version of what I am aiming to do. It utilizes weather information from the National Weather Service as well as flight data from the Federal Aviation Administration in order to create an API that provides real-time delay data...

## GitHub 2: [Airport Delays Repository](https://github.com/JeffWhitfill/airport-delays)

I may look to utilize some of the work in this repository to create a supporting part of my web app in the future. This repository utilizes airline data to gather what the average delay time at any given airport is...

# Future Enhancements

In the future, I would like to make the search button functional, creating a results display page. I plan to keep the new page simple for easy user understanding. Additionally, incorporating climate data and average weather delays based on the season into the results page is on the roadmap. Furthermore, I aim to move the charts from the homepage to another page and replace them with a live weather radar map.

# Citations

- [W3Schools CSS](https://www.w3schools.com/css/default.asp)
- MIST 353 Class Lectures
- Chat GPT + Prompts
  - "how do i create the glow effect in yellow for my text" I used this prompt to create glowing text
  - "How do i make the glowing text appear in typewriter style" I used this prompt to make the glowing text move across the screen
  - "Why wont my picture show up" I used this prompt to figure out why my picture wouldn't show up

# Reflection on Resources

Overall, during this assignment, I found the most useful resource to be the class examples. Coding alongside the lecture helped me understand the concepts better. W3Schools and Chat GPT were valuable for tasks not covered in class. Chat GPT successfully handled small tasks, with minimal alterations to its suggestions, primarily for aesthetic purposes.
