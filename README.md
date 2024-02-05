
# AirportDelayFinder

## Project Overview

My project in its current phase includes a homepage with some statistics on flight delays & their causes, and the homepage contains a link to my ‘search’ page. In this page the user sees a calendar to select the date they desire and a dropdown of airports to select. There is a search button implemented however it is not functional yet as there is no data to provide the user.
## Page Descriptions

### Home Page

The homepage of my website is headed by a glowing-typewriter (moves across the screen) text h1 header that welcomes the user to the page. Below this there is an about section that details to the user what the tool could be used for, and a link to the search page of the tool. Below this I included images of charts that outline the top reasons for airport delays and the airports that experience the most weather related delay. The only custom css on this page to overlay the bootswatch was the glowing header text that moves across the screen.

### Tool/Search Page

Clicking the link on the homepage that says ‘Access the Delay Predictor Here’ will take you to my second functional page which is the main search page. This page also contains a custom css heading to overlay the bootswatch with the glowing header text that moves across the screen. Below this, I included an interactive calendar option where the user can select their travel date, a dropdown option menu with some sample airports, and a search button (not yet functional as there is no data to send back to the user). The table below this is written off a custom css class as I tried to replicate what an old flight status board would look like with a black background and green text. Finally, the page has a new HTML element in the form of a list of climate patterns that may delay your flight.

## Research Summaries

### Website 1: [FlightStats](https://www.flightstats.com/v2/)
One of the main aspects of this site that I would like to somewhat replicate is the feature where you can select an airport and see the current conditions. While this website uses current conditions, I would like to show historical trends for an airport and a date, but I feel like the way this search mechanism works is something that I may look to implement further down the line. One thing that I noticed with the url changes is that the general url for all airports is ‘https://www.flightstats.com/v2/airport-conditions/search’ and once you type in your desired airport the url changes to reflect that for example Pittsburgh becomes ‘https://www.flightstats.com/v2/airport-conditions/PIT’. I guess this is something similar to what we went over in class with the url changes based on user inputs.

### Website 2: [FAA Flight Delay Information](https://www.fly.faa.gov/flyfaa/usmap.jsp?legacy=true)
From the FAA 	Flight Delay Information - Air Traffic Control System Command Center I would eventually like to try and create a similar search result feature. Once the user selects an airport, the webpage provides a table that shows why there may be a delay at a given airport. I would like to try and combine this with the search feature from the first page, because I felt the first page had a simpler and more aesthetic look to the search area. In the results of this page that were displayed in the table, I recognized some custom CSS written to style the table in a certain way.

### Website 3: [FlightAware](https://www.flightaware.com/live/airport/delays%20airport%20delays)
From this website, the main feature that I liked that I would potentially look to incorporate much later in my design may be the map that highlights a few major airports and an overlay of the current weather radar. This looks to be quite a complex mechanism that is coded into the site, so I may look to do this on a somewhat scaled down version that only includes 3-4 cities. This may be something that adds some aesthetic quality to the homepage of my site rather than it just being text and a few charts as it currently is. I noticed that this page had a lot of custom css written to change the way the body text was presented.

### GitHub 1: [ASWS Repository](https://github.com/Federal-Aviation-Administration/ASWS)
This repository seemed to be a more complex version of what I am aiming to do. It utilizes weather information from the National Weather Service as well as flight data from the Federal Aviation Administration in order to create an API that provides real time delay data. I think that I could take inspiration from some of the code developed in this repository in order to further develop my design. Since I am looking to base mine of past data, not current data, I may need to take a deeper dive to understand how they are achieving their results in order to correctly develop mine. It is also written in Java so there will need to be changes to utilize their basis.

### GitHub 2: [Airport Delays Repository](https://github.com/JeffWhitfill/airport-delays)
I may look to utilize some of the work in this repository to create a supporting part of my web app in the future. This repository utilizes airline data to gather what the average delay time at any given airport is. This may be useful in the future as I would be able to implement the average delays experienced at an airport depending on the season it was in. The user has an option to add/drop multiple airports and the data is adjusted respectively which could be useful for me to implement.
## Future Enhancements
In the future I would obviously like to make the search button functional so that a user may enter their date of travel and destination airport and see a result. This would also require the creation of some sort of results display page. I think I would like to keep this new page fairly simple so that the user can easily see their results. I will eventually also need to figure out how to draw the climate data in along with average weather delays based on season so that the results page can have some sort of output. I would also like to move the charts on the homepage to one of the other pages at some point and replace it with the live weather radar map that I discussed above.
| Objectives                                          | Priorities |
| --------------------------------------------------- | ---------- |
| Create results page template                        | Priority 1 |
| Make search button functional                        | Priority 2 |
| Make changes to the aesthetic of homepage            | Priority 3 |
| Incorporate radar map into the homepage              | Priority 3 |

## Citations

- [W3Schools CSS](https://www.w3schools.com/css/default.asp)
- MIST 353 Class Lectures
- Chat GPT + Prompts
  - "how do i create the glow effect in yellow for my text" I used this prompt to create glowing text
  - "How do i make the glowing text appear in typewriter style" I used this prompt to make the glowing text move across the screen
  - "Why wont my picture show up" I used this prompt to figure out why my picture wouldn't show up

## Reflection on Resources

Overall during this assignment I found the most useful resource to be the class example that we had worked on during class lectures. I found that coding alongside the lecture helped me understand what was going on and reduced my need to look up stuff, for the most part. I did find both w3schools and Chat GPT to be very useful when tasked to utilize things that had not yet been discussed in class. I found that Chat GPT was able to do the small tasks I asked it to do with quite good success, the only alterations I made to its suggestions were aesthetic.