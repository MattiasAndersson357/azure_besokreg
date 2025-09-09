# Guest registration/visitor registration

To register guest(s) to a database.

## Description

This program will ask the user to input their fullname and email, which then will send a post-endpoint to Azure functions(backend).
And if the input data is a success it will save the data in a Azure SQL database.

## Getting Started

### Dependencies

* This will work on Windows 11, but should work on Win10, macOS and on linux.
* Must have Node.js preferably v.18x or later that have 'npm'.
* Azure Functions Core Tools, which you can find in Visual Studio Code or you can use Azure CLI.

### Configuration
* You will need Azure SQL for best use and then get your connectionstring which will be in the overview in your Azure SQL.
* In the project create a ```local.settings.json``` and copy and paste this json data
  ```{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "",
    "ConnectionStrings:SqlConnectionString": "Your-connectionstring"
  }
}```
* In ```"ConnectionStrings:SqlConnectionString": "Your-connectionstring"``` you should put your Azure SQL connectionstring. Do not share your connectionstring!

### Installing

* Visual Studio Code - download on their website (preferably latest version)
* Node.js - download on their website (v.18 or later)
* Azure Functions Core Tools, you can use VSCode terminal to download using this: ```npm install -g azure-functions-core-tools@4 --unsafe-perm true```
  Or search in extension-browser in VSCode
* To create Azure SQL, you'll need to have Azure account on 'Azure Portal'
* Connectionstring to connect to your database

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
