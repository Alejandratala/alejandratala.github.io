---
title: "Serverless Applications"
layout: post
---

## What is Serverless and  what is FaaS?

Serverless means that apps arent using a server, they are being stored in a cloud service, going serverless helps developers to build applications faster because the services using something like azure enables.

FaaS or function as a service allows the costumers trying to help shift the focus on developing running and managing the applications and its functionalities and less focus on the infrastruction. I will be taking a look at functions in azure.

## Testing out functions by building a calculator

The task was simple, go in and create a resource by making a function App, I created a resource group, once created you can find it in the dashboard. There under Functions, you can create individual ones, I wanted to try adding 2 numbers together so I made an HTTP trigger, once its been created and we want to change the code a little bit in order for it to add the numbers.

![Azure Function code](/assets/Images/AzureFunctionCode.png)

here we introduce two integers and we try to parse them, then we simply make another value to store them being added in line 15, and then we want to convert the result to string.
We can check out aswell in the azure website test/run, we can enter some values for the numbers and then run it and get a response.

![Azure Function code](/assets/Images/AzureFunctionTest.png)

## Resources

[Microsoft Docs: Azure Functions HTTP trigger](https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-http-webhook-trigger?tabs=csharp)
