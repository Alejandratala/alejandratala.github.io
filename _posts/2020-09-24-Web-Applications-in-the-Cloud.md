---
title: "Web Applications in the Cloud"
layout: post
---

My goal is to use Azures:Cosmos DB and pair it up with a Razor page web application. I will be going through the steps on how I got it done.


## Description of the Application.

I created a Cosmos database for this project (named blog6database) then I made a container (name: Users) which will hold my data: first name and a last name, id. We use the database to store our information that our users are inputing. The website has two pages: Home, Users. 

* Home: here we just have two fields for the user to write a first name and then a last name, then there is a submit button for the data to be submitted to the database. And there is also another button where you can view all of the users, this button re-directs the user to the Users page.
* Users: This page lists all of the entries in the database, only displaying the first and last name.

## The Code

1. We first want to make a Razor Pages project started.
2. Adding the nuget package to the project ([Nuget: Microsoft.Azure.Cosmos](https://www.nuget.org/packages/Microsoft.Azure.Cosmos))
3. Make the connection between the web-app and the cosmosdb. This can be achieved by going into the "appsettings.json" file and after "AllowedHosts" line we should add our CosmosDb stuff for the connection.

![Appsettings.json File](/assets/Images/Blog6/appsettingsJsonFile.png)

4. I want to add some stuff in the Startup.cs file, first we are adding the 

## Cost

## Resources

[Bootstrap Docs: List group](https://getbootstrap.com/docs/5.1/components/list-group/)

[Microsoft Docs: Tutorial ASP.NET Core MVC web application with Azure Cosmos Db](https://docs.microsoft.com/en-us/azure/cosmos-db/sql/sql-api-dotnet-application)

[W3 Schools: HTML forms](https://www.w3schools.com/html/html_forms.asp)

[Microsoft Docs: Introduction to Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-5.0&tabs=visual-studio-code)

[Microsoft Docs: Tutorial: Get started with Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-5.0&tabs=visual-studio-code)