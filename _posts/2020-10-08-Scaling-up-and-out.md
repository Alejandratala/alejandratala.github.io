---
title: "Scaling up and out"
layout: post
---

In todays blog I will be looking at scaling up and scaling out, what it means, what the differences are, some prices, what different services you can scale.


## Scaling up

Scaling up means to add more resources to an application, so you grab your application and you give it more memory or more CPU. With scaling up you can have it to auto scale, by having some conditions or rules that get triggered and it would scale up or scale down. You can also set it to specific times of the day, or a specific day if the company knows that the app will have alot of users because of a sale for example.

![Scaling up picture](/assets/Images/Blog10/ScalingUp.png)

## Scaling out

Scaling out means that you are taking the same application and making a copy and Azure redirects some of the traffic to that instance (the copy of the app). With adding some conditions you can have it trigger and either create or remove that instance.

![Scaling out picture](/assets/Images/Blog10/ScalingOut.png)

## Differences between Scaling up and Scaling out

Scaling up: Adding more resources to an application, so adding more power, so cpu or memory. with high CPU it would be faster if there isnt alot to do. so with high workload they are similar but on low workload the high cpu would be faster. 

Scaling out: multi instance aware, if it supports multi instance, then you can dynamically grow it, when you pay for the horse power when you need it. Perfect with PaaS
Azure starts new instances of the hardware defined by the App service plan to the app we are using. If stuff is happening paralized chances are that scaling out would be more beneficial because then you have more instances doing things at the same thing, if the app is single threaded, as in you have an operation and it has to wait for it to go to the next thing then scaling up is faster. We can look at it in a sense of a highway, if you have multiple lanes (scaling out) then you can have multiple cars going and doing things fast at the same time, but if you are in a one lane road, you cant have 5 cars trying to go at the same time because you dont have any other roads.

if you have low CPU


More headaches if you try it with IaaS,

* The biggest difference is that with scaling up, you can only go so far with maximizing the CPU, memory, at some point with scaling up you end up hitting max and there isn't anything to do about it. Compared to scaling out, where you can just keep creating more instances. Scaling out has more of an adantage with hosting alot of users in the application.

## Which Azure Service Apps can you scale?

* Web apps - you can auto-scale, by setting conditions you can tell the system when to scale.

## Resources

[Scaling up and scaling out with windows azure web sites](https://azure.microsoft.com/sv-se/blog/scaling-up-and-scaling-out-in-windows-azure-web-sites/)

[Microsoft docs: Scale up an app in Azure app service](https://docs.microsoft.com/en-us/azure/app-service/manage-scale-up)

[Microsoft Docs: Scale out to multiple instances](https://docs.microsoft.com/en-us/azure/azure-monitor/autoscale/autoscale-get-started?toc=/azure/app-service/toc.json)

[Youtube video: scaling up and out with Microsoft Azure](https://www.youtube.com/watch?v=Oy32KEeREVI)