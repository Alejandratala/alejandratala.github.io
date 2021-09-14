---
title: "Containers and Github Actions."
layout: post
---

Docker containers, building them, creating a CI pipeline with Github actions making sure that the app would work on pull/push requests, this article will be a continuation of the previous one, here I will go more in depth on how Github actions can work with containers and will try to explain step by step.


## Docker File

First we need to make a docker file, in order to make the image, we can think of images like the base, we need the image in order to make a container, the container is run once the application starts it uses the image and also stores other data and the container stores everything. In the following picture I will explain how the image works:

![Dockerfile](/assets/Images/DockerFile.png)

* FROM here we are getting the Microsoft .Net image and the AS is just giving the image a name, in this case build-env. 
* WORKDIR  working directory and we give it a name /App, telling the container where to work in.
* COPY  we are copying the .csproj into the ./ and this means the container inside the /App.
* RUN here is a dotnet restore, its a command getting everything it needs for the project.
* COPY we are copying everything in the project to the image in this case inside the /App.
* Line 12 here is another FROM, here we are getting another microsoft image but for ASP.Net
* Line 13, still same working directory
* Line 14, we are taking everything from before so to the out folder in App.
* ENTRYPOINT is what should be done once we run the container, so in CMD we would write: dotnet SimpleWebHalloWorld.dll

## Github Actions with docker image.

Going back to last blog post, we want to make our project try to build an image and check if it fails or succeeds in making it. In my example each time there is a push or pull request to the main branch it will run the Github actions based off our dotnet.yml file in our /.github/workflows folder. In this exercise it was still the same:

* You have the name of the action
* Then the on which is when it gets triggered; on push and on pull requests.
* jobs, here we have two jobs, first one is the set up of the .net stuff (which is what I covered in the [previous post](https://alejandratala.github.io/Git-Hub-Actions/)).
    * Second job would be the Docker image build, here we are still using ubutu, and we give it the steps.
    * What's new is that we are adding a registry, along with username and password, github thankfully sorts the token for us (line 35) so we dont have to do any github secrets or anything its just automated.
    * Line 38, we are doing the action of what its trying to do.
    * Line 40, we are automatically push the build result to the registry, in my example case it would be the githut packages.
    * Line 41, we give it the registry (ghcr.io) if we dont give it one, it will automatically try to use the docker one, then we have the user name (alejandratala) this one is a must, its the host name, and it has to be according to DNS rules if its incorrect it won't work, along with the this applies also to the name of the project. I also didn't add a latest at the end of this line because it always tries to do it automatically.

![GitHub actions with docker job](/assets/Images/DockerimageJob.png)

## Github Secret

I wanted to write a more prominent space for this, because in my workflow I am using github username and password, well... github already sorts the token out automatically. It just knows it has to sort out a token, so it does it on the background, there was no need to go in and make a secret and add a value in my project.

## OUTRO
I hope this has proven helpful to someone out there, I know it can be confusing, specially if you want to understand what each thing does while using docker images and containers, along with actions!

## References

[Docker tag, extended description](https://docs.docker.com/engine/reference/commandline/tag/)

[About the Github token](https://docs.github.com/en/actions/reference/authentication-in-a-workflow)

[Github Docker build-push](https://github.com/docker/buildx/blob/master/docs/reference/buildx_build.md#push)

[Github, build-push-action](https://github.com/docker/build-push-action)

[Github, login-action](https://github.com/docker/login-action#github-container-registry)

[What's wrong with the docker: latest tag?](https://vsupalov.com/docker-latest-tag/)