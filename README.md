# RuPeng.RestTemplateCore
Technology stack: C#, .Net Core, Consul

Description: It is a service locator of microservice architecture, which can resolve service name to a real server address.

Just like RestTemplate in the Spring Cloud, RestTemplateCore can resolve the service name in Consul to the physical address, for example: http://ProductService/api/Product/ --> http://192.168.1.21:5000/api/Product/
