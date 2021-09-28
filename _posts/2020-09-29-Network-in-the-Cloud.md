---
title: "Network in the Cloud"
layout: post
---

Currently we have an application within the company that we are trying to modernize within the company. This application holds and moves information that is classified, so we can't simply move it to a public cloud and have the data being able to be accessed by everyone. This is why I present with Azure service bus, I will provide proof as to why this is our best option for modernizing this application.


## Azure Private Link

With azure private link, we can modernize the application by being able to use all Azure services and host them in a private endpoint. That means that the information wouldn't make it onto the public IP addresses. 

![Azure's private link](/assets/Images/Blog7/AzurePrivateLink.png)

## What is Azure Service Bus

With the help of Azure's Private Link, we can set up a Service Bus. 

## Resources

[Microsoft Doc's: What is Azure Private Link](https://docs.microsoft.com/en-us/azure/private-link/private-link-overview)

