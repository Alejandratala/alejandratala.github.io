---
title: "Web Applications in the Cloud"
layout: post
---

My goal is to use Azures:Cosmos DB and pair it up with a Razor page web application. I will be going through the steps on how I got it done.


## Description of the Application

I created a Cosmos database for this project (named blog6database) then I made a container (name: Users) which will hold my data: first name and a last name, id. We use the database to store our information that our users are inputing. The website has two pages: Home, Users. 

* Home: here we just have two fields for the user to write a first name and then a last name, then there is a submit button for the data to be submitted to the database. And there is also another button where you can view all of the users, this button re-directs the user to the Users page.
* Users: This page lists all of the entries in the database, only displaying the first and last name.

## The Code

* We first want to make a Razor Pages project started.
* Adding the nuget package to the project ([Nuget: Microsoft.Azure.Cosmos](https://www.nuget.org/packages/Microsoft.Azure.Cosmos))
* Add a model, make a folder in the project called Model, there I put my [User class](https://github.com/Alejandratala/blog6WebApp/blob/master/Model/User.cs).
* Adding services; I made a new folder holding the services, I want to add a new file in order to hold the [CosmosService](https://github.com/Alejandratala/blog6WebApp/blob/master/Services/CosmosDbService.cs) and an [interface](https://github.com/Alejandratala/blog6WebApp/blob/master/Services/ICosmosDbService.cs)
* In the [Startup.cs file](https://github.com/Alejandratala/blog6WebApp/blob/master/Startup.cs):
 * first we are adding a method that initializes  Cosmosdb into the project, so we can add this service into our project. I am basically trying to connect to the database. We then can go into a Page like [Index.cshtml.cs](https://github.com/Alejandratala/blog6WebApp/blob/master/Pages/Index.cshtml.cs) and we are injecting the cosmosdb service so it does it by itself. 
  * Then we are also adding in the ConfigureServices method our service so its always running.

  ![Configure services method](/assets/Images/Blog6/Services.png)

* Make the connection between the web-app and the cosmosdb. This can be achieved by going into the "appsettings.json" file and after "AllowedHosts" line we should add our CosmosDb stuff for the connection.

![Appsettings.json File](/assets/Images/Blog6/appsettingsJsonFile.png)

### Pages

In this section I will be explaining the pages, and what I added to them.

* Index: this is just the main page.
 * I added a @Section styles to be able to make a CSS file for the page incase I want to add individual CSS. (make sure you add a @RenderSection  in the header in the [_Layout.cshtml](https://github.com/Alejandratala/blog6WebApp/blob/master/Pages/Shared/_Layout.cshtml))
 * I add a form to add a first and last name, once they hit submit it would go to the [.cs file](https://github.com/Alejandratala/blog6WebApp/blob/master/Pages/Index.cshtml.cs) and On a post it takes the users first name and last name entered and it adds a user to the database along with a random number as id. 

 ![Azure Website database items](/assets/Images/Blog6/AzureWebsiteDatabaseItems.png)

 * Last piece in the Index page is a button that redirrects the user to the Users page.

* Users: In this page we show how many users we have, and a list of all of the users.
 * To get the count, we just do a @Model.Users.Count
 * Then I create a div to display the users.

## Cost

I used the [Azure Pricing Calculator](https://azure.microsoft.com/en-us/pricing/calculator/) to determine my prices.

For cosmosDb I chose Serverless, the transactional storage 1 gigabyte.
For App services,  I used a linux operating system.

Very little people visiting the site: 11.50€

For the cosmosDb part I still chose Serverless, and with a storage of 10 gigabytes.
For the App Services, I left it the same because even if we had high traffic there isn't that much to the website.

Lots of people visiting the site: 15.58€

## Look of the website

Here is two pictures of how the website looks when its running.

![Home Page](/assets/Images/Blog6/WelcomePage.png)

![Users Page](/assets/Images/Blog6/UsersPage.png)

## Resources

[Bootstrap Docs: List group](https://getbootstrap.com/docs/5.1/components/list-group/)

[Microsoft Docs: Tutorial ASP.NET Core MVC web application with Azure Cosmos Db](https://docs.microsoft.com/en-us/azure/cosmos-db/sql/sql-api-dotnet-application)

[W3 Schools: HTML forms](https://www.w3schools.com/html/html_forms.asp)

[Microsoft Docs: Introduction to Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio-code)

[Microsoft Docs: Tutorial: Get started with Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-5.0&tabs=visual-studio-code)