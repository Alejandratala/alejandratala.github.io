---
title: "Monitoring of Cloud Applications"
layout: post
---

With the help of Azure logging and application insights we are able to get alot of data of how the website it running and be able to check out different data. This blog will be focusing on how to set those services up and show some examples of data you can get by running some queries.


## Code example

I decided to revisit some [old code](https://github.com/Alejandratala/blog6WebApp) from a [previous blog post](https://alejandratala.github.io/Web-Applications-in-the-Cloud/). I reused the already deployed [web application](https://blog6webapp.azurewebsites.net/). 

I first sorted out the logging part, first in the Azure portal:webapp6 I went into the App Service logs and I enabled that.

![Azure portal App Service Logs picture](/assets/Images/Blog09/AzureAppServiceLogs.png)

After this step I went into Visual studio, and downloaded a nuget package called: *Microsoft.Extensions.Logging.AzureAppServices*. Then I went into the *Program.cs* file and added some code there:

![Program.cs picture](/assets/Images/Blog09/ProgramCSFile.png)

Now it's time to add the insights, with the help of the [Microsoft docs](https://docs.microsoft.com/en-us/azure/azure-monitor/app/asp-net-core) and I enable the application insights on the azure portal and similarly to the logging we go back to visual studio code and do the steps to add the nuget package and add the *Application Insights Telemetry* just like how the guide tells us, then after all the steps from the guide  once we are all done we publish the web application. 

Once that is done we can go back to the Azure portal and viola! the insights should be attached with the logging  and you can get information in the background with the use of [queries](https://docs.microsoft.com/en-us/azure/data-explorer/kusto/query/) to see what's going on in the background. Here are some examples of queries that can be done:

My first example is just the top 5 countries that have visited the website, I thought it was interesting because I involved some friends from different countries.

![Top 5 query picture](/assets/Images/Blog09/querietop5countries.png)

Checked out Server requests, and i wanted to see how many requests there were under 1 hour, and just have it display the count:

![Server request query count](/assets/Images/Blog09/Requestscount.png)

## Summary

I think that by using logging and insights can help with security issues because you can have access to data in which you can use in order to figure out what's going on. For example you could have some crashes in the website, and you could go into azure and check out the logs and see what the logs say about that crash. By looking at the logs with that crash you could get an idea of how it crashed and prevent future crashes. When it comes to security it would be the same thing, once there is a security breach you could look at the logs and get some information from them in order to try to prevent it onwards.

## Resources

[Microsoft Docs: Logging in .Net Core and ASP.Net Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-5.0)

[Microsoft Docs: Application Insights for ASP.NET Core applications](https://docs.microsoft.com/en-us/azure/azure-monitor/app/asp-net-core)

[How to: Configure Azure Web App Logging with .Net 5](https://medium.com/swlh/how-to-configure-azure-web-app-logging-with-net-5-786918eb2ff3)

[Youtube video: Configure Azure Web App Logging with .Net 5](https://www.youtube.com/watch?v=VZduc54meKQ)

[Microsoft Docs: Kusto Query](https://docs.microsoft.com/en-us/azure/data-explorer/kusto/query/)