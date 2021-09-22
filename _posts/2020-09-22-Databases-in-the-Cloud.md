---
title: "Databases in the Cloud"
layout: post
---

## Databases in the Cloud

In this blogg post we will be looking at Azures Cosmosdb and how it works, how I set up a small test project, and also making a HTTP Trigger function to be able to get/post something in the database.


## Project

My idea was simple: make a database, then make a collection (or as someone would say a table) with the name of "User", it had a simple Id as the Primary key, then a firstName and lastName. My goal with the project was to make a database have it be as simple as possible then be able to enter and get information from the database with functions.

## Code

First I have a Users.cs file, and here is where a


## Future proofing the database

I think this goes with any database, it is important to think about expanding and making sure that data is seperated for example: if you have an online-business and someone sat there and made one big table with costumer information, product information, then lets say we end up having different store locations later on, it would be a nightmare to change it in the future. In the example I have attached the top one is a bad-future-proofing example and here is why: on Costumers for membership and for the store name its just a normal name, what happens if we want to change the membership name? then we have to go individually through all of the costumers and change individualy which people can make mistakes and maybe someone's doesn't get changed.. the other problem is that for Stores, "Ica Maxi" there is so many different ones and there is no way to make it different  it would mean every store has to be unique.

Now if we look at the bottom example then we see, each table has a Unique number that can't repeat itself in each table, then that number is used in the other tables, so you dont have to worry about store with the id of 5 and 6 because even if the store name is the same the id makes them automatically different stores.

![ER diagram example](/assets/Images/ERDiagramExample.png)

## Prices

I used the [Azure Calculator](https://azure.microsoft.com/en-us/pricing/calculator/) in order to figure out prices for a basic not very popular database, and I got €73 per month, but if it were to become very popular and get alot of updating and reloading  to get the information and we had thousands of people try to access the database I mean the sky is the limit with pricing (thousands of euros).

## Resources

[Github Azure-functions-bindings-cosmosdb](https://github.com/MicrosoftDocs/azure-docs/blob/master/articles/azure-functions/functions-bindings-cosmosdb-v2-input.md#http-trigger-get-multiple-docs-using-documentclient-c)

[Integrating Azure Cosmos DB with Azure Functions](https://www.youtube.com/watch?v=L88quzuyjDY)