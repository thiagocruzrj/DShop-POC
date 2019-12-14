# Distributed .NET Core

![DevMentors](https://github.com/devmentors/DNC-DShop/blob/master/assets/devmentors_logo.png)

**What is Distributed .NET Core?**
----------------

It's an open source project (and a course available soon at [devmentors.io](https://devmentors.io)), providing in-depth knowledge about building microservices using [.NET Core](https://www.microsoft.com/net/learn/get-started-with-dotnet-tutorial) framework and variety of tools. One of the goals, was to create a cloud agnostic solution, that you shall be able to run anywhere. 

We encourage you to join our [Discourse](https://www.discourse.org) forum available at [forum.devmentors.io](https://forum.devmentors.io).

For this particular course, please have a look at the topics being discussed under this [category](https://forum.devmentors.io/c/courses/distributed-dotnet-core).

**What is DShop.Services.Identity?**
----------------

DShop.Services.Identity is a microservice designed for the users bounded context [DShop](https://github.com/devmentors/DNC-DShop) solution.

|Branch             |Build status                                                  
|-------------------|-----------------------------------------------------
|master             |[![master branch build status](https://api.travis-ci.org/devmentors/DNC-DShop.Services.Identity.svg?branch=master)](https://travis-ci.org/devmentors/DNC-DShop.Services.Identity)
|develop            |[![develop branch build status](https://api.travis-ci.org/devmentors/DNC-DShop.Services.Identity.svg?branch=develop)](https://travis-ci.org/devmentors/DNC-DShop.Services.Identity/branches)


**How to start the application?**
----------------

Service can be started locally via `dotnet run` (executed in the `/src/DShop.Services.Identity` directory) or `./scripts/dotnet-run.sh` shell script, by default it will be available under http://localhost:5000.

You can also run the application using [Docker](https://www.docker.com) `docker run --name identity-service -p 5000:5000 --network dshop-network devmentors/dshop.services.identity` (include `-d` to run the container in the background).

It is required to have the basic infrastructure up and running first ([RabbitMQ](https://www.rabbitmq.com), [MongoDB](https://www.mongodb.com) and [Redis](https://redis.io)) in the same docker network named `dshop-network`. Services can be started using [Docker Compose](https://docs.docker.com/compose) (and [this file](https://github.com/devmentors/DNC-DShop/blob/master/compose/docker-compose-infrastructure.yml)) as described [here](https://github.com/devmentors/DNC-DShop).