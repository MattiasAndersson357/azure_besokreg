# Guest registration/visitor registration

To register guest(s) to a database.

## Description

This program will ask the user to input their fullname and email, which then will send a post-endpoint to Azure functions(backend).
And if the input data is a success it will save the data in a Azure SQL database.

## Getting Started

### Dependencies

* This will work on Windows 11, but should work on Win10, macOS and on linux.


### Installing

* Visual Studio Code - download on their website (preferably latest version)

### Executing program

* In the project you can use two terminals to execute the frontend and backend, i used PowerShell.
* Go to Terminal > New Terminal make sure you're using two different terminals. (one for frontend and second for backend)
* In terminal type: ```cd frontend``` to access the frontend-folder
* Then type: ```npm install``` and follow the instructions and when you're done use: ```npm run dev```
  Remember the localhost-adress and the port which is the numbers after localhost.

* In the second terminal type: ```func start --cors "your localhost-adress" --verbose```
* CORS means that you can use your frontend to communicate with the backend without endpoint request block.
  Verbose means more detail information in the logs, which is good for debugging.
* Go back to frontend-folder and click on the localhost-adress and you should be directed to the web-browser.

## Help

If you need help use the error message, try to troubleshoot while using your web-browser.
It should be a common solution to a common problem.

## Authors

MattiasAndersson357 

## Version History

* v 1.0
    * First release
