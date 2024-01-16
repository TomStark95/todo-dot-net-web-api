# dot-net-web-api-demo

Very basic CRUD style ASP.NET Core Web API.

Minimal API vs Full/Controller based API

- Generally minimal APIs are designed to be SIMPLE smaller API services. With that being said minimal APIs can grow into larger API services and controller based APIs can be kept simple if done right...
- Micro-services can benefit from being coded as a minimal API.
- Controller based APIs are classes that derive from the ControllerBase class. Classes that derive off ControllerBase define the API route (controller) and assocated logic for any HTTP methods on that route.
- Minimal APIs simply define routes and associated logic using lambdas.
