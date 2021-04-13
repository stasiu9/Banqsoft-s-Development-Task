### Banqsoft-s-Development-Task
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)


## General info
Simple SPA application used for calculating the cost of loan. Application is connected with database where are stored information about loans and interest rate.

## Technologies
* .NET Core 3.1
* Angular 9
* Docker
## Setup
### Angular project
#### Prerequisites
* Install Node.js which includes Node Package Manager
#### Setting Up a Project
Install the Angular CLI globally:
```
npm install -g @angular/cli
```
After installation you should install node packages
```
$ npm install
```
Run project:
```
$ ng serve
```

### .Net Core with database connection
#### Prerequisites
* Install dotnet sdk
* Install docker
#### Firstly you should follow instructions in link below to install SQL Server:
* https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker

Next you should setup migration:
* Remove the contents of the folder Migrations
* Then open the Package Manager Console
* Run the following commands:
```
$ Add-Migration Initial
$ Update-Database
````

Now you can run application
```
dotnet run or press F5
```


