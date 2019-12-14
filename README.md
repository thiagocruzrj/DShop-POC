**What technologies?**
----------------

A lot of them, covering different aspects of building distributed services, whether it comes to implementing the code, managing services discovery and load balancing, configuring logging or monitoring, and eventually deploying to the VM using Docker.

Just to name a few:
- [RESTful API](https://www.restapitutorial.com) implementation with [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-2.1)
- [Domain Driven Design](http://dddcommunity.org) fundamentals
- SQL and NoSQL databases ([SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-2017), [MongoDB](https://www.mongodb.com), [InfluxDB](https://www.influxdata.com))
- Distributed caching with [Redis](https://redis.io)
- [API Gateway](https://microservices.io/patterns/apigateway.html) and other patterns designed for microservices
- [JWT](https://jwt.io), authentication, authorization
- Communication via websockets using [SignalR](https://docs.microsoft.com/en-us/aspnet/core/signalr/?view=aspnetcore-2.1)
- [CQRS](https://martinfowler.com/bliki/CQRS.html), Commands, Queries & Events handlers
- Using [RabbitMQ](https://www.rabbitmq.com) as a message queue with [RawRabbit](https://github.com/pardahlman/RawRabbit)
- Dealing with asynchronous requests, Process Managers and Sagas
- Internal HTTP communication with [RestEase](https://github.com/canton7/RestEase)
- Service discovery with [Consul](https://www.consul.io)
- Storing secrets with [Vault](https://www.vaultproject.io)
- Monitoring with [App Metrics](https://www.app-metrics.io), [Grafana](https://grafana.com), [Prometheus](https://prometheus.io) and [Jaeger](https://www.jaegertracing.io)
- Logging with [Serilog](https://serilog.net), [Seq](https://getseq.net) and [ELK stack](https://www.elastic.co/elk-stack)
- Building [Docker](https://www.docker.com) images, managing containers, networks and [registries](https://hub.docker.com)
- Defining [Docker compose](https://docs.docker.com/compose) stacks
- Managing your own Nuget feeds (e.g. [MyGet](https://myget.org))
- CI & CD with build services such as [Travis CI](https://travis-ci.org), [Bitbucket Pipelines](https://bitbucket.org/product/features/pipelines) or [VSTS](https://visualstudio.microsoft.com/pl/team-services)
- Deploying services to the Linux Servers and configuring [Nginx](https://www.nginx.com)
- Orchestrating services on your VM or in the Cloud using [Portainer](https://portainer.io) or [Rancher](https://rancher.com) (built on top of [Kubernetes](https://kubernetes.io))