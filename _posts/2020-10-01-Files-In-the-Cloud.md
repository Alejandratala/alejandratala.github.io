---
title: "Files in the Cloud"
layout: post
---

In this blog I will go into detail of how I set up a console app and set it up with Azure's Storage. I will be explaining the code, how much it would cost with a given scenario.


## Application

So it's a console app, and it attempts to upload an image onto Azure Storage, if there is already one with that name it doesn't add it, then displays the URL along with the different files in that folder (Azure calls them containers).

## Code

I followed the official [Microsoft Documentation for how to set up Azure Blob Storage Client](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet) to get started, I made a Storage account on Azure, then I got the storage "Connection String" in order to  set it as an enviroment variable in Windows, what that means is that in the background of my computer the variable will be saved so it won't be on the program. After that I just started to add the code for the console app.

* So I first get the connection string from the Windows enviroment in the background.
* Then I use the connection string to eventually try to connect and create a container in Azure Storage.
* In the [tutorial](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet) it creates a unique container name each time but since I just wanted to have one container I just hard coded a name for it (blog07images).
* Then do a try catch in order to check if there is that container there, if its there it just gets the container name and it works with it. If there isn't one it creates it.
* After that it try to get the local path and the file name in order to find it and be able to add it  to Azure in Line 39.
* The rest of the lines just show in the Console the URL and then make a foreach to show the name of the files inside the container.

![The code picture](/assets/Images/Blog08/Code.png)

## Pricing

The pricing scenario was that we have 1000 users that are uploading 100MB worth of pictures each day, along with all of the pictures in the container getting downloaded 3 times per day. [Azure Price](https://blog07.blob.core.windows.net/blog07images/screencapture-azure-microsoft-en-us-pricing-calculator-2021-10-01-18_57_34.png)

My monthly cost with this scenario would end up being 680€ (In the [picture](https://blog07.blob.core.windows.net/blog07images/screencapture-azure-microsoft-en-us-pricing-calculator-2021-10-01-18_57_34.png) its in dollars) 

I used this [formula](https://en.wikipedia.org/wiki/1_%2B_2_%2B_3_%2B_4_%2B_%E2%8B%AF) to figure out the download rate since each day there is more pictures that means the number gets increased  with every day that goes by.

Other factores also being assumed is that each photograph is 5MB per so that means the user is uploading 20 per day, I needed this number in order to figure out how many times the user is writing to the database.

## Resources

[Microsoft Docs: Quickstart: Azure Blob Storage Client](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet)

[Microsoft Docs: BlobServiceClient.GetBlobContainerClient() Method](https://docs.microsoft.com/en-us/dotnet/api/azure.storage.blobs.blobserviceclient.getblobcontainerclient?view=azure-dotnet)

[Microsoft Docs: BlobServiceClient.CreateBlobContainerAsync() Method](https://docs.microsoft.com/en-us/dotnet/api/azure.storage.blobs.blobserviceclient.createblobcontainerasync?view=azure-dotnet)

[Azure Pricing Calculator](https://azure.microsoft.com/en-us/pricing/calculator/)

[Math Formula](https://en.wikipedia.org/wiki/1_%2B_2_%2B_3_%2B_4_%2B_%E2%8B%AF)