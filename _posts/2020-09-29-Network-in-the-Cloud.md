---
title: "Network in the Cloud"
layout: post
---

Currently we have an application within the company that we are trying to modernize within the company. This application holds and moves information that is classified, so we can't simply move it to a public cloud and have the data being able to be accessed by everyone. This is why I present with Azure service bus, I will provide proof as to why this is our best option for modernizing this application.


## Azure Private Link

With azure private link, we can modernize the application by being able to use all Azure services and host them in a private endpoint. That means that the information wouldn't make it onto the public IP addresses. We make a virtual private cloud to host the data and the information there, and it wouldnt be on the internet for anyone to be able to grab.

![Azure's private link](/assets/Images/Blog7/AzurePrivateLink.png)

## What is Azure Service Bus

With the help of Azure's Private Link, we can set up a Service Bus. A service bus would act between the applications we have in my example we can have a mobile app, along with a website, let's say a shopper wants to buy a T-shirt and they are checking out, the app would send messages to the the bus, and the messages would be in a qeue waiting for the software to check if there is any messages then it see's that there is messages and takes the first one and the software would understand what to do with the information. It goes both ways, if the software does the payment process then it sends a message to the qeue and the mobile app would check if there is messages, and if there are they would do something with the information.

The good thing about this is that it makes our applications easier to upgrade, if by any chance we upgrade software we wouldnt have to rework the app to be able to work with us, it would just be reworking how to handle messages. 

The other good thing is that if any service went offline, the messages would still be there on the qeue of the service bus. It minimilizes the risk of data loss if there is any offline or weird happenings on one end. 

![Service Bus](/assets/Images/Blog7/ServiceBus.png)

## Summary

Even though it would mean alot of changes, I really think its a good idea to move to a virtual private cloud witht he help of Azure private link and then handling the communication between applications and software with Azure service bus.

## Resources

[Microsoft Doc's: What is Azure Private Link](https://docs.microsoft.com/en-us/azure/private-link/private-link-overview)

[Microsoft Doc's: What is Azure Service Bus?](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-messaging-overview)