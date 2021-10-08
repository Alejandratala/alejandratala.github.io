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
 
* When you scale up and increase the CPU it would be faster if there isnt alot to do. so with high workload they are similar but on low workload the high cpu would be faster. 

* When you scale out, Azure starts new instances of the hardware defined by the App service plan to the app we are using. If stuff is happening paralized chances are that scaling out would be more beneficial because then you have more instances doing things at the same time, if the app is single threaded, as in you have an operation and it has to wait for it to go to the next thing then scaling up is faster.

* We can look at it in a sense of a highway, if you have multiple lanes (scaling out) then you can have multiple cars going and doing things fast at the same time, but if you are in a one lane road, you cant have 5 cars trying to go at the same time because you dont have any other roads.

* The biggest difference is that with scaling up, you can only go so far with maximizing the CPU, memory, at some point with scaling up you end up hitting max and there isn't anything to do about it. Compared to scaling out, where you can just keep creating more instances. Scaling out has more of an adantage with hosting alot of users in the application.

## Pricing

* App Service: I did monthly prices, I looked at the pricing list [here](ttps://azure.microsoft.com/en-us/pricing/details/app-service/windows/)
    * Scaling up: in the basic service plan, you start at B1 (46.171€/month) and you scale up to the next tier which ends up just doubling the price, it seems pretty consistant that the price just keeps doubling.
    * Scaling out: I looked at Basic service plan, and there you can have up to 3 instances so each instance is 46.171€ if you end up having 3 instances up the whole month it would be 46.171 * 3 = 138.513€ here it would be good to do the pricing or the calculation by the ammount of hours per month you have used it, since most likely you won't have 3 instances running *ALL* of the time.
* Virtual Machine: I ran it out for linux VM, also monthly prices. I looked at [this](https://azure.microsoft.com/en-us/pricing/details/virtual-machines/linux/) to check my pricing 
    * Scaling up: I looked at the Bs-series, it gives you different options of paying-as-you-go, or 1 year reserved. Just B1s costs 3.7245€ each month with the year reserved contract.
    * Scaling out: you could take the amount of instances used * whichever instance tier and way of payment you used, so 3 instances * 3.7245€ = your price.

## Which Azure Service App can you scale?

* Scale out: Basic Dedicated enviroment for dev/test, Standard Run productions workloads, Premium enhanced performance and scale, and Isolated High performance security and isolation packages allow scaling out

* Auto Scale: same as above.

* Scale up: You can go from Basic to standard and from there add more resources, once you max out on standard you can end up moving to premium.

## Resources

[Scaling up and scaling out with windows azure web sites](https://azure.microsoft.com/sv-se/blog/scaling-up-and-scaling-out-in-windows-azure-web-sites/)

[Microsoft docs: Scale up an app in Azure app service](https://docs.microsoft.com/en-us/azure/app-service/manage-scale-up)

[Microsoft Docs: Scale out to multiple instances](https://docs.microsoft.com/en-us/azure/azure-monitor/autoscale/autoscale-get-started?toc=/azure/app-service/toc.json)

[Youtube video: scaling up and out with Microsoft Azure](https://www.youtube.com/watch?v=Oy32KEeREVI)

[Microsoft Docs: Azure App Service plan overview](https://docs.microsoft.com/en-us/azure/app-service/overview-hosting-plans)

[App Service Pricing Details](https://azure.microsoft.com/en-us/pricing/details/app-service/windows/)

[Virtual Machine Pricing](https://azure.microsoft.com/en-us/pricing/details/virtual-machines/linux/)